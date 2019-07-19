using GrapeCity.ActiveReports;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RestaurantNet.Reports
{
    public partial class ReportViewer : frmMain
    {
        public DataSet dsReport = new DataSet();
        public string tableNameReport = string.Empty;
        public string reporteName = string.Empty;
        public string printerName = string.Empty;
        public int paperWidth = 0;
        public int paperHeight = 0;
        private SectionReport report = null;

        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            if (paperWidth > 0)
                CustomPrint();
            else
                NormalPrint();
        }

        private void CustomPrint()
        {
            report = new ReporteBar();
            var preview = AppConstant.GeneralInfo.Preview.Bar;

            report.DataSource = dsReport;
            report.DataMember = tableNameReport;            
            report.Document.Printer.PrinterName = printerName;
            var pSize = new PaperSize("CUSTOM", paperWidth, paperHeight);
            report.Document.Printer.PaperKind = PaperKind.Custom;
            report.Document.Printer.PaperSize = pSize;
            viewer1.Document = report.Document;
            report.Run();
            report.Document.Print(false, false, false);
            Close();
        }

        private void NormalPrint()
        {
            var preview = false;
            try
            {
                switch (reporteName)
                {
                    case AppConstant.Reportes.Cocina:
                        report = new ReporteCocina();
                        preview = AppConstant.GeneralInfo.Preview.Cocina;
                        break;
                    case AppConstant.Reportes.Bar:
                        report = new ReporteBar();
                        preview = AppConstant.GeneralInfo.Preview.Bar;
                        break;
                    case AppConstant.Reportes.Cuenta:
                        report = new ReporteRecibos();
                        preview = AppConstant.GeneralInfo.Preview.Recibos;
                        break;
                    case AppConstant.Reportes.Boleta:
                        report = new ReporteBoleta();
                        preview = AppConstant.GeneralInfo.Preview.Boleta;
                        break;
                    case AppConstant.Reportes.Recibos:
                        report = new ReporteRecibos();
                        preview = AppConstant.GeneralInfo.Preview.Recibos;
                        break;
                    case AppConstant.Reportes.Turno:
                        report = new ReporteTurno();
                        preview = AppConstant.GeneralInfo.Preview.Reportes;
                        break;
                    case AppConstant.Reportes.ReporteVentas:
                        report = new ReporteVentas();
                        preview = AppConstant.GeneralInfo.Preview.Reportes;
                        break;
                    case AppConstant.Reportes.ReporteCierre:
                        report = new ReporteCierre();
                        preview = AppConstant.GeneralInfo.Preview.Reportes;
                        break;
                }
                report.DataSource = dsReport;
                report.DataMember = tableNameReport;
                if (report.Document.Printer.PrinterName == "EPSON TM-T88III Receipt")
                {
                    report.Document.Printer.PrinterName = string.Empty;
                    var pSize = new PaperSize("EPSON", 80, 297);
                    report.Document.Printer.PaperKind = PaperKind.Custom;
                    report.Document.Printer.PaperSize = pSize;
                }
                else if (report.Document.Printer.PrinterName == "CITIZEN CT-S310" || printerName == "CITIZEN CT-S310")
                {
                    report.Document.Printer.PrinterName = "CITIZEN CT-S310";
                    //var pSize = new PaperSize("CITIZEN", 80, 297);
                    //rpt.Document.Printer.PaperKind = PaperKind.A4;
                    //rpt.Document.Printer.PaperSize = pSize;
                }
                else
                {
                    if (PrinterValid(printerName))
                        report.Document.Printer.PrinterName = printerName;
                    else
                        report.Document.Printer.PrinterName = string.Empty;
                }
                viewer1.Document = report.Document;
                report.Run();
                if (report.Document.Printer.PrinterName != string.Empty)
                    report.Document.Print(false, false, false);
                if (preview == false)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error en reporte : " + ex.Message);
            }
        }

        internal bool PrinterValid(string printer)
        {
            try
            {
                try
                {
                    var pd = new PrintDocument();
                    pd.PrinterSettings.PrinterName = printer;
                    if (pd.PrinterSettings.IsValid)
                        return true;
                    else
                    {
                        MessageBox.Show(@"La impresora no esta configurada o no existe.");
                        return false;
                    }
                }
                finally
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
