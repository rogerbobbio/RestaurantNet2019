using GrapeCity.ActiveReports.Document.Section;
using System;

namespace RestaurantNet.Reports
{
    /// <summary>
    /// Summary description for ReporteBar.
    /// </summary>
    public partial class ReporteBar : MainReport
    {
        protected override Margins PortraitDefaultMargins
        {
            get { return new Margins(0f, 0f, 0f, 0f); }
        }

        public ReporteBar()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void pageHeader_BeforePrint(object sender, EventArgs e)
        {
            lblDate.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));
            lblOrderNum.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));
            txtOrdenDia.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));
            lblPedidoNo.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));
            txtOrderID.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));
            lblOrderDate.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));
            txtOrderDate.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));


            lblAtentidoPor.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));
            txtEmployee.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));
            lblCantidad.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));
            lblProducto.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Bar));


            lblDate.Text = DataUtil.GetString(DateTime.Now);
            if (DataUtil.GetString(Fields["Mesa_id"].Value) != string.Empty)
            {
                string mesaId = DataUtil.GetString(Fields["Mesa_id"].Value);
                string sWhere = "mesa_id = " + mesaId + "";
                mesaId = DataUtil.FindSingleRow("mesa", "Mesa_descripcion", sWhere);
                txtTable.Text = mesaId;
            }
            else
            {
                lblMesa.Text = @"LLEVAR";
                txtTable.Text = string.Empty;
            }
        }
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            txtQty.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontDetail.Bar));
            txtDescription.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontDetail.Bar));
        }

        protected override void MainReport_ReportStart(object sender, EventArgs e)
        {
            base.MainReport_ReportStart(sender, e);
        }
    }
}
