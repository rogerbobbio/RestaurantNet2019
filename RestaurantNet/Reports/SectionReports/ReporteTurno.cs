using GrapeCity.ActiveReports.Document.Section;
using System;

namespace RestaurantNet.Reports
{
    public partial class ReporteTurno : MainReport
    {
        public ReporteTurno()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }
        protected override Margins PortraitDefaultMargins
        {
            get { return new Margins(0f, 0f, 0f, 0f); }
        }

        private void pageHeader_BeforePrint(object sender, EventArgs e)
        {
            if (DataUtil.GetString(Fields["Turno_id"].Value) != string.Empty)
            {
                string turnoID = DataUtil.GetString(Fields["Turno_id"].Value);
                string sWhere = "turno_id = " + turnoID + "";
                txtTurno.Text = turnoID;
                txtFechaApertura.Text = DataUtil.FindSingleRow("turno", "Fecha_apertura", sWhere);
                txtFechaCierre.Text = DataUtil.FindSingleRow("turno", "Fecha_cierre", sWhere);
            }
        }

        protected override void MainReport_ReportStart(object sender, EventArgs e)
        {
            base.MainReport_ReportStart(sender, e);
        }
    }
}
