using GrapeCity.ActiveReports;
using System;

namespace RestaurantNet.Reports
{
    /// <summary>
    /// Summary description for CorteCajaDetallado.
    /// </summary>
    public partial class ReporteCierre : SectionReport
    {

        public ReporteCierre()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
            label1.Text = @"Reporte de Ventas - " + AppConstant.GeneralInfo.Compania;
        }
    }
}
