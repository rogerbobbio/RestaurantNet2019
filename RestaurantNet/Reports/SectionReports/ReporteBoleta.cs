using GrapeCity.ActiveReports.Document.Section;
using System;

namespace RestaurantNet.Reports
{
    /// <summary>
    /// Summary description for ReporteBoleta.
    /// </summary>
    public partial class ReporteBoleta : MainReport
    {
        protected override Margins PortraitDefaultMargins
        {
            get { return new Margins(0f, 0f, 0f, 0f); }
        }

        public ReporteBoleta()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void pageHeader_BeforePrint(object sender, EventArgs e)
        {
            lblCompania.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblDireccion.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblDocumento.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblTelefono.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblBoleta.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblBoletaTitle.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblOrdenTitle.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblOrden.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblFechaTitle.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblFecha.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblTipoTitle.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblTipo.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblAtendidoPorTitle.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblMesaTitle.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblMesa.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblCantidadTitle.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblProductoTitle.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));
            lblSubTotalTitle.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontHeader.Boleta));

            lblCompania.Text = AppConstant.GeneralInfo.Compania;
            lblDireccion.Text = AppConstant.GeneralInfo.Direccion;
            lblDocumento.Text = @"RUC: " + AppConstant.GeneralInfo.RUC;
            lblTelefono.Text = @"Telefono: " + AppConstant.GeneralInfo.Telefono;

            string mesaId = DataUtil.GetString(Fields["Mesa_id"].Value);
            if (mesaId != string.Empty)
            {
                string sWhere = "mesa_id = " + mesaId + "";
                mesaId = DataUtil.FindSingleRow("mesa", "Mesa_descripcion", sWhere);
                lblMesa.Text = mesaId;
            }
            else
                lblMesa.Text = string.Empty;
        }

        private void reportFooter1_BeforePrint(object sender, EventArgs e)
        {
            lblIGV.Text = @"IGV " + AppConstant.GeneralInfo.IGV + @" % :";
            if (AppConstant.GeneralInfo.MostrarIGVBoleta == false)
            {
                lblIGV.Visible = false;
                lblIGVTotal.Visible = false;
                lblConsumo.Visible = false;
                lblConsumoTitle.Visible = false;
            }
            lblMensaje1.Text = AppConstant.GeneralInfo.Mensaje1;
            lblMensaje2.Text = AppConstant.GeneralInfo.Mensaje2;
            lblMensaje3.Text = AppConstant.GeneralInfo.Mensaje3;

            decimal dTotal = DataUtil.GetDecimal(lblTotalG.Text);
            var @let = new ConvertUtil.Numalet();
            let.SeparadorDecimalSalida = "Soles";
            let.ApocoparUnoParteEntera = true;
            lblLetras.Text = @"Son: " + let.ToCustomCardinal(dTotal);
        }

        private void detail_BeforePrint(object sender, EventArgs e)
        {
            lblProducto.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontDetail.Boleta));
            lblCantidad.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontDetail.Boleta));
            lblSubTotal.Font = new System.Drawing.Font("Courier New", float.Parse(AppConstant.GeneralInfo.FontDetail.Boleta));
        }

        protected override void MainReport_ReportStart(object sender, EventArgs e)
        {
            base.MainReport_ReportStart(sender, e);
        }
    }
}
