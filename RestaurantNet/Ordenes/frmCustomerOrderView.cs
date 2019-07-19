using RestaurantNet.Reports;
using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmCustomerOrderView : frmMain
  {
    public int pedidoID = 0;
    public int ventaIdParam = 0;
    public string tipoVenta = string.Empty;
    public string pedidoOrigenView = string.Empty;

    public frmCustomerOrderView()
    {
      InitializeComponent();
    }

    private void frmCustomerOrderView_Load(object sender, EventArgs e)
    {
      if (ventaIdParam > 0)
      {
        label4.Visible = true;
        lblVentaNo.Visible = true;
        lblVentaNo.Text = DataUtil.GetString(ventaIdParam);
      }      
      lblEmployee.Text = AppConstant.EmployeeInfo.Apellidos + @", " + AppConstant.EmployeeInfo.Nombres;
      GetTurnInfo(0);

      Text = Text + @" - Pedido No.: " + pedidoID;

      var dsPedidoInfo = DataUtil.FillDataSet("SELECT last_line, Tipo_venta, turno_id, Atendido_por, Fecha_anulacion, Comentarios, Estado FROM pedido WHERE pedido_id = " + pedidoID + "", "pedido");

      tipoVenta = DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Tipo_venta");
      ViewOrder();
      GetTurnInfo(DataUtil.GetInt(dsPedidoInfo.Tables[0].Rows[0], "turno_id"));
      GetEmployee(DataUtil.GetInt(dsPedidoInfo.Tables[0].Rows[0], "Atendido_por"));

      lblFechaAnulacion.Text = DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Fecha_anulacion");
      txtComentarios.Text = DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Comentarios");

      if (DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Estado") == AppConstant.PedidoEstado.Anulado)
      {
        lblEstado.Text = @"ANULADO";
        lblTipoMotivo.Text = @"Motivos de la anulacion :";
        lblFecha.Text = @"Fecha de la anulacion :";
      }
      else if (DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Estado") == AppConstant.PedidoEstado.NotaVenta)
      {
        lblEstado.Text = @"NOTA DE VENTA";
        lblTipoMotivo.Text = @"Motivos de la Nota de Venta :";
        lblFecha.Text = @"Fecha de la Nota de Venta :";
      }
      else if (DataUtil.GetString(dsPedidoInfo.Tables[0].Rows[0], "Estado") == AppConstant.PedidoEstado.Facturado)
      {
        lblEstado.Text = @"FACTURADO";
        lblTipoMotivo.Visible = false;
        lblFecha.Visible = false;
        txtComentarios.Visible = false;
      }

      lblTipoOrden.Text = tipoVenta;
      if (pedidoOrigenView != string.Empty)
      {
        lblOrdenOrigen.Visible = true;
        lblOrdenOrigenValue.Visible = true;
        lblOrdenOrigenValue.Text = pedidoOrigenView;
        lblFecha.Visible = false;
        lblFechaAnulacion.Visible = false;
        lblTipoMotivo.Visible = false;
        txtComentarios.Visible = false;
      }
    }
    private void GetTurnInfo(int turnoId)
    {
      if (turnoId.Equals(0))
        DataUtil.GetTurnInfo(turnoId);


      if (AppConstant.Turno.Codigo != string.Empty)
      {
        lblTurno.Text = AppConstant.Turno.Codigo;        
        lblTurnoEstado.Visible = true;
        lblTurnoEstadoTexto.Visible = true;
        lblTurnoEstadoTexto.Text = AppConstant.Turno.Estado;        
      }
      else
      {
        lblTurno.Text = string.Empty;        
      }
    }
    private void ViewOrder()
    {
      dgwCuenta.Rows.Clear();      
      var dsPedidoDetalleInfo = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet("pedido_detalle", "pedido_id", DataUtil.GetString(pedidoID), string.Empty), "pedido_detalle");
      foreach (DataRow pedidoDetalleRow in dsPedidoDetalleInfo.Tables["pedido_detalle"].Rows)
      {
        string[] row = {DataUtil.GetString(pedidoDetalleRow["Linea"]),
                        DataUtil.GetString(pedidoDetalleRow["Codigo_Producto"]),
                        DataUtil.GetString(pedidoDetalleRow["Descripcion_Producto"]),
                        DataUtil.GetString(pedidoDetalleRow["Cantidad"]),
                        DataUtil.GetString(pedidoDetalleRow["Descuento"]),
                       };
        dgwCuenta.Rows.Add(row);
      }
    }
    private void GetEmployee(int codigoEmpleado)
    {
      var dsLogin = DataUtil.FillDataSet("SELECT estado, codigo_empleado, nombres_empleado, apellidos_empleado, cargo, [password] FROM empleado WHERE codigo_empleado = " + codigoEmpleado + "", "empleado");
      if (dsLogin.Tables[0].Rows.Count > 0)
      {
        lblEmployee.Text = DataUtil.GetString(dsLogin.Tables[0].Rows[0], "apellidos_empleado") + @", " +
                           DataUtil.GetString(dsLogin.Tables[0].Rows[0], "nombres_empleado");
      }
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnReprint_Click(object sender, EventArgs e)
    {
      if (DataBaseQuerys.GetAccess(AppConstant.MenuItems.CuentasFacturadas, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Especial))
      {
        PrintBill(ventaIdParam);
      }
      else
        MessageBox.Show(@"No tiene permisos para ingresar a esta opcion.", @"Permisos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }

    private void PrintBill(int ventaId)
    {
      var sqlCuenta = "SELECT Venta.Venta_id, " +
                         "       Venta.venta_documento_tipo," +
                         "       Venta.venta_documento," +
                         "       Empleado.Nombres_empleado+', '+Empleado.Apellidos_empleado AS AtendidoPor," +
                         "       Venta.Mesa_id," +
                         "       IIf(Cliente.Tipo_documento='RUC',Cliente.cliente_apellidos,Cliente.cliente_apellidos+', '+Cliente.cliente_nombres) AS Cliente," +
                         "       Cliente.Documento," +
                         "       Cliente.Cliente_direccion," +
                         "       Venta.Pedido_id," +
                         "       Venta.Fecha_Pedido," +
                         "       Venta.Monto_total," +
                         "       Venta.Sub_total," +
                         "       Venta.IGV_total," +
                         "       Venta.Monto_descuento," +
                         "       Venta.Monto_efectivo," +
                         "       Venta.Tipo_pago," +
                         "       Venta.Numero_documento_pago," +
                         "       Venta.Fecha_pago," +
                         "       Venta.Tipo_venta," +
                         "       Producto.Producto_categoria_id," +
                         "       Producto.Precio_proveedor," +
                         "       Venta_detalle.Codigo_Producto," +
                         "       Venta_detalle.Descripcion_Producto," +
                         "       Venta_detalle.Descuento," +
                         "       SUM(Venta_detalle.Cantidad) AS Venta_cantidad,";

      sqlCuenta = sqlCuenta + "       ROUND((SUM(Venta_detalle.Precio_final) * 1.18)) AS Producto_precio ";

      sqlCuenta = sqlCuenta + "  FROM Cliente " +
                       " RIGHT JOIN (Producto  " +
                       " INNER JOIN (Empleado " +
                       " INNER JOIN (Venta " +
                       " INNER JOIN Venta_detalle ON Venta.Venta_id = Venta_detalle.Venta_id) " +
                       "    ON Empleado.Codigo_empleado = Venta.Atendido_por) " +
                       "    ON Producto.Producto_id = Venta_detalle.Codigo_Producto) ON Cliente.Cliente_id = Venta.Cliente_id " +
                       " WHERE Venta.Venta_id = " + ventaId + "" +
                       " GROUP BY Venta.Venta_id, " +
                       "          Venta.venta_documento_tipo," +
                       "          Venta.venta_documento," +
                       "          Empleado.Nombres_empleado," +
                       "          Empleado.Apellidos_empleado," +
                       "          Venta.Mesa_id," +
                       "          Cliente.Tipo_documento," +
                       "          Cliente.cliente_apellidos," +
                       "          Cliente.cliente_nombres," +
                       "          Cliente.Documento," +
                       "          Venta.Pedido_id," +
                       "          Venta.Fecha_Pedido," +
                       "          Venta.Monto_total," +
                       "          Venta.Sub_total," +
                       "          Venta.IGV_total," +
                       "          Venta.Monto_descuento," +
                       "          Venta.Monto_efectivo," +
                       "          Venta.Tipo_pago," +
                       "          Venta.Numero_documento_pago," +
                       "          Venta.Fecha_pago," +
                       "          Venta.Tipo_venta," +
                       "          Producto.Producto_categoria_id," +
                       "          Producto.Precio_proveedor," +
                       "          Venta_detalle.Codigo_Producto," +
                       "          Venta_detalle.Descripcion_Producto," +
                       "          Venta_detalle.Descuento," +
                       "          Cliente.Cliente_direccion";
      const string reportTitle = AppConstant.Reportes.Boleta;      

      var reportViewerForm = new ReportViewer();
      reportViewerForm.dsReport = DataUtil.FillDataSet(sqlCuenta, "venta_detalle");
      reportViewerForm.reporteName = reportTitle;
      reportViewerForm.tableNameReport = "venta_detalle";
      reportViewerForm.printerName = string.Empty;

      if (AppConstant.GeneralInfo.Impresora.Boleta != string.Empty)
      {
        reportViewerForm.printerName = AppConstant.GeneralInfo.Impresora.Boleta;
        reportViewerForm.ShowDialog();
      }
      else
        MessageBox.Show(@"La impresora de Boletas no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }
}
