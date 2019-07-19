using System;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmEmployee : frmMainTable
  {
    public frmEmployee()
    {
      InitializeComponent();
    }
    private void frmEmployee_Load(object sender, EventArgs e)
    {
      btnDelete.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Empleados, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnSave.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Empleados, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo) ||
                        DataBaseQuerys.GetAccess(AppConstant.MenuItems.Empleados, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);

      tableName = "empleado";
      formWhereField = "Codigo_empleado";
      OnLoad();
      BindDataFields();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (IsReadyToSave())
      {
        var dtpFechaNacimientoObj = "'" + DataUtil.GetString(dtpFechaNacimiento.Value) + "'";
        var dtpFechaIngresoObj = "'" + DataUtil.GetString(dtpFechaIngreso.Value) + "'";
        if (dtpFechaNacimiento.Value == DateTime.MinValue)
          dtpFechaNacimientoObj = "null";
        if (dtpFechaIngreso.Value == DateTime.MinValue)
          dtpFechaIngresoObj = "null";

        try
        {
          string sqlForExecute;
          if (adding)
          {
            sqlForExecute = "INSERT INTO " + tableName + " (" +
                               formWhereField + "," +
                               "Nombres_empleado," +
                               "Apellidos_empleado," +
                               "Direccion," +
                               "Telefono_fijo," +
                               "Celular," +
                               "Email," +
                               "Fecha_nacimiento," +
                               "Fecha_ingreso," +
                               "[Password]," +
                               "Comentarios," +
                               "Estado," +
                               "Cargo," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por)" +
                         " VALUES (" +
                               DataUtil.GetNewId(tableName) + "," +
                               "'" + txtNombres.Text.Trim() + "'," +
                               "'" + txtApellidos.Text.Trim() + "'," +
                               "'" + txtDireccion.Text.Trim() + "'," +
                               "'" + txtTelefono.Text.Trim() + "'," +
                               "'" + txtCelular.Text.Trim() + "'," +
                               "'" + txtEmail.Text.Trim() + "'," +
                               "" + dtpFechaNacimientoObj + "," +
                               "" + dtpFechaIngresoObj + "," +
                               "'" + txtPassword.Text.Trim() + "'," +
                               "'" + txtComentarios.Text.Trim() + "'," +
                               "'" + cbEstado.SelectedItem + "'," +
                               "'" + cbCargo.SelectedItem + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'" +
                         ")";
          }
          else
          {
            sqlForExecute = "UPDATE " + tableName + " SET " +
                        "Nombres_empleado = '" + txtNombres.Text.Trim() + "'" +
                        ", Apellidos_empleado = '" + txtApellidos.Text.Trim() + "'" +
                        ", Direccion = '" + txtDireccion.Text.Trim() + "'" +
                        ", Telefono_fijo = '" + txtTelefono.Text.Trim() + "'" +
                        ", Celular = '" + txtCelular.Text.Trim() + "'" +
                        ", Email = '" + txtEmail.Text.Trim() + "'" +
                        ", Comentarios = '" + txtComentarios.Text.Trim() + "'" +
                        ", Estado = '" + cbEstado.SelectedItem + "'" +
                        ", Cargo = '" + cbCargo.SelectedItem + "'" +
                        ", Fecha_nacimiento = " + dtpFechaNacimientoObj + "" +
                        ", Fecha_ingreso = " + dtpFechaIngresoObj + "" +
                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                        " WHERE " + formWhereField + " = " + txtCodigo.Text;
          }

          if (DataUtil.Update(sqlForExecute))
          {
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
    private void btnAddCargo_Click(object sender, EventArgs e)
    {
      var refValue = string.Empty;
      if (frmInputBox.InputBox("Agregar Cargo", "Descripcion Cargo", "empleado_cargo", "descripcion", string.Empty, ref refValue, false, true) == DialogResult.OK)
      {
        DataUtil.FillComboBox(cbCargo.Items, "SELECT * FROM empleado_cargo", null);
        cbCargo.SelectedItem = refValue;
      }
    }
    private void btnChangePassword_Click(object sender, EventArgs e)
    {
      var changePasswordForm = new frmChangePassword {oldPassword = txtPassword.Text};
      changePasswordForm.ShowDialog();
    }
    private void btnVerificar_Click(object sender, EventArgs e)
    {
      if (VerificarPassword())
        MessageBox.Show(@"El password es valido.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private bool IsReadyToSave()
    {
      epNombres.SetError(txtNombres, string.Empty);
      epApellidos.SetError(txtApellidos, string.Empty);
      epPassword.SetError(txtPassword, string.Empty);
      epCargo.SetError(cbCargo, string.Empty);
      var valueResult = true;
      if (txtNombres.Text == string.Empty)
      {
        epNombres.SetError(txtNombres, "Por favor ingresar sus Nombres.");
        valueResult = false;
      }
        
      if (txtApellidos.Text == string.Empty)
      {
        epApellidos.SetError(txtApellidos, "Por favor ingresar sus Apellidos.");
        valueResult = false;
      }
        
      if (txtPassword.Text == string.Empty)
      {
        epPassword.SetError(txtPassword, "Por favor ingresar su Contraseña.");
        valueResult = false;
      }
        
      if (dtpFechaIngreso.Value.Equals(dtpFechaIngreso.MinDate))
      {
        epFechaIngreso.SetError(dtpFechaIngreso, "Debe ingresar una Fecha de Ingreso correcta.");
        valueResult = false;
      }
        
      if (cbCargo.SelectedItem == null)
      {
        epCargo.SetError(cbCargo, "Por favor ingresar el Cargo.");
        valueResult = false;
      }
        
      if (adding)
      {
        if(VerificarPassword().Equals(false))
          valueResult = false;
      }
      return valueResult;
    }
    private bool VerificarPassword()
    {
      if (txtPassword.Text != string.Empty)
      {
        var sWhere = "[password] = '" + txtPassword.Text + "'";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show(@"El password no es valido.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
        return true;
      }
      MessageBox.Show(@"Por favor ingresar su Contraseña.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return false;
    }
    private void BindDataFields()
    {
      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);

      DataUtil.FillComboBox(cbCargo.Items, "SELECT * FROM empleado_cargo ORDER BY descripcion", null);

      if (mainDataSet.Tables[0].Rows.Count > 0)
      {
        txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
        txtNombres.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "nombres_empleado");
        txtApellidos.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "apellidos_empleado");
        txtDireccion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "direccion");
        txtTelefono.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "telefono_fijo");
        txtCelular.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "celular");
        txtEmail.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "email");
        txtPassword.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "password");
        txtPassword.Enabled = false;
        btnVerificar.Enabled = false;
        txtComentarios.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "comentarios");
        if (DataUtil.GetDateTime(mainDataSet.Tables[0].Rows[0], "Fecha_nacimiento") != DateTime.MinValue)
          dtpFechaNacimiento.Value = DataUtil.GetDateTime(mainDataSet.Tables[0].Rows[0], "Fecha_nacimiento");
        if (DataUtil.GetDateTime(mainDataSet.Tables[0].Rows[0], "Fecha_ingreso") != DateTime.MinValue)
          dtpFechaIngreso.Value = DataUtil.GetDateTime(mainDataSet.Tables[0].Rows[0], "Fecha_ingreso");

        cbCargo.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "cargo");
        cbEstado.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");
      }
      else
      {
        cbEstado.SelectedItem = AppConstant.RegistroEstado.Activo;
        btnChangePassword.Enabled = false;
      }
      if (txtCodigo.Text.Equals(AppConstant.CodigoAdministrador))
      {
        btnDelete.Enabled = false;
        cbEstado.Enabled = false;
        cbCargo.Enabled = false;
      }
    }
    protected override bool ExistRecord()
    {
      var recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("venta", "Count(*)", "atendido_por = " + txtCodigo.Text + ""));
      recordCount = recordCount + DataUtil.GetInt(DataUtil.FindSingleRow("pedido", "Count(*)", "atendido_por = " + txtCodigo.Text + ""));
      if (recordCount > 0)
      {
        MessageBox.Show(@"No se puede borrar el empleado tiene ventas y ordenes asociadas.", @"Borrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      return true;
    }

    private void btnPermisos_Click(object sender, EventArgs e)
    {

    }
  }
}
