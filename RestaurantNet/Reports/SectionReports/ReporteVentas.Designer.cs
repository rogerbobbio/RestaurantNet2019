using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;

namespace RestaurantNet.Reports
{
    /// <summary>
    /// Summary description for ReporteVentas.
    /// </summary>
    partial class ReporteVentas
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ReporteVentas));
      this.pageHeader = new PageHeader();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label8 = new Label();
      this.label10 = new Label();
      this.label11 = new Label();
      this.label12 = new Label();
      this.lblBoleta = new Label();
      this.label7 = new Label();
      this.line1 = new Line();
      this.detail = new Detail();
      this.lblProducto = new Label();
      this.lblCantidad = new Label();
      this.lblSubTotal = new Label();
      this.pageFooter = new PageFooter();
      ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label11)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label12)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblBoleta)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // pageHeader
      // 
      this.pageHeader.Controls.AddRange(new ARControl[] {
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.label6,
            this.label8,
            this.label10,
            this.label11,
            this.label12,
            this.lblBoleta,
            this.label7,
            this.line1});
      this.pageHeader.Height = 1.78125F;
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
      this.label1.Text = "Reporte de Ventas";
      this.label1.Top = 0.0625F;
      this.label1.Width = 6.875F;
      // 
      // label2
      // 
      this.label2.Border.BottomColor = System.Drawing.Color.Black;
      this.label2.Border.BottomStyle = BorderLineStyle.None;
      this.label2.Border.LeftColor = System.Drawing.Color.Black;
      this.label2.Border.LeftStyle = BorderLineStyle.None;
      this.label2.Border.RightColor = System.Drawing.Color.Black;
      this.label2.Border.RightStyle = BorderLineStyle.None;
      this.label2.Border.TopColor = System.Drawing.Color.Black;
      this.label2.Border.TopStyle = BorderLineStyle.None;
      this.label2.Height = 0.1875F;
      this.label2.HyperLink = null;
      this.label2.Left = 0.125F;
      this.label2.Name = "label2";
      this.label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
      this.label2.Text = "Desde:";
      this.label2.Top = 0.4375F;
      this.label2.Width = 0.5F;
      // 
      // label3
      // 
      this.label3.Border.BottomColor = System.Drawing.Color.Black;
      this.label3.Border.BottomStyle = BorderLineStyle.None;
      this.label3.Border.LeftColor = System.Drawing.Color.Black;
      this.label3.Border.LeftStyle = BorderLineStyle.None;
      this.label3.Border.RightColor = System.Drawing.Color.Black;
      this.label3.Border.RightStyle = BorderLineStyle.None;
      this.label3.Border.TopColor = System.Drawing.Color.Black;
      this.label3.Border.TopStyle = BorderLineStyle.None;
      this.label3.Height = 0.1875F;
      this.label3.HyperLink = null;
      this.label3.Left = 1.625F;
      this.label3.Name = "label3";
      this.label3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
      this.label3.Text = "Hasta:";
      this.label3.Top = 0.4375F;
      this.label3.Width = 0.5F;
      // 
      // label4
      // 
      this.label4.Border.BottomColor = System.Drawing.Color.Black;
      this.label4.Border.BottomStyle = BorderLineStyle.None;
      this.label4.Border.LeftColor = System.Drawing.Color.Black;
      this.label4.Border.LeftStyle = BorderLineStyle.None;
      this.label4.Border.RightColor = System.Drawing.Color.Black;
      this.label4.Border.RightStyle = BorderLineStyle.None;
      this.label4.Border.TopColor = System.Drawing.Color.Black;
      this.label4.Border.TopStyle = BorderLineStyle.None;
      this.label4.Height = 0.1979167F;
      this.label4.HyperLink = null;
      this.label4.Left = 0.625F;
      this.label4.Name = "label4";
      this.label4.Style = "";
      this.label4.Text = "00/00/0000";
      this.label4.Top = 0.4375F;
      this.label4.Width = 1F;
      // 
      // label5
      // 
      this.label5.Border.BottomColor = System.Drawing.Color.Black;
      this.label5.Border.BottomStyle = BorderLineStyle.None;
      this.label5.Border.LeftColor = System.Drawing.Color.Black;
      this.label5.Border.LeftStyle = BorderLineStyle.None;
      this.label5.Border.RightColor = System.Drawing.Color.Black;
      this.label5.Border.RightStyle = BorderLineStyle.None;
      this.label5.Border.TopColor = System.Drawing.Color.Black;
      this.label5.Border.TopStyle = BorderLineStyle.None;
      this.label5.Height = 0.1979167F;
      this.label5.HyperLink = null;
      this.label5.Left = 2.125F;
      this.label5.Name = "label5";
      this.label5.Style = "";
      this.label5.Text = "00/00/0000";
      this.label5.Top = 0.4375F;
      this.label5.Width = 1F;
      // 
      // label6
      // 
      this.label6.Border.BottomColor = System.Drawing.Color.Black;
      this.label6.Border.BottomStyle = BorderLineStyle.None;
      this.label6.Border.LeftColor = System.Drawing.Color.Black;
      this.label6.Border.LeftStyle = BorderLineStyle.None;
      this.label6.Border.RightColor = System.Drawing.Color.Black;
      this.label6.Border.RightStyle = BorderLineStyle.None;
      this.label6.Border.TopColor = System.Drawing.Color.Black;
      this.label6.Border.TopStyle = BorderLineStyle.None;
      this.label6.Height = 0.1875F;
      this.label6.HyperLink = null;
      this.label6.Left = 0.125F;
      this.label6.Name = "label6";
      this.label6.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
      this.label6.Text = "Total de Ordenes:";
      this.label6.Top = 0.8125F;
      this.label6.Width = 1.5F;
      // 
      // label8
      // 
      this.label8.Border.BottomColor = System.Drawing.Color.Black;
      this.label8.Border.BottomStyle = BorderLineStyle.None;
      this.label8.Border.LeftColor = System.Drawing.Color.Black;
      this.label8.Border.LeftStyle = BorderLineStyle.None;
      this.label8.Border.RightColor = System.Drawing.Color.Black;
      this.label8.Border.RightStyle = BorderLineStyle.None;
      this.label8.Border.TopColor = System.Drawing.Color.Black;
      this.label8.Border.TopStyle = BorderLineStyle.None;
      this.label8.Height = 0.1875F;
      this.label8.HyperLink = null;
      this.label8.Left = 0.125F;
      this.label8.Name = "label8";
      this.label8.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
      this.label8.Text = "Monto Total S/.:";
      this.label8.Top = 1.0625F;
      this.label8.Width = 1.5F;
      // 
      // label10
      // 
      this.label10.Border.BottomColor = System.Drawing.Color.Black;
      this.label10.Border.BottomStyle = BorderLineStyle.None;
      this.label10.Border.LeftColor = System.Drawing.Color.Black;
      this.label10.Border.LeftStyle = BorderLineStyle.None;
      this.label10.Border.RightColor = System.Drawing.Color.Black;
      this.label10.Border.RightStyle = BorderLineStyle.None;
      this.label10.Border.TopColor = System.Drawing.Color.Black;
      this.label10.Border.TopStyle = BorderLineStyle.None;
      this.label10.Height = 0.1875F;
      this.label10.HyperLink = null;
      this.label10.Left = 0.125F;
      this.label10.Name = "label10";
      this.label10.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
      this.label10.Text = "Producto";
      this.label10.Top = 1.5F;
      this.label10.Width = 0.875F;
      // 
      // label11
      // 
      this.label11.Border.BottomColor = System.Drawing.Color.Black;
      this.label11.Border.BottomStyle = BorderLineStyle.None;
      this.label11.Border.LeftColor = System.Drawing.Color.Black;
      this.label11.Border.LeftStyle = BorderLineStyle.None;
      this.label11.Border.RightColor = System.Drawing.Color.Black;
      this.label11.Border.RightStyle = BorderLineStyle.None;
      this.label11.Border.TopColor = System.Drawing.Color.Black;
      this.label11.Border.TopStyle = BorderLineStyle.None;
      this.label11.Height = 0.1875F;
      this.label11.HyperLink = null;
      this.label11.Left = 6F;
      this.label11.Name = "label11";
      this.label11.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9pt; ";
      this.label11.Text = "Cantidad";
      this.label11.Top = 1.5F;
      this.label11.Width = 0.625F;
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
      this.label12.Top = 1.5F;
      this.label12.Width = 0.625F;
      // 
      // lblBoleta
      // 
      this.lblBoleta.Border.BottomColor = System.Drawing.Color.Black;
      this.lblBoleta.Border.BottomStyle = BorderLineStyle.None;
      this.lblBoleta.Border.LeftColor = System.Drawing.Color.Black;
      this.lblBoleta.Border.LeftStyle = BorderLineStyle.None;
      this.lblBoleta.Border.RightColor = System.Drawing.Color.Black;
      this.lblBoleta.Border.RightStyle = BorderLineStyle.None;
      this.lblBoleta.Border.TopColor = System.Drawing.Color.Black;
      this.lblBoleta.Border.TopStyle = BorderLineStyle.None;
      this.lblBoleta.DataField = "total_ordenes";
      this.lblBoleta.Height = 0.1875F;
      this.lblBoleta.HyperLink = null;
      this.lblBoleta.Left = 1.625F;
      this.lblBoleta.Name = "lblBoleta";
      this.lblBoleta.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Arial; ";
      this.lblBoleta.Text = "lblTotalOrdenes";
      this.lblBoleta.Top = 0.8125F;
      this.lblBoleta.Width = 0.5F;
      // 
      // label7
      // 
      this.label7.Border.BottomColor = System.Drawing.Color.Black;
      this.label7.Border.BottomStyle = BorderLineStyle.None;
      this.label7.Border.LeftColor = System.Drawing.Color.Black;
      this.label7.Border.LeftStyle = BorderLineStyle.None;
      this.label7.Border.RightColor = System.Drawing.Color.Black;
      this.label7.Border.RightStyle = BorderLineStyle.None;
      this.label7.Border.TopColor = System.Drawing.Color.Black;
      this.label7.Border.TopStyle = BorderLineStyle.None;
      this.label7.DataField = "monto_total";
      this.label7.Height = 0.1875F;
      this.label7.HyperLink = null;
      this.label7.Left = 1.625F;
      this.label7.Name = "label7";
      this.label7.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Arial; ";
      this.label7.Text = "lblMontoTotal";
      this.label7.Top = 1.0625F;
      this.label7.Width = 1.5F;
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
      this.line1.Top = 1.75F;
      this.line1.Width = 9.8125F;
      this.line1.X1 = 0.0625F;
      this.line1.X2 = 9.875F;
      this.line1.Y1 = 1.75F;
      this.line1.Y2 = 1.75F;
      // 
      // detail
      // 
      this.detail.ColumnSpacing = 0F;
      this.detail.Controls.AddRange(new ARControl[] {
            this.lblProducto,
            this.lblCantidad,
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
      this.lblProducto.DataField = "Descripcion_Producto";
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
      // lblCantidad
      // 
      this.lblCantidad.Border.BottomColor = System.Drawing.Color.Black;
      this.lblCantidad.Border.BottomStyle = BorderLineStyle.None;
      this.lblCantidad.Border.LeftColor = System.Drawing.Color.Black;
      this.lblCantidad.Border.LeftStyle = BorderLineStyle.None;
      this.lblCantidad.Border.RightColor = System.Drawing.Color.Black;
      this.lblCantidad.Border.RightStyle = BorderLineStyle.None;
      this.lblCantidad.Border.TopColor = System.Drawing.Color.Black;
      this.lblCantidad.Border.TopStyle = BorderLineStyle.None;
      this.lblCantidad.DataField = "Venta_cantidad";
      this.lblCantidad.Height = 0.1875F;
      this.lblCantidad.HyperLink = null;
      this.lblCantidad.Left = 6F;
      this.lblCantidad.Name = "lblCantidad";
      this.lblCantidad.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 9pt; font-fa" +
    "mily: Arial; ";
      this.lblCantidad.Text = "999";
      this.lblCantidad.Top = 0F;
      this.lblCantidad.Width = 0.5F;
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
      this.lblSubTotal.DataField = "Producto_precio";
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
      // ReporteVentas
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
      ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.label11)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.label12)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblBoleta)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblProducto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblCantidad)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label8;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label lblBoleta;
    private Label label7;
    private Line line1;
    private Label lblProducto;
    private Label lblCantidad;
    private Label lblSubTotal;
  }
}
