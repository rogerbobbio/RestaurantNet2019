using GrapeCity.ActiveReports.Document.Section;
using System;

namespace RestaurantNet.Reports
{
    /// <summary>
    /// Summary description for ReporteRecibos.
    /// </summary>
    public partial class ReporteRecibos : MainReport
    {
        protected override Margins PortraitDefaultMargins
        {
            get { return new Margins(0f, 0f, 0f, 0f); }
        }

        double subTotal = 0;
        public ReporteRecibos()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void pageHeader_BeforePrint(object sender, EventArgs e)
        {
            lblCompania.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblDireccion.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblDocumento.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblTelefono.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblOrderNo.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            txtOrderID.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblOrderDate.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            txtOrderDate.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblAtentidoPor.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            txtEmployee.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblMesa.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            txtTable.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblCantidad.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblProducto.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblSubTotal.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));

            lblCompania.Text = AppConstant.GeneralInfo.Compania;
            lblDireccion.Text = AppConstant.GeneralInfo.Direccion;
            lblDocumento.Text = "RUC: " + AppConstant.GeneralInfo.RUC;
            lblTelefono.Text = "Telefono: " + AppConstant.GeneralInfo.Telefono;

            if (DataUtil.GetString(Fields["Mesa_id"].Value) != string.Empty)
            {
                string mesaID = DataUtil.GetString(Fields["Mesa_id"].Value);
                string sWhere = "mesa_id = " + mesaID + "";
                mesaID = DataUtil.FindSingleRow("mesa", "Mesa_descripcion", sWhere);
                txtTable.Text = mesaID;
            }
            else
            {
                lblMesa.Text = "Tipo Venta:";
                txtTable.Text = DataUtil.GetString(Fields["tipo_venta"].Value);
            }
        }

        private void detail_BeforePrint(object sender, EventArgs e)
        {
            txtDescription.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontDetail.Recibos));
            txtQty.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontDetail.Recibos));
            txtMonto.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontDetail.Recibos));

            double calculoMonto = 0;
            if (DataUtil.GetString(Fields["Pedido_Descuento"].Value) != string.Empty)
                calculoMonto = (DataUtil.GetDouble(Fields["Producto_precio"].Value) * (1 - DataUtil.GetDouble(Fields["Pedido_Descuento"].Value) / 100));
            else
                calculoMonto = (DataUtil.GetDouble(Fields["Producto_precio"].Value));

            txtMonto.Text = calculoMonto.ToString(DataUtil.Amount);

            subTotal = subTotal + calculoMonto;
        }

        private void reportFooter1_BeforePrint(object sender, EventArgs e)
        {
            lblConsumo.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            txtSubTotal.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblIGV.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            txtIGV.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            lblTotalGeneral.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));
            txtTotalGeneral.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Recibos));

            double igvValue = (subTotal * (DataUtil.GetDouble(AppConstant.GeneralInfo.IGV) / 100));
            double totalGeneral = subTotal + igvValue;
            txtSubTotal.Text = subTotal.ToString(DataUtil.Format.Decimals);
            txtIGV.Text = igvValue.ToString(DataUtil.Format.Decimals);
            txtTotalGeneral.Text = totalGeneral.ToString(DataUtil.Format.Decimals);
            lblIGV.Text = "IGV (" + AppConstant.GeneralInfo.IGV + " %)";
        }

        protected override void MainReport_ReportStart(object sender, EventArgs e)
        {
            base.MainReport_ReportStart(sender, e);
        }
    }
}
