using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmMovements : frmMain
  {
    private double totalGeneral = 0;
    private double totalRetiro = 0;
    private double totalDeposito = 0;

    public frmMovements()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }
    private void frmMovements_Load(object sender, EventArgs e)
    {
      GetTurnInfo();
      DataUtil.FillComboBoxValues(cbEstacion.Items, "SELECT Estacion_descripcion, Estacion_id FROM Estacion WHERE Estacion_id IN (SELECT Estacion_id FROM turno_estacion WHERE Turno_id = "+ lblTurno.Text +") ORDER BY Estacion_descripcion", string.Empty);
      if (AppConstant.EmployeeInfo.Codigo != AppConstant.CodigoAdministrador)
      {
        var dsTurnoEstacion = DataUtil.FillDataSet("SELECT Estacion_Descripcion FROM estacion WHERE persona_asignada = " + AppConstant.EmployeeInfo.Codigo + "", "empleado");
        if (dsTurnoEstacion.Tables[0].Rows.Count > 0)
        {
          cbEstacion.Text = DataUtil.GetString(dsTurnoEstacion.Tables[0].Rows[0], "Estacion_Descripcion");
          cbEstacion.Enabled = false;
        }
      }
      else
        cbEstacion.Text = string.Empty;
      FillGrid();
      txtConcepto.Focus();

      btnDelete.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Movimientos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnAddCargo.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Movimientos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
    }    
    private void cbEstacion_SelectedIndexChanged(object sender, EventArgs e)
    {
      FillGrid();
      txtConcepto.Focus();
    }
    private void btnAddCargo_Click(object sender, EventArgs e)
    {
      if (IsReadyToSaveFirst())
      {
        int movimientoID = DataUtil.GetNewId("movimientos");
        string tipoMovimiento = "RETIRO";
        if (rbtnDeposito.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
        {
          totalDeposito = totalDeposito + DataUtil.GetDouble(txtImporte.Text);
          tipoMovimiento = "DEPOSITO";
        }
        else
          totalRetiro = totalRetiro + DataUtil.GetDouble(txtImporte.Text);

        string sqlForExecute = "INSERT INTO movimientos (" +
                                 "Movimiento_id," +
                                 "Turno_id," +
                                 "Estacion_id," +
                                 "Tipo_movimiento," +
                                 "Concepto," +
                                 "Referencia," +
                                 "Importe," +
                                 "Fecha_creacion," +
                                 "Creado_por)" +
                           " VALUES (" +
                                 movimientoID + "," +
                                 "" + lblTurno.Text + "," +
                                 "" + ((System.Web.UI.WebControls.ListItem)(cbEstacion.SelectedItem)).Value + "," +
                                 "'" + tipoMovimiento + "'," +
                                 "'" + txtConcepto.Text.Trim() + "'," +
                                 "'" + txtReferencia.Text.Trim() + "'," +
                                 "'" + DataUtil.GetDouble(txtImporte.Text) + "'," +
                                 "'" + DateTime.Now + "'," +
                                 "'" + AppConstant.EmployeeInfo.Codigo + "'" +
                           ")";

        if (DataUtil.Update(sqlForExecute))
        {
          totalGeneral = totalRetiro + totalDeposito;
          txtDepositro.Text = totalDeposito.ToString(DataUtil.Format.Decimals);
          txtRetiro.Text = totalRetiro.ToString(DataUtil.Format.Decimals);
          txtTotal.Text = totalGeneral.ToString(DataUtil.Format.Decimals);

          string[] row = { DataUtil.GetString(movimientoID),
                        DataUtil.GetString(tipoMovimiento),
                        DataUtil.GetString(txtConcepto.Text.Trim()),
                        DataUtil.GetCurrency(txtImporte.Text),
                        DataUtil.GetString(DateTime.Now)
                       };
          dgwCuenta.Rows.Add(row);
          txtConcepto.Text = string.Empty;
          txtReferencia.Text = string.Empty;
          txtImporte.Text = string.Empty;
          MessageBox.Show("Registro grabado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
          txtConcepto.Focus();
        }
      }
    }
    private bool IsReadyToSaveFirst()
    {
      epEstacion.SetError(cbEstacion, string.Empty);
      epConcepto.SetError(txtConcepto, string.Empty);
      epImporte.SetError(txtImporte, string.Empty);
      bool valueResult = true;

      if (cbEstacion.SelectedItem == null)
      {
        epEstacion.SetError(cbEstacion, "Por favor ingresar la estacion.");
        valueResult = false;
      }

      if (txtConcepto.Text == string.Empty)
      {
        epConcepto.SetError(txtConcepto, "Por favor ingresar el concepto.");
        valueResult = false;
      }

      if (txtImporte.Text == string.Empty)
      {
        epImporte.SetError(txtImporte, "Por favor ingresar el importe.");
        valueResult = false;
      }

      return valueResult;
    }
    private void FillGrid()
    {
      var commandSQL = string.Empty;
      totalGeneral = 0;
      totalRetiro = 0;
      totalDeposito = 0;

      dgwCuenta.Rows.Clear();
      if (cbEstacion.SelectedItem.ToString() != string.Empty)
        commandSQL = DataBaseQuerys.Movimientos(DataUtil.GetInt(lblTurno.Text), 
                                                DataUtil.GetInt(((System.Web.UI.WebControls.ListItem)(cbEstacion.SelectedItem)).Value));
      else
        commandSQL = DataBaseQuerys.Movimientos(DataUtil.GetInt(lblTurno.Text),0);

      var dsMovimientosInfo = DataUtil.FillDataSet(commandSQL, "movimientos");
      foreach (DataRow movimientosRow in dsMovimientosInfo.Tables["movimientos"].Rows)
      {
        if (DataUtil.GetString(movimientosRow["Tipo_movimiento"]) == "DEPOSITO")
          totalDeposito = totalDeposito + DataUtil.GetDouble(movimientosRow["Importe"]);
        else
          totalRetiro = totalRetiro + DataUtil.GetDouble(movimientosRow["Importe"]);

        totalGeneral = totalRetiro + totalDeposito;

        string[] row = {DataUtil.GetString(movimientosRow["Movimiento_id"]),
                        DataUtil.GetString(movimientosRow["Tipo_movimiento"]),
                        DataUtil.GetString(movimientosRow["Concepto"]),
                        DataUtil.GetString(movimientosRow["Importe"]),
                        DataUtil.GetString(movimientosRow["Fecha_creacion"])
                       };
        dgwCuenta.Rows.Add(row);
      }
      txtDepositro.Text = totalDeposito.ToString(DataUtil.Format.Decimals);
      txtRetiro.Text = totalRetiro.ToString(DataUtil.Format.Decimals);
      txtTotal.Text = totalGeneral.ToString(DataUtil.Format.Decimals);
    }
    private void GetTurnInfo()
    {
      if (AppConstant.Turno.Codigo != string.Empty)
      {
        lblTurno.Text = AppConstant.Turno.Codigo;
        lblTurnoFecha.Text = AppConstant.Turno.FechaHora;
      }
      else
      {
        lblTurno.Text = string.Empty;
        lblTurnoFecha.Text = string.Empty;
      }
    }
    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (isRecordSelected())
      {
        DialogResult diagResult = MessageBox.Show("Está seguro de eliminar el movimiento seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (diagResult == DialogResult.Yes)
        {
          DataGridViewSelectedRowCollection Seleccionados = dgwCuenta.SelectedRows;
          foreach (DataGridViewRow item in Seleccionados)
          {
            if (DataUtil.Update("DELETE FROM movimientos WHERE Movimiento_id = " + item.Cells["MOVIMIENTO_ID"].Value.ToString() + ""))
            {
              if (DataUtil.GetString(item.Cells["Tipo_movimiento"].Value) == "DEPOSITO")
                totalDeposito = totalDeposito - DataUtil.GetDouble(item.Cells["ImporteNeto"].Value);
              else
                totalRetiro = totalRetiro - DataUtil.GetDouble(item.Cells["ImporteNeto"].Value);

              totalGeneral = totalRetiro + totalDeposito;
              txtDepositro.Text = totalDeposito.ToString(DataUtil.Format.Decimals);
              txtRetiro.Text = totalRetiro.ToString(DataUtil.Format.Decimals);
              txtTotal.Text = totalGeneral.ToString(DataUtil.Format.Decimals);

              this.dgwCuenta.Rows.RemoveAt(item.Index);
            }
          }
        }
      }
      else
        MessageBox.Show("Seleccione un registro", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private bool isRecordSelected()
    {
      bool result = false;
      DataGridViewSelectedRowCollection Seleccionados = dgwCuenta.SelectedRows;
      foreach (DataGridViewRow item in Seleccionados)
        result = true;
      return result;
    }
  }
}
