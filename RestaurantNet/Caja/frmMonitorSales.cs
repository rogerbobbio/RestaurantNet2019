using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace RestaurantNet
{
  public partial class frmMonitorSales : frmMain
  {
    private double ventaBebidas = 0;
    private double ventaAlimentos = 0;
    private double ventaOtros = 0;
    private double ventaSubTotal = 0;
    private double ventaDescuentos = 0;
    private double ventaTotal = 0;
    private double ventaIGV = 0;
    private double ventaConIGV = 0;
    private double ventaSalon = 0;
    private double ventaDelivery = 0;
    private double ventaRapido = 0;
    private double ventaTotalPorTipo = 0;
    private double ventaContado = 0;
    private double ventaTarjeta = 0;
    private double ventaCheque = 0;

    private string searchWhere = string.Empty;
    private string stringSQL = string.Empty;
    
    private DataSet dsSearch = null;
    public frmMonitorSales()
    {
      InitializeComponent();
      IniTurnoCombo();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void IniTurnoCombo()
    {
      radmccbTurno.AutoSizeDropDownToBestFit = true;
      RadMultiColumnComboBoxElement multiColumnComboElement = radmccbTurno.MultiColumnComboBoxElement;
      multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
      multiColumnComboElement.DropDownMinSize = new Size(420, 100);
      multiColumnComboElement.EditorControl.MasterGridViewTemplate.AutoGenerateColumns = false;
      var column = new GridViewTextBoxColumn("Turno_id");
      column.HeaderText = "Turno Code";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Fecha_apertura");
      column.HeaderText = "Fecha Apertura";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Fecha_cierre");
      column.HeaderText = "Fecha Cierre";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Estado");
      column.HeaderText = "Estado";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Turno_Desc");
      column.HeaderText = "Turno Descripcion";
      column.IsVisible = false;
      multiColumnComboElement.Columns.Add(column);
    }
    private void IniValues()
    {
      ventaBebidas = 0;
      ventaAlimentos = 0;
      ventaOtros = 0;
      ventaSubTotal = 0;
      ventaDescuentos = 0;
      ventaTotal = 0;
      ventaIGV = 0;
      ventaConIGV = 0;
      ventaSalon = 0;
      ventaDelivery = 0;
      ventaRapido = 0;
      ventaTotalPorTipo = 0;
      ventaContado = 0;
      ventaTarjeta = 0;
      ventaCheque = 0;
    }
    private void FillTurnoCombo()
    {
      DataSet dsResult = DataUtil.FillDataSet("SELECT Turno_id, Fecha_apertura, Fecha_cierre, Estado, LTrim((Str(Turno_id))+ ' - ' +Format(Fecha_apertura , 'Short Date')) AS Turno_Desc FROM turno ORDER BY fecha_apertura DESC", "turno");
      radmccbTurno.DataSource = dsResult.Tables[0];
      radmccbTurno.DisplayMember = "Turno_Desc";
      // Filtering START
      var filter = new FilterExpression(this.radmccbTurno.DisplayMember,
                                                     FilterExpression.BinaryOperation.AND,
                                                     GridKnownFunction.StartsWith,
                                                     GridFilterCellElement.ParameterName);
      filter.Parameters.Add(GridFilterCellElement.ParameterName, string.Empty);
      radmccbTurno.EditorControl.MasterGridViewTemplate.FilterExpressions.Add(filter);
      radmccbTurno.MultiColumnComboBoxElement.AutoCompleteMode = AutoCompleteMode.None;
      radmccbTurno.DropDownStyle = RadDropDownStyle.DropDown;
      // Filtering END
      radmccbTurno.SelectedItem = null;
    }
    private void Venta()
    {      
      stringSQL = "vd.precio_final," +
                  "prd.Producto_categoria_id " +
                  " FROM ((venta_detalle AS vd" +
                  " LEFT JOIN producto AS prd ON vd.Codigo_Producto = prd.producto_id)" +
                  " LEFT JOIN venta AS v ON vd.venta_id = v.venta_id) " +
                  "WHERE v.venta_id <> 0";

      stringSQL = stringSQL + BuildWhereVenta();

      dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + "", "venta_detalle");

      foreach (DataRow searchRow in dsSearch.Tables["venta_detalle"].Rows)
      {
        switch (DataUtil.GetString(searchRow["Producto_categoria_id"]))
        {
          case AppConstant.ProductoCategoriaDelSistema.Bebidas:
            ventaBebidas = ventaBebidas + DataUtil.GetDouble(searchRow["precio_final"]);
            break;
          case AppConstant.ProductoCategoriaDelSistema.Entradas:
          case AppConstant.ProductoCategoriaDelSistema.PlatosPrincipales:
          case AppConstant.ProductoCategoriaDelSistema.Postres:
            ventaAlimentos = ventaAlimentos + DataUtil.GetDouble(searchRow["precio_final"]);
            break;
          default:
            ventaOtros = ventaOtros + DataUtil.GetDouble(searchRow["precio_final"]);
            break;
        }
      }
      txtVentaBedidas.Text = ventaBebidas.ToString(DataUtil.Format.Decimals);
      txtVentaAlimentos.Text = ventaAlimentos.ToString(DataUtil.Format.Decimals);
      txtVentaOtros.Text = ventaOtros.ToString(DataUtil.Format.Decimals);
      ventaSubTotal = ventaBebidas + ventaAlimentos + ventaOtros;
      txtVentaSubtotal.Text = ventaSubTotal.ToString(DataUtil.Format.Decimals);

      stringSQL = "venta_documento_tipo," +
                  "IGV_Total, " +
                  "Monto_Total, " +
                  "Monto_descuento, " +
                  "Tipo_pago, " +
                  "Tipo_venta " +
                  " FROM venta "+
                  "WHERE venta_id <> 0";

      stringSQL = stringSQL + BuildWhereVenta();

      dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + "", "venta");

      foreach (DataRow searchRow in dsSearch.Tables["venta"].Rows)
      {
        ventaDescuentos = ventaDescuentos + DataUtil.GetDouble(searchRow["Monto_descuento"]);
        ventaIGV = ventaIGV + DataUtil.GetDouble(searchRow["IGV_Total"]);
        ventaConIGV = ventaConIGV + DataUtil.GetDouble(searchRow["Monto_Total"]);

        switch (DataUtil.GetString(searchRow["Tipo_venta"]))
        {
          case AppConstant.TipoVenta.Salon:
            ventaSalon = ventaSalon + DataUtil.GetDouble(searchRow["Monto_Total"]);
            break;
          case AppConstant.TipoVenta.Rapida:
            ventaRapido = ventaRapido + DataUtil.GetDouble(searchRow["Monto_Total"]);
            break;
          case AppConstant.TipoVenta.Delivery:
            ventaDelivery = ventaDelivery + DataUtil.GetDouble(searchRow["Monto_Total"]);
            break;
        }

        switch (DataUtil.GetString(searchRow["Tipo_pago"]))
        {
          case AppConstant.TipoPago.Contado:
            ventaContado = ventaContado + DataUtil.GetDouble(searchRow["Monto_Total"]);
            break;
          case AppConstant.TipoPago.TarjetaCredito:
            ventaTarjeta = ventaTarjeta + DataUtil.GetDouble(searchRow["Monto_Total"]);
            break;
          case AppConstant.TipoPago.Cheque:
            ventaCheque = ventaCheque + DataUtil.GetDouble(searchRow["Monto_Total"]);
            break;
        }
      }
      txtVentaDescuentos.Text = ventaDescuentos.ToString(DataUtil.Format.Decimals);
      ventaTotal = ventaSubTotal - ventaDescuentos;
      txtVentaTotal.Text = ventaTotal.ToString(DataUtil.Format.Decimals);
      txtVentaIGV.Text = ventaIGV.ToString(DataUtil.Format.Decimals);
      txtVentaConIGV.Text = ventaConIGV.ToString(DataUtil.Format.Decimals);

      txtVentaSalon.Text = ventaSalon.ToString(DataUtil.Format.Decimals);
      txtVentaRapida.Text = ventaRapido.ToString(DataUtil.Format.Decimals);
      txtVentaDelivery.Text = ventaDelivery.ToString(DataUtil.Format.Decimals);
      ventaTotalPorTipo = ventaSalon + ventaRapido + ventaDelivery;
      txtVentaTotalPorTipo.Text = ventaTotalPorTipo.ToString(DataUtil.Format.Decimals);

      txtVentaContado.Text = ventaContado.ToString(DataUtil.Format.Decimals);
      txtVentaTarjetaCredito.Text = ventaTarjeta.ToString(DataUtil.Format.Decimals);
      txtVentaCheque.Text = ventaCheque.ToString(DataUtil.Format.Decimals);      
    }
    private void PorCobrar()
    {
      double ventaBebidas_Cobrar = 0;
      double ventaAlimentos_Cobrar = 0;
      double ventaOtros_Cobrar = 0;
      double ventaSubTotal_Cobrar = 0;
      double ventaIGV_Cobrar = 0;
      double ventaConIGV_Cobrar = 0;

      stringSQL =  "       Producto.Producto_categoria_id," +
                   "       Pedido_detalle.Descuento AS Pedido_Descuento," +
                   "       Producto.Precio_final AS Producto_precio " +
                   "  FROM Producto " +
                   " INNER JOIN (Pedido "+
                   " INNER JOIN Pedido_detalle ON Pedido.Pedido_id = Pedido_detalle.Pedido_id) "+
                   "                           ON Producto.Producto_id = Pedido_detalle.Codigo_Producto" +
                   " WHERE Pedido.pedido_id <> 0";

      stringSQL = stringSQL + BuildWherePedidoPorCobrar();
      dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + "", "Pedido_detalle");

      foreach (DataRow searchRow in dsSearch.Tables["Pedido_detalle"].Rows)
      {
        ventaDescuentos = ventaDescuentos + DataUtil.GetDouble(searchRow["Pedido_Descuento"]);

        switch (DataUtil.GetString(searchRow["Producto_categoria_id"]))
        {
          case AppConstant.ProductoCategoriaDelSistema.Bebidas:
            ventaBebidas_Cobrar = ventaBebidas_Cobrar + DataUtil.GetDouble(searchRow["Producto_precio"]);
            break;
          case AppConstant.ProductoCategoriaDelSistema.Entradas:
          case AppConstant.ProductoCategoriaDelSistema.PlatosPrincipales:
          case AppConstant.ProductoCategoriaDelSistema.Postres:
            ventaAlimentos_Cobrar = ventaAlimentos_Cobrar + DataUtil.GetDouble(searchRow["Producto_precio"]);
            break;
          default:
            ventaOtros_Cobrar = ventaOtros_Cobrar + DataUtil.GetDouble(searchRow["Producto_precio"]);
            break;
        }
      }
      ventaSubTotal_Cobrar = ventaBebidas_Cobrar + ventaAlimentos_Cobrar + ventaOtros_Cobrar;
      ventaBebidas = ventaBebidas + ventaBebidas_Cobrar;
      ventaAlimentos = ventaAlimentos + ventaAlimentos_Cobrar;
      ventaOtros = ventaOtros + ventaOtros_Cobrar;


      txtVentaBedidas.Text = ventaBebidas.ToString(DataUtil.Format.Decimals);
      txtVentaAlimentos.Text = ventaAlimentos.ToString(DataUtil.Format.Decimals);
      txtVentaOtros.Text = ventaOtros.ToString(DataUtil.Format.Decimals);
      ventaSubTotal = ventaBebidas + ventaAlimentos + ventaOtros;
      txtVentaSubtotal.Text = ventaSubTotal.ToString(DataUtil.Format.Decimals);

      txtVentaDescuentos.Text = ventaDescuentos.ToString(DataUtil.Format.Decimals);
      ventaTotal = ventaSubTotal - ventaDescuentos;
      txtVentaTotal.Text = ventaTotal.ToString(DataUtil.Format.Decimals);

      ventaIGV_Cobrar = (ventaSubTotal_Cobrar * (DataUtil.GetDouble(AppConstant.GeneralInfo.IGV) / 100));
      ventaIGV = ventaIGV + ventaIGV_Cobrar;
      txtVentaIGV.Text = ventaIGV.ToString(DataUtil.Format.Decimals);

      ventaConIGV_Cobrar = ventaIGV_Cobrar + ventaSubTotal_Cobrar;
      ventaConIGV = ventaConIGV + ventaConIGV_Cobrar;
      txtVentaConIGV.Text = ventaConIGV.ToString(DataUtil.Format.Decimals);

      stringSQL ="       Pedido.Tipo_venta, " +
                 "       SUM(Producto.Precio_final) AS Monto_Total " +
                 "  FROM Producto " +
                 " INNER JOIN (Pedido "+ 
                 " INNER JOIN Pedido_detalle ON Pedido.Pedido_id = Pedido_detalle.Pedido_id) "+
                 "                           ON Producto.Producto_id = Pedido_detalle.Codigo_Producto" +
                 " WHERE Pedido.pedido_id <> 0";

      stringSQL = stringSQL + BuildWherePedidoPorCobrar();
      stringSQL = stringSQL + " GROUP BY Pedido.Tipo_venta";
      dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + "", "Pedido_detalle");

      foreach (DataRow searchRow in dsSearch.Tables["Pedido_detalle"].Rows)
      {
        switch (DataUtil.GetString(searchRow["Tipo_venta"]))
        {
          case AppConstant.TipoVenta.Salon:
            ventaSalon = ventaSalon + DataUtil.GetDouble(searchRow["Monto_Total"]);
            break;
          case AppConstant.TipoVenta.Rapida:
            ventaRapido = ventaRapido + DataUtil.GetDouble(searchRow["Monto_Total"]);
            break;
          case AppConstant.TipoVenta.Delivery:
            ventaDelivery = ventaDelivery + DataUtil.GetDouble(searchRow["Monto_Total"]);
            break;
        }
      }

      txtVentaSalon.Text = ventaSalon.ToString(DataUtil.Format.Decimals);
      txtVentaRapida.Text = ventaRapido.ToString(DataUtil.Format.Decimals);
      txtVentaDelivery.Text = ventaDelivery.ToString(DataUtil.Format.Decimals);
      ventaTotalPorTipo = ventaSalon + ventaRapido + ventaDelivery;
      txtVentaTotalPorTipo.Text = ventaTotalPorTipo.ToString(DataUtil.Format.Decimals);

      txtVentaContado.Text = ventaContado.ToString(DataUtil.Format.Decimals);
      txtVentaTarjetaCredito.Text = ventaTarjeta.ToString(DataUtil.Format.Decimals);
      txtVentaCheque.Text = ventaCheque.ToString(DataUtil.Format.Decimals);
    }
    private string BuildWhereVenta()
    {
      searchWhere = string.Empty;
      
      if (radmccbTurno.Text != string.Empty)
        searchWhere = searchWhere + " AND Turno_id = " + radmccbTurno.EditorControl.Rows[radmccbTurno.SelectedIndex].Cells["Turno_id"].Value + "";
      
      return searchWhere;
    }
    private string BuildWherePedido()
    {
      searchWhere = string.Empty;

      if (radmccbTurno.Text != string.Empty)
        searchWhere = searchWhere + " AND Turno_id = " + radmccbTurno.EditorControl.Rows[radmccbTurno.SelectedIndex].Cells["Turno_id"].Value + "";

      return searchWhere;
    }
    private string BuildWherePedidoPorCobrar()
    {
      searchWhere = string.Empty;

      if (radmccbTurno.Text != string.Empty)
        searchWhere = searchWhere + " AND Turno_id = " + radmccbTurno.EditorControl.Rows[radmccbTurno.SelectedIndex].Cells["Turno_id"].Value + "";

      return searchWhere;
    }

    private void frmMonitorSales_Load(object sender, EventArgs e)
    {
      FillTurnoCombo();
      IniValues();
      if (AppConstant.Turno.Codigo != string.Empty)
          radmccbTurno.SelectedIndex = 0;
      this.cbTipoVentas.SelectedItem = "TODAS";
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
        if (radmccbTurno.Text == string.Empty)
            MessageBox.Show(@"Debe seleccionar un turno.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        else
        {
            var waiting = new ShowWaitingBox("Procesando...", "Procesando informacion por favor espere..");
            waiting.Start();
            btnSearch.Enabled = false;
            btnClose.Enabled = false;
            btnVerProductosVendidos.Enabled = false;
            IniValues();
            switch (DataUtil.GetString(cbTipoVentas.SelectedItem))
            {
                case "TODAS":
                    Venta();
                    PorCobrar();
                    break;
                case "POR COBRAR":
                    PorCobrar();
                    break;
                case "COBRADAS":
                    Venta();
                    break;
            }
            txtOrdenesAbiertas.Text = DataUtil.FindSingleRow("pedido", "Count(*)", "Estado = 'A'" + BuildWherePedido());
            txtOrdenesPagadas.Text = DataUtil.FindSingleRow("pedido", "Count(*)", "Estado = 'F'" + BuildWherePedido());
            btnSearch.Enabled = true;
            btnVerProductosVendidos.Enabled = true;
            btnClose.Enabled = true;
            waiting.Stop();
        }
    }

    private void btnVerProductosVendidos_Click(object sender, EventArgs e)
    {
      var frmTurnProductForm = new frmTurnProduct();
      frmTurnProductForm.TurnoId = Convert.ToInt32(radmccbTurno.EditorControl.Rows[radmccbTurno.SelectedIndex].Cells["Turno_id"].Value);
      frmTurnProductForm.ShowDialog();
    }
  }
}
