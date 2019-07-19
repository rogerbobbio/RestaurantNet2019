using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Printing;
using RestaurantNet.Reports;

namespace RestaurantNet
{
    public partial class frmGeneralConfig : frmMain
    {
        public frmGeneralConfig()
        {
            InitializeComponent();
        }

        private void frmGeneralcConfig_Load(object sender, EventArgs e)
        {
            try
            {
                rtsMain.SelectedTab = tabEmpresa;

                var mainDataSet = DataUtil.FillDataSet("SELECT * FROM configuracion_general", "configuracion_general");

                if (mainDataSet.Tables[0].Rows.Count > 0)
                {
                    txtCompania.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Nombre_compania");
                    txtRUC.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Documento_compania");
                    txtTelefono.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Telefono1_compania");
                    txtFax.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Telefono2_compania");
                    txtMobile.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Telefono3_compania");
                    txtEmail.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Email_compania");
                    txtWeb.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Web_compania");
                    txtDireccion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Direccion_compania");
                    txtLogo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Ruta_logo_compania");
                    txtLinea1.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Mensaje_recibo_1");
                    txtLinea2.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Mensaje_recibo_2");
                    txtLinea3.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Mensaje_recibo_3");
                    txtIGV.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "IGV");
                    txtFactura.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Ultima_factura");
                    txtBoleta.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Ultima_boleta");
                    txtPrefijoBoleta.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Prefijo_Boleta");
                    txtPrefijoFactura.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Prefijo_Factura");
                    txtNotaCredito.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Ultima_Nota_Credito");
                    txtNotaDebito.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Ultima_Nota_Debito");
                    txtPrefijoNotaCredito.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Prefijo_Nota_Credito");
                    txtPrefijoNotaDebito.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Prefijo_Nota_Debito");

                    txtDepartamento.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Departamento");
                    txtProvincia.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Provincia");
                    txtUrbanizacion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Urbanizacion");
                    txtCodigoPostal.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Codigo_Postal");

                    //Alegra
                    txtAlegraUsuario.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Alegra_Usuario");
                    txtAlegraToken.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Alegra_Token");

                    foreach (var strPrinter in PrinterSettings.InstalledPrinters)
                    {
                        cbBar.Items.Add(strPrinter);
                        cbCocina.Items.Add(strPrinter);
                        cbBoletas.Items.Add(strPrinter);
                        cbRecibos.Items.Add(strPrinter);
                        cbReportes.Items.Add(strPrinter);
                    }

                    txtRazonSocial.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Razon_social");
                    txtDireccionFiscal.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Direccion_fiscal");
                    txtCaja.Text = DataUtil.GetDecimal(mainDataSet.Tables[0].Rows[0], "Monto_caja").ToString();

                    cbAnulaciones.Checked = false;
                    cbNotaVenta.Checked = false;
                    cbDividirCuentas.Checked = false;
                    cbCambioMesero.Checked = false;
                    cbReImpresiones.Checked = false;
                    cbCambioMesa.Checked = false;
                    cbContrasenaSalir.Checked = false;
                    cbEliminarProducto.Checked = false;

                    if (DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Contrasena_Anulaciones") > 0)
                        cbAnulaciones.Checked = true;
                    if (DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Contrasena_NotaVenta") > 0)
                        cbNotaVenta.Checked = true;
                    if (DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Contrasena_DividirCuenta") > 0)
                        cbDividirCuentas.Checked = true;
                    if (DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Contrasena_CambioMesero") > 0)
                        cbCambioMesero.Checked = true;
                    if (DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Contrasena_ReImpresiones") > 0)
                        cbReImpresiones.Checked = true;
                    if (DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Contrasena_CambioMesa") > 0)
                        cbCambioMesa.Checked = true;
                    if (DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Contrasena_Salir") > 0)
                        cbContrasenaSalir.Checked = true;
                    if (DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Contrasena_EliminarProducto") > 0)
                        cbEliminarProducto.Checked = true;


                    cbMostrarIGVBoletas.Checked = false;
                    if (DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Mostrar_IGV_Boleta") > 0)
                        cbPreviewReportes.Checked = true;
                }

                cbPreviewBar.Checked = false;
                cbPreviewCocina.Checked = false;
                cbPreviewBoletas.Checked = false;
                cbPreviewRecibos.Checked = false;
                cbPreviewReportes.Checked = false;

                cbBarTexto.Checked = false;
                cbCocinaTexto.Checked = false;


                var dsImpresoraBar = DataUtil.FillDataSet("SELECT * FROM Impresora WHERE tipo = 'B'", "Impresora");
                if (dsImpresoraBar.Tables[0].Rows.Count > 0)
                {
                    cbBar.Text = DataUtil.GetString(dsImpresoraBar.Tables[0].Rows[0], "Ruta");
                    txtFontHeaderBar.Text = DataUtil.GetDouble(dsImpresoraBar.Tables[0].Rows[0], "Font_header").ToString();
                    txtFontDetailBar.Text = DataUtil.GetDouble(dsImpresoraBar.Tables[0].Rows[0], "Font_detail").ToString();
                    if (DataUtil.GetInt(dsImpresoraBar.Tables[0].Rows[0], "Preview") > 0)
                        cbPreviewBar.Checked = true;

                    if (DataUtil.GetInt(dsImpresoraBar.Tables[0].Rows[0], "Texto") > 0)
                        cbBarTexto.Checked = true;
                }
                var dsImpresoraCocina = DataUtil.FillDataSet("SELECT * FROM Impresora WHERE tipo = 'C'", "Impresora");
                if (dsImpresoraCocina.Tables[0].Rows.Count > 0)
                {
                    cbCocina.Text = DataUtil.GetString(dsImpresoraCocina.Tables[0].Rows[0], "Ruta");
                    txtFontHeaderCocina.Text = DataUtil.GetDouble(dsImpresoraCocina.Tables[0].Rows[0], "Font_header").ToString();
                    txtFontDetailCocina.Text = DataUtil.GetDouble(dsImpresoraCocina.Tables[0].Rows[0], "Font_detail").ToString();
                    if (DataUtil.GetInt(dsImpresoraCocina.Tables[0].Rows[0], "Preview") > 0)
                        cbPreviewCocina.Checked = true;

                    if (DataUtil.GetInt(dsImpresoraBar.Tables[0].Rows[0], "Texto") > 0)
                        cbCocinaTexto.Checked = true;
                }
                var dsImpresoraBoleta = DataUtil.FillDataSet("SELECT * FROM Impresora WHERE tipo = 'L'", "Impresora");
                if (dsImpresoraBoleta.Tables[0].Rows.Count > 0)
                {
                    cbBoletas.Text = DataUtil.GetString(dsImpresoraBoleta.Tables[0].Rows[0], "Ruta");
                    txtFontHeaderBoletas.Text = DataUtil.GetDouble(dsImpresoraBoleta.Tables[0].Rows[0], "Font_header").ToString();
                    txtFontDetailBoletas.Text = DataUtil.GetDouble(dsImpresoraBoleta.Tables[0].Rows[0], "Font_detail").ToString();
                    if (DataUtil.GetInt(dsImpresoraBoleta.Tables[0].Rows[0], "Preview") > 0)
                        cbPreviewBoletas.Checked = true;
                }

                var dsImpresoraRecibos = DataUtil.FillDataSet("SELECT * FROM Impresora WHERE tipo = 'R'", "Impresora");
                if (dsImpresoraRecibos.Tables[0].Rows.Count > 0)
                {
                    cbRecibos.Text = DataUtil.GetString(dsImpresoraRecibos.Tables[0].Rows[0], "Ruta");
                    txtFontHeaderRecibos.Text = DataUtil.GetDouble(dsImpresoraRecibos.Tables[0].Rows[0], "Font_header").ToString();
                    txtFontDetailRecibos.Text = DataUtil.GetDouble(dsImpresoraRecibos.Tables[0].Rows[0], "Font_detail").ToString();
                    if (DataUtil.GetInt(dsImpresoraRecibos.Tables[0].Rows[0], "Preview") > 0)
                        cbPreviewRecibos.Checked = true;
                }

                var dsImpresoraReportes = DataUtil.FillDataSet("SELECT * FROM Impresora WHERE tipo = 'P'", "Impresora");
                if (dsImpresoraReportes.Tables[0].Rows.Count > 0)
                {
                    cbReportes.Text = DataUtil.GetString(dsImpresoraReportes.Tables[0].Rows[0], "Ruta");
                    txtFontHeaderReportes.Text = DataUtil.GetDouble(dsImpresoraReportes.Tables[0].Rows[0], "Font_header").ToString();
                    txtFontDetailReportes.Text = DataUtil.GetDouble(dsImpresoraReportes.Tables[0].Rows[0], "Font_detail").ToString();
                    if (DataUtil.GetInt(dsImpresoraReportes.Tables[0].Rows[0], "Preview") > 0)
                        cbPreviewReportes.Checked = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(@"Error al obtener los valores de la tabla configuracion general: " + err.Message);
            }
        }

        private void btnSearchLogo_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
                txtLogo.Text = openFileDialog1.FileName;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsReadyToSave() && IsReadyToSaveFont())
            {
                try
                {
                    var valueAnulaciones = "0";
                    var valueNotaVenta = "0";
                    var valueDividirCuentas = "0";
                    var valueCambioMesero = "0";
                    var valueReImpresiones = "0";
                    var valueCambioMesa = "0";
                    var valueContrasenaSalir = "0";
                    var valueEliminarProducto = "0";

                    var valuePreviewBar = "0";
                    var valuePreviewCocina = "0";
                    var valuePreviewBoletas = "0";
                    var valuePreviewRecibos = "0";
                    var valuePreviewReportes = "0";

                    var valueBarTexto = "0";
                    var valueCocinaTexto = "0";

                    var valueMostrarIgvBoleta = "0";

                    if (cbAnulaciones.Checked)
                        valueAnulaciones = "1";
                    if (cbNotaVenta.Checked)
                        valueNotaVenta = "1";
                    if (cbDividirCuentas.Checked)
                        valueDividirCuentas = "1";
                    if (cbCambioMesero.Checked)
                        valueCambioMesero = "1";
                    if (cbReImpresiones.Checked)
                        valueReImpresiones = "1";
                    if (cbCambioMesa.Checked)
                        valueCambioMesa = "1";
                    if (cbContrasenaSalir.Checked)
                        valueContrasenaSalir = "1";
                    if (cbEliminarProducto.Checked)
                        valueEliminarProducto = "1";


                    if (cbPreviewBar.Checked)
                        valuePreviewBar = "1";
                    if (cbPreviewCocina.Checked)
                        valuePreviewCocina = "1";
                    if (cbPreviewBoletas.Checked)
                        valuePreviewBoletas = "1";
                    if (cbPreviewRecibos.Checked)
                        valuePreviewRecibos = "1";
                    if (cbPreviewReportes.Checked)
                        valuePreviewReportes = "1";

                    if (cbBarTexto.Checked)
                        valueBarTexto = "1";
                    if (cbCocinaTexto.Checked)
                        valueCocinaTexto = "1";

                    if (cbMostrarIGVBoletas.Checked)
                        valueMostrarIgvBoleta = "1";

                    var sqlForExecute = "UPDATE Impresora SET " +
                                           " Font_header = '" + DataUtil.GetDouble(txtFontHeaderBar.Text) + "'" +
                                           ", Font_detail = '" + DataUtil.GetDouble(txtFontDetailBar.Text) + "'" +
                                           ", Ruta = '" + cbBar.Text + "'" +
                                           ", Preview = '" + valuePreviewBar + "'" +
                                           ", Texto = '" + valueBarTexto + "'" +
                                           " WHERE tipo = 'B'";
                    DataUtil.Update(sqlForExecute);

                    sqlForExecute = "UPDATE Impresora SET " +
                                    " Font_header = '" + DataUtil.GetDouble(txtFontHeaderCocina.Text) + "'" +
                                    ", Font_detail = '" + DataUtil.GetDouble(txtFontDetailCocina.Text) + "'" +
                                    ", Ruta = '" + cbCocina.Text + "'" +
                                    ", Preview = '" + valuePreviewCocina + "'" +
                                    ", Texto = '" + valueCocinaTexto + "'" +
                                    " WHERE tipo = 'C'";
                    DataUtil.Update(sqlForExecute);

                    sqlForExecute = "UPDATE Impresora SET " +
                                    " Font_header = '" + DataUtil.GetDouble(txtFontHeaderBoletas.Text) + "'" +
                                    ", Font_detail = '" + DataUtil.GetDouble(txtFontDetailBoletas.Text) + "'" +
                                    ", Ruta = '" + cbBoletas.Text + "'" +
                                    ", Preview = '" + valuePreviewBoletas + "'" +
                                    " WHERE tipo = 'L'";
                    DataUtil.Update(sqlForExecute);

                    sqlForExecute = "UPDATE Impresora SET " +
                                    " Font_header = '" + DataUtil.GetDouble(txtFontHeaderRecibos.Text) + "'" +
                                    ", Font_detail = '" + DataUtil.GetDouble(txtFontDetailRecibos.Text) + "'" +
                                    ", Ruta = '" + cbRecibos.Text + "'" +
                                    ", Preview = '" + valuePreviewRecibos + "'" +
                                    " WHERE tipo = 'R'";
                    DataUtil.Update(sqlForExecute);

                    sqlForExecute = "UPDATE Impresora SET " +
                                    " Font_header = '" + DataUtil.GetDouble(txtFontHeaderReportes.Text) + "'" +
                                    ", Font_detail = '" + DataUtil.GetDouble(txtFontDetailReportes.Text) + "'" +
                                    ", Ruta = '" + cbReportes.Text + "'" +
                                    ", Preview = '" + valuePreviewReportes + "'" +
                                    " WHERE tipo = 'P'";
                    DataUtil.Update(sqlForExecute);

                    sqlForExecute = "UPDATE configuracion_general SET " +
                                    "  Nombre_compania = '" + txtCompania.Text.Trim().Replace("'", "''") + "'" +
                                    ", Razon_social = '" + txtRazonSocial.Text.Trim().Replace("'", "''") + "'" +
                                    ", Documento_compania = '" + txtRUC.Text.Trim() + "'" +
                                    ", Telefono1_compania = '" + txtTelefono.Text.Trim() + "'" +
                                    ", Telefono2_compania = '" + txtFax.Text.Trim() + "'" +
                                    ", Telefono3_compania = '" + txtMobile.Text.Trim() + "'" +
                                    ", Direccion_compania = '" + txtDireccion.Text.Trim().Replace("'", "''") + "'" +
                                    ", Direccion_fiscal = '" + txtDireccionFiscal.Text.Trim().Replace("'", "''") + "'" +
                                    ", Mensaje_recibo_1 = '" + txtLinea1.Text.Trim().Replace("'", "''") + "'" +
                                    ", Mensaje_recibo_2 = '" + txtLinea2.Text.Trim().Replace("'", "''") + "'" +
                                    ", Mensaje_recibo_3 = '" + txtLinea3.Text.Trim().Replace("'", "''") + "'" +
                                    ", Ruta_logo_compania = '" + txtLogo.Text.Trim().Replace("'", "''") + "'" +
                                    ", Departamento = '" + txtDepartamento.Text.Trim().Replace("'", "''") + "'" +
                                    ", Provincia = '" + txtProvincia.Text.Trim().Replace("'", "''") + "'" +
                                    ", Urbanizacion = '" + txtUrbanizacion.Text.Trim().Replace("'", "''") + "'" +
                                    ", Codigo_Postal = '" + txtCodigoPostal.Text.Trim().Replace("'", "''") + "'" +
                                    ", Alegra_Usuario = '" + txtAlegraUsuario.Text.Trim().Replace("'", "''") + "'" +
                                    ", Alegra_Token = '" + txtAlegraToken.Text.Trim().Replace("'", "''") + "'" +                                    
                                    ", Email_compania = '" + txtEmail.Text.Trim().Replace("'", "''") + "'" +
                                    ", Web_compania = '" + txtWeb.Text.Trim().Replace("'", "''") + "'" +
                                    ", IGV = '" + txtIGV.Text.Trim() + "'" +
                                    ", Monto_caja = '" + DataUtil.GetCurrency(txtCaja.Text) + "'" +
                                    ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                                    ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                                    ", Ultima_boleta = '" + txtBoleta.Text.Trim() + "'" +
                                    ", Ultima_factura = '" + txtFactura.Text.Trim() + "'" +
                                    ", Prefijo_Boleta = '" + txtPrefijoBoleta.Text.Trim() + "'" +
                                    ", Prefijo_Factura = '" + txtPrefijoFactura.Text.Trim() + "'" +
                                    ", Ultima_Nota_Credito = '" + txtNotaCredito.Text.Trim() + "'" +
                                    ", Ultima_Nota_Debito = '" + txtNotaDebito.Text.Trim() + "'" +
                                    ", Prefijo_Nota_Credito = '" + txtPrefijoNotaCredito.Text.Trim() + "'" +
                                    ", Prefijo_Nota_Debito = '" + txtPrefijoNotaDebito.Text.Trim() + "'" +
                                    ", Contrasena_Anulaciones = '" + valueAnulaciones + "'" +
                                    ", Contrasena_NotaVenta = '" + valueNotaVenta + "'" +
                                    ", Contrasena_DividirCuenta = '" + valueDividirCuentas + "'" +
                                    ", Contrasena_CambioMesero = '" + valueCambioMesero + "'" +
                                    ", Contrasena_ReImpresiones = '" + valueReImpresiones + "'" +
                                    ", Contrasena_CambioMesa = '" + valueCambioMesa + "'" +
                                    ", Contrasena_Salir = '" + valueContrasenaSalir + "'" +
                                    ", Contrasena_EliminarProducto = '" + valueEliminarProducto + "'" +
                                    ", Mostrar_IGV_Boleta = '" + valueMostrarIgvBoleta + "'";


                    if (!DataUtil.Update(sqlForExecute)) return;
                    MessageBox.Show(@"Registro grabado correctamente", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error en Grabar: " + ex.Message);
                }
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtLogo.Text = string.Empty;
        }

        private bool IsReadyToSave()
        {
            epCompania.SetError(txtCompania, string.Empty);
            epRUC.SetError(txtRUC, string.Empty);
            epDireccion.SetError(txtDireccion, string.Empty);
            epIGV.SetError(txtIGV, string.Empty);
            epDocumento.SetError(txtFactura, string.Empty);
            bool valueResult = true;

            if (txtCompania.Text == string.Empty)
            {
                epCompania.SetError(txtCompania, "Por favor ingresar el nombre de la Compañia.");
                valueResult = false;
            }

            if (txtRUC.Text == string.Empty)
            {
                epRUC.SetError(txtRUC, "Por favor ingresar el numero de RUC.");
                valueResult = false;
            }

            if (txtDireccion.Text == string.Empty)
            {
                epDireccion.SetError(txtDireccion, "Por favor ingresar la direccion.");
                valueResult = false;
            }

            if (txtIGV.Text == string.Empty)
            {
                epIGV.SetError(txtIGV, "Por favor ingresar el IGV %.");
                valueResult = false;
            }

            if (txtFactura.Text == string.Empty)
            {
                epDocumento.SetError(txtFactura, "Por favor ingresar el numero de la ultima factura.");
                valueResult = false;
            }

            return valueResult;
        }
        private bool IsReadyToSaveFont()
        {
            bool valueResult = true;
            epFontDetailBar.SetError(txtFontDetailBar, string.Empty);
            epFontHeaderBar.SetError(txtFontHeaderBar, string.Empty);
            epFontDetail.SetError(txtFontDetailCocina, string.Empty);
            epFontHeader.SetError(txtFontHeaderCocina, string.Empty);

            double fontDetailBar = DataUtil.GetDouble(txtFontDetailBar.Text);
            double fontHeaderBar = DataUtil.GetDouble(txtFontHeaderBar.Text);
            double fontDetail = DataUtil.GetDouble(txtFontDetailCocina.Text);
            double fontHeader = DataUtil.GetDouble(txtFontHeaderCocina.Text);

            if (fontDetailBar > 12 || fontDetailBar < 1)
            {
                valueResult = false;
                epFontDetailBar.SetError(txtFontDetailBar, "El tamaño de letra de los detalles (Bar/Cocina) tiene que ser mayor a 0 y menor que 12");
            }
            if (fontHeaderBar > 12 || fontHeaderBar < 1)
            {
                valueResult = false;
                epFontHeaderBar.SetError(txtFontHeaderBar, "El tamaño de letra de la cabezera (Bar/Cocina) tiene que ser mayor a 0 y menor que 12");
            }
            if (fontDetail > 12 || fontDetail < 1)
            {
                valueResult = false;
                epFontDetail.SetError(txtFontDetailCocina, "El tamaño de letra de los detalles tiene que ser mayor a 0 y menor que 12");
            }
            if (fontHeader > 12 || fontHeader < 1)
            {
                valueResult = false;
                epFontHeader.SetError(txtFontHeaderCocina, "El tamaño de letra de la cabezera tiene que ser mayor a 0 y menor que 12");
            }
            return valueResult;
        }

        private void btnTestImpresora_Click(object sender, EventArgs e)
        {
            if (IsReadyToSaveFont())
            {
                AppConstant.GeneralInfo.FontHeader.Bar = txtFontHeaderBar.Text;
                AppConstant.GeneralInfo.FontDetail.Bar = txtFontDetailBar.Text;
                AppConstant.GeneralInfo.FontHeader.Cocina = txtFontHeaderCocina.Text;
                AppConstant.GeneralInfo.FontDetail.Cocina = txtFontDetailCocina.Text;
                AppConstant.GeneralInfo.FontHeader.Boleta = txtFontHeaderBoletas.Text;
                AppConstant.GeneralInfo.FontDetail.Boleta = txtFontDetailBoletas.Text;
                AppConstant.GeneralInfo.FontHeader.Recibos = txtFontHeaderRecibos.Text;
                AppConstant.GeneralInfo.FontDetail.Recibos = txtFontDetailRecibos.Text;
                AppConstant.GeneralInfo.FontHeader.Reportes = txtFontHeaderReportes.Text;
                AppConstant.GeneralInfo.FontDetail.Reportes = txtFontDetailReportes.Text;

                var reportViewerForm = new ReportViewer();
                DataSet dsResult;

                if (rbBar.Checked)
                {
                    dsResult = DataUtil.FillDataSet(DataBaseQuerys.ImpresoraTest(), "pedido_detalle");
                    if (dsResult.Tables[0].Rows.Count > 0)
                    {                       
                        if (cbBar.Text != string.Empty)
                        {
                            if (cbBarTexto.Checked)
                            {
                                PrintByText.printDocument(cbBar.Text, dsResult, "B");
                            }
                            else
                            {
                                reportViewerForm.dsReport = dsResult;
                                reportViewerForm.reporteName = AppConstant.Reportes.Bar;
                                reportViewerForm.tableNameReport = "pedido_detalle";
                                reportViewerForm.printerName = string.Empty;

                                reportViewerForm.printerName = cbBar.Text;
                                reportViewerForm.ShowDialog();
                            }
                        }
                        else
                            MessageBox.Show(@"La impresora del bar no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (rbCocina.Checked)
                {
                    dsResult = DataUtil.FillDataSet(DataBaseQuerys.ImpresoraTest(), "pedido_detalle");
                    if (dsResult.Tables[0].Rows.Count > 0)
                    {
                        if (cbCocina.Text != string.Empty)
                        {
                            if (cbCocinaTexto.Checked)
                            {
                                PrintByText.printDocument(cbCocina.Text, dsResult, "C");
                            }
                            else
                            {
                                reportViewerForm.dsReport = dsResult;
                                reportViewerForm.reporteName = AppConstant.Reportes.Cocina;
                                reportViewerForm.tableNameReport = "pedido_detalle";
                                reportViewerForm.printerName = string.Empty;

                                reportViewerForm.printerName = cbCocina.Text;
                                reportViewerForm.ShowDialog();
                            }                            
                        }
                        else
                            MessageBox.Show(@"La impresora de la cocina no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (rbRecibos.Checked)
                {
                    dsResult = DataUtil.FillDataSet(DataBaseQuerys.ImpresoraTest(), "pedido_detalle");
                    reportViewerForm.dsReport = dsResult;
                    reportViewerForm.reporteName = AppConstant.Reportes.Cuenta;
                    reportViewerForm.tableNameReport = "pedido_detalle";
                    reportViewerForm.printerName = string.Empty;

                    if (cbRecibos.Text != string.Empty)
                    {
                        reportViewerForm.printerName = cbRecibos.Text;
                        reportViewerForm.ShowDialog();
                    }
                    else
                        MessageBox.Show(@"La impresora del Recibos no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (rbBoleta.Checked)
                {
                    dsResult = DataUtil.FillDataSet(DataBaseQuerys.ImpresoraTest(), "pedido_detalle");
                    reportViewerForm.dsReport = dsResult;
                    reportViewerForm.reporteName = AppConstant.Reportes.Boleta;
                    reportViewerForm.tableNameReport = "pedido_detalle";
                    reportViewerForm.printerName = string.Empty;

                    if (cbBoletas.Text != string.Empty)
                    {
                        reportViewerForm.printerName = cbBoletas.Text;
                        reportViewerForm.ShowDialog();
                    }
                    else
                        MessageBox.Show(@"La impresora del Boleta no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (rbReportes.Checked)
                {
                    MessageBox.Show(@"Aun no esta disponible en el sistema.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnImpresoras_Click(object sender, EventArgs e)
        {
            var frmPrinterTest = new frmPrinterTest();
            frmPrinterTest.ShowDialog();
        }
    }
}
