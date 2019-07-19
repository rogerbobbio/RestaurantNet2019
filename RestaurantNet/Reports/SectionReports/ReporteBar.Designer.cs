using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;

namespace RestaurantNet.Reports
{
    /// <summary>
    /// Summary description for ReporteBar.
    /// </summary>
    partial class ReporteBar
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ReporteBar));
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.lblProducto = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblOrderNum = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblOrderDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblAtentidoPor = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtEmployee = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblMesa = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtTable = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblCantidad = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Line = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.lblPedidoNo = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtOrdenDia = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.txtQty = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtDescription = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAtentidoPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPedidoNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.lblProducto,
            this.lblDate,
            this.lblTitle,
            this.lblOrderNum,
            this.txtOrderID,
            this.lblOrderDate,
            this.txtOrderDate,
            this.lblAtentidoPor,
            this.txtEmployee,
            this.lblMesa,
            this.txtTable,
            this.lblCantidad,
            this.Line,
            this.lblPedidoNo,
            this.txtOrdenDia});
            this.pageHeader.Height = 1.208334F;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.BeforePrint += new System.EventHandler(this.pageHeader_BeforePrint);
            // 
            // lblProducto
            // 
            this.lblProducto.Height = 0.1876251F;
            this.lblProducto.HyperLink = "";
            this.lblProducto.Left = 0.3125F;
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: bold; text-align: left;" +
    " vertical-align: bottom; ddo-char-set: 0";
            this.lblProducto.Text = "Producto";
            this.lblProducto.Top = 1F;
            this.lblProducto.Width = 0.671875F;
            // 
            // lblDate
            // 
            this.lblDate.Height = 0.1875F;
            this.lblDate.HyperLink = null;
            this.lblDate.Left = 1.0625F;
            this.lblDate.Name = "lblDate";
            this.lblDate.Style = "font-family: Courier New; font-size: 6.75pt; text-align: right; ddo-char-set: 0";
            this.lblDate.Text = "06/12/2010 12:59:59 AM";
            this.lblDate.Top = 0F;
            this.lblDate.Width = 1.4375F;
            // 
            // lblTitle
            // 
            this.lblTitle.Height = 0.25F;
            this.lblTitle.HyperLink = "";
            this.lblTitle.Left = 0F;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Style = "font-family: Courier New; font-size: 9pt; font-weight: normal; text-align: left; " +
    "ddo-char-set: 0";
            this.lblTitle.Text = "Bar";
            this.lblTitle.Top = 0F;
            this.lblTitle.Width = 1F;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.Height = 0.1875F;
            this.lblOrderNum.HyperLink = null;
            this.lblOrderNum.Left = 0.0625F;
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblOrderNum.Text = "Orden #:";
            this.lblOrderNum.Top = 0.375F;
            this.lblOrderNum.Width = 0.9375F;
            // 
            // txtOrderID
            // 
            this.txtOrderID.CanGrow = false;
            this.txtOrderID.DataField = "Pedido_id";
            this.txtOrderID.Height = 0.1875F;
            this.txtOrderID.Left = 2.5F;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Style = "background-color: Transparent; font-family: Courier New; font-size: 6.75pt; text-" +
    "align: left; vertical-align: middle; ddo-char-set: 0";
            this.txtOrderID.Text = "99999";
            this.txtOrderID.Top = 0.375F;
            this.txtOrderID.Width = 0.5000002F;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Height = 0.1875F;
            this.lblOrderDate.HyperLink = null;
            this.lblOrderDate.Left = 0.0625F;
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblOrderDate.Text = "Fecha Orden:";
            this.lblOrderDate.Top = 0.5F;
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
    "align: left; vertical-align: middle; ddo-char-set: 0";
            this.txtOrderDate.Text = "99/99/9999";
            this.txtOrderDate.Top = 0.5F;
            this.txtOrderDate.Width = 1.9375F;
            // 
            // lblAtentidoPor
            // 
            this.lblAtentidoPor.Height = 0.1875F;
            this.lblAtentidoPor.HyperLink = null;
            this.lblAtentidoPor.Left = 0F;
            this.lblAtentidoPor.Name = "lblAtentidoPor";
            this.lblAtentidoPor.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblAtentidoPor.Text = "Mozo :";
            this.lblAtentidoPor.Top = 0.625F;
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
            this.txtEmployee.Top = 0.625F;
            this.txtEmployee.Width = 1.5625F;
            // 
            // lblMesa
            // 
            this.lblMesa.Height = 0.1875F;
            this.lblMesa.HyperLink = null;
            this.lblMesa.Left = 0.875F;
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Style = "font-family: Courier New; font-size: 13pt; font-weight: normal; text-align: right" +
    "; vertical-align: middle; ddo-char-set: 1";
            this.lblMesa.Text = "Mesa:";
            this.lblMesa.Top = 0.1875F;
            this.lblMesa.Width = 0.9375F;
            // 
            // txtTable
            // 
            this.txtTable.CanGrow = false;
            this.txtTable.Height = 0.1875F;
            this.txtTable.Left = 1.812F;
            this.txtTable.Name = "txtTable";
            this.txtTable.Style = "background-color: Transparent; font-family: Courier New; font-size: 13pt; text-al" +
    "ign: left; vertical-align: middle; ddo-char-set: 1";
            this.txtTable.Text = "999";
            this.txtTable.Top = 0.187F;
            this.txtTable.Width = 0.625F;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Height = 0.1875F;
            this.lblCantidad.HyperLink = "";
            this.lblCantidad.Left = 0.125F;
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: bold; text-align: left;" +
    " vertical-align: bottom; ddo-char-set: 0";
            this.lblCantidad.Text = "Cant.";
            this.lblCantidad.Top = 1F;
            this.lblCantidad.Width = 0.3125F;
            // 
            // Line
            // 
            this.Line.Height = 0F;
            this.Line.Left = 0F;
            this.Line.LineWeight = 1F;
            this.Line.Name = "Line";
            this.Line.Top = 1.187F;
            this.Line.Width = 3F;
            this.Line.X1 = 0F;
            this.Line.X2 = 3F;
            this.Line.Y1 = 1.187F;
            this.Line.Y2 = 1.187F;
            // 
            // lblPedidoNo
            // 
            this.lblPedidoNo.Height = 0.1875F;
            this.lblPedidoNo.HyperLink = null;
            this.lblPedidoNo.Left = 1.75F;
            this.lblPedidoNo.Name = "lblPedidoNo";
            this.lblPedidoNo.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblPedidoNo.Text = "Pedido #:";
            this.lblPedidoNo.Top = 0.375F;
            this.lblPedidoNo.Width = 0.75F;
            // 
            // txtOrdenDia
            // 
            this.txtOrdenDia.CanGrow = false;
            this.txtOrdenDia.DataField = "Orden_turno";
            this.txtOrdenDia.Height = 0.1875F;
            this.txtOrdenDia.Left = 1.0625F;
            this.txtOrdenDia.Name = "txtOrdenDia";
            this.txtOrdenDia.Style = "background-color: Transparent; font-family: Courier New; font-size: 6.75pt; text-" +
    "align: left; vertical-align: middle; ddo-char-set: 0";
            this.txtOrdenDia.Text = "99999";
            this.txtOrdenDia.Top = 0.375F;
            this.txtOrdenDia.Width = 0.625F;
            // 
            // detail
            // 
            this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.txtQty,
            this.txtDescription});
            this.detail.Height = 0.1875F;
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
            this.txtQty.Width = 0.3125F;
            // 
            // txtDescription
            // 
            this.txtDescription.CanGrow = false;
            this.txtDescription.DataField = "Descripcion_Producto";
            this.txtDescription.Height = 0.1875F;
            this.txtDescription.Left = 0.3125F;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Style = "font-family: Courier New; font-size: 6.75pt; text-align: left; white-space: nowra" +
    "p; ddo-char-set: 0";
            this.txtDescription.Text = "txtDescription";
            this.txtDescription.Top = 0F;
            this.txtDescription.Width = 2.6875F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // ReporteBar
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 2.9795F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            this.ReportStart += new System.EventHandler(this.MainReport_ReportStart);
            ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAtentidoPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPedidoNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
    #endregion

    private Label lblDate;
    private Label lblTitle;
    private Label lblOrderNum;
    private TextBox txtOrderID;
    private Label lblOrderDate;
    private TextBox txtOrderDate;
    private Label lblAtentidoPor;
    private TextBox txtEmployee;
    private Label lblMesa;
    private TextBox txtTable;
    private Label lblCantidad;
    private Line Line;
    private Label lblProducto;
    private TextBox txtQty;
    private TextBox txtDescription;
    private Label lblPedidoNo;
    private TextBox txtOrdenDia;
  }
}
