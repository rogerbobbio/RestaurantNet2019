using GrapeCity.ActiveReports.Document.Section;
using System;

namespace RestaurantNet.Reports
{
    /// <summary>
    /// Summary description for ReporteCocina.
    /// </summary>
    public partial class ReporteCocina : MainReport
    {
        protected override Margins PortraitDefaultMargins
        {
            get { return new Margins(0f, 0f, 0f, 0f); }
        }
                
        public ReporteCocina()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void pageHeader_BeforePrint(object sender, EventArgs e)
        {
            lblDate.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));
            lblOrderNum.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));
            txtOrdenDia.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));
            lblPedidoNo.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));
            txtOrderID.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));
            lblOrderDate.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));
            txtOrderDate.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));

            lblAtentidoPor.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));
            txtEmployee.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));
            lblCantidad.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));
            lblProducto.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Cocina));


            lblDate.Text = DataUtil.GetString(DateTime.Now);
            if (DataUtil.GetString(Fields["Mesa_id"].Value) != string.Empty)
            {
                string mesaID = DataUtil.GetString(Fields["Mesa_id"].Value);
                string sWhere = "mesa_id = " + mesaID + "";
                mesaID = DataUtil.FindSingleRow("mesa", "Mesa_descripcion", sWhere);
                txtTable.Text = mesaID;
            }
            else
            {
                lblMesa.Text = "LLEVAR";
                txtTable.Text = string.Empty;
                //txtTable.Text = DataUtil.GetString(Fields["tipo_venta"].Value);
            }
        }

        protected override void MainReport_ReportStart(object sender, EventArgs e)
        {
            base.MainReport_ReportStart(sender, e);
        }

        private void detail_BeforePrint(object sender, EventArgs e)
        {
            txtQty.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontDetail.Cocina));
            txtDescription.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontDetail.Cocina));
        }
    }
}
