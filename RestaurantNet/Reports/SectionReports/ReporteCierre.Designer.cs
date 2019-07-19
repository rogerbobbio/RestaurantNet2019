using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;

namespace RestaurantNet.Reports
{
  /// <summary>
  /// Summary description for CorteCajaDetallado.
  /// </summary>
  partial class ReporteCierre
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ReporteCierre));
      this.pageHeader = new PageHeader();
      this.label1 = new Label();
      this.label12 = new Label();
      this.line1 = new Line();
      this.detail = new Detail();
      this.lblProducto = new Label();
      this.lblSubTotal = new Label();
      this.pageFooter = new PageFooter();
      ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label12)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // pageHeader
      // 
      this.pageHeader.Controls.AddRange(new ARControl[] {
            this.label1,
            this.label12,
            this.line1});
      this.pageHeader.Height = 0.9375F;
      this.pageHeader.Name = "pageHeader";
      this.pageHeader.Format += new System.EventHandler(this.pageHeader_Format);
      // 
      // label1
      // 
      this.label1.Border.BottomColor = System.Drawing.Color.Black;
      this.label1.Border.BottomStyle = BorderLineStyle.None;
      this.label1.Border.LeftColor = System.Drawing.Color.Black;
      this.label1.Border.LeftStyle = BorderLineStyle.None;
      this.label1.Border.RightColor = System.Drawing.Color.Black;
      this.label1.Border.RightStyle = BorderLineStyle.None;
      this.label1.Border.TopColor = System.Drawing.Color.Black;
      this.label1.Border.TopStyle = BorderLineStyle.None;
      this.label1.Height = 0.3125F;
      this.label1.HyperLink = null;
      this.label1.Left = 0.125F;
      this.label1.Name = "label1";
      this.label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 15.75pt; ";
      this.label1.Text = "Cierre de Turno";
      this.label1.Top = 0.0625F;
      this.label1.Width = 6.875F;
      // 
      // label12
      // 
      this.label12.Border.BottomColor = System.Drawing.Color.Black;
      this.label12.Border.BottomStyle = BorderLineStyle.None;
      this.label12.Border.LeftColor = System.Drawing.Color.Black;
      this.label12.Border.LeftStyle = BorderLineStyle.None;
      this.label12.Border.RightColor = System.Drawing.Color.Black;
      this.label12.Border.RightStyle = BorderLineStyle.None;
      this.label12.Border.TopColor = System.Drawing.Color.Black;
      this.label12.Border.TopStyle = BorderLineStyle.None;
      this.label12.Height = 0.1875F;
      this.label12.HyperLink = null;
      this.label12.Left = 6.625F;
      this.label12.Name = "label12";
      this.label12.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
      this.label12.Text = "Total";
      this.label12.Top = 0.625F;
      this.label12.Width = 0.625F;
      // 
      // line1
      // 
      this.line1.Border.BottomColor = System.Drawing.Color.Black;
      this.line1.Border.BottomStyle = BorderLineStyle.None;
      this.line1.Border.LeftColor = System.Drawing.Color.Black;
      this.line1.Border.LeftStyle = BorderLineStyle.None;
      this.line1.Border.RightColor = System.Drawing.Color.Black;
      this.line1.Border.RightStyle = BorderLineStyle.None;
      this.line1.Border.TopColor = System.Drawing.Color.Black;
      this.line1.Border.TopStyle = BorderLineStyle.None;
      this.line1.Height = 0F;
      this.line1.Left = 0.0625F;
      this.line1.LineWeight = 1F;
      this.line1.Name = "line1";
      this.line1.Top = 0.875F;
      this.line1.Width = 9.8125F;
      this.line1.X1 = 0.0625F;
      this.line1.X2 = 9.875F;
      this.line1.Y1 = 0.875F;
      this.line1.Y2 = 0.875F;
      // 
      // detail
      // 
      this.detail.ColumnSpacing = 0F;
      this.detail.Controls.AddRange(new ARControl[] {
            this.lblProducto,
            this.lblSubTotal});
      this.detail.Height = 0.2083333F;
      this.detail.Name = "detail";
      // 
      // lblProducto
      // 
      this.lblProducto.Border.BottomColor = System.Drawing.Color.Black;
      this.lblProducto.Border.BottomStyle = BorderLineStyle.None;
      this.lblProducto.Border.LeftColor = System.Drawing.Color.Black;
      this.lblProducto.Border.LeftStyle = BorderLineStyle.None;
      this.lblProducto.Border.RightColor = System.Drawing.Color.Black;
      this.lblProducto.Border.RightStyle = BorderLineStyle.None;
      this.lblProducto.Border.TopColor = System.Drawing.Color.Black;
      this.lblProducto.Border.TopStyle = BorderLineStyle.None;
      this.lblProducto.DataField = "Descripcion";
      this.lblProducto.Height = 0.1875F;
      this.lblProducto.HyperLink = null;
      this.lblProducto.Left = 0.125F;
      this.lblProducto.Name = "lblProducto";
      this.lblProducto.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 9pt; font-fami" +
    "ly: Arial; ";
      this.lblProducto.Text = "lblProducto";
      this.lblProducto.Top = 0F;
      this.lblProducto.Width = 5.875F;
      // 
      // lblSubTotal
      // 
      this.lblSubTotal.Border.BottomColor = System.Drawing.Color.Black;
      this.lblSubTotal.Border.BottomStyle = BorderLineStyle.None;
      this.lblSubTotal.Border.LeftColor = System.Drawing.Color.Black;
      this.lblSubTotal.Border.LeftStyle = BorderLineStyle.None;
      this.lblSubTotal.Border.RightColor = System.Drawing.Color.Black;
      this.lblSubTotal.Border.RightStyle = BorderLineStyle.None;
      this.lblSubTotal.Border.TopColor = System.Drawing.Color.Black;
      this.lblSubTotal.Border.TopStyle = BorderLineStyle.None;
      this.lblSubTotal.DataField = "Valor";
      this.lblSubTotal.Height = 0.1875F;
      this.lblSubTotal.HyperLink = null;
      this.lblSubTotal.Left = 6.625F;
      this.lblSubTotal.Name = "lblSubTotal";
      this.lblSubTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 9pt; font-fam" +
    "ily: Arial; ";
      this.lblSubTotal.Text = "999";
      this.lblSubTotal.Top = 0F;
      this.lblSubTotal.Width = 0.5625F;
      // 
      // pageFooter
      // 
      this.pageFooter.Height = 0.25F;
      this.pageFooter.Name = "pageFooter";
      // 
      // ReporteCierre
      // 
      this.MasterReport = false;
      this.PageSettings.PaperHeight = 11F;
      this.PageSettings.PaperWidth = 8.5F;
      this.PrintWidth = 9.947917F;
      this.Sections.Add(this.pageHeader);
      this.Sections.Add(this.detail);
      this.Sections.Add(this.pageFooter);
      this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black; ", "Normal"));
      this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
      this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic; ", "Heading2", "Normal"));
      this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
      ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.label12)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
    #endregion

    private Label label1;
    private Label label12;
    private Line line1;
    private Label lblProducto;
    private Label lblSubTotal;
  }
}
