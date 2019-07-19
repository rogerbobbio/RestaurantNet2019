using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmCustomerOrderSplit : frmMain
  {    
    public string tipoVentaView = string.Empty;
    public int pedidoIDView = 0;
    public string tipoMesaView = string.Empty;
    public string mesaIDView = string.Empty;
    public string clienteIDView = string.Empty;

    private int ordenesCreadas = 0;

    private double subTotal0 = 0;
    private double subTotal1 = 0;
    private double subTotal2 = 0;
    private double subTotal3 = 0;

    private int lineGrid0 = 0;
    private int lineGrid1 = 0;
    private int lineGrid2 = 0;
    private int lineGrid3 = 0;

    public frmCustomerOrderSplit()
    {
      InitializeComponent();
    }

    private void frmCustomerOrderSplit_Load(object sender, EventArgs e)
    {
      lblEmployee.Text = AppConstant.EmployeeInfo.Apellidos + ", " + AppConstant.EmployeeInfo.Nombres;
      if (tipoVentaView.Equals(AppConstant.TipoVenta.Salon))
      {
        DataSet dsMesaInfo = DataUtil.FillDataSet("SELECT Pedido_id FROM mesa WHERE mesa_id = " + mesaIDView + "", "mesa");
        pedidoIDView = DataUtil.GetInt(dsMesaInfo.Tables[0].Rows[0], "Pedido_id");
      }
      else
      {
        lblTipo.Visible = false;
        lblMesa.Visible = false;
      }
      GetTurnInfo(0);

      if (pedidoIDView != 0)
      {
        lblCuentaOrigen.Text = DataUtil.GetString(pedidoIDView);
        DataSet dsPedidoInfo = DataUtil.FillDataSet("SELECT last_line, Tipo_venta, turno_id, Atendido_por FROM pedido WHERE pedido_id = " + pedidoIDView + "", "pedido");        

        tipoVentaView = DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Tipo_venta");
        if (tipoVentaView != AppConstant.TipoVenta.Salon)
        {          
          lblTipo.Visible = false;
          lblMesa.Visible = false;
        }
        ViewOrder();
        GetTurnInfo(DataUtil.GetInt(dsPedidoInfo.Tables[0].Rows[0], "turno_id"));
        GetEmployee(DataUtil.GetInt(dsPedidoInfo.Tables[0].Rows[0], "Atendido_por"));
      }      

      lblTipo.Text = tipoMesaView;
      lblMesa.Text = mesaIDView;
      lblTipoOrden.Text = tipoVentaView;
    }    

    #region Botones
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnCuenta1_Click(object sender, EventArgs e)
    {
      if (PasarProducto(1))
        btnCuenta2.Enabled = true;
    }
    private void btnCuenta2_Click(object sender, EventArgs e)
    {
      if (PasarProducto(2))
        btnCuenta3.Enabled = true;
    }
    private void btnCuenta3_Click(object sender, EventArgs e)
    {
      PasarProducto(3);
    }
    private void btnDividir_Click(object sender, EventArgs e)
    {      
      DialogResult result = MessageBox.Show("Desea proceder a dividir esta orden?", "Crear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        if (txtSubTotal.Text == "0.00")
          MessageBox.Show("La cuenta origen no debe quedarse sin productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
          if (txtSubTotal1.Text == "0.00" && txtSubTotal2.Text == "0.00" && txtSubTotal3.Text == "0.00")
            MessageBox.Show("Debe tener al menos 1 nueva cueta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);          
          else
          {
            string refValue = string.Empty;
            if (frmInputBox.InputBox("Ingresar codigo de autorizacion", "Codigo", "empleado", "password", "1", ref refValue, true, AppConstant.GeneralInfo.PasswordDividirCuentas) == DialogResult.OK)
            {
              if (txtSubTotal1.Text != "0.00")
                SaveAccount(dgwCuenta1, lineGrid1);

              if (txtSubTotal2.Text != "0.00")
                SaveAccount(dgwCuenta2, lineGrid2);

              if (txtSubTotal3.Text != "0.00")
                SaveAccount(dgwCuenta3, lineGrid3);

              UpdateCurrentAccount();

              MessageBox.Show("Se crearon " + ordenesCreadas + " orden(es) correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              this.Close();
            }
          }
        }
      }
    }
    #endregion

    #region Metodos Privados
    private bool PasarProducto(int cuentaNumber)
    {
      bool result = false;
      DataGridViewSelectedRowCollection Seleccionados = dgwCuenta.SelectedRows;
      foreach (DataGridViewRow item in Seleccionados)
      {
        DataSet dsProducto = DataUtil.FillDataSet(DataBaseQuerys.Producto(item.Cells["CODIGO"].Value.ToString(), string.Empty, string.Empty, string.Empty), "producto");
        txtCodigoProducto.Text = item.Cells["CODIGO"].Value.ToString();
        txtProducto.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Producto_descripcion");
        txtPrecioUnitario.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Precio_final");
        txtPrecioProveedor.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Precio_proveedor");
        txtCantidad.Text = item.Cells["CANTIDAD"].Value.ToString();
        txtDescuento.Text = item.Cells["DESCUENTO"].Value.ToString();
        AddDetail(cuentaNumber);

        subTotal0 = CalculoMontos(DataUtil.GetDouble(dgwCuenta.Rows[item.Index].Cells["PRECIO_FINAL"].Value), false, subTotal0);
        txtSubTotal.Text = subTotal0.ToString(DataUtil.Format.Decimals);
        this.dgwCuenta.Rows.RemoveAt(item.Index);
        result = true;
      }

      if (result == false)
        MessageBox.Show("Se debe seleccionar al menos 1 producto a divir.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); 

      return result;
    }
    private void GetTurnInfo(int turnoId)
    {
      if (turnoId.Equals(0))
        DataUtil.GetTurnInfo(turnoId);


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
    private void ViewOrder()
    {
      dgwCuenta.Rows.Clear();

      DataSet dsPedidoDetalleInfo = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet("pedido_detalle", "pedido_id", DataUtil.GetString(pedidoIDView), string.Empty), "pedido_detalle");
      foreach (DataRow pedidoDetalleRow in dsPedidoDetalleInfo.Tables["pedido_detalle"].Rows)
      {
        DataSet dsProducto = DataUtil.FillDataSet(DataBaseQuerys.Producto(DataUtil.GetString(pedidoDetalleRow["Codigo_Producto"]), string.Empty, string.Empty, string.Empty), "producto");
        txtCodigoProducto.Text = DataUtil.GetString(pedidoDetalleRow["Codigo_Producto"]);
        txtProducto.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Producto_descripcion");
        txtPrecioUnitario.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Precio_final");
        txtPrecioProveedor.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Precio_proveedor");
        txtCantidad.Text = DataUtil.GetString(pedidoDetalleRow["Cantidad"]);
        txtDescuento.Text = DataUtil.GetString(pedidoDetalleRow["Descuento"]);
        AddDetail(0);
      }
    }
    private void GetEmployee(int codigoEmpleado)
    {
      DataSet dsLogin = DataUtil.FillDataSet("SELECT estado, codigo_empleado, nombres_empleado, apellidos_empleado, cargo, [password] FROM empleado WHERE codigo_empleado = " + codigoEmpleado + "", "empleado");
      if (dsLogin.Tables[0].Rows.Count > 0)
      {
        lblEmployee.Text = DataUtil.GetString(dsLogin.Tables[0].Rows[0], "apellidos_empleado") + ", " +
                           DataUtil.GetString(dsLogin.Tables[0].Rows[0], "nombres_empleado");
      }
    }
    private void AddDetail(int cuentaNumber)
    {
      int lineGrid = 0;
      double calculoMonto = 0;
      if (txtDescuento.Text.Trim() != string.Empty)
        calculoMonto = (DataUtil.GetDouble(txtPrecioUnitario.Text) * (1 - DataUtil.GetDouble(txtDescuento.Text) / 100)) * DataUtil.GetInt(txtCantidad.Text);
      else
        calculoMonto = (DataUtil.GetDouble(txtPrecioUnitario.Text) * DataUtil.GetInt(txtCantidad.Text));

      switch (cuentaNumber)
      {
        case 0:
          lineGrid0 = lineGrid0 + 1;
          lineGrid = lineGrid0;
          break;
        case 1:
          lineGrid1 = lineGrid1 + 1;
          lineGrid = lineGrid1;
          break;
        case 2:
          lineGrid2 = lineGrid2 + 1;
          lineGrid = lineGrid2;
          break;
        case 3:
          lineGrid3 = lineGrid3 + 1;
          lineGrid = lineGrid3;
          break;
      }
      string[] row = {DataUtil.GetString(lineGrid),
                      txtCodigoProducto.Text,
                      txtCantidad.Text,
                      txtProducto.Text,                      
                      txtDescuento.Text,
                      DataUtil.GetString(calculoMonto).ToString()};

      switch (cuentaNumber)
      {
        case 0:
          subTotal0 = CalculoMontos(calculoMonto, true, subTotal0);
          dgwCuenta.Rows.Add(row);
          txtSubTotal.Text = subTotal0.ToString(DataUtil.Format.Decimals);
          break;
        case 1:
          subTotal1 = CalculoMontos(calculoMonto, true, subTotal1);
          dgwCuenta1.Rows.Add(row);
          txtSubTotal1.Text = subTotal1.ToString(DataUtil.Format.Decimals);
          break;
        case 2:
          subTotal2 = CalculoMontos(calculoMonto, true, subTotal2);
          dgwCuenta2.Rows.Add(row);
          txtSubTotal2.Text = subTotal2.ToString(DataUtil.Format.Decimals);
          break;
        case 3:
          subTotal3 = CalculoMontos(calculoMonto, true, subTotal3);
          dgwCuenta3.Rows.Add(row);
          txtSubTotal3.Text = subTotal3.ToString(DataUtil.Format.Decimals);
          break;
      }


      txtCodigoProducto.Text = string.Empty;
      txtProducto.Text = string.Empty;
      txtCantidad.Text = "1";
      txtDescuento.Text = string.Empty;
      txtPrecioUnitario.Text = string.Empty;
      txtPrecioProveedor.Text = string.Empty;
    }
    private double CalculoMontos(double monto, bool sumar, double subTotal)
    {
      if (sumar)
        subTotal = subTotal + monto;
      else
        subTotal = subTotal - monto;
      return subTotal;
    }
    private void SaveAccount(DataGridView dgvMain, int lineGrid)
    {
      int pedidoID = 0;
      int ordenDiaID = 0;

      string sqlForExecute = string.Empty;
      try
      {
        if (pedidoID.Equals(0))
        {
          pedidoID = DataUtil.GetNewId("pedido");
          ordenDiaID = DataUtil.GetOrderByTurn(DataUtil.GetInt(lblTurno.Text));

          string clienteIDValue = "null";
          if (clienteIDView != string.Empty)
            clienteIDValue = clienteIDView;

          string mesaIDValue = "null";
          if (mesaIDView != string.Empty)
            mesaIDValue = mesaIDView;

          sqlForExecute = "INSERT INTO pedido (" +
                             "Pedido_id," +
                             "Mesa_id," +
                             "Turno_id," +
                             "Fecha_Pedido," +
                             "Atendido_por," +
                             "Estado," +
                             "Tipo_venta," +
                             "Cliente_id,"+
                             "Pedido_origen_id,"+
                             "Orden_turno)" +
                       " VALUES (" +
                             pedidoID + "," +
                             "" + mesaIDValue + "," +
                             "" + lblTurno.Text + "," +
                             "'" + DateTime.Now + "'," +
                             "" + AppConstant.EmployeeInfo.Codigo + "," +
                             "'A'," +
                             "'" + tipoVentaView + "'," +
                             "" + clienteIDValue + "," +
                             "" + pedidoIDView + "," +
                             "" + ordenDiaID + "" +
             ")";

          DataUtil.UpdateThrow(sqlForExecute);
        }

        foreach (DataGridViewRow row in dgvMain.Rows)
        {
          string descuentoValue = DataUtil.GetString(row.Cells[4].Value);
          if (descuentoValue.Equals(string.Empty))
            descuentoValue = "null";

          sqlForExecute = "INSERT INTO pedido_detalle (" +
                          "Pedido_detalle_id," +
                          "Pedido_id," +
                          "Linea," +
                          "Codigo_Producto," +
                          "Descripcion_Producto," +
                          "Descuento," +
                          "Cantidad," +
                          "Impreso)" +
                          " VALUES (" +
                           DataUtil.GetNewId("pedido_detalle") + "," +
                           pedidoID + "," +
                           "'" + DataUtil.GetString(row.Cells[0].Value) + "'," +
                           "" + DataUtil.GetString(row.Cells[1].Value) + "," +
                           "'" + DataUtil.GetString(row.Cells[3].Value).Replace("'", "''") + "'," +
                           "" + descuentoValue + "," +
                           "'" + DataUtil.GetString(row.Cells[2].Value) + "'," +
                           "0" +
           ")";
          DataUtil.UpdateThrow(sqlForExecute);
        }

        sqlForExecute = "UPDATE pedido SET " +
                        "Last_Line = " + lineGrid + "" +
                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                        " WHERE Pedido_id = " + pedidoID;
        DataUtil.UpdateThrow(sqlForExecute);

        ordenesCreadas++;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error en Grabar: " + ex.Message);
      }
    }
    private void UpdateCurrentAccount()
    { 
      string sqlForExecute = string.Empty;
      try
      {
        DataUtil.Update("DELETE FROM pedido_detalle WHERE Pedido_id = " + pedidoIDView + "");

        foreach (DataGridViewRow row in dgwCuenta.Rows)
        {
          string descuentoValue = DataUtil.GetString(row.Cells[4].Value);
          if (descuentoValue.Equals(string.Empty))
            descuentoValue = "null";

          sqlForExecute = "INSERT INTO pedido_detalle (" +
                          "Pedido_detalle_id," +
                          "Pedido_id," +
                          "Linea," +
                          "Codigo_Producto," +
                          "Descripcion_Producto," +
                          "Descuento," +
                          "Cantidad," +
                          "Impreso)" +
                          " VALUES (" +
                           DataUtil.GetNewId("pedido_detalle") + "," +
                           pedidoIDView + "," +
                           "'" + DataUtil.GetString(row.Cells[0].Value) + "'," +
                           "" + DataUtil.GetString(row.Cells[1].Value) + "," +
                           "'" + DataUtil.GetString(row.Cells[3].Value).Replace("'", "''") + "'," +
                           "" + descuentoValue + "," +
                           "'" + DataUtil.GetString(row.Cells[2].Value) + "'," +
                           "0" +
           ")";
          DataUtil.UpdateThrow(sqlForExecute);
        }

        sqlForExecute = "UPDATE pedido SET " +
                        "Last_Line = " + lineGrid0 + "" +
                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                        " WHERE Pedido_id = " + pedidoIDView;
        DataUtil.UpdateThrow(sqlForExecute);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error en Grabar: " + ex.Message);
      }
    }
    #endregion
  }
}
