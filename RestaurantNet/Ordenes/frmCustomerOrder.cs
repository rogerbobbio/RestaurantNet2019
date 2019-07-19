using System;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using RestaurantNet.Reports;

namespace RestaurantNet
{
  public partial class frmCustomerOrder : frmMain
  {
    #region Constant
    private int lineGrid = 0;
    public string mesaID = string.Empty;
    public string mesaDesc = string.Empty;
    public string tipoMesa = string.Empty;
    public int pedidoID = 0;
    public int ordenDiaID = 0;
    public string tipoVenta = string.Empty;
    public string clienteID = string.Empty;
    private double subTotal;
    private double totalDescuento;

    private int gridLineaNumero = 0;
    private int gridProdCodigo = 1;
    private int gridProdDescripcion = 2;
    private int gridCantidad = 3;
    private int gridDescuento = 4;
    private int gridPrecio = 5;
    private int gridDescuentoMonto = 9;
    #endregion

    public frmCustomerOrder()
    {
      InitializeComponent();
      IniEmpleadoCombo();
    }
    private void frmCustomerOrder_Load(object sender, EventArgs e)
    {
      FillEmpleadoCombo();
      if (tipoVenta.Equals(AppConstant.TipoVenta.Salon))
      {
        GetMesaInfo();                
        btnCambiarMesa.Visible = true;
        lblTipoMesa.Visible = true;
        lblMesaDesc.Visible = true;
      }
      else
      {
        btnCambiarMesa.Visible = false;
        lblTipoMesa.Visible = false;
        lblMesaDesc.Visible = false;
      }
      GetTurnInfo(0);

      if (pedidoID != 0)
      {
        var dsPedidoInfo = DataUtil.FillDataSet("SELECT last_line, Tipo_venta, turno_id, Atendido_por, Pedido_origen_id, mesa_id, Cliente_id, Orden_turno " +
                                                    " FROM pedido WHERE pedido_id = " + pedidoID + "", "pedido");
        lineGrid = DataUtil.GetInt(dsPedidoInfo.Tables[0].Rows[0], "last_line");
        tipoVenta = DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Tipo_venta");
        clienteID = DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Cliente_id");
        ordenDiaID = DataUtil.GetInt(dsPedidoInfo.Tables[0].Rows[0], "Orden_turno");
        GetCustomerInfo();
        lblTipoOrden.Text = tipoVenta;
        if (tipoVenta != AppConstant.TipoVenta.Salon)
        {          
          btnCambiarMesa.Visible = false;
          lblTipoMesa.Visible = false;
          lblMesaDesc.Visible = false;
        }
        else
        {
          mesaID = DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "mesa_id");
          GetMesaInfo();
          btnCambiarMesa.Visible = true;
          lblTipoMesa.Visible = true;
          lblMesaDesc.Visible = true;
        }
        btnViewOrder_Click(null, null);
        ShowButtonsOrder(true);
        GetTurnInfo(DataUtil.GetInt(dsPedidoInfo.Tables[0].Rows[0], "turno_id"));
        GetEmployee(DataUtil.GetInt(dsPedidoInfo.Tables[0].Rows[0], "Atendido_por"));

        if (DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Pedido_origen_id") != string.Empty)
        {
          lblOrdenOrigen.Visible = true;
          lblOrdenOrigenValue.Visible = true;
          lblOrdenOrigenValue.Text = DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Pedido_origen_id");
          btnSepararCuenta.Visible = false;
          btnNotaVenta.Visible = false;
          btnCancelOrder.Visible = false;
          btnCambiarMesa.Visible = false;
        }

        if (ExistenOrdenesAsociadas())
          btnVerCuentasAsociadas.Visible = true;
      }
      else
      {
        if (tipoVenta != string.Empty)
          lblTipoOrden.Text = tipoVenta;
        btnViewOrder.Visible = false;
        btnReprint.Visible = false;
        ShowButtonsOrder(false);
        if (AppConstant.EmployeeInfo.Cargo != AppConstant.EmpleadoCargo.Mozo)
          radmccbEmpleado.Enabled = true;
        radmccbEmpleado.Text = AppConstant.EmployeeInfo.Apellidos + @", " + AppConstant.EmployeeInfo.Nombres;
        radmccbEmpleado.SelectedValue = AppConstant.EmployeeInfo.Apellidos + ", " + AppConstant.EmployeeInfo.Nombres;
      }
      GetCustomerInfo();
      txtProducto.Focus();
      Text = Text + @": " + pedidoID;
      lblOrderDiaNo.Text = DataUtil.GetString(ordenDiaID);
      lblOrderDia.Visible = true;
      lblOrderDiaNo.Visible = true;
      lblIGVCopy.Text = @"IGV (" + AppConstant.GeneralInfo.IGV + @" %)";
    }

    #region Eventos
    private void txtProducto_Leave(object sender, EventArgs e)
    {
      txtCodigoProducto.Text = string.Empty;
      txtPrecioUnitario.Text = string.Empty;

      if (txtProducto.Text != string.Empty)
      {
        var stringSql = DataBaseQuerys.ProductoSearch();

        var dsSearch = DataUtil.FillDataSet("SELECT " + stringSql + " WHERE p.Producto_descripcion like '%" + txtProducto.Text.Trim().Replace("'", "''") + "%' ORDER BY p.Producto_descripcion", "producto");
        if (dsSearch.Tables[0].Rows.Count == 1)
        {
          txtProducto.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Producto");
          txtCodigoProducto.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Codigo");
          txtPrecioUnitario.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Precio final");
        }
        else if (dsSearch.Tables[0].Rows.Count > 1)
        {
          frmProductSearch frmProductSearchForm = new frmProductSearch();
          frmProductSearchForm.descriptionSearch = txtProducto.Text;
          frmProductSearchForm.dsSearchProd = dsSearch;
          frmProductSearchForm.ShowDialog();
          SetProductValues();
        }
        else
        {
          DialogResult result = MessageBox.Show(@"No existe el producto. Desea crear uno nuevo?", @"Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == DialogResult.Yes)
          {
            frmProduct frmProductAdd = new frmProduct();
            frmProductAdd.adding = true;
            frmProductAdd.createSpecial = true;
            frmProductAdd.productoNombre = txtProducto.Text.Trim();
            frmProductAdd.formTitle = "Producto - Agregar";
            frmProductAdd.ShowDialog();
            SetProductValues();
          }
          else
            txtProducto.Focus();
        }
      }
    }
    private void txtProducto_DoubleClick(object sender, EventArgs e)
    {
      AppConstant.Calculator.textIN = string.Empty;
      frmKeyboard frmKeyboardForm = new frmKeyboard();
      frmKeyboardForm.ShowDialog();
      if (AppConstant.Calculator.textOUT != string.Empty)
        txtProducto.Text = AppConstant.Calculator.textOUT;

      AppConstant.Calculator.textIN = string.Empty;
      AppConstant.Calculator.textOUT = string.Empty;
    }
    private void txtCantidad_DoubleClick(object sender, EventArgs e)
    {
      txtCantidad.Text = GotoCalculator(string.Empty);
    }
    private void txtDescuento_DoubleClick(object sender, EventArgs e)
    {
      txtDescuento.Text = GotoCalculator(string.Empty);
    }
    private void txtLinea_DoubleClick(object sender, EventArgs e)
    {
      txtLinea.Text = GotoCalculator(string.Empty);
    }
    #endregion

    #region Botones

      private void btnAdd_Click(object sender, EventArgs e)
      {
          if (btnCreateOrder.Visible)
          {
              if (txtCantidad.Text.Trim() != string.Empty && txtProducto.Text.Trim() != string.Empty)
              {
                  double calculoMonto;
                  double descuentoMonto = 0;
                  if (txtDescuento.Text.Trim() != string.Empty)
                  {
                      calculoMonto = Math.Round((DataUtil.GetDouble(txtPrecioUnitario.Text) * (1 - DataUtil.GetDouble(txtDescuento.Text) / 100)) * DataUtil.GetInt(txtCantidad.Text), 2);
                      var totalSinDescuento = Math.Round((DataUtil.GetDouble(txtPrecioUnitario.Text) * DataUtil.GetInt(txtCantidad.Text)) ,2);
                      descuentoMonto = Math.Round(totalSinDescuento - calculoMonto, 2);
                  }                  
                  else
                    calculoMonto = Math.Round((DataUtil.GetDouble(txtPrecioUnitario.Text) * DataUtil.GetInt(txtCantidad.Text)),2);

                  var montoIgv = Math.Round((calculoMonto * 1.18), 1);

                  lineGrid = lineGrid + 1;
                  string[] row =
                  {
                      DataUtil.GetString(lineGrid),
                      txtCodigoProducto.Text,
                      txtProducto.Text,
                      txtCantidad.Text,
                      txtDescuento.Text,
                      DataUtil.GetString(calculoMonto),
                      txtPrecioUnitario.Text,
                      txtProductoPrecioProveedor.Text,
                      DataUtil.GetString(montoIgv),
                      DataUtil.GetString(descuentoMonto)
                  };
                  dgwCuenta.Rows.Add(row);
                  CalculoMontos(calculoMonto, true, descuentoMonto);

                  txtCodigoProducto.Text = string.Empty;
                  txtProducto.Text = string.Empty;
                  txtCantidad.Text = @"1";
                  txtDescuento.Text = string.Empty;
                  txtPrecioUnitario.Text = string.Empty;
                  txtProductoPrecioProveedor.Text = string.Empty;

                  txtProducto.Focus();
              }
              else
              {
                  txtProducto.Focus();
                  MessageBox.Show(@"Debe ingresar el Producto y la cantidad.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
          }
          else
              MessageBox.Show(@"Debe crear una nueva orden.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    private void btnNewOrder_Click(object sender, EventArgs e)
    {
      btnViewOrder.Visible = true;
      btnNewOrder.Visible = false;
      btnCreateOrder.Visible = true;
      btnReprint.Visible = false;
      dgwCuenta.Rows.Clear();
      if (pedidoID != 0)
      {
        string sWhere = "pedido_id = " + DataUtil.GetString(pedidoID) + "";
        lineGrid = DataUtil.GetInt(DataUtil.FindSingleRow("pedido", "last_line", sWhere));
      }
      else
        lineGrid = 0;
    }

      private void btnViewOrder_Click(object sender, EventArgs e)
      {
          dgwCuenta.Rows.Clear();
          subTotal = 0;
          totalDescuento = 0;

          btnViewOrder.Visible = false;
          btnNewOrder.Visible = true;
          btnCreateOrder.Visible = false;

          var dsPedidoDetalleInfo = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet("pedido_detalle", "pedido_id", DataUtil.GetString(pedidoID), string.Empty), "pedido_detalle");
          foreach (DataRow pedidoDetalleRow in dsPedidoDetalleInfo.Tables["pedido_detalle"].Rows)
          {
              var dsProducto = DataUtil.FillDataSet(DataBaseQuerys.Producto(DataUtil.GetString(pedidoDetalleRow["Codigo_Producto"]), string.Empty,
                          string.Empty, string.Empty), "producto");
              var precioUnitario = DataUtil.GetDouble(dsProducto.Tables[0].Rows[0], "Precio_final");
              var precioProveedor = DataUtil.GetDouble(dsProducto.Tables[0].Rows[0], "Precio_proveedor");
              var descuento = DataUtil.GetDouble(pedidoDetalleRow["Descuento"]);
              var cantidad = DataUtil.GetInt(pedidoDetalleRow["Cantidad"]);

              double calculoMonto;
              double descuentoMonto = 0;
              if (Math.Abs(descuento) > 0)
              {
                  calculoMonto = Math.Round((precioUnitario * (1 - descuento / 100)) * cantidad, 2);
                  var totalSinDescuento = Math.Round(precioUnitario * cantidad, 2);
                  descuentoMonto = Math.Round(totalSinDescuento - calculoMonto, 2);
              }
              else
                  calculoMonto = precioUnitario * cantidad;

              var montoIgv = Math.Round((calculoMonto * 1.18), 1);

              string[] row =
              {
                  DataUtil.GetString(pedidoDetalleRow["Linea"]),
                  DataUtil.GetString(pedidoDetalleRow["Codigo_Producto"]),
                  DataUtil.GetString(pedidoDetalleRow["Descripcion_Producto"]),
                  DataUtil.GetString(pedidoDetalleRow["Cantidad"]),
                  DataUtil.GetString(pedidoDetalleRow["Descuento"]),
                  DataUtil.GetString(calculoMonto),
                  DataUtil.GetString(precioUnitario),
                  DataUtil.GetString(precioProveedor),
                  DataUtil.GetString(montoIgv),
                  DataUtil.GetString(descuentoMonto)
              };
              dgwCuenta.Rows.Add(row);
              CalculoMontos(calculoMonto, true, descuentoMonto);
          }
      }

      private void btnCreateOrder_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show(@"Desea proceder a crear esta orden?", @"Crear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        if (IsReadyToSave())
        {
          try
          {
            string sqlForExecute;
            if (pedidoID.Equals(0))
            {
              pedidoID = DataUtil.GetNewId("pedido");
              ordenDiaID = DataUtil.GetOrderByTurn(DataUtil.GetInt(lblTurno.Text));
              Text = Text + @": " + pedidoID;
              lblOrderDiaNo.Text = DataUtil.GetString(ordenDiaID);
              lblOrderDia.Visible = true;
              lblOrderDiaNo.Visible = true;

              string clienteIDValue = "null";
              if (clienteID != string.Empty)
                clienteIDValue = clienteID;

              string mesaIDValue = "null";
              if (mesaID != string.Empty)
                mesaIDValue = mesaID;

              sqlForExecute = "INSERT INTO pedido (" +
                                 "Pedido_id," +
                                 "Mesa_id," +
                                 "Turno_id," +
                                 "Fecha_Pedido," +
                                 "Atendido_por," +
                                 "Estado," +
                                 "Tipo_venta," +
                                 "Cliente_id," +
                                 "Orden_turno)" +
                           " VALUES (" +
                                 pedidoID + "," +
                                 "" + mesaIDValue + "," +
                                 "" + lblTurno.Text + "," +
                                 "'" + DateTime.Now + "'," +
                                 "" + radmccbEmpleado.EditorControl.Rows[radmccbEmpleado.SelectedIndex].Cells["Codigo_empleado"].Value + "," +
                                 "'A'," +
                                 "'" + tipoVenta + "'," +
                                 "" + clienteIDValue + "," +
                                 "" + ordenDiaID + "" +
                 ")";

              DataUtil.UpdateThrow(sqlForExecute);
            }

            foreach (DataGridViewRow row in dgwCuenta.Rows)
            {
              string descuentoValue = DataUtil.GetString(row.Cells[gridDescuento].Value);
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
                               "'" + DataUtil.GetString(row.Cells[gridLineaNumero].Value) + "'," +
                               "" + DataUtil.GetString(row.Cells[gridProdCodigo].Value) + "," +
                               "'" + DataUtil.GetString(row.Cells[gridProdDescripcion].Value).Replace("'", "''") + "'," +
                               "" + descuentoValue + "," +
                               "'" + DataUtil.GetString(row.Cells[gridCantidad].Value) + "'," +
                               "0"+
               ")";
              DataUtil.UpdateThrow(sqlForExecute);
            }

            if (mesaID != string.Empty)
            {
              sqlForExecute = "UPDATE mesa SET " +
                              " Mesa_estado = 'OCUPADA'," +
                              " Pedido_id = " + pedidoID + "" +
                              " WHERE Mesa_id = " + mesaID;
              DataUtil.UpdateThrow(sqlForExecute);
            }

            sqlForExecute = "UPDATE pedido SET " +
                            "  Last_Line = " + lineGrid + "" +
                            ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                            ", Actualizado_por = '" + radmccbEmpleado.EditorControl.Rows[radmccbEmpleado.SelectedIndex].Cells["Codigo_empleado"].Value + "'" +
                            " WHERE Pedido_id = " + pedidoID;
            DataUtil.UpdateThrow(sqlForExecute);


            PrintDocuments(pedidoID, 0);
            btnReprint.Visible = true;
            btnCreateOrder.Visible = false;
            MessageBox.Show(@"Orden agregada correctamente.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNewOrder.Visible = true;
            radmccbEmpleado.Enabled = false;
            ShowButtonsOrder(true);
          }
          catch (Exception ex)
          {
            MessageBox.Show(@"Error en Grabar: " + ex.Message);
          }
        }
      }
    }
    private void btnCambiarMesa_Click(object sender, EventArgs e)
    {
      if (pedidoID != 0)
      {
        frmChangeTable frmChangeTableForm = new frmChangeTable();
        frmChangeTableForm.mesa = mesaID;
        frmChangeTableForm.pedidoID = DataUtil.GetString(pedidoID);
        frmChangeTableForm.ShowDialog();

        string sWhere = "pedido_id = " + DataUtil.GetString(pedidoID) + "";
        string newMesaId = DataUtil.FindSingleRow("pedido", "mesa_id", sWhere);
        tipoVenta = DataUtil.FindSingleRow("pedido", "Tipo_venta", sWhere);
        if (newMesaId != mesaID)
        {
          lblTipoOrden.Text = tipoVenta;
          mesaID = newMesaId;
          GetMesaInfo();
        }
      }
      else
        MessageBox.Show(@"Debe agregar una Orden.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    private void btnSepararCuenta_Click(object sender, EventArgs e)
    {
      if (pedidoID != 0)
      {
        frmCustomerOrderSplit frmCustomerOrderSplitForm = new frmCustomerOrderSplit();
        frmCustomerOrderSplitForm.mesaIDView = mesaID;
        frmCustomerOrderSplitForm.pedidoIDView = pedidoID;
        frmCustomerOrderSplitForm.tipoVentaView = tipoVenta;
        frmCustomerOrderSplitForm.tipoMesaView = tipoMesa;
        frmCustomerOrderSplitForm.clienteIDView = clienteID;
        frmCustomerOrderSplitForm.ShowDialog();

        if (ExistenOrdenesAsociadas())
        {
          btnViewOrder_Click(null, null);
          btnVerCuentasAsociadas.Visible = true;
        }        
      }
      else
        MessageBox.Show(@"Debe agregar una Orden.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    private void btnPagar_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(31, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        if (ValidarCajero())
        {
          if (DataUtil.GetDouble(txtTotalGeneralCopy.Text) != 0)
          {
            if (pedidoID != 0)
            {
              DialogResult result = MessageBox.Show(@"Desea proceder a pagar esta orden?", @"Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (result == DialogResult.Yes)
              {
                AppConstant.Order.PedidoID = DataUtil.GetString(pedidoID);
                AppConstant.Order.OrdenDiaID = DataUtil.GetString(ordenDiaID);
                AppConstant.Order.MesaID = mesaID;
                AppConstant.Order.MesaDescripcion = mesaDesc;
                AppConstant.Order.MesaTipo = tipoMesa;
                AppConstant.Order.TipoVenta = tipoVenta;
                if (lblOrdenOrigenValue.Visible)
                  AppConstant.Order.PedidoOrigenID = lblOrdenOrigenValue.Text;
                Close();
              }
            }
            else
              MessageBox.Show(@"Debe agregar una Orden.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
          else
          {
            txtProducto.Focus();
            MessageBox.Show(@"Debe tener algun producto a pagar.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      AppConstant.Order.PedidoID = string.Empty;
      AppConstant.Order.OrdenDiaID = string.Empty;
      AppConstant.Order.PedidoOrigenID = string.Empty;
      Close();
    }
    private void btnCancelOrder_Click(object sender, EventArgs e)
    {
      if (pedidoID != 0)
      {
        var result = MessageBox.Show(@"Desea anular esta orden?", @"Anular Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
          var frmCustomerOrderCancelForm = new frmCustomerOrderCancel();
          frmCustomerOrderCancelForm.mesaID = DataUtil.GetInt(mesaID);
          frmCustomerOrderCancelForm.pedidoID = pedidoID;
          frmCustomerOrderCancelForm.ShowDialog();

          var sWhere = "pedido_id = " + DataUtil.GetString(pedidoID) + "";
          var newEstado = DataUtil.GetString(DataUtil.FindSingleRow("pedido", "Estado", sWhere));
          if (newEstado.Equals(AppConstant.PedidoEstado.Anulado))
            Close();
        }
      }
      else
        MessageBox.Show(@"Debe agregar una Orden.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }    
    private void btnNotaVenta_Click(object sender, EventArgs e)
    {
      if (pedidoID != 0)
      {
        DialogResult result = MessageBox.Show(@"Desea generar una nota de venta con esta orden?", @"Nota Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
          var frmCustomerOrderSaleNoteForm = new frmCustomerOrderSaleNote();
          frmCustomerOrderSaleNoteForm.mesaID = DataUtil.GetInt(mesaID);
          frmCustomerOrderSaleNoteForm.pedidoID = pedidoID;
          frmCustomerOrderSaleNoteForm.ShowDialog();
          string sWhere = "pedido_id = " + DataUtil.GetString(pedidoID) + "";
          string newEstado = DataUtil.GetString(DataUtil.FindSingleRow("pedido", "Estado", sWhere));
          if (newEstado.Equals("N"))
            this.Close();
        }
      }
      else
        MessageBox.Show(@"Debe agregar una Orden.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    private void btnReprint_Click(object sender, EventArgs e)
    {
      string refValue = string.Empty;
      var result = MessageBox.Show(@"Desea re-imprimir la orden de la mesa?", @"Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        if (CheckPrinters())
        {
          if (frmInputBox.InputBox("Ingresar codigo de autorizacion", "Codigo", "empleado", "password", "1", ref refValue, true, AppConstant.GeneralInfo.PasswordReimpresiones) == DialogResult.OK)         
            PrintDocuments(pedidoID, 1);         
        }
      }
    }
    private void btnVerCuentasAsociadas_Click(object sender, EventArgs e)
    {
      var frmAccountSearchForm = new frmAccountSearch();
      frmAccountSearchForm.titleForm = "Busqueda de Ordenes por Cobrar";
      frmAccountSearchForm.pedidoEstado = "A";
      frmAccountSearchForm.pedidoOrigen = DataUtil.GetString(pedidoID);
      frmAccountSearchForm.ShowDialog();
    }
    private void btnAddProduct_Click(object sender, EventArgs e)
    {
      if (btnCreateOrder.Visible == true)
      {
        var frmTakeOrderForm = new frmTakeOrder();
        frmTakeOrderForm.ShowDialog();
        if (DataUtil.dgvTemporal != null)
        {
          foreach (DataGridViewRow row in DataUtil.dgvTemporal.Rows)
          {
            txtCodigoProducto.Text = DataUtil.GetString(row.Cells[gridProdCodigo].Value);
            txtProducto.Text = DataUtil.FindSingleRow("producto", "Producto_descripcion", "Producto_id = " + DataUtil.GetString(row.Cells[gridProdCodigo].Value) + "");
            txtPrecioUnitario.Text = DataUtil.FindSingleRow("producto", "Precio_final", "Producto_id = " + DataUtil.GetString(row.Cells[gridProdCodigo].Value) + "");            
            txtCantidad.Text = DataUtil.GetString(row.Cells[gridCantidad].Value);
            btnAdd_Click(null, null);
          }
          DataUtil.dgvTemporal = null;
        }
      }
      else
        MessageBox.Show(@"Debe crear una nueva orden.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    private void btnBorrar_Click(object sender, EventArgs e)
    {
      var refValue = string.Empty;
      if (txtLinea.Text.Trim() != string.Empty)
      {
        var result = MessageBox.Show(@"Está seguro de eliminar la linea " + txtLinea.Text + @" ?", @"Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
          if (btnCreateOrder.Visible)
          {
            for (int i = 0; i < dgwCuenta.RowCount; i++)
            {
              if (DataUtil.GetString(dgwCuenta.Rows[i].Cells[gridLineaNumero].Value) == txtLinea.Text)
              {
                CalculoMontos(DataUtil.GetDouble(dgwCuenta.Rows[i].Cells[gridPrecio].Value), false, DataUtil.GetDouble(dgwCuenta.Rows[i].Cells[gridDescuentoMonto].Value));
                dgwCuenta.Rows.RemoveAt(i);
                txtLinea.Text = string.Empty;
                break;
              }
            }
          }
          else
          {
            if (frmInputBox.InputBox("Ingresar codigo de autorizacion", "Codigo", "empleado", "password", "1", ref refValue, true, AppConstant.GeneralInfo.PasswordEliminarProducto) == DialogResult.OK)
            {
              for (int i = 0; i < dgwCuenta.RowCount; i++)
              {
                if (DataUtil.GetString(dgwCuenta.Rows[i].Cells[gridLineaNumero].Value) == txtLinea.Text)
                {
                  CalculoMontos(DataUtil.GetDouble(dgwCuenta.Rows[i].Cells[gridPrecio].Value), false, DataUtil.GetDouble(dgwCuenta.Rows[i].Cells[gridDescuentoMonto].Value));
                  SaveProductDeleted(txtLinea.Text,
                                     DataUtil.GetInt(dgwCuenta.Rows[i].Cells[gridProdCodigo].Value),
                                     DataUtil.GetString(dgwCuenta.Rows[i].Cells[gridProdDescripcion].Value));
                  dgwCuenta.Rows.RemoveAt(i);
                  txtLinea.Text = string.Empty;
                  break;
                }
              }
            }
          }
        }
      }
      else
        MessageBox.Show(@"Seleccionar la linea a borrar.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    #endregion
    
    #region Metodos privados
    private void SetProductValues()
    {
      if (AppConstant.Product.ProductoDescription != string.Empty)
      {
        txtProducto.Text = AppConstant.Product.ProductoDescription;
        txtCodigoProducto.Text = AppConstant.Product.ProductoCodigo;
        txtPrecioUnitario.Text = AppConstant.Product.ProductoPrecio;

        AppConstant.Product.ProductoDescription = string.Empty;
        AppConstant.Product.ProductoCodigo = string.Empty;
        AppConstant.Product.ProductoPrecio = string.Empty;
      }
    }
    private bool IsReadyToSave()
    {      
      var valueResult = true;
      if (dgwCuenta.Rows.Count.Equals(0))
      {
        MessageBox.Show(@"Agregar al menos un producto.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        valueResult = false;
      }      

      return valueResult && CheckPrinters();
    }
    private bool CheckPrinters()
    {
      var contadorImpresoras = 0;
      var valueResult = true;
      if (cbBar.Checked)
        contadorImpresoras++;
      if (cbCocina.Checked)
        contadorImpresoras++;      
      if (contadorImpresoras.Equals(0))
      {
        MessageBox.Show(@"Marcar al menos una impresora.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        valueResult = false;
      }
      return valueResult;
    }
    private void GetTurnInfo(int turnoId)
    {
      if (turnoId.Equals(0))
        DataUtil.GetTurnInfo(turnoId);
      

      if (AppConstant.Turno.Codigo != string.Empty)
      {
        lblTurno.Text = AppConstant.Turno.Codigo;
        lblTurnoFecha.Text = AppConstant.Turno.FechaHora;
        if (AppConstant.Turno.Estado.Equals("CERRADO"))
        {
          lblTurnoEstado.Visible = true;
          lblTurnoEstadoTexto.Visible = true;
          lblTurnoEstadoTexto.Text = @"CERRADO";
        }
      }
      else
      {
        lblTurno.Text = string.Empty;
        lblTurnoFecha.Text = string.Empty;
      }
    }
    private void ShowButtonsOrder(bool value)
    {      
      btnPagar.Visible = value;
      btnNotaVenta.Visible = value;
      btnCancelOrder.Visible = value;      
      btnSepararCuenta.Visible = value;
      btnCambiarMesa.Visible = value;
      HideDelivery();
    }
    private void HideDelivery()
    {
      if (tipoVenta == AppConstant.TipoVenta.Delivery)
      {
        btnSepararCuenta.Visible = false;
        btnCambiarMesa.Visible = false;
      }
    }
    private void GetEmployee(int codigoEmpleado)
    {
      DataSet dsEmpleado = DataUtil.FillDataSet("SELECT estado, codigo_empleado, nombres_empleado, apellidos_empleado, cargo, [password] FROM empleado WHERE codigo_empleado = " + codigoEmpleado + "", "empleado");
      if (dsEmpleado.Tables[0].Rows.Count > 0)
      {
        radmccbEmpleado.Text = DataUtil.GetString(dsEmpleado.Tables[0].Rows[0], "apellidos_empleado") + ", " +
                               DataUtil.GetString(dsEmpleado.Tables[0].Rows[0], "nombres_empleado");
        radmccbEmpleado.SelectedValue = DataUtil.GetString(dsEmpleado.Tables[0].Rows[0], "apellidos_empleado") + ", " +
                                        DataUtil.GetString(dsEmpleado.Tables[0].Rows[0], "nombres_empleado");
      }
    }
    private string GotoCalculator(string textIn)
    {
      string returnValue = string.Empty;
      AppConstant.Calculator.textIN = textIn;
      frmCalculator frmCalculatorForm = new frmCalculator();
      frmCalculatorForm.ShowDialog();
      if (AppConstant.Calculator.textOUT != string.Empty)
        returnValue = AppConstant.Calculator.textOUT;

      AppConstant.Calculator.textIN = string.Empty;
      AppConstant.Calculator.textOUT = string.Empty;
      return returnValue;
    }
    private void GetMesaInfo()
    {      
      var dsMesaInfo = DataUtil.FillDataSet(DataBaseQuerys.Mesa(DataUtil.GetInt(mesaID)), "mesa");
      if (dsMesaInfo.Tables[0].Rows.Count > 0)
      {
        if (DataUtil.GetString(DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "mesa_tipo")).Equals("BAR"))
          tipoMesa = "Bar :";
        else
          tipoMesa = "Mesa :";

        mesaDesc = DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Mesa_descripcion");
        if (pedidoID == 0)       
          pedidoID = DataUtil.GetInt(dsMesaInfo.Tables[0].Rows[0], "Pedido_id");        
        
        lblTipoMesa.Visible = true;
        lblMesaDesc.Visible = true;
        lblTipoMesa.Text = tipoMesa;
        lblMesaDesc.Text = mesaDesc;
      }
    }
    private bool ExistenOrdenesAsociadas()
    {
      var result = false;      
      var dsPedido = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet("pedido", "Pedido_origen_id", DataUtil.GetString(pedidoID), string.Empty), "pedido");
      if (dsPedido.Tables[0].Rows.Count > 0)
        result = true;
      return result;
    }
    private void GetCustomerInfo()
    {
      if (clienteID != string.Empty)
      {
        var dsSearch = DataUtil.FillDataSet("SELECT IIf(Tipo_documento='RUC',cliente_apellidos,cliente_apellidos+', '+cliente_nombres) AS Cliente FROM cliente WHERE cliente_id = " + clienteID + "", "cliente");
        if (dsSearch.Tables[0].Rows.Count == 1)
        {
          lblClienteValue.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Cliente");
          lblClienteValue.Visible = true;
          lblClienteLabel.Visible = true;
        }
      }
    }

      private void CalculoMontos(double monto, bool sumar, double descuento)
      {
          if (sumar)
          {
              subTotal = subTotal + monto;
              totalDescuento = totalDescuento + descuento;
          }
          else
          {
              subTotal = subTotal - monto;
              totalDescuento = totalDescuento - descuento;
          }          
          var igvValue = (subTotal * (DataUtil.GetDouble(AppConstant.GeneralInfo.IGV) / 100));
          var totalGeneral = subTotal + igvValue - totalDescuento;
          txtSubTotalCopy.Text = subTotal.ToString(DataUtil.Format.Decimals);
          txtTotalDescuentoCopy.Text = totalDescuento.ToString(DataUtil.Format.Decimals);
          txtIGVCopy.Text = igvValue.ToString(DataUtil.Format.Decimals);
          txtTotalGeneralCopy.Text = totalGeneral.ToString(DataUtil.Format.Decimals);
      }

      private bool ValidarCajero()
    {
      var resultado = false;
      
        if (AppConstant.EmployeeInfo.Codigo != AppConstant.CodigoAdministrador)
        {
          var dsTurnoEstacion = DataUtil.FillDataSet(DataBaseQuerys.TurnoEstacion(), "empleado");
          if (dsTurnoEstacion.Tables[0].Rows.Count > 0)
            resultado = true;
          else          
            MessageBox.Show(@"Su estacion no esta registrada en el turno actual.", @"Estacion", MessageBoxButtons.OK, MessageBoxIcon.Error);          
        }
        else
          resultado = true;      

      return resultado;
    }
    private void SaveProductDeleted(string lineaNo, int codigoProducto, string descripcionProducto)
    {
      try
      {
        var pedidoProductoID = DataUtil.GetNewId("pedido_producto_eliminado");
        var sqlForExecute = "INSERT INTO Pedido_Producto_Eliminado (" +
                                 "Pedido_producto_id," +
                                 "Pedido_id," +
                                 "Codigo_Producto," +
                                 "Descripcion_Producto," +
                                 "Fecha_anulacion," +
                                 "Eliminado_por)" +
                           " VALUES (" +
                                 pedidoProductoID + "," +
                                 pedidoID + "," +
                                 codigoProducto + "," +
                                 "'" + descripcionProducto + "'," +
                                 "'" + DateTime.Now + "'," +
                                 "" + AppConstant.EmployeeInfo.Codigo + "" +
                 ")";

        DataUtil.UpdateThrow(sqlForExecute);

        var sqlUpdate = "DELETE FROM pedido_detalle WHERE pedido_id = " + pedidoID + " AND linea = '" + lineaNo + "'";
        DataUtil.UpdateThrow(sqlUpdate);
      }
      catch (Exception ex)
      {
        MessageBox.Show(@"Error en Grabar: " + ex.Message);
      }
    }
    #endregion

    #region Reportes    
    private void PrintDocuments(int pedidoIdPrint, int rePrint)
    {
      string sqlUpdate;
      var reportViewerForm = new ReportViewer();
      DataSet dsResult = null;

      bool printCocina = false;
      bool printBar = false;
      bool printCocinaOk = false;
      bool printBarOk = false;

      if (cbCocina.Checked)
      {        
        dsResult = DataUtil.FillDataSet(DataBaseQuerys.ReporteCocina(pedidoIdPrint,rePrint), "pedido_detalle");
        if (dsResult.Tables[0].Rows.Count > 0)
        {
          if (AppConstant.GeneralInfo.Impresora.Cocina != string.Empty)
          {
                        if (AppConstant.GeneralInfo.PrintText.Cocina)
                        {
                            PrintByText.printDocument(AppConstant.GeneralInfo.Impresora.Cocina, dsResult, "C");
                        }
                        else
                        {
                            reportViewerForm.dsReport = dsResult;
                            reportViewerForm.reporteName = AppConstant.Reportes.Cocina;
                            reportViewerForm.tableNameReport = "pedido_detalle";
                            reportViewerForm.printerName = string.Empty;

                            reportViewerForm.printerName = AppConstant.GeneralInfo.Impresora.Cocina;
                            reportViewerForm.ShowDialog();
                        }                       
                        printCocina = true;            
          }
          else
            MessageBox.Show(@"La impresora de la cocina no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

          sqlUpdate = "UPDATE pedido_detalle SET Impreso = 1 WHERE Codigo_Producto IN (SELECT Producto_id FROM Producto WHERE Producto_categoria_id <> 3) AND pedido_id = " + pedidoIdPrint + "";
          DataUtil.UpdateThrow(sqlUpdate);
        }
        else
        {
          if (rePrint == 1)
            MessageBox.Show(@"No existen nuevos productos o productos modificados.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      if (cbBar.Checked)
      {
          if (printCocina)
          {
              var diagResult = MessageBox.Show(@"Imprimio Correctamente el ticket de Cocina?", @"Impresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (diagResult == DialogResult.Yes)
                  printCocinaOk = true;
          }
          else
              printCocinaOk = true;

          if (printCocinaOk)
          {
              dsResult = DataUtil.FillDataSet(DataBaseQuerys.ReporteBar(pedidoIdPrint, rePrint), "pedido_detalle");
              if (dsResult.Tables[0].Rows.Count > 0)
              {
                  if (AppConstant.GeneralInfo.Impresora.Bar != string.Empty)
                  {
                            if (AppConstant.GeneralInfo.PrintText.Bar)
                            {
                                PrintByText.printDocument(AppConstant.GeneralInfo.Impresora.Bar, dsResult, "B");
                            }
                            else
                            {
                                reportViewerForm.dsReport = dsResult;
                                reportViewerForm.reporteName = AppConstant.Reportes.Bar;
                                reportViewerForm.tableNameReport = "pedido_detalle";
                                reportViewerForm.printerName = string.Empty;

                                reportViewerForm.printerName = AppConstant.GeneralInfo.Impresora.Bar;
                                reportViewerForm.ShowDialog();
                            }                            

                            printBar = true;                      
                  }
                  else
                      MessageBox.Show(@"La impresora del Bar no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                  sqlUpdate = "UPDATE pedido_detalle SET Impreso = 1 WHERE Codigo_Producto IN (SELECT Producto_id FROM Producto WHERE Producto_categoria_id = 3) AND pedido_id = " + pedidoIdPrint + "";
                  DataUtil.UpdateThrow(sqlUpdate);
              }
              else
              {
                if (rePrint == 1)
                  MessageBox.Show(@"No existen nuevos productos o productos modificados.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
          }
      }
    }
    #endregion            

    #region Turno
    private void IniEmpleadoCombo()
    {
      this.radmccbEmpleado.AutoSizeDropDownToBestFit = true;
      RadMultiColumnComboBoxElement multiColumnComboElement = this.radmccbEmpleado.MultiColumnComboBoxElement;
      multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
      multiColumnComboElement.EditorControl.MasterGridViewTemplate.AutoGenerateColumns = false;
      GridViewTextBoxColumn column = new GridViewTextBoxColumn("Empleado");
      column.HeaderText = @"Empleado";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Cargo");
      column.HeaderText = @"Cargo";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Codigo_empleado");
      column.HeaderText = @"Codigo empleado";
      column.IsVisible = false;
      multiColumnComboElement.Columns.Add(column);
    }
    private void FillEmpleadoCombo()
    {
      var dsResult = DataUtil.FillDataSet("SELECT Apellidos_empleado + ', ' + Nombres_empleado AS Empleado, Codigo_empleado, Cargo FROM empleado WHERE estado = 'ACTIVO' ORDER BY Apellidos_empleado", "empleado");
      this.radmccbEmpleado.DataSource = dsResult.Tables[0];
      this.radmccbEmpleado.DisplayMember = "Empleado";
      // Filtering START
      var filter = new FilterExpression(this.radmccbEmpleado.DisplayMember,
                                                     FilterExpression.BinaryOperation.AND,
                                                     GridKnownFunction.StartsWith,
                                                     GridFilterCellElement.ParameterName);
      filter.Parameters.Add(GridFilterCellElement.ParameterName, string.Empty);
      this.radmccbEmpleado.EditorControl.MasterGridViewTemplate.FilterExpressions.Add(filter);
      this.radmccbEmpleado.MultiColumnComboBoxElement.AutoCompleteMode = AutoCompleteMode.None;
      this.radmccbEmpleado.DropDownStyle = RadDropDownStyle.DropDown;
      // Filtering END
      this.radmccbEmpleado.SelectedItem = null;
    }
    #endregion
  }
}
