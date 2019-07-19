using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;

namespace RestaurantNet.Reports
{
  /// <summary>
  /// Summary description for ReporteBoleta.
  /// </summary>
  partial class ReporteBoleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteBoleta));
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.lblDireccion = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblDocumento = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblTelefono = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblCompania = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblBoletaTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.lblOrdenTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblFechaTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblTipoTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblAtendidoPorTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblMesaTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.lblCantidadTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblProductoTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblSubTotalTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblBoleta = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblOrden = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblFecha = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblTipo = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblAtendidoPor = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblMesa = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.lblCantidad = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblProducto = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblSubTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            this.reportHeader1 = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
            this.reportFooter1 = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
            this.lblMensaje1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblMensaje2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblMensaje3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.line5 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.lblConsumoTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblIGV = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblTotalGTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblLetras = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblConsumo = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblIGVTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblTotalG = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.line6 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.barcodeBottom = new GrapeCity.ActiveReports.SectionReportModel.Barcode();
            this.label6 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCompania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBoletaTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrdenTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFechaTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTipoTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAtendidoPorTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMesaTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidadTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProductoTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSubTotalTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBoleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAtendidoPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMensaje1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMensaje2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMensaje3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConsumoTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalGTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIGVTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.lblDireccion,
            this.lblDocumento,
            this.lblTelefono,
            this.lblCompania,
            this.lblBoletaTitle,
            this.line1,
            this.lblOrdenTitle,
            this.lblFechaTitle,
            this.lblTipoTitle,
            this.lblAtendidoPorTitle,
            this.lblMesaTitle,
            this.line2,
            this.line3,
            this.lblCantidadTitle,
            this.lblProductoTitle,
            this.lblSubTotalTitle,
            this.lblBoleta,
            this.lblOrden,
            this.lblFecha,
            this.lblTipo,
            this.lblAtendidoPor,
            this.lblMesa,
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.label5});
            this.pageHeader.Height = 3.511F;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.BeforePrint += new System.EventHandler(this.pageHeader_BeforePrint);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Height = 0.5425F;
            this.lblDireccion.HyperLink = null;
            this.lblDireccion.Left = 0F;
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Style = "font-family: Courier New; font-size: 8.25pt; text-align: center; white-space: now" +
    "rap; ddo-char-set: 0";
            this.lblDireccion.Text = "lblDireccion";
            this.lblDireccion.Top = 0.187F;
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
            this.lblDocumento.Top = 0.7295001F;
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
            this.lblTelefono.Top = 0.9170001F;
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
            // lblBoletaTitle
            // 
            this.lblBoletaTitle.Height = 0.1875F;
            this.lblBoletaTitle.HyperLink = null;
            this.lblBoletaTitle.Left = 0F;
            this.lblBoletaTitle.Name = "lblBoletaTitle";
            this.lblBoletaTitle.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; ddo-char-set: 0";
            this.lblBoletaTitle.Text = "Boleta # :";
            this.lblBoletaTitle.Top = 1.354F;
            this.lblBoletaTitle.Width = 1F;
            // 
            // line1
            // 
            this.line1.Height = 0.0002499819F;
            this.line1.Left = 0F;
            this.line1.LineWeight = 1F;
            this.line1.Name = "line1";
            this.line1.Top = 1.3225F;
            this.line1.Width = 2.969F;
            this.line1.X1 = 2.969F;
            this.line1.X2 = 0F;
            this.line1.Y1 = 1.3225F;
            this.line1.Y2 = 1.32275F;
            // 
            // lblOrdenTitle
            // 
            this.lblOrdenTitle.Height = 0.1875F;
            this.lblOrdenTitle.HyperLink = null;
            this.lblOrdenTitle.Left = 0F;
            this.lblOrdenTitle.Name = "lblOrdenTitle";
            this.lblOrdenTitle.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; ddo-char-set: 0";
            this.lblOrdenTitle.Text = "Orden # :";
            this.lblOrdenTitle.Top = 1.551917F;
            this.lblOrdenTitle.Width = 1F;
            // 
            // lblFechaTitle
            // 
            this.lblFechaTitle.Height = 0.1875F;
            this.lblFechaTitle.HyperLink = null;
            this.lblFechaTitle.Left = 0F;
            this.lblFechaTitle.Name = "lblFechaTitle";
            this.lblFechaTitle.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; ddo-char-set: 0";
            this.lblFechaTitle.Text = "Fecha :";
            this.lblFechaTitle.Top = 1.749833F;
            this.lblFechaTitle.Width = 1F;
            // 
            // lblTipoTitle
            // 
            this.lblTipoTitle.Height = 0.1875F;
            this.lblTipoTitle.HyperLink = null;
            this.lblTipoTitle.Left = 0F;
            this.lblTipoTitle.Name = "lblTipoTitle";
            this.lblTipoTitle.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; ddo-char-set: 0";
            this.lblTipoTitle.Text = "Tipo :";
            this.lblTipoTitle.Top = 1.94775F;
            this.lblTipoTitle.Width = 1F;
            // 
            // lblAtendidoPorTitle
            // 
            this.lblAtendidoPorTitle.Height = 0.1875F;
            this.lblAtendidoPorTitle.HyperLink = null;
            this.lblAtendidoPorTitle.Left = 0F;
            this.lblAtendidoPorTitle.Name = "lblAtendidoPorTitle";
            this.lblAtendidoPorTitle.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; ddo-char-set: 0";
            this.lblAtendidoPorTitle.Text = "Atendido por :";
            this.lblAtendidoPorTitle.Top = 2.145667F;
            this.lblAtendidoPorTitle.Width = 1F;
            // 
            // lblMesaTitle
            // 
            this.lblMesaTitle.Height = 0.1875F;
            this.lblMesaTitle.HyperLink = null;
            this.lblMesaTitle.Left = 0F;
            this.lblMesaTitle.Name = "lblMesaTitle";
            this.lblMesaTitle.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; ddo-char-set: 0";
            this.lblMesaTitle.Text = "Mesa :";
            this.lblMesaTitle.Top = 2.343583F;
            this.lblMesaTitle.Width = 1F;
            // 
            // line2
            // 
            this.line2.Height = 0.0005002022F;
            this.line2.Left = 0F;
            this.line2.LineWeight = 1F;
            this.line2.Name = "line2";
            this.line2.Top = 3.2285F;
            this.line2.Width = 2.969F;
            this.line2.X1 = 2.969F;
            this.line2.X2 = 0F;
            this.line2.Y1 = 3.2285F;
            this.line2.Y2 = 3.229F;
            // 
            // line3
            // 
            this.line3.Height = 0.0005002022F;
            this.line3.Left = 0F;
            this.line3.LineWeight = 1F;
            this.line3.Name = "line3";
            this.line3.Top = 3.4785F;
            this.line3.Width = 2.969F;
            this.line3.X1 = 2.969F;
            this.line3.X2 = 0F;
            this.line3.Y1 = 3.4785F;
            this.line3.Y2 = 3.479F;
            // 
            // lblCantidadTitle
            // 
            this.lblCantidadTitle.Height = 0.1875F;
            this.lblCantidadTitle.HyperLink = null;
            this.lblCantidadTitle.Left = 0.031F;
            this.lblCantidadTitle.Name = "lblCantidadTitle";
            this.lblCantidadTitle.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; ddo-char-set: 0";
            this.lblCantidadTitle.Text = "Cant.";
            this.lblCantidadTitle.Top = 3.281F;
            this.lblCantidadTitle.Width = 0.3125F;
            // 
            // lblProductoTitle
            // 
            this.lblProductoTitle.Height = 0.25F;
            this.lblProductoTitle.HyperLink = null;
            this.lblProductoTitle.Left = 0.343F;
            this.lblProductoTitle.Name = "lblProductoTitle";
            this.lblProductoTitle.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; ddo-char-set: 0";
            this.lblProductoTitle.Text = "Producto";
            this.lblProductoTitle.Top = 3.271F;
            this.lblProductoTitle.Width = 1.4375F;
            // 
            // lblSubTotalTitle
            // 
            this.lblSubTotalTitle.Height = 0.1875F;
            this.lblSubTotalTitle.HyperLink = null;
            this.lblSubTotalTitle.Left = 1.562F;
            this.lblSubTotalTitle.Name = "lblSubTotalTitle";
            this.lblSubTotalTitle.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; ddo-char-set: 0";
            this.lblSubTotalTitle.Text = "Sub Total";
            this.lblSubTotalTitle.Top = 3.271F;
            this.lblSubTotalTitle.Width = 0.75F;
            // 
            // lblBoleta
            // 
            this.lblBoleta.DataField = "venta_documento";
            this.lblBoleta.Height = 0.1875F;
            this.lblBoleta.HyperLink = null;
            this.lblBoleta.Left = 1.03125F;
            this.lblBoleta.Name = "lblBoleta";
            this.lblBoleta.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; ddo-char-set: 0";
            this.lblBoleta.Text = "lblBoleta";
            this.lblBoleta.Top = 1.354F;
            this.lblBoleta.Width = 1F;
            // 
            // lblOrden
            // 
            this.lblOrden.DataField = "Pedido_id";
            this.lblOrden.Height = 0.1875F;
            this.lblOrden.HyperLink = null;
            this.lblOrden.Left = 1.03125F;
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; ddo-char-set: 0";
            this.lblOrden.Text = "lblOrden";
            this.lblOrden.Top = 1.551917F;
            this.lblOrden.Width = 1F;
            // 
            // lblFecha
            // 
            this.lblFecha.DataField = "Fecha_Pedido";
            this.lblFecha.Height = 0.1875F;
            this.lblFecha.HyperLink = null;
            this.lblFecha.Left = 1.03125F;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; ddo-char-set: 0";
            this.lblFecha.Text = "99/99/9999  99:99:99 AM";
            this.lblFecha.Top = 1.739417F;
            this.lblFecha.Width = 1.93775F;
            // 
            // lblTipo
            // 
            this.lblTipo.DataField = "Tipo_venta";
            this.lblTipo.Height = 0.1875F;
            this.lblTipo.HyperLink = null;
            this.lblTipo.Left = 1.03125F;
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; ddo-char-set: 0";
            this.lblTipo.Text = "lblTipo";
            this.lblTipo.Top = 1.94775F;
            this.lblTipo.Width = 1F;
            // 
            // lblAtendidoPor
            // 
            this.lblAtendidoPor.DataField = "AtendidoPor";
            this.lblAtendidoPor.Height = 0.1875F;
            this.lblAtendidoPor.HyperLink = null;
            this.lblAtendidoPor.Left = 1.03125F;
            this.lblAtendidoPor.Name = "lblAtendidoPor";
            this.lblAtendidoPor.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; ddo-char-set: 0";
            this.lblAtendidoPor.Text = "lblAtendidoPor";
            this.lblAtendidoPor.Top = 2.145667F;
            this.lblAtendidoPor.Width = 1.93775F;
            // 
            // lblMesa
            // 
            this.lblMesa.Height = 0.1875F;
            this.lblMesa.HyperLink = null;
            this.lblMesa.Left = 1.03125F;
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; vertical-align: top; ddo-char-set: 0";
            this.lblMesa.Text = "lblMesa";
            this.lblMesa.Top = 2.343583F;
            this.lblMesa.Width = 1F;
            // 
            // label1
            // 
            this.label1.Height = 0.1875F;
            this.label1.HyperLink = null;
            this.label1.Left = 0F;
            this.label1.Name = "label1";
            this.label1.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; ddo-char-set: 0";
            this.label1.Text = "Cliente :";
            this.label1.Top = 2.5415F;
            this.label1.Width = 1F;
            // 
            // label2
            // 
            this.label2.DataField = "Cliente";
            this.label2.Height = 0.1875F;
            this.label2.HyperLink = null;
            this.label2.Left = 1.03125F;
            this.label2.Name = "label2";
            this.label2.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; ddo-char-set: 0";
            this.label2.Text = "";
            this.label2.Top = 2.5415F;
            this.label2.Width = 1.93775F;
            // 
            // label3
            // 
            this.label3.Height = 0.1875F;
            this.label3.HyperLink = null;
            this.label3.Left = 0.01041667F;
            this.label3.Name = "label3";
            this.label3.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; ddo-char-set: 0";
            this.label3.Text = "Direccion :";
            this.label3.Top = 2.76025F;
            this.label3.Width = 1F;
            // 
            // label4
            // 
            this.label4.DataField = "Cliente_direccion";
            this.label4.Height = 0.375F;
            this.label4.HyperLink = null;
            this.label4.Left = 1.041667F;
            this.label4.Name = "label4";
            this.label4.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: lef" +
    "t; ddo-char-set: 0";
            this.label4.Text = "";
            this.label4.Top = 2.76025F;
            this.label4.Width = 1.927333F;
            // 
            // label5
            // 
            this.label5.Height = 0.1875F;
            this.label5.HyperLink = null;
            this.label5.Left = 0F;
            this.label5.Name = "label5";
            this.label5.Style = "font-family: Courier New; font-size: 8.25pt; text-align: center; ddo-char-set: 0";
            this.label5.Text = "BOLETA DE VENTA ELECTRONICA";
            this.label5.Top = 1.105F;
            this.label5.Width = 2.5F;
            // 
            // detail
            // 
            this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.lblCantidad,
            this.lblProducto,
            this.lblSubTotal});
            this.detail.Height = 0.2089166F;
            this.detail.Name = "detail";
            this.detail.BeforePrint += new System.EventHandler(this.detail_BeforePrint);
            // 
            // lblCantidad
            // 
            this.lblCantidad.DataField = "Venta_cantidad";
            this.lblCantidad.Height = 0.1875F;
            this.lblCantidad.HyperLink = null;
            this.lblCantidad.Left = 0.124F;
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: cen" +
    "ter; ddo-char-set: 0";
            this.lblCantidad.Text = "99";
            this.lblCantidad.Top = 0F;
            this.lblCantidad.Width = 0.1875F;
            // 
            // lblProducto
            // 
            this.lblProducto.DataField = "Descripcion_Producto";
            this.lblProducto.Height = 0.1875F;
            this.lblProducto.HyperLink = null;
            this.lblProducto.Left = 0.312F;
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: lef" +
    "t; ddo-char-set: 0";
            this.lblProducto.Text = "lblProducto";
            this.lblProducto.Top = 0F;
            this.lblProducto.Width = 1.625F;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.DataField = "Producto_precio";
            this.lblSubTotal.Height = 0.1875F;
            this.lblSubTotal.HyperLink = null;
            this.lblSubTotal.Left = 1.937F;
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Style = "font-family: Courier New; font-size: 8.25pt; font-weight: normal; text-align: rig" +
    "ht; ddo-char-set: 0";
            this.lblSubTotal.Text = "999";
            this.lblSubTotal.Top = 0F;
            this.lblSubTotal.Width = 0.3125F;
            // 
            // pageFooter
            // 
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
            this.lblMensaje1,
            this.lblMensaje2,
            this.lblMensaje3,
            this.line5,
            this.line4,
            this.lblConsumoTitle,
            this.lblIGV,
            this.lblTotalGTitle,
            this.lblLetras,
            this.lblConsumo,
            this.lblIGVTotal,
            this.lblTotalG,
            this.line6,
            this.barcodeBottom,
            this.label6});
            this.reportFooter1.Height = 3.985972F;
            this.reportFooter1.Name = "reportFooter1";
            this.reportFooter1.BeforePrint += new System.EventHandler(this.reportFooter1_BeforePrint);
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.Height = 0.1875F;
            this.lblMensaje1.HyperLink = null;
            this.lblMensaje1.Left = 0F;
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Style = "font-family: Courier New; font-size: 9pt; text-align: center; ddo-char-set: 0";
            this.lblMensaje1.Text = "lblMensaje1";
            this.lblMensaje1.Top = 1.0625F;
            this.lblMensaje1.Width = 2.5F;
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.Height = 0.1875F;
            this.lblMensaje2.HyperLink = null;
            this.lblMensaje2.Left = 0F;
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Style = "font-family: Courier New; font-size: 9pt; text-align: center; ddo-char-set: 0";
            this.lblMensaje2.Text = "lblMensaje2";
            this.lblMensaje2.Top = 1.25F;
            this.lblMensaje2.Width = 2.5F;
            // 
            // lblMensaje3
            // 
            this.lblMensaje3.Height = 0.1875F;
            this.lblMensaje3.HyperLink = null;
            this.lblMensaje3.Left = 0F;
            this.lblMensaje3.Name = "lblMensaje3";
            this.lblMensaje3.Style = "font-family: Courier New; font-size: 9pt; text-align: center; ddo-char-set: 0";
            this.lblMensaje3.Text = "lblMensaje3";
            this.lblMensaje3.Top = 1.4375F;
            this.lblMensaje3.Width = 2.5F;
            // 
            // line5
            // 
            this.line5.Height = 0.0002499819F;
            this.line5.Left = 0F;
            this.line5.LineWeight = 1F;
            this.line5.Name = "line5";
            this.line5.Top = 1.031F;
            this.line5.Width = 2.969F;
            this.line5.X1 = 2.969F;
            this.line5.X2 = 0F;
            this.line5.Y1 = 1.031F;
            this.line5.Y2 = 1.03125F;
            // 
            // line4
            // 
            this.line4.Height = 0F;
            this.line4.Left = 0F;
            this.line4.LineWeight = 1F;
            this.line4.Name = "line4";
            this.line4.Top = 0F;
            this.line4.Width = 2.969F;
            this.line4.X1 = 2.969F;
            this.line4.X2 = 0F;
            this.line4.Y1 = 0F;
            this.line4.Y2 = 0F;
            // 
            // lblConsumoTitle
            // 
            this.lblConsumoTitle.Height = 0.1875F;
            this.lblConsumoTitle.HyperLink = null;
            this.lblConsumoTitle.Left = 0.75F;
            this.lblConsumoTitle.Name = "lblConsumoTitle";
            this.lblConsumoTitle.Style = "font-family: Courier New; font-size: 9pt; font-weight: normal; text-align: right;" +
    " ddo-char-set: 0";
            this.lblConsumoTitle.Text = "Consumo :";
            this.lblConsumoTitle.Top = 0.0625F;
            this.lblConsumoTitle.Width = 0.875F;
            // 
            // lblIGV
            // 
            this.lblIGV.Height = 0.1875F;
            this.lblIGV.HyperLink = null;
            this.lblIGV.Left = 0.5625F;
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Style = "font-family: Courier New; font-size: 9pt; font-weight: normal; text-align: right;" +
    " ddo-char-set: 0";
            this.lblIGV.Text = "IGV (19 %)";
            this.lblIGV.Top = 0.25F;
            this.lblIGV.Width = 1.0625F;
            // 
            // lblTotalGTitle
            // 
            this.lblTotalGTitle.Height = 0.1875F;
            this.lblTotalGTitle.HyperLink = null;
            this.lblTotalGTitle.Left = 0.75F;
            this.lblTotalGTitle.Name = "lblTotalGTitle";
            this.lblTotalGTitle.Style = "font-family: Courier New; font-size: 10pt; font-weight: normal; text-align: right" +
    "; ddo-char-set: 1";
            this.lblTotalGTitle.Text = "Total S/. :";
            this.lblTotalGTitle.Top = 0.4375F;
            this.lblTotalGTitle.Width = 0.875F;
            // 
            // lblLetras
            // 
            this.lblLetras.Height = 0.3125F;
            this.lblLetras.HyperLink = null;
            this.lblLetras.Left = 0F;
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Style = "font-family: Courier New; font-size: 8.25pt; text-align: left; ddo-char-set: 0";
            this.lblLetras.Text = "lblLetras";
            this.lblLetras.Top = 0.6874999F;
            this.lblLetras.Width = 2.5F;
            // 
            // lblConsumo
            // 
            this.lblConsumo.DataField = "Sub_total";
            this.lblConsumo.Height = 0.1875F;
            this.lblConsumo.HyperLink = null;
            this.lblConsumo.Left = 1.625F;
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Style = "font-family: Courier New; font-size: 9pt; font-weight: normal; text-align: right;" +
    " ddo-char-set: 0";
            this.lblConsumo.Text = "9999.99";
            this.lblConsumo.Top = 0.0625F;
            this.lblConsumo.Width = 0.75F;
            // 
            // lblIGVTotal
            // 
            this.lblIGVTotal.DataField = "IGV_total";
            this.lblIGVTotal.Height = 0.1875F;
            this.lblIGVTotal.HyperLink = null;
            this.lblIGVTotal.Left = 1.625F;
            this.lblIGVTotal.Name = "lblIGVTotal";
            this.lblIGVTotal.Style = "font-family: Courier New; font-size: 9pt; font-weight: normal; text-align: right;" +
    " ddo-char-set: 0";
            this.lblIGVTotal.Text = "9999.99";
            this.lblIGVTotal.Top = 0.25F;
            this.lblIGVTotal.Width = 0.75F;
            // 
            // lblTotalG
            // 
            this.lblTotalG.DataField = "Monto_total";
            this.lblTotalG.Height = 0.1875F;
            this.lblTotalG.HyperLink = null;
            this.lblTotalG.Left = 1.625F;
            this.lblTotalG.Name = "lblTotalG";
            this.lblTotalG.Style = "font-family: Courier New; font-size: 10pt; font-weight: normal; text-align: right" +
    "; ddo-char-set: 1";
            this.lblTotalG.Text = "9999.99";
            this.lblTotalG.Top = 0.4375F;
            this.lblTotalG.Width = 0.75F;
            // 
            // line6
            // 
            this.line6.Height = 0.0002499819F;
            this.line6.Left = 0.01000035F;
            this.line6.LineWeight = 1F;
            this.line6.Name = "line6";
            this.line6.Top = 1.6825F;
            this.line6.Width = 2.969F;
            this.line6.X1 = 2.979F;
            this.line6.X2 = 0.01000035F;
            this.line6.Y1 = 1.6825F;
            this.line6.Y2 = 1.68275F;
            // 
            // barcodeBottom
            // 
            this.barcodeBottom.CaptionPosition = GrapeCity.ActiveReports.SectionReportModel.BarCodeCaptionPosition.Below;
            this.barcodeBottom.CheckSumEnabled = false;
            this.barcodeBottom.DataField = "venta_documento";
            this.barcodeBottom.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.barcodeBottom.Height = 1.309722F;
            this.barcodeBottom.Left = 0.03100002F;
            this.barcodeBottom.Name = "barcodeBottom";
            this.barcodeBottom.QRCode.Encoding = ((System.Text.Encoding)(resources.GetObject("resource.Encoding")));
            this.barcodeBottom.QuietZoneBottom = 0F;
            this.barcodeBottom.QuietZoneLeft = 0F;
            this.barcodeBottom.QuietZoneRight = 0F;
            this.barcodeBottom.QuietZoneTop = 0F;
            this.barcodeBottom.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Pdf417;
            this.barcodeBottom.Top = 1.7535F;
            this.barcodeBottom.Width = 2.947917F;
            // 
            // label6
            // 
            this.label6.Height = 0.964F;
            this.label6.HyperLink = null;
            this.label6.Left = 0.01F;
            this.label6.Name = "label6";
            this.label6.Style = "font-family: Courier New; font-size: 8.25pt; text-align: center; ddo-char-set: 0";
            this.label6.Text = "Autorizado Mediante Resolucion\r\nNro. 0180050002841/SUNAT\r\nRepresentacion Impresa " +
    "del Documento\r\nde Venta Electronica\r\nEste documento puede ser valido en\r\nwww.chi" +
    "fahugos.com.pe\r\n";
            this.label6.Top = 3.063F;
            this.label6.Width = 2.938F;
            // 
            // ReporteBoleta
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 2.979F;
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
            ((System.ComponentModel.ISupportInitialize)(this.lblDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCompania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBoletaTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrdenTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFechaTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTipoTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAtendidoPorTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMesaTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidadTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProductoTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSubTotalTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBoleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAtendidoPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMensaje1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMensaje2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMensaje3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConsumoTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalGTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIGVTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
    #endregion

    private ReportHeader reportHeader1;
    private ReportFooter reportFooter1;
    private Label lblMensaje1;
    private Label lblMensaje2;
    private Label lblMensaje3;
    private Label lblDireccion;
    private Label lblDocumento;
    private Label lblTelefono;
    private Label lblCompania;
    private Label lblBoletaTitle;
    private Line line1;
    private Label lblOrdenTitle;
    private Label lblFechaTitle;
    private Label lblTipoTitle;
    private Label lblAtendidoPorTitle;
    private Label lblMesaTitle;
    private Line line2;
    private Line line3;
    private Label lblCantidadTitle;
    private Label lblProductoTitle;
    private Label lblSubTotalTitle;
    private Label lblBoleta;
    private Label lblOrden;
    private Label lblFecha;
    private Label lblTipo;
    private Label lblAtendidoPor;
    private Label lblMesa;
    private Label lblCantidad;
    private Label lblProducto;
    private Label lblSubTotal;
    private Line line5;
    private Line line4;
    private Label lblConsumoTitle;
    private Label lblIGV;
    private Label lblTotalGTitle;
    private Label lblLetras;
    private Label lblConsumo;
    private Label lblIGVTotal;
    private Label lblTotalG;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
        private Label label5;
        private Line line6;
        private Barcode barcodeBottom;
        private Label label6;
    }
}
