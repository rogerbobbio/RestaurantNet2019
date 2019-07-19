using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;

namespace RestaurantNet.Reports
{
    /// <summary>
    /// Summary description for ReporteRecibos.
    /// </summary>
    partial class ReporteRecibos
    {
        private PageHeader pageHeader;
        private Detail detail;
        private PageFooter pageFooter;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ReporteRecibos));
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.lblSubTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblProducto = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblCantidad = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Line = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.lblOrderNo = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblOrderDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblAtentidoPor = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtEmployee = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblMesa = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtTable = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblDireccion = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblDocumento = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblTelefono = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblCompania = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.txtQty = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtDescription = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtMonto = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            this.reportHeader1 = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
            this.reportFooter1 = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
            this.txtSubTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtIGV = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtTotalGeneral = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblConsumo = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblIGV = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblTotalGeneral = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            ((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAtentidoPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCompania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.lblSubTotal,
            this.lblProducto,
            this.lblCantidad,
            this.Line,
            this.lblOrderNo,
            this.txtOrderID,
            this.lblOrderDate,
            this.txtOrderDate,
            this.lblAtentidoPor,
            this.txtEmployee,
            this.lblMesa,
            this.txtTable,
            this.lblDireccion,
            this.lblDocumento,
            this.lblTelefono,
            this.lblCompania,
            this.line2,
            this.line3});
            this.pageHeader.Height = 1.9375F;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.BeforePrint += new System.EventHandler(this.pageHeader_BeforePrint);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Height = 0.1875F;
            this.lblSubTotal.HyperLink = "";
            this.lblSubTotal.Left = 1.875F;
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: bottom; ddo-char-set: 0";
            this.lblSubTotal.Text = "Sub T.";
            this.lblSubTotal.Top = 1.6875F;
            this.lblSubTotal.Width = 0.4375F;
            // 
            // lblProducto
            // 
            this.lblProducto.Height = 0.1876251F;
            this.lblProducto.HyperLink = "";
            this.lblProducto.Left = 0.5420001F;
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; vertical-align: bottom; ddo-char-set: 0";
            this.lblProducto.Text = "Producto";
            this.lblProducto.Top = 1.687F;
            this.lblProducto.Width = 0.671875F;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Height = 0.1875F;
            this.lblCantidad.HyperLink = "";
            this.lblCantidad.Left = 0.121F;
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: lef" +
    "t; vertical-align: bottom; ddo-char-set: 0";
            this.lblCantidad.Text = "Cant.";
            this.lblCantidad.Top = 1.687F;
            this.lblCantidad.Width = 0.3125F;
            // 
            // Line
            // 
            this.Line.Height = 0.0002499819F;
            this.Line.Left = 0F;
            this.Line.LineWeight = 1F;
            this.Line.Name = "Line";
            this.Line.Top = 1.906F;
            this.Line.Width = 3.000001F;
            this.Line.X1 = 0F;
            this.Line.X2 = 3.000001F;
            this.Line.Y1 = 1.906F;
            this.Line.Y2 = 1.90625F;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.Height = 0.1875F;
            this.lblOrderNo.HyperLink = null;
            this.lblOrderNo.Left = 0.375F;
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblOrderNo.Text = "Pedido #:";
            this.lblOrderNo.Top = 0.812F;
            this.lblOrderNo.Width = 0.625F;
            // 
            // txtOrderID
            // 
            this.txtOrderID.CanGrow = false;
            this.txtOrderID.DataField = "Pedido_id";
            this.txtOrderID.Height = 0.1875F;
            this.txtOrderID.Left = 1.062F;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Style = "background-color: Transparent; font-family: Courier New; font-size: 6.75pt; text-" +
    "align: left; vertical-align: middle; ddo-char-set: 0";
            this.txtOrderID.Text = "99999";
            this.txtOrderID.Top = 0.812F;
            this.txtOrderID.Width = 0.9375F;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Height = 0.1875F;
            this.lblOrderDate.HyperLink = null;
            this.lblOrderDate.Left = 0.0625F;
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblOrderDate.Text = "Fecha:";
            this.lblOrderDate.Top = 1F;
            this.lblOrderDate.Width = 0.9375F;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.DataField = "Fecha_Pedido";
            this.txtOrderDate.Height = 0.1875F;
            this.txtOrderDate.Left = 1.0625F;
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.OutputFormat = resources.GetString("txtOrderDate.OutputFormat");
            this.txtOrderDate.Style = "background-color: Transparent; font-family: Courier New; font-size: 6.75pt; text-" +
    "align: left; vertical-align: middle; white-space: nowrap; ddo-char-set: 0";
            this.txtOrderDate.Text = "99/99/9999";
            this.txtOrderDate.Top = 1F;
            this.txtOrderDate.Width = 1.4375F;
            // 
            // lblAtentidoPor
            // 
            this.lblAtentidoPor.Height = 0.1875F;
            this.lblAtentidoPor.HyperLink = null;
            this.lblAtentidoPor.Left = 0F;
            this.lblAtentidoPor.Name = "lblAtentidoPor";
            this.lblAtentidoPor.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblAtentidoPor.Text = "Mozo:";
            this.lblAtentidoPor.Top = 1.1875F;
            this.lblAtentidoPor.Width = 1F;
            // 
            // txtEmployee
            // 
            this.txtEmployee.CanGrow = false;
            this.txtEmployee.DataField = "AtendidoPor";
            this.txtEmployee.Height = 0.1875F;
            this.txtEmployee.Left = 1.0625F;
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Style = "background-color: Transparent; font-family: Courier New; font-size: 6.75pt; text-" +
    "align: left; vertical-align: middle; ddo-char-set: 0";
            this.txtEmployee.Text = "txtEmployee";
            this.txtEmployee.Top = 1.1875F;
            this.txtEmployee.Width = 1.9275F;
            // 
            // lblMesa
            // 
            this.lblMesa.Height = 0.1875F;
            this.lblMesa.HyperLink = null;
            this.lblMesa.Left = 0.0625F;
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblMesa.Text = "Mesa:";
            this.lblMesa.Top = 1.375F;
            this.lblMesa.Width = 0.9375F;
            // 
            // txtTable
            // 
            this.txtTable.CanGrow = false;
            this.txtTable.Height = 0.1875F;
            this.txtTable.Left = 1.0625F;
            this.txtTable.Name = "txtTable";
            this.txtTable.Style = "background-color: Transparent; font-family: Courier New; font-size: 6.75pt; text-" +
    "align: left; vertical-align: middle; ddo-char-set: 0";
            this.txtTable.Text = "txtTable";
            this.txtTable.Top = 1.375F;
            this.txtTable.Width = 0.6875F;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Height = 0.1875F;
            this.lblDireccion.HyperLink = null;
            this.lblDireccion.Left = 0F;
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Style = "font-family: Courier New; font-size: 8.25pt; text-align: center; white-space: now" +
    "rap; ddo-char-set: 0";
            this.lblDireccion.Text = "lblDireccion";
            this.lblDireccion.Top = 0.1875F;
            this.lblDireccion.Width = 2.5F;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Height = 0.1875F;
            this.lblDocumento.HyperLink = null;
            this.lblDocumento.Left = 0F;
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Style = "font-family: Courier New; font-size: 8.25pt; text-align: center; ddo-char-set: 0";
            this.lblDocumento.Text = "lblDocumento";
            this.lblDocumento.Top = 0.375F;
            this.lblDocumento.Width = 2.5F;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Height = 0.1875F;
            this.lblTelefono.HyperLink = null;
            this.lblTelefono.Left = 0F;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Style = "font-family: Courier New; font-size: 8.25pt; text-align: center; ddo-char-set: 0";
            this.lblTelefono.Text = "lblTelefono";
            this.lblTelefono.Top = 0.5625F;
            this.lblTelefono.Width = 2.5F;
            // 
            // lblCompania
            // 
            this.lblCompania.Height = 0.1875F;
            this.lblCompania.HyperLink = null;
            this.lblCompania.Left = 0F;
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Style = "font-family: Courier New; font-size: 8.25pt; text-align: center; ddo-char-set: 0";
            this.lblCompania.Text = "lblCompania";
            this.lblCompania.Top = 0F;
            this.lblCompania.Width = 2.5F;
            // 
            // line2
            // 
            this.line2.Height = 0.0001667142F;
            this.line2.Left = 0F;
            this.line2.LineWeight = 1F;
            this.line2.Name = "line2";
            this.line2.Top = 0.7708333F;
            this.line2.Width = 2.99F;
            this.line2.X1 = 2.99F;
            this.line2.X2 = 0F;
            this.line2.Y1 = 0.771F;
            this.line2.Y2 = 0.7708333F;
            // 
            // line3
            // 
            this.line3.Height = 0.0001670122F;
            this.line3.Left = 0F;
            this.line3.LineWeight = 1F;
            this.line3.Name = "line3";
            this.line3.Top = 1.604F;
            this.line3.Width = 2.99F;
            this.line3.X1 = 2.99F;
            this.line3.X2 = 0F;
            this.line3.Y1 = 1.604F;
            this.line3.Y2 = 1.604167F;
            // 
            // detail
            // 
            this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.txtQty,
            this.txtDescription,
            this.txtMonto});
            this.detail.Height = 0.1979167F;
            this.detail.Name = "detail";
            this.detail.BeforePrint += new System.EventHandler(this.detail_BeforePrint);
            // 
            // txtQty
            // 
            this.txtQty.CanGrow = false;
            this.txtQty.DataField = "Pedido_cantidad";
            this.txtQty.Height = 0.1875F;
            this.txtQty.Left = 0F;
            this.txtQty.Name = "txtQty";
            this.txtQty.Style = "font-family: Courier New; font-size: 6.75pt; text-align: center; ddo-char-set: 0";
            this.txtQty.Text = "99";
            this.txtQty.Top = 0F;
            this.txtQty.Width = 0.1875F;
            // 
            // txtDescription
            // 
            this.txtDescription.CanGrow = false;
            this.txtDescription.DataField = "Descripcion_Producto";
            this.txtDescription.Height = 0.1875F;
            this.txtDescription.Left = 0.1875F;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Style = "font-family: Courier New; font-size: 6.75pt; text-align: left; white-space: nowra" +
    "p; ddo-char-set: 0";
            this.txtDescription.Text = "txtDescription";
            this.txtDescription.Top = 0F;
            this.txtDescription.Width = 1.5F;
            // 
            // txtMonto
            // 
            this.txtMonto.DataField = "Producto_precio";
            this.txtMonto.Height = 0.1875F;
            this.txtMonto.Left = 1.875F;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.OutputFormat = resources.GetString("txtMonto.OutputFormat");
            this.txtMonto.Style = "font-family: Courier New; font-size: 6.75pt; text-align: right; white-space: nowr" +
    "ap; ddo-char-set: 0";
            this.txtMonto.Text = "999";
            this.txtMonto.Top = 0F;
            this.txtMonto.Width = 0.4375F;
            // 
            // pageFooter
            // 
            this.pageFooter.CanShrink = true;
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // reportHeader1
            // 
            this.reportHeader1.Height = 0F;
            this.reportHeader1.Name = "reportHeader1";
            // 
            // reportFooter1
            // 
            this.reportFooter1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.txtSubTotal,
            this.txtIGV,
            this.txtTotalGeneral,
            this.lblConsumo,
            this.lblIGV,
            this.lblTotalGeneral,
            this.line1});
            this.reportFooter1.Height = 0.7083333F;
            this.reportFooter1.Name = "reportFooter1";
            this.reportFooter1.BeforePrint += new System.EventHandler(this.reportFooter1_BeforePrint);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.DataField = "Descripcion_Monto";
            this.txtSubTotal.Height = 0.1875F;
            this.txtSubTotal.Left = 1.5625F;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.OutputFormat = resources.GetString("txtSubTotal.OutputFormat");
            this.txtSubTotal.Style = "font-family: Courier New; font-size: 6.75pt; text-align: right; vertical-align: m" +
    "iddle; white-space: nowrap; ddo-char-set: 0";
            this.txtSubTotal.Text = "txtSubTotal";
            this.txtSubTotal.Top = 0.0625F;
            this.txtSubTotal.Width = 0.875F;
            // 
            // txtIGV
            // 
            this.txtIGV.DataField = "Descripcion_Monto";
            this.txtIGV.Height = 0.1875F;
            this.txtIGV.Left = 1.5625F;
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.OutputFormat = resources.GetString("txtIGV.OutputFormat");
            this.txtIGV.Style = "font-family: Courier New; font-size: 6.75pt; text-align: right; vertical-align: m" +
    "iddle; white-space: nowrap; ddo-char-set: 0";
            this.txtIGV.Text = "txtIGV";
            this.txtIGV.Top = 0.25F;
            this.txtIGV.Width = 0.875F;
            // 
            // txtTotalGeneral
            // 
            this.txtTotalGeneral.DataField = "Descripcion_Monto";
            this.txtTotalGeneral.Height = 0.1875F;
            this.txtTotalGeneral.Left = 1.5625F;
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.OutputFormat = resources.GetString("txtTotalGeneral.OutputFormat");
            this.txtTotalGeneral.Style = "font-family: Courier New; font-size: 6.75pt; text-align: right; vertical-align: m" +
    "iddle; white-space: nowrap; ddo-char-set: 0";
            this.txtTotalGeneral.Text = "txtTotalGeneral";
            this.txtTotalGeneral.Top = 0.4375F;
            this.txtTotalGeneral.Width = 0.875F;
            // 
            // lblConsumo
            // 
            this.lblConsumo.Height = 0.1876251F;
            this.lblConsumo.HyperLink = "";
            this.lblConsumo.Left = 0.875F;
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblConsumo.Text = "Consumo";
            this.lblConsumo.Top = 0.0625F;
            this.lblConsumo.Width = 0.671875F;
            // 
            // lblIGV
            // 
            this.lblIGV.Height = 0.1875F;
            this.lblIGV.HyperLink = "";
            this.lblIGV.Left = 0.5416667F;
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblIGV.Text = "IGV (19 %)";
            this.lblIGV.Top = 0.25F;
            this.lblIGV.Width = 1F;
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.Height = 0.1876251F;
            this.lblTotalGeneral.HyperLink = "";
            this.lblTotalGeneral.Left = 0.875F;
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblTotalGeneral.Text = "Total";
            this.lblTotalGeneral.Top = 0.4375F;
            this.lblTotalGeneral.Width = 0.671875F;
            // 
            // line1
            // 
            this.line1.Height = 0F;
            this.line1.Left = 0F;
            this.line1.LineWeight = 1F;
            this.line1.Name = "line1";
            this.line1.Top = 0F;
            this.line1.Width = 3F;
            this.line1.X1 = 0F;
            this.line1.X2 = 3F;
            this.line1.Y1 = 0F;
            this.line1.Y2 = 0F;
            // 
            // ReporteRecibos
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 3F;
            this.Sections.Add(this.reportHeader1);
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.Sections.Add(this.reportFooter1);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            this.ReportStart += new System.EventHandler(this.MainReport_ReportStart);
            ((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAtentidoPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCompania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Label lblProducto;
        private Label lblCantidad;
        private Line Line;
        private Label lblSubTotal;
        private TextBox txtQty;
        private TextBox txtDescription;
        private TextBox txtMonto;
        private ReportHeader reportHeader1;
        private ReportFooter reportFooter1;
        private Label lblOrderNo;
        private TextBox txtOrderID;
        private Label lblOrderDate;
        private TextBox txtOrderDate;
        private Label lblAtentidoPor;
        private TextBox txtEmployee;
        private Label lblMesa;
        private TextBox txtTable;
        private TextBox txtSubTotal;
        private TextBox txtIGV;
        private TextBox txtTotalGeneral;
        private Label lblConsumo;
        private Label lblIGV;
        private Label lblTotalGeneral;
        private Line line1;
        private Label lblDireccion;
        private Label lblDocumento;
        private Label lblTelefono;
        private Label lblCompania;
        private Line line2;
        private Line line3;
    }
}
