using System;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmStation : frmMainTable
  {    
    private string personaAsignadaOld = string.Empty;
    private string oldEstado = string.Empty;

    public frmStation()
    {
      InitializeComponent();
    }

    private void frmStation_Load(object sender, EventArgs e)
    {
      tableName = "estacion";
      formWhereField = "estacion_id";
      OnLoad();
      BindDataFields();
      if (!adding)
        personaAsignadaOld = DataUtil.GetString(cbCajero.SelectedItem);

      btnDelete.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Estaciones, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnSave.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Estaciones, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo) ||
                        DataBaseQuerys.GetAccess(AppConstant.MenuItems.Estaciones, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (IsReadyToSave())
      {
        var tableId = 0;
        try
        {
          string sqlForExecute;
          if (adding)
          {
            tableId = DataUtil.GetNewId(tableName);
            sqlForExecute = "INSERT INTO " + tableName + " (" +
                               formWhereField + "," +
                               "Estacion_descripcion," +
                               "Persona_asignada," +
                               "Estado," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por)" +
                         " VALUES (" +
                               tableId + "," +
                               "'" + txtDescripcion.Text.Trim() + "'," +
                               "'" + ((System.Web.UI.WebControls.ListItem)(cbCajero.SelectedItem)).Value + "'," +
                               "'" + cbEstado.SelectedItem + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'" +
                         ")";
          }
          else
          {
            sqlForExecute = "UPDATE " + tableName + " SET " +
                        "Estacion_descripcion = '" + txtDescripcion.Text.Trim() + "'" +
                        ", Estado = '" + cbEstado.SelectedItem + "'" +
                        ", Persona_asignada = '" + ((System.Web.UI.WebControls.ListItem)(cbCajero.SelectedItem)).Value + "'" +
                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                        " WHERE " + formWhereField + " = " + txtCodigo.Text;
          }

          if (DataUtil.Update(sqlForExecute))
          {
            if (adding)
              UpdateLog(tableId, "Cajero Asignado", string.Empty, cbCajero.SelectedItem.ToString());
            else
            {
              oldEstado = DataUtil.GetString(cbEstado.SelectedItem);
              if (personaAsignadaOld != DataUtil.GetString(cbCajero.SelectedItem))
                UpdateLog(tableId, "Cajero Asignado", personaAsignadaOld, cbCajero.SelectedItem.ToString());
            }
            MessageBox.Show(@"Registro grabado correctamente", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (adding)
              Close();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(@"Error en Grabar: " + ex.Message);
        }
      }
    }
    protected override void DeleteData()
    {
      idToDelete = txtCodigo.Text;
      base.DeleteData();
    }

    private bool IsReadyToSave()
    {
      bool valueResult = true;
      if (txtDescripcion.Text == string.Empty)
      {
        epDescripcion.SetError(txtDescripcion, "Por favor ingresar la descripcion de la estacion.");
        valueResult = false;
      }
      else
        epDescripcion.SetError(txtDescripcion, string.Empty);
      if (cbCajero.SelectedItem == null)
      {
        epCajeroAsignado.SetError(cbCajero, "Por favor ingresar el Cajero Asignado.");
        valueResult = false;
      }
      else
        epCajeroAsignado.SetError(cbCajero, string.Empty);
      if (adding)
      {
        if (VerificarAsignacion().Equals(false))
          valueResult = false;

        if (VerificarDuplicados().Equals(false))
          valueResult = false;
      }
      else
      {
        if (CanInactivate())
        {
          MessageBox.Show(@"No se puede inactivar este registro.", @"Update", MessageBoxButtons.OK, MessageBoxIcon.Stop);
          valueResult = false;
        }
      }
      return valueResult;
    }
    private void BindDataFields()
    {
      DataUtil.FillComboBoxValues(cbCajero.Items, "SELECT Apellidos_empleado + ', ' + Nombres_empleado AS Nombre, Codigo_empleado FROM empleado WHERE Cargo = 'CAJERO' ORDER BY Apellidos_empleado", null);

      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);
      if (mainDataSet.Tables[0].Rows.Count > 0)
      {
        txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
        txtDescripcion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Estacion_descripcion");
        cbEstado.SelectedItem = oldEstado = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");

        var sWhere = "Codigo_empleado = " + DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Persona_asignada") + "";
        cbCajero.Text = DataUtil.FindSingleRow("empleado", "Apellidos_empleado + ', ' + Nombres_empleado AS Nombre", sWhere);        
      }
      else
        cbEstado.SelectedItem = AppConstant.RegistroEstado.Activo;
    }
    private void UpdateLog(int recordId, string field, string oldValue, string newValue)
    {
      var sqlForExecute = "INSERT INTO Estacion_Log (" +
                               "Estacion_Log_id," +
                               "Estacion_id," +
                               "Campo," +
                               "Valor_antiguo," +
                               "Valor_nuevo," +
                               "Fecha_actualizacion," +
                               "Actualizado_por)" +
                         " VALUES (" +
                               DataUtil.GetNewId("Estacion_Log") + "," +
                               recordId + "," +
                               "'" + field + "'," +
                               "'" + oldValue + "'," +
                               "'" + newValue + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'" +
                         ")";
      DataUtil.Update(sqlForExecute);
    }
    private bool VerificarAsignacion()
    {
      if (cbCajero.SelectedItem != null)
      {
        var sWhere = "[Persona_asignada] = " + ((System.Web.UI.WebControls.ListItem)(cbCajero.SelectedItem)).Value + "";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show(@"El cajero ya tiene una estacion asignada.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
        return true;
      }
      MessageBox.Show(@"Por favor ingresar Cajero a Asignar.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return false;     
    }
    private bool VerificarDuplicados()
    {
      if (txtDescripcion.Text != string.Empty)
      {
        var sWhere = "Estacion_descripcion = '" + txtDescripcion.Text.Replace("'", "''") + "'";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show(@"La estacion ya existe.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }
      return true;
    }

    protected override bool ExistRecord()
    {
      var recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("turno_estacion", "Count(*)", "estacion_id = " + txtCodigo.Text + ""));
      if (recordCount > 0)
      {
        MessageBox.Show(@"No se puede borrar la estacion, tiene " + recordCount + @" turnos asociados.", @"Borrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      return true;
    }
    private bool CanInactivate()
    {
      var result = false;
      if (DataUtil.GetString(cbEstado.SelectedItem) == AppConstant.RegistroEstado.Inactivo)
      {
        if (DataUtil.GetString(cbEstado.SelectedItem) != oldEstado)
        {
          var dsResult = DataUtil.FillDataSet(DataBaseQuerys.Turno(0, DataUtil.GetInt(txtCodigo.Text), false), "turno");
          if (dsResult.Tables[0].Rows.Count > 0)
            result = true;
        }
      }
      return result;
    }
  }
}
