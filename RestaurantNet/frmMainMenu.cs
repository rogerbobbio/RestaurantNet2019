using System;
using System.Data;
using System.Windows.Forms;
using RestaurantNet.Seguridad;
using RestaurantNet.Reports;

namespace RestaurantNet
{
  public partial class frmMainMenu : frmMain
  {
    #region Constant
    private int lineGrid = 0;
    private double subTotal = 0;
    private double totalDescuento;

    private int gridLineaNumero = 0;
    private int gridProdCodigo = 1;
    private int gridProdDescripcion = 2;
    private int gridCantidad = 3;
    private int gridDescuento = 4;
    private int gridPrecio = 5;
    private int gridDescuentoMonto = 6;
    //private int gridPrecioUnitario = 7;
    //private int gridPrecioProveedor = 8;
    #endregion

        public frmMainMenu()
    {
      InitializeComponent();
    }
    private void frmMainMenu_Load(object sender, EventArgs e)
    {
      GetTurnInfo();
      GetPersonalInfo();
      GetOutStock();
    }

    #region Menu
    private void rbtnSalir_Click(object sender, EventArgs e)
    {
      DataUtil.DisconectDB();
      Close();
    }
    private void rbtnAbout_Click(object sender, EventArgs e)
    {
      var aboutForm = new frmAbout();
      aboutForm.ShowDialog();
    }
    private void rbtnDelSistema_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(1, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        GetGeneralInfo();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);        
    }
    private void rbtnMesa_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(2, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var tableForm = new frmTable();
        tableForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    private void rbtnBotones_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(3, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmQuickButtonsConfigForm = new frmQuickButtonsConfig();
        frmQuickButtonsConfigForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    private void rbtnEmpleados_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(4, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var empleadoForm = new frmEmployeeBrowser();
        empleadoForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    private void rbtnClientes_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(12, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var clienteForm = new frmCustomerBrowser();
        clienteForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    private void rbtnProductos_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(13, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var productForm = new frmProductBrowser();
        productForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    private void rbtnProductoCategoria_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(14, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var categoriaForm = new frmProductCategoryBrowser();
        categoriaForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void rbtnProductoSubCategoria_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(15, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var subCategoriaForm = new frmProductSubCategoryBrowser();
        subCategoriaForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);            
    }
    private void rbtnProveedores_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(16, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var proveedorForm = new frmSupplierBrowser();
        proveedorForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void rbtnCuentasAnuladas_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(17, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmAccountSearchForm = new frmAccountSearch
        {
          titleForm = "Busqueda de Cuentas Anuladas",
          pedidoEstado = AppConstant.PedidoEstado.Anulado
        };
        frmAccountSearchForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);            
    }
    private void rbtnCuentasPCobrar_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(20, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmAccountSearchForm = new frmAccountSearch {titleForm = "Busqueda de Notas de venta", pedidoEstado = "N"};
        frmAccountSearchForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void rbtnCuentasFacturadas_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(19, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmBillSearchForm = new frmBillSearch();
        frmBillSearchForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }    
    private void rbtnReincializar_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(32, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var result = MessageBox.Show(@"Desea reinicializar el sistema?", @"RestaurantNet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
          DataUtil.Update("DELETE FROM Cliente");
          DataUtil.Update("DELETE FROM Cliente_Email");
          DataUtil.Update("DELETE FROM Empleado WHERE codigo_empleado <> 1");
          DataUtil.Update("DELETE FROM Movimientos");
          DataUtil.Update("DELETE FROM Pedido_detalle");
          DataUtil.Update("DELETE FROM Pedido_Producto_Eliminado");
          DataUtil.Update("DELETE FROM Pedido");
          DataUtil.Update("DELETE FROM Producto_boton");
          DataUtil.Update("DELETE FROM Producto_insumo");
          DataUtil.Update("DELETE FROM Insumo");
          DataUtil.Update("DELETE FROM Insumo_grupo");
          DataUtil.Update("DELETE FROM Producto_Paquete");
          DataUtil.Update("DELETE FROM Producto");
          DataUtil.Update("DELETE FROM Producto_sub_categoria");
          DataUtil.Update("DELETE FROM Producto_categoria WHERE Producto_categoria_id > 4");
          DataUtil.Update("DELETE FROM Proveedor");
          DataUtil.Update("DELETE FROM Turno_Estacion");
          DataUtil.Update("DELETE FROM Turno_Cierre");
          DataUtil.Update("DELETE FROM Turno");
          DataUtil.Update("DELETE FROM Venta");
          DataUtil.Update("DELETE FROM Venta_detalle");
          DataUtil.Update("DELETE FROM Estacion");
          DataUtil.Update("DELETE FROM Estacion_log");

          string sqlForExecute = "UPDATE secuencia SET " +
                                 "Ultimo_valor = 0";
          DataUtil.UpdateThrow(sqlForExecute);

          sqlForExecute = "UPDATE secuencia SET " +
                          "Ultimo_valor = 1 WHERE Nombre_tabla = 'empleado'";
          DataUtil.UpdateThrow(sqlForExecute);

          sqlForExecute = "UPDATE secuencia SET " +
                          "Ultimo_valor = 4 WHERE Nombre_tabla = 'producto_categoria'";
          DataUtil.UpdateThrow(sqlForExecute);

          sqlForExecute = "UPDATE mesa SET " +
                          "Mesa_estado = 'LIBRE'," +
                          "Mesa_descripcion = 'Config. Mesa'," +
                          "fecha_actualizacion = null," +
                          "pedido_id = null," +
                          "actualizado_por = null," +
                          "Mesa_habilitado = '0'";
          DataUtil.UpdateThrow(sqlForExecute);


          sqlForExecute = "UPDATE configuracion_general SET " +
                          "  Nombre_compania = ''" +
                          ", Razon_social = ''" +
                          ", Documento_compania = ''" +
                          ", Telefono1_compania = ''" +
                          ", Telefono2_compania = ''" +
                          ", Telefono3_compania = ''" +
                          ", Direccion_compania = ''" +
                          ", Direccion_fiscal = ''" +
                          ", Mensaje_recibo_1 = ''" +
                          ", Mensaje_recibo_2 = ''" +
                          ", Mensaje_recibo_3 = ''" +
                          ", Ruta_logo_compania = ''" +
                          ", Email_compania = ''" +
                          ", Web_compania = ''" +
                          ", Impresora_reportes = ''" +
                          ", IGV = '19'" +
                          ", Monto_caja = '0.00'" +
                          ", Font_header = '7'" +
                          ", Font_detail = '7'" +
                          ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                          ", Actualizado_por = '1'" +
                          ", Ultima_boleta = '0'" +
                          ", Ultima_factura = '0'" +
                          ", Prefijo_Boleta = ''" +
                          ", Prefijo_Factura = ''" +
                          ", Impresora_bar = ''" +
                          ", Impresora_cocina = ''" +
                          ", Impresora_factura = ''" +
                          ", Impresora_recibos = ''" +
                          ", Contrasena_Anulaciones = '0'" +
                          ", Contrasena_NotaVenta = '0'" +
                          ", Contrasena_DividirCuenta = '0'" +
                          ", Contrasena_CambioMesero = '0'" +
                          ", Contrasena_ReImpresiones = '0'" +
                          ", Contrasena_CambioMesa = '0'" +
                          ", Contrasena_Salir = '0'" +
                          ", Contrasena_EliminarProducto = '0'" +
                          ", Preview_bar = '0'" +
                          ", Preview_cocina = '0'" +
                          ", Preview_factura = '0'" +
                          ", Preview_recibos = '0'" +
                          ", Preview_reportes = '0'" +
                          ", Mostrar_IGV_Boleta = '1'";

          DataUtil.UpdateThrow(sqlForExecute);
          Close();
        }
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void rbtnEstacion_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(7, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmStationBrowserForm = new frmStationBrowser();
        frmStationBrowserForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);     
    }
    private void rbtnTurnos_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(8, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmTurnBrowserForm = new frmTurnBrowser();
        frmTurnBrowserForm.ShowDialog();
        GetTurnInfo();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);           
    }
    private void rbtnOrdenCobrar_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(20, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmAccountSearchForm = new frmAccountSearch { titleForm = "Busqueda de Ordenes por Cobrar", pedidoEstado = "A" };
        frmAccountSearchForm.ShowDialog();
        GetOrder();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void rbtnMovimiento_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(AppConstant.MenuItems.Movimientos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        if (IsTurnOpen())
        {
          if (ValidarCajero())
          {
            var frmMovementsForm = new frmMovements();
            frmMovementsForm.ShowDialog();
          }
        }
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    private void rbtnCerrarTurno_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(AppConstant.MenuItems.Turnos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion))
      {
        if (IsTurnOpen())
        {
          var result = MessageBox.Show(@"Desea cerrar el turno actual?", @"Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == DialogResult.Yes)
          {
            int ordenesAbiertas = DataUtil.GetInt(DataUtil.FindSingleRow("pedido", "Count(*)", "Estado = 'A' AND turno_id = " + lblTurno.Text + ""));
            if (ordenesAbiertas > 0)
              MessageBox.Show(@"No se puede cerrar el turno tiene " + ordenesAbiertas + @" Ordenes pendientes de pago.", @"Ordenes Abiertas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
              var frmCloseTurnForm = new frmCloseTurn();
              frmCloseTurnForm.ShowDialog();
              GetTurnInfo();
            }
          }
        }
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void rbtnCorteCaja_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(11, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        //var frmCashierReportForm = new frmCashierReport();
        //frmCashierReportForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    private void rbtnMonitorVentas_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(10, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmMonitorSalesForm = new frmMonitorSales();
        frmMonitorSalesForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    private void rbtnConsultaMovimientos_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(21, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmMovementsSearchForm = new frmMovementsSearch();
        frmMovementsSearchForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void rbtnCambiarPassword_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(6, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmChangePasswordForm = new frmChangePassword {oldPassword = AppConstant.EmployeeInfo.Password};
        frmChangePasswordForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void rbtnInsumosClasificacion_Click(object sender, EventArgs e)
    {
      var frmInsumoGroupClassificationBrowserForm = new frmInsumoGroupClassificationBrowser();
      frmInsumoGroupClassificationBrowserForm.ShowDialog();
    }
    private void rbtnGruposInsumos_Click(object sender, EventArgs e)
    {
      var frmInsumoGroupBrowserForm = new frmInsumoGroupBrowser();
      frmInsumoGroupBrowserForm.ShowDialog();
    }
    private void rbtnInsumos_Click(object sender, EventArgs e)
    {

    }
    private void rbtnInsumosElaborados_Click(object sender, EventArgs e)
    {

    }
    private void rbtnPresentaciones_Click(object sender, EventArgs e)
    {
      var frmInsumoPresentacionBrowserForm = new frmInsumoPresentacionBrowser();
      frmInsumoPresentacionBrowserForm.ShowDialog();
    }
    private void rbtnPermisos_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(5, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmSecurityPermissions = new frmSecurityPermissions();
        frmSecurityPermissions.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    #endregion    

    #region Botones

      private void btnAdd_Click(object sender, EventArgs e)
      {
          if (txtCantidad.Text.Trim() == string.Empty)
              txtCantidad.Text = @"1";

          if (IsTurnOpen())
          {
              if (btnCreateOrder.Visible)
              {
                  if (txtCantidad.Text.Trim() != string.Empty && txtProducto.Text.Trim() != string.Empty)
                  {
                      double calculoMonto;
                      double descuentoMonto = 0;
                      if (txtDescuento.Text.Trim() != string.Empty)
                      {
                          calculoMonto = Math.Round((DataUtil.GetDouble(txtPrecioUnitario.Text) * (1 - DataUtil.GetDouble(txtDescuento.Text) / 100)) * DataUtil.GetInt(txtCantidad.Text) , 2);
                          var totalSinDescuento = Math.Round((DataUtil.GetDouble(txtPrecioUnitario.Text) * DataUtil.GetInt(txtCantidad.Text)), 2);
                          descuentoMonto = Math.Round(totalSinDescuento - calculoMonto, 2);
                        }                          
                      else
                          calculoMonto = (DataUtil.GetDouble(txtPrecioUnitario.Text) * DataUtil.GetInt(txtCantidad.Text));

                      lineGrid = lineGrid + 1;
                      string[] row =
                      {
                          DataUtil.GetString(lineGrid),
                          txtCodigoProducto.Text,
                          txtProducto.Text,
                          txtCantidad.Text,
                          txtDescuento.Text,
                          DataUtil.GetString(calculoMonto),
                          DataUtil.GetString(descuentoMonto),
                          txtPrecioUnitario.Text,
                          txtProductoPrecioProveedor.Text                          
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
    private void btnOrdenesPorMesas_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(22, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        if (IsTurnOpen())
        {
          var viewtableForm = new frmViewLiving();
          viewtableForm.ShowDialog();
          GetOrder();
        }
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void btnLogoff_Click(object sender, EventArgs e)
    {
      var refValue = string.Empty;
      if (frmInputBox.InputBox("Verificar Password del usuario actual", "Password", "empleado", "password", AppConstant.EmployeeInfo.Codigo, ref refValue, true, AppConstant.GeneralInfo.PasswordSalir) == DialogResult.OK)
      {
        var diagResult = MessageBox.Show(@"Está seguro de cerrar la cesion actual?", @"Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (diagResult == DialogResult.Yes)
        {
          btnCreateOrder.Visible = true;
          btnNewOrder.Visible = false;
          btnPagar.Visible = false;
          gbPrintOptions.Visible = true;
          btnClean_Click(null, null);
          var frmLoginForm = new frmLogin();
          frmLoginForm.StartPosition = FormStartPosition.CenterScreen;
          frmLoginForm.WindowState = FormWindowState.Maximized;
          var result = frmLoginForm.ShowDialog();
          if (result == DialogResult.OK)
            GetPersonalInfo();
          else
            Close();
        }
      }      
    }
    private void btnPagar_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(31, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        if (ValidarCajero())
        {
          if (DataUtil.GetDouble(txtTotalGeneral.Text) != 0)
          {
            DialogResult result = MessageBox.Show(@"Desea proceder a pagar?", @"Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
              PayOrder();
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
    private void btnDelivery_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(23, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        if (IsTurnOpen())
        {
          var frmDeliveryForm = new frmDelivery();
          frmDeliveryForm.ShowDialog();
          GetOrder();
        }
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void btnClean_Click(object sender, EventArgs e)
    {
      lblMesaDesc.Visible = false;
      lblMesaTipo.Visible = false;
      lblOrderLabel.Visible = false;
      lblOrderDia.Visible = false;
      lblOrderNo.Visible = false;
      lblOrderDiaNo.Visible = false;
      CleanTotal();
      lblTipoVenta.Text = AppConstant.TipoVenta.Rapida;
      btnPagar.Visible = false;
      btnNewOrder.Visible = false;
      btnImprimirCuenta.Visible = false;
      btnCreateOrder.Visible = true;
    }
    private void btnViewOrder_Click(object sender, EventArgs e)
    {
      var frmAccountViewerForm = new frmAccountViewer();
      frmAccountViewerForm.ShowDialog();
      GetOrder();
    }
    private void btnCreateOrder_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(25, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        if (DataUtil.GetDouble(txtTotalGeneral.Text) != 0)
        {
          var result = MessageBox.Show(@"Desea generar una orden?", @"Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == DialogResult.Yes)
          {
            if (IsReadyToPrint())
            {
              try
              {
                var pedidoId = DataUtil.GetNewId("pedido");
                var ordenDiaId = DataUtil.GetOrderByTurn(DataUtil.GetInt(lblTurno.Text));

                const string clienteIdValue = "null";
                const string mesaIdValue = "null";

                var sqlForExecute = "INSERT INTO pedido (" +
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
                                       pedidoId + "," +
                                       "" + mesaIdValue + "," +
                                       "" + lblTurno.Text + "," +
                                       "'" + DateTime.Now + "'," +
                                       "" + AppConstant.EmployeeInfo.Codigo + "," +
                                       "'A'," +
                                       "'" + lblTipoVenta.Text + "'," +
                                       "" + clienteIdValue + "," +
                                       "" + ordenDiaId + "" +
                                       ")";

                DataUtil.UpdateThrow(sqlForExecute);

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
                                   pedidoId + "," +
                                   "'" + DataUtil.GetString(row.Cells[gridLineaNumero].Value) + "'," +
                                   "" + DataUtil.GetString(row.Cells[gridProdCodigo].Value) + "," +
                                   "'" + DataUtil.GetString(row.Cells[gridProdDescripcion].Value).Replace("'", "''") + "'," +
                                   "" + descuentoValue + "," +
                                   "'" + DataUtil.GetString(row.Cells[gridCantidad].Value) + "'," +
                                   "0" +
                   ")";
                  DataUtil.UpdateThrow(sqlForExecute);
                }

                sqlForExecute = "UPDATE pedido SET " +
                                "Last_Line = " + lineGrid + "" +
                                ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                                ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                                " WHERE Pedido_id = " + pedidoId;
                DataUtil.UpdateThrow(sqlForExecute);


                PrintDocuments(pedidoId, 0);
                btnCreateOrder.Visible = false;
                btnReprint.Visible = true;
                lblOrderLabel.Visible = true;
                lblOrderDia.Visible = true;
                lblOrderNo.Visible = true;
                lblOrderDiaNo.Visible = true;
                lblOrderNo.Text = DataUtil.GetString(pedidoId);
                lblOrderDiaNo.Text = DataUtil.GetString(ordenDiaId);
                MessageBox.Show(@"Orden agregada correctamente.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNewOrder.Visible = true;
                btnPagar.Visible = true;
                btnImprimirCuenta.Visible = true;
                btnPagar.Focus();
              }
              catch (Exception ex)
              {
                MessageBox.Show(@"Error en Grabar: " + ex.Message);
              }
            }
          }
        }
        else
          MessageBox.Show(@"Debe tener algun producto para generar la orden.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void btnNewOrder_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(25, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var result = MessageBox.Show(@"Desea generar una nueva orden?", @"Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
          btnCreateOrder.Visible = true;
          btnNewOrder.Visible = false;
          btnPagar.Visible = false;
          btnImprimirCuenta.Visible = false;
          gbPrintOptions.Visible = true;
          btnClean_Click(null, null);
          btnReprint.Visible = false;
        }
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void btnSearchProduct_Click(object sender, EventArgs e)
    {
      var productForm = new frmProductBrowser();
      productForm.ShowDialog();
    }
    private void btnReprint_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(25, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        if (lblOrderNo.Text != string.Empty)
        {
          var result = MessageBox.Show(@"Desea re-imprimir la orden de la mesa?", @"Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == DialogResult.Yes)
          {
            if (IsReadyToPrint())
            {
              var refValue = string.Empty;
              if (frmInputBox.InputBox("Ingresar codigo de autorizacion", "Codigo", "empleado", "password", "1", ref refValue, true, AppConstant.GeneralInfo.PasswordReimpresiones) == DialogResult.OK)
              {
                PrintDocuments(DataUtil.GetInt(lblOrderNo.Text), 1);
              }
            }
          }
        }
        else
          MessageBox.Show(@"Debe crear una orden.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);      
    }
    private void btnAddProduct_Click(object sender, EventArgs e)
    {
      if (btnCreateOrder.Visible)
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
            txtProductoPrecioProveedor.Text = DataUtil.FindSingleRow("producto", "Precio_proveedor", "Producto_id = " + DataUtil.GetString(row.Cells[gridProdCodigo].Value) + "");
            txtCantidad.Text = DataUtil.GetString(row.Cells[gridCantidad].Value);
            btnAdd_Click(null, null);
          }
          DataUtil.dgvTemporal = null;
        }
      }
      else
        MessageBox.Show(@"Debe crear una nueva orden.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);      
    }
    private void btnMonitorCocina_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(24, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        var frmKitchenMonitorForm = new frmKitchenMonitor();
        frmKitchenMonitorForm.ShowDialog();
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);        
    }
    private void btnImprimirCuenta_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(26, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Accesso))
      {
        if (lblOrderNo.Text != string.Empty)
        {
          var result = MessageBox.Show(@"Desea imprimir la cuenta de la mesa?", @"Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == DialogResult.Yes)
          {
            btnImprimirCuenta.Enabled = false;

            var reportViewerForm = new ReportViewer
            {
              dsReport = DataUtil.FillDataSet(DataBaseQuerys.ReporteCuenta(DataUtil.GetInt(lblOrderNo.Text)), "pedido_detalle"),
              reporteName = AppConstant.Reportes.Cuenta,
              tableNameReport = "pedido_detalle",
              printerName = string.Empty
            };

            if (AppConstant.GeneralInfo.Impresora.Recibos != string.Empty)
            {
              reportViewerForm.printerName = AppConstant.GeneralInfo.Impresora.Recibos;
              reportViewerForm.ShowDialog();
            }
            else
              MessageBox.Show(@"La impresora del Recibos no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            btnImprimirCuenta.Enabled = true;
          }
        }
        else
          MessageBox.Show(@"Debe agregar una Orden.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    private void rbtnReporteVentas_Click(object sender, EventArgs e)
    {
      //var frmReporteVentasForm = new frmReporteVentas();
      //frmReporteVentasForm.ShowDialog();
    }    
    #endregion

    #region Metodos privados
    private void GetPersonalInfo()
    {
      lblEmployee.Text = AppConstant.EmployeeInfo.Apellidos + @", " + AppConstant.EmployeeInfo.Nombres;

      DataUtil.GetGeneralInfo();
      if (AppConstant.GeneralInfo.Compania.Equals(string.Empty))
        GetGeneralInfo();
      else
        lblCompany.Text = AppConstant.GeneralInfo.Compania;
      
      if (AppConstant.EmployeeInfo.Cargo == AppConstant.EmpleadoCargo.Cajero)
      {
        lblEstacion.Visible = true;
        lblEstacionLabel.Visible = true;
        lblEstacion.Text = string.Empty;
        var sqlCommand = "SELECT Estacion.Estacion_descripcion, Turno.Estado, turno_estacion.* " +
                            "  FROM Turno INNER JOIN (Estacion INNER JOIN turno_estacion ON Estacion.Estacion_id = turno_estacion.Estacion_id) ON Turno.Turno_id = turno_estacion.Turno_id" +
                            " WHERE (((turno_estacion.estacion_id)=(SELECT estacion_id FROM estacion WHERE persona_asignada = " + AppConstant.EmployeeInfo.Codigo + " AND estado = 'ACTIVO') AND Turno.Estado = 'ABIERTO'))";
        var dsTurnoEstacion = DataUtil.FillDataSet(sqlCommand, "Estacion");
        if (dsTurnoEstacion.Tables[0].Rows.Count > 0)
          lblEstacion.Text = DataUtil.GetString(dsTurnoEstacion.Tables[0].Rows[0], "Estacion_Descripcion");
      }
      else
      {
        lblEstacion.Visible = false;
        lblEstacionLabel.Visible = false;
      }
      btnReprint.Visible = false;
      Text = @"Restaurant Net - Menu Principal - PERFIL : " + AppConstant.EmployeeInfo.Cargo;      
    }
    private void SetProductValues()
    {
      if (AppConstant.Product.ProductoDescription != string.Empty)
      {
        txtProducto.Text = AppConstant.Product.ProductoDescription;
        txtCodigoProducto.Text = AppConstant.Product.ProductoCodigo;
        txtPrecioUnitario.Text = AppConstant.Product.ProductoPrecio;
        txtProductoPrecioProveedor.Text = AppConstant.Product.ProductoPrecioProveedor;

        AppConstant.Product.ProductoDescription = string.Empty;
        AppConstant.Product.ProductoCodigo = string.Empty;
        AppConstant.Product.ProductoPrecio = string.Empty;
        AppConstant.Product.ProductoPrecioProveedor = string.Empty;
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
          txtSubTotalCopy.Text = txtSubTotal.Text = subTotal.ToString(DataUtil.Format.Decimals);
          txtTotalDescuentoCopy.Text = txtTotalDescuento.Text = totalDescuento.ToString(DataUtil.Format.Decimals);
          txtIGVCopy.Text = txtIGV.Text = igvValue.ToString(DataUtil.Format.Decimals);
          txtTotalGeneralCopy.Text = txtTotalGeneral.Text = totalGeneral.ToString(DataUtil.Format.Decimals);
      }

      private void GetOrder()
    {
      if (AppConstant.Order.PedidoID != string.Empty)
      {
        btnCreateOrder.Visible = true;
        lblMesaDesc.Visible = true;
        lblMesaTipo.Visible = true;
        lblOrderLabel.Visible = true;
        lblOrderDia.Visible = true;
        lblOrderNo.Visible = true;
        lblOrderDiaNo.Visible = true;
  
        CleanTotal();

        DataSet dsPedidoDetalleInfo = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet("pedido_detalle","pedido_id", AppConstant.Order.PedidoID, string.Empty), "pedido_detalle");
        foreach (DataRow pedidoDetalleRow in dsPedidoDetalleInfo.Tables["pedido_detalle"].Rows)
        {
          var dsProducto = DataUtil.FillDataSet(DataBaseQuerys.Producto(DataUtil.GetString(pedidoDetalleRow["Codigo_Producto"]), string.Empty, string.Empty, string.Empty), "producto");
          txtCodigoProducto.Text = DataUtil.GetString(pedidoDetalleRow["Codigo_Producto"]);
          txtProducto.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Producto_descripcion");
          txtPrecioUnitario.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Precio_final");
          txtProductoPrecioProveedor.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Precio_proveedor");
          txtCantidad.Text = DataUtil.GetString(pedidoDetalleRow["Cantidad"]);
          txtDescuento.Text = DataUtil.GetString(pedidoDetalleRow["Descuento"]);
          btnAdd_Click(null, null);
        }

        lblOrderNo.Text = AppConstant.Order.PedidoID;
        lblOrderDiaNo.Text = AppConstant.Order.OrdenDiaID;
        lblOrdenOrigenValue.Text = AppConstant.Order.PedidoOrigenID;
        lblMesaDesc.Text = AppConstant.Order.MesaDescripcion;
        lblMesaTipo.Text = AppConstant.Order.MesaTipo;
        lblTipoVenta.Text = AppConstant.Order.TipoVenta;

        if (AppConstant.Order.PedidoOrigenID != string.Empty)
        {
          lblOrdenOrigenValue.Visible = true;
          lblOrdenOrigenLabel.Visible = true;
        }        

        gbPrintOptions.Visible = false;
        btnCreateOrder.Visible = false;
        btnNewOrder.Visible = true;
        btnPagar.Visible = false;
        PayOrder();
        btnPagar.Visible = true;
      }
      else
      {
        lblMesaDesc.Visible = false;
        lblMesaTipo.Visible = false;
        lblOrderLabel.Visible = false;
        lblOrderDia.Visible = false;
        lblOrderNo.Visible = false;
        lblOrderDiaNo.Visible = false;
        btnCreateOrder.Visible = true;
        btnNewOrder.Visible = false;
        btnImprimirCuenta.Visible = false;
        btnPagar.Visible = false;
        lblOrdenOrigenValue.Visible = false;
        lblOrdenOrigenLabel.Visible = false;
        btnReprint.Visible = false;

        CleanTotal();
      }
      AppConstant.Order.PedidoID = string.Empty;
      AppConstant.Order.PedidoOrigenID = string.Empty;
      AppConstant.Order.MesaID = string.Empty;
      AppConstant.Order.MesaDescripcion = string.Empty;
      AppConstant.Order.MesaTipo = string.Empty;
      AppConstant.Order.TipoVenta = string.Empty;      
    }

      private void PayOrder()
      {
          var atendidoPor = AppConstant.EmployeeInfo.Codigo;
          var fechaPedido = DateTime.Now;

          var frmSaleForm = new frmSale();
          frmSaleForm.empleadoLogeado = lblEmployee.Text;
          frmSaleForm.tipoVenta = lblTipoVenta.Text;
          if (lblOrderNo.Visible)
          {
              frmSaleForm.pedidoID = lblOrderNo.Text;
              frmSaleForm.ordenDiaID = lblOrderDiaNo.Text;
              DataSet dsPedidoInfo =
                  DataUtil.FillDataSet(
                      DataBaseQuerys.FillMainDataSet("pedido", "Pedido_id", lblOrderNo.Text, string.Empty), "pedido");
              atendidoPor = DataUtil.GetString(dsPedidoInfo.Tables["pedido"].Rows[0]["Atendido_por"]);
              fechaPedido = DataUtil.GetDateTime(dsPedidoInfo.Tables["pedido"].Rows[0]["Fecha_Pedido"]);
              frmSaleForm.clienteID = DataUtil.GetString(dsPedidoInfo.Tables["pedido"].Rows[0]["cliente_id"]);
          }
          if (lblMesaDesc.Visible)
              frmSaleForm.mesaID = lblMesaDesc.Text;

          if (lblOrdenOrigenValue.Visible)
          {
              frmSaleForm.pedidoOrigen = lblOrdenOrigenValue.Text;
          }

          frmSaleForm.ultimaLinea = DataUtil.GetString(lineGrid);
          frmSaleForm.atendidoPor = atendidoPor;
          frmSaleForm.fechaPedido = fechaPedido;

          frmSaleForm.subTotal = txtSubTotal.Text;
          frmSaleForm.igvTotal = txtIGV.Text;
          frmSaleForm.totalGeneral = txtTotalGeneral.Text;
          frmSaleForm.descuentoTotal = txtTotalDescuento.Text;
          frmSaleForm.dgwCuenta = dgwCuenta;
          frmSaleForm.ShowDialog();
          if (AppConstant.Pay.paySuccesfully)
          {
              btnCreateOrder.Visible = true;
              btnNewOrder.Visible = false;
              btnPagar.Visible = false;
              btnImprimirCuenta.Visible = false;
              gbPrintOptions.Visible = true;
              btnClean_Click(null, null);
              AppConstant.Pay.paySuccesfully = false;
          }
      }

      private void CleanTotal()
      {
          lineGrid = 0;
          dgwCuenta.Rows.Clear();
          txtSubTotalCopy.Text = txtSubTotal.Text = @"0.00";
          txtIGVCopy.Text = txtIGV.Text = @"0.00";
          txtTotalGeneralCopy.Text = txtTotalGeneral.Text = @"0.00";
          txtTotalDescuentoCopy.Text = txtTotalDescuento.Text = @"0.00";
          subTotal = 0;
          totalDescuento = 0;
      }

      private bool IsReadyToPrint()
    {
      int contadorImpresoras = 0;
      bool valueResult = true;

      if (cbBar.Checked)
        contadorImpresoras++;
      if (cbCocina.Checked)
        contadorImpresoras++;
      if (cbRecibos.Checked)
        contadorImpresoras++;
      if (contadorImpresoras.Equals(0))
      {
        tcPrincipal.SelectedIndex = 0;
        MessageBox.Show(@"Marcar al menos una impresora.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        valueResult = false;
      }

      return valueResult;
    }
    private bool IsTurnOpen()
    {
      if (DataUtil.GetInt(DataUtil.FindSingleRow("turno", "Count(*)", "Estado = 'ABIERTO'")) == 0)
      {
        MessageBox.Show(@"No se tiene ningun Turno abierto.", @"Turno", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }
    private void GetGeneralInfo()
    {      
        var configForm = new frmGeneralConfig();
        var result = configForm.ShowDialog();
        if (result == DialogResult.OK)
        {
          DataUtil.GetGeneralInfo();
          lblCompany.Text = AppConstant.GeneralInfo.Compania;          
        }      
    }
    private void GetTurnInfo()
    {
        DataUtil.GetTurnInfo(0);
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
    private string GoToCalculator(string textIn)
    {
      var returnValue = string.Empty;
      AppConstant.Calculator.textIN = textIn;
      var frmCalculatorForm = new frmCalculator();
      frmCalculatorForm.ShowDialog();
      if (AppConstant.Calculator.textOUT != string.Empty)
        returnValue = AppConstant.Calculator.textOUT;

      AppConstant.Calculator.textIN = string.Empty;
      AppConstant.Calculator.textOUT = string.Empty;
      return returnValue;
    }
    private void GetOutStock()
    {
      if (DataUtil.GetInt(DataUtil.FindSingleRow("producto p", "count(*)", "p.Alerta_fuera_stock = '1' AND p.Cantidad_actual <= p.Cantidad_fuera_stock")) > 0)
      {
        var frmOutStockForm = new frmOutStock();
        frmOutStockForm.ShowDialog();
      }
    }
    private void SaveProductDeleted(string lineaNo, int codigoProducto, string descripcionProducto)
    {
      try
      {
        var pedidoProductoId = DataUtil.GetNewId("pedido_producto_eliminado");
        var sqlForExecute = "INSERT INTO Pedido_Producto_Eliminado (" +
                                 "Pedido_producto_id," +
                                 "Pedido_id," +
                                 "Codigo_Producto," +
                                 "Descripcion_Producto," +
                                 "Fecha_anulacion," +
                                 "Eliminado_por)" +
                           " VALUES (" +
                                 pedidoProductoId + "," +
                                 lblOrderNo.Text + "," +
                                 codigoProducto + "," +
                                 "'" + descripcionProducto + "'," +
                                 "'" + DateTime.Now + "'," +
                                 "" + AppConstant.EmployeeInfo.Codigo + "" +
                 ")";

        DataUtil.UpdateThrow(sqlForExecute);

        var sqlUpdate = "DELETE FROM pedido_detalle WHERE pedido_id = " + lblOrderNo.Text + " AND linea = '" + lineaNo + "'";
        DataUtil.UpdateThrow(sqlUpdate);
      }
      catch (Exception ex)
      {
        MessageBox.Show(@"Error en Grabar: " + ex.Message);
      }
    }
    #endregion
 
    #region Reportes
    private void PrintDocuments(int pedidoId, int rePrint)
    {
      string sqlUpdate;
      var reportViewerForm = new ReportViewer();
      DataSet dsResult;

      var printCocina = false;
      var printBar = false;
      var printCocinaOk = false;
      var printBarOk = false;

      if (cbCocina.Checked)
      {
        dsResult = DataUtil.FillDataSet(DataBaseQuerys.ReporteCocina(pedidoId,rePrint), "pedido_detalle");
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
            MessageBox.Show(@"La impresora de la Cocina no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);          
            

          sqlUpdate = "UPDATE pedido_detalle SET Impreso = 1 WHERE Codigo_Producto IN (SELECT Producto_id FROM Producto WHERE Producto_categoria_id <> 3) AND pedido_id = " + pedidoId + "";
          DataUtil.UpdateThrow(sqlUpdate);
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
              dsResult = DataUtil.FillDataSet(DataBaseQuerys.ReporteBar(pedidoId, rePrint), "pedido_detalle");
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


                  sqlUpdate = "UPDATE pedido_detalle SET Impreso = 1 WHERE Codigo_Producto IN (SELECT Producto_id FROM Producto WHERE Producto_categoria_id = 3) AND pedido_id = " + pedidoId + "";
                  DataUtil.UpdateThrow(sqlUpdate);
              }
          }
      }
      if (cbRecibos.Checked)
      {
          if (printBar)
          {
            var diagResult = MessageBox.Show(@"Imprimio correctamente el ticket Bar?", @"Impresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (diagResult == DialogResult.Yes)
                  printBarOk = true;
          }
          else
            printBarOk = true;

          if (printBarOk)
          {
              dsResult = DataUtil.FillDataSet(DataBaseQuerys.ReporteCuenta(pedidoId), "pedido_detalle");
              reportViewerForm.dsReport = dsResult;
              reportViewerForm.reporteName = AppConstant.Reportes.Cuenta;
              reportViewerForm.tableNameReport = "pedido_detalle";
              reportViewerForm.printerName = string.Empty;

              if (AppConstant.GeneralInfo.Impresora.Recibos != string.Empty)
              {
                  reportViewerForm.printerName = AppConstant.GeneralInfo.Impresora.Recibos;
                  reportViewerForm.ShowDialog();
              }
              else
                  MessageBox.Show(@"La impresora de Recibos no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
      }
    }
    #endregion

    #region Eventos
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
    private void dgwCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      if ((dgwCuenta.Rows.Count > 0) && (dgwCuenta.CurrentRow.Cells[gridLineaNumero].Value != null))
        txtLinea.Text = DataUtil.GetString(dgwCuenta.CurrentRow.Cells[gridLineaNumero].Value);
    }
    private void txtCantidad_DoubleClick(object sender, EventArgs e)
    {
      txtCantidad.Text = GoToCalculator(string.Empty);
    }
    private void txtDescuento_DoubleClick(object sender, EventArgs e)
    {
      txtDescuento.Text = GoToCalculator(string.Empty);
    }
    private void txtLinea_DoubleClick(object sender, EventArgs e)
    {
      txtLinea.Text = GoToCalculator(string.Empty);
    }
    private void txtProducto_Leave(object sender, EventArgs e)
    {
      txtCodigoProducto.Text = string.Empty;
      txtPrecioUnitario.Text = string.Empty;
      txtProductoPrecioProveedor.Text = string.Empty;
      DataSet dsSearch = null;

      if (txtProducto.Text != string.Empty)
      {
        string stringSQL = DataBaseQuerys.ProductoSearch();

        if (txtProducto.Text.Trim() != "*")
          dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE p.Producto_descripcion like '%" + txtProducto.Text.Trim().Replace("'", "''") + "%' ORDER BY p.Producto_descripcion", "producto");
        else
          dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " ORDER BY p.Producto_descripcion", "producto");
        if (dsSearch.Tables[0].Rows.Count == 1)
        {
          txtProducto.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Producto");
          txtCodigoProducto.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Codigo");
          txtPrecioUnitario.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Precio final");
          txtProductoPrecioProveedor.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Precio proveedor");
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
          DialogResult result = MessageBox.Show("No existe el producto. Desea crear uno nuevo?", "Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    #endregion
                     
    private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
      var diagResult = MessageBox.Show(@"Está seguro de cerrar la cesion actual?", @"Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      e.Cancel = diagResult != DialogResult.Yes;
    }    
  }
}
