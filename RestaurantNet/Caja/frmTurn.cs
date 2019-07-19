using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmTurn : frmMainTable
  {    
    private int lineGrid = 0;
    private double subTotal = 0;
    string sqlForExecute = string.Empty;

    public frmTurn()
    {
      InitializeComponent();
    }

    private void frmTurn_Load(object sender, EventArgs e)
    {
      tableName = "Turno";
      formWhereField = "Turno_id";
      OnLoad();
      BindDataFields();

      btnDelete.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Turnos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);
      btnSave.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Turnos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
    }

    private void BindDataFields()
    {
      txtMontoInicial.Text = AppConstant.GeneralInfo.MontoCaja;
      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);

      DataUtil.FillComboBoxValues(cbEstacion.Items, "SELECT Estacion_descripcion, Estacion_id FROM Estacion WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' ORDER BY Estacion_descripcion", null);
      
      if (mainDataSet.Tables[0].Rows.Count > 0)
      {
        txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
        cbEstado.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");
        subTotal = DataUtil.GetDouble(mainDataSet.Tables[0].Rows[0], "Fondo_inicial_total");
        txtFondoInicialTotal.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Fondo_inicial_total");
        txtVentaTotal.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Venta_total");
        txtOrdenes.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Orden");

        if (DataUtil.GetDateTime(mainDataSet.Tables[0].Rows[0], "Fecha_apertura") != DateTime.MinValue)
        {
          lblFechaApetura.Visible = true;
          dtpFechaApetura.Visible = true;
          dtpFechaApetura.Value = DataUtil.GetDateTime(mainDataSet.Tables[0].Rows[0], "Fecha_apertura");
        }
        if (DataUtil.GetDateTime(mainDataSet.Tables[0].Rows[0], "Fecha_cierre") != DateTime.MinValue)
        {
          lblFechaCierre.Visible = true;
          dtpFechaCierre.Visible = true;
          dtpFechaCierre.Value = DataUtil.GetDateTime(mainDataSet.Tables[0].Rows[0], "Fecha_cierre");
        }
        if (DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado").Equals("CERRADO"))
        {
          btnDelete.Enabled = false;
          gbEstaciones.Enabled = false;
          btnDetalle.Visible = true;
        }
        CargarTurnoEstacion(DataUtil.GetInt(txtCodigo.Text));
        btnBorrar.Enabled = false;
        btnSave.Enabled = false;        
      }
      else
      {
        cbEstado.SelectedItem = "ABIERTO";
      }
    }
    private bool IsReadyToSave()
    {
      bool valueResult = true;

      if (adding)
      {
        if (VerificarDuplicados().Equals(false))
          valueResult = false;
      }

      if (valueResult)
      {
        if (dgwCuenta.RowCount == 0)
        {
          valueResult = false;
          cbEstacion.Focus();
          MessageBox.Show(@"Debe ingresar al menos una estacion.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      
      return valueResult;
    }
    private bool VerificarDuplicados()
    {
      DataSet dsSearch = DataUtil.FillDataSet(DataBaseQuerys.Turno(0,0,false), tableName);
      if (dsSearch.Tables[0].Rows.Count > 0)
      {
        MessageBox.Show(@"Ya existe un Turno abierto.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    protected override void DeleteData()
    {
      DialogResult result = MessageBox.Show(@"Está seguro de cerrar el turno actual?", @"Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        int ordenesAbiertas = DataUtil.GetInt(DataUtil.FindSingleRow("pedido", "Count(*)", "Estado = 'A' AND turno_id = " + txtCodigo.Text + ""));
        if (ordenesAbiertas > 0)
          MessageBox.Show(@"No se puede cerrar el turno tiene " + ordenesAbiertas + @" Ordenes pendientes de pago.", @"Ordenes Abiertas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
          frmCloseTurn frmCloseTurnForm = new frmCloseTurn();
          frmCloseTurnForm.ShowDialog();
          if (AppConstant.Turno.Codigo.Equals(string.Empty))
            this.Close();
        }
      }
    }
    private void btnSave_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show(@"Está seguro de abrir el turno?", @"Abrir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        if (IsReadyToSave())
        {          
          try
          {
            if (adding)
            {
              txtCodigo.Text = DataUtil.GetString(DataUtil.GetNewId(tableName));
                            
              sqlForExecute = "INSERT INTO " + tableName + " (" +
                                 formWhereField + "," +
                                 "Estado," +
                                 "Fondo_inicial_total,"+
                                 "Venta_total,"+
                                 "Fecha_apertura," +
                                 "Aperturado_por)" +
                           " VALUES (" +
                                 txtCodigo.Text + "," +
                                 "'ABIERTO'," +
                                 "" + txtFondoInicialTotal.Text + "," +
                                 "'0.00'," +
                                 "'" + DateTime.Now + "'," +
                                 "'" + AppConstant.EmployeeInfo.Codigo + "'" +
                           ")";
            }
            
            if (DataUtil.Update(sqlForExecute))
            {
              AgregarTurnoEstacion(DataUtil.GetInt(txtCodigo.Text));
              if (adding)
                this.Close();
            }
          }
          catch (Exception ex)
          {
              MessageBox.Show("Error en Grabar: " + ex.Message + "  " + sqlForExecute);
          }
        }
      }
    }

    private void btnAddCargo_Click(object sender, EventArgs e)
    {
      if (cbEstacion.SelectedItem != null && txtMontoInicial.Text.Trim() != string.Empty)
      {
        if (!ExisteEstacion(((System.Web.UI.WebControls.ListItem)(cbEstacion.SelectedItem)).Text))
        {
          lineGrid = lineGrid + 1;
          string[] row = {DataUtil.GetString(lineGrid),
                        ((System.Web.UI.WebControls.ListItem)(cbEstacion.SelectedItem)).Text,
                        txtMontoInicial.Text,
                        ((System.Web.UI.WebControls.ListItem)(cbEstacion.SelectedItem)).Value
                       };
          dgwCuenta.Rows.Add(row);
          CalculoMontoInicial(DataUtil.GetDouble(txtMontoInicial.Text), true);

          if (!adding)
          {
            sqlForExecute = "UPDATE " + tableName + " SET Fondo_inicial_total = " + txtFondoInicialTotal.Text + "" +
                          " WHERE " + formWhereField + " = " + txtCodigo.Text;

            DataUtil.Update(sqlForExecute);

            sqlForExecute = "INSERT INTO Turno_Estacion (" +
                         "Turno_id," +
                         "Estacion_id," +
                         "Linea," +
                         "Fondo_inicial)" +
                        " VALUES (" +
                         txtCodigo.Text + "," +
                         ((System.Web.UI.WebControls.ListItem)(cbEstacion.SelectedItem)).Value + "," +
                         "'" + DataUtil.GetString(lineGrid) + "'," +
                         "" + txtMontoInicial.Text + "" +
                         ")";
            DataUtil.UpdateThrow(sqlForExecute);
          }
          cbEstacion.Text = string.Empty;
          txtMontoInicial.Text = AppConstant.GeneralInfo.MontoCaja;

          cbEstacion.Focus();
        }
      }
      else
      {
        cbEstacion.Focus();
        MessageBox.Show(@"Debe ingresar la estacion y el monto inicial.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private void btnBorrar_Click(object sender, EventArgs e)
    {
      if (txtLinea.Text.Trim() != string.Empty)
      {
        DialogResult result = MessageBox.Show(@"Está seguro de eliminar la linea " + txtLinea.Text + @" ?", @"Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
          for (int i = 0; i < dgwCuenta.RowCount; i++)
          {
            if (DataUtil.GetString(dgwCuenta.Rows[i].Cells["LINEA"].Value) == txtLinea.Text)
            {
              CalculoMontoInicial(DataUtil.GetDouble(dgwCuenta.Rows[i].Cells["MONTO_INICIAL"].Value), false);
              this.dgwCuenta.Rows.RemoveAt(i);
              txtLinea.Text = string.Empty;
              break;
            }
          }
        }
      }
      else
      {
        txtLinea.Focus();
        MessageBox.Show(@"Seleccionar la linea a borrar.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void CalculoMontoInicial(double monto, bool sumar)
    {
      if (sumar)
        subTotal = subTotal + monto;
      else
        subTotal = subTotal - monto;

      txtFondoInicialTotal.Text = subTotal.ToString(DataUtil.Format.Decimals);
    }
    private bool ExisteEstacion(string estacion)
    {
      for (int i = 0; i < dgwCuenta.RowCount; i++)
      {
        if (DataUtil.GetString(dgwCuenta.Rows[i].Cells["ESTACION"].Value) == estacion)
          return true;
      }
      return false;
    }
    private void AgregarTurnoEstacion(int turnoId)
    {
      DataUtil.Update("DELETE FROM Turno_Estacion WHERE " + formWhereField + " = " + turnoId);

      foreach (DataGridViewRow row in dgwCuenta.Rows)
      {
        sqlForExecute = "INSERT INTO Turno_Estacion (" +
                         "Turno_id," +
                         "Estacion_id," +
                         "Linea," +
                         "Fondo_inicial)" +
                        " VALUES (" +
                         turnoId + "," +
                         DataUtil.GetInt(row.Cells[3].Value) + "," +
                         "'" + DataUtil.GetString(row.Cells[0].Value) + "'," +
                         "" + DataUtil.GetString(row.Cells[2].Value) + "" +
                         ")";
        DataUtil.UpdateThrow(sqlForExecute);
      }
    }
    private void CargarTurnoEstacion(int turnoId)
    {
      string sqlCommand = "SELECT turno_estacion.*, Estacion.Estacion_descripcion FROM Estacion INNER JOIN turno_estacion ON Estacion.Estacion_id = turno_estacion.Estacion_id WHERE turno_id = " + turnoId + " order by Linea";
      DataSet dsTurnoEstacionInfo = DataUtil.FillDataSet(sqlCommand, "turno_estacion");
      foreach (DataRow turnoEstacionRow in dsTurnoEstacionInfo.Tables["turno_estacion"].Rows)
      {
        string[] row = {DataUtil.GetString(turnoEstacionRow["Linea"]),
                        DataUtil.GetString(turnoEstacionRow["Estacion_Descripcion"]),
                        DataUtil.GetString(turnoEstacionRow["Fondo_inicial"]),
                        DataUtil.GetString(turnoEstacionRow["Estacion_id"])
                       };
        dgwCuenta.Rows.Add(row);
        lineGrid = DataUtil.GetInt(turnoEstacionRow["Linea"]);
      }      
    }

    private void dgwCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      if ((dgwCuenta.Rows.Count > 0) && (dgwCuenta.CurrentRow.Cells[0].Value != null))
        txtLinea.Text = DataUtil.GetString(dgwCuenta.CurrentRow.Cells[0].Value);
    }

    private void btnDetalle_Click(object sender, EventArgs e)
    {
      frmCloseTurn frmCloseTurnForm = new frmCloseTurn();
      frmCloseTurnForm.TurnoIDValue = DataUtil.GetInt(txtCodigo.Text);
      frmCloseTurnForm.ShowDialog();
    }
  }
}
