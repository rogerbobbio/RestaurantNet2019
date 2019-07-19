using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;

namespace RestaurantNet.Reports
{
    partial class ReporteTurno
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ReporteTurno));
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.lblSubTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblProducto = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Line = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.lblOrderDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtFechaApertura = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblAtentidoPor = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblMesa = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtTurno = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblReportTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtFechaCierre = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.txtDescription = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtMonto = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            this.reportHeader = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
            this.reportFooter = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
            ((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaApertura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAtentidoPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblReportTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.lblSubTotal,
            this.lblProducto,
            this.Line,
            this.lblOrderDate,
            this.txtFechaApertura,
            this.lblAtentidoPor,
            this.lblMesa,
            this.txtTurno,
            this.lblReportTitle,
            this.txtFechaCierre,
            this.line3});
            this.pageHeader.Height = 0.9791667F;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.BeforePrint += new System.EventHandler(this.pageHeader_BeforePrint);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Height = 0.1875F;
            this.lblSubTotal.HyperLink = "";
            this.lblSubTotal.Left = 1.875F;
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Style = "font-family: Courier New; font-size: 8.5pt; font-weight: normal; text-align: righ" +
    "t; vertical-align: bottom; ddo-char-set: 1";
            this.lblSubTotal.Text = "Valor";
            this.lblSubTotal.Top = 0.75F;
            this.lblSubTotal.Width = 0.5625F;
            // 
            // lblProducto
            // 
            this.lblProducto.Height = 0.1875F;
            this.lblProducto.HyperLink = "";
            this.lblProducto.Left = 0.1875F;
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Style = "font-family: Courier New; font-size: 8.5pt; font-weight: normal; text-align: left" +
    "; vertical-align: bottom; ddo-char-set: 1";
            this.lblProducto.Text = "Descripcion";
            this.lblProducto.Top = 0.75F;
            this.lblProducto.Width = 1.125F;
            // 
            // Line
            // 
            this.Line.Height = 0F;
            this.Line.Left = 0F;
            this.Line.LineWeight = 1F;
            this.Line.Name = "Line";
            this.Line.Top = 0.937F;
            this.Line.Width = 2.99F;
            this.Line.X1 = 0F;
            this.Line.X2 = 2.99F;
            this.Line.Y1 = 0.937F;
            this.Line.Y2 = 0.937F;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Height = 0.1875F;
            this.lblOrderDate.HyperLink = null;
            this.lblOrderDate.Left = 0F;
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblOrderDate.Text = "Turno Actual:";
            this.lblOrderDate.Top = 0.1875F;
            this.lblOrderDate.Width = 0.9375F;
            // 
            // txtFechaApertura
            // 
            this.txtFechaApertura.DataField = "Fecha_Pedido";
            this.txtFechaApertura.Height = 0.1875F;
            this.txtFechaApertura.Left = 1F;
            this.txtFechaApertura.Name = "txtFechaApertura";
            this.txtFechaApertura.Style = "background-color: Transparent; font-family: Courier New; font-size: 6.75pt; text-" +
    "align: left; vertical-align: middle; white-space: nowrap; ddo-char-set: 0";
            this.txtFechaApertura.Text = "99/99/9999";
            this.txtFechaApertura.Top = 0.375F;
            this.txtFechaApertura.Width = 1.5F;
            // 
            // lblAtentidoPor
            // 
            this.lblAtentidoPor.Height = 0.1875F;
            this.lblAtentidoPor.HyperLink = null;
            this.lblAtentidoPor.Left = 0F;
            this.lblAtentidoPor.Name = "lblAtentidoPor";
            this.lblAtentidoPor.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblAtentidoPor.Text = "Apertura:";
            this.lblAtentidoPor.Top = 0.375F;
            this.lblAtentidoPor.Width = 0.9375F;
            // 
            // lblMesa
            // 
            this.lblMesa.Height = 0.1875F;
            this.lblMesa.HyperLink = null;
            this.lblMesa.Left = 0F;
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Style = "font-family: Courier New; font-size: 6.75pt; font-weight: normal; text-align: rig" +
    "ht; vertical-align: middle; ddo-char-set: 0";
            this.lblMesa.Text = "Cierre:";
            this.lblMesa.Top = 0.5625F;
            this.lblMesa.Width = 0.9375F;
            // 
            // txtTurno
            // 
            this.txtTurno.CanGrow = false;
            this.txtTurno.Height = 0.1875F;
            this.txtTurno.Left = 1F;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Style = "background-color: Transparent; font-family: Courier New; font-size: 6.75pt; text-" +
    "align: left; vertical-align: middle; ddo-char-set: 0";
            this.txtTurno.Text = "9999";
            this.txtTurno.Top = 0.1875F;
            this.txtTurno.Width = 0.6875F;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Height = 0.1875F;
            this.lblReportTitle.HyperLink = null;
            this.lblReportTitle.Left = 0F;
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Style = "font-family: Courier New; font-size: 8.25pt; text-align: center; ddo-char-set: 0";
            this.lblReportTitle.Text = "Reporte de Turno";
            this.lblReportTitle.Top = 0F;
            this.lblReportTitle.Width = 2.99F;
            // 
            // txtFechaCierre
            // 
            this.txtFechaCierre.DataField = "Fecha_Pedido";
            this.txtFechaCierre.Height = 0.1875F;
            this.txtFechaCierre.Left = 1F;
            this.txtFechaCierre.Name = "txtFechaCierre";
            this.txtFechaCierre.Style = "background-color: Transparent; font-family: Courier New; font-size: 6.75pt; text-" +
    "align: left; vertical-align: middle; white-space: nowrap; ddo-char-set: 0";
            this.txtFechaCierre.Text = "99/99/9999";
            this.txtFechaCierre.Top = 0.5625F;
            this.txtFechaCierre.Width = 1.5F;
            // 
            // line3
            // 
            this.line3.Height = 5.960464E-08F;
            this.line3.Left = 0F;
            this.line3.LineWeight = 1F;
            this.line3.Name = "line3";
            this.line3.Top = 0.75F;
            this.line3.Width = 2.99F;
            this.line3.X1 = 2.99F;
            this.line3.X2 = 0F;
            this.line3.Y1 = 0.7500001F;
            this.line3.Y2 = 0.75F;
            // 
            // detail
            // 
            this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.txtDescription,
            this.txtMonto});
            this.detail.Height = 0.1979167F;
            this.detail.Name = "detail";
            // 
            // txtDescription
            // 
            this.txtDescription.CanGrow = false;
            this.txtDescription.DataField = "Descripcion";
            this.txtDescription.Height = 0.1875F;
            this.txtDescription.Left = 0.1875F;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Style = "font-family: Courier New; font-size: 6.75pt; text-align: left; white-space: nowra" +
    "p; ddo-char-set: 0";
            this.txtDescription.Text = "txtDescription";
            this.txtDescription.Top = 0F;
            this.txtDescription.Width = 1.6875F;
            // 
            // txtMonto
            // 
            this.txtMonto.DataField = "Valor";
            this.txtMonto.Height = 0.1875F;
            this.txtMonto.Left = 1.875F;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Style = "font-family: Courier New; font-size: 6.75pt; text-align: right; white-space: nowr" +
    "ap; ddo-char-set: 0";
            this.txtMonto.Text = "txtMonto";
            this.txtMonto.Top = 0F;
            this.txtMonto.Width = 0.5625F;
            // 
            // pageFooter
            // 
            this.pageFooter.CanShrink = true;
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = 0F;
            this.reportHeader.Name = "reportHeader";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = 0F;
            this.reportFooter.Name = "reportFooter";
            // 
            // ReporteTurno
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 2.96875F;
            this.Sections.Add(this.reportHeader);
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.Sections.Add(this.reportFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            this.ReportStart += new System.EventHandler(this.MainReport_ReportStart);
            ((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaApertura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAtentidoPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblReportTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Label lblProducto;
        private Line Line;
        private Label lblSubTotal;
        private TextBox txtDescription;
        private TextBox txtMonto;
        private ReportHeader reportHeader;
        private ReportFooter reportFooter;
        private Label lblOrderDate;
        private TextBox txtFechaApertura;
        private Label lblAtentidoPor;
        private Label lblMesa;
        private TextBox txtTurno;
        private Label lblReportTitle;
        private Line line3;
        private TextBox txtFechaCierre;
    }
}
