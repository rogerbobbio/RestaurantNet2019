using GrapeCity.ActiveReports;
using System;

namespace RestaurantNet.Reports
{
    /// <summary>
    /// Summary description for ReporteVentas.
    /// </summary>
    public partial class ReporteVentas : SectionReport
    {

        public ReporteVentas()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
            label1.Text = @"Reporte de Ventas - " + AppConstant.GeneralInfo.Compania;
            label4.Text = AppConstant.ReporteVentas.FechaInicio;
            label5.Text = AppConstant.ReporteVentas.FechaFin;
        }
    }
}
