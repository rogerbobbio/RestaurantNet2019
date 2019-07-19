using RestaurantNet.Reports;
using System;
using System.Data;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections.Generic;
using RestaurantNet.AlegraClasses;

namespace RestaurantNet
{
    public partial class frmSale : frmMain
    {
        #region Constantes

        public string empleadoLogeado = string.Empty;
        public string atendidoPor = string.Empty;
        public string pedidoID = string.Empty;
        public string ordenDiaID = string.Empty;
        public string pedidoOrigen = string.Empty;
        public string tipoVenta = string.Empty;
        public string mesaID = string.Empty;
        public string ultimaLinea = string.Empty;
        public string clienteID = string.Empty;

        public string subTotal = "0.00";
        public string igvTotal = "0.00";
        public string totalGeneral = "0.00";
        public string descuentoTotal = "0.00";
        public DateTime fechaPedido;

        private string lastBoletaPrinted = string.Empty;
        private string prefijoBoleta = string.Empty;
        private string lastFacturaPrinted = string.Empty;
        private string prefijoFactura = string.Empty;

        private string lastNotaCreditoPrinted = string.Empty;
        private string prefijoNotaCredito = string.Empty;
        private string lastNotaDebitoPrinted = string.Empty;
        private string prefijoNotaDebito = string.Empty;

        private int documentPrinted;
        private int ventaID = 0;

        private int gridLineaNumero = 0;
        private int gridProdCodigo = 1;
        private int gridProdDescripcion = 2;
        private int gridCantidad = 3;
        private int gridDescuento = 4;
        private int gridPrecio = 5;
        private int gridDescuentoMonto = 6;
        private int gridPrecioUnitario = 7;
        private int gridPrecioProveedor = 8;

        #endregion

        public frmSale()
        {
            InitializeComponent();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            lblDocumentoLabel.Text = @"DNI:";
            lblRUC.Text = "";
            lblCodigoCliente.Text = string.Empty;

            lblEmployee.Text = empleadoLogeado;
            lblTipoVenta.Text = tipoVenta;
            if (pedidoID != string.Empty)
            {
                lblOrderNo.Visible = true;
                lblOrderLabel.Visible = true;
                lblOrderDia.Visible = true;
                lblOrderDiaNo.Visible = true;
                lblOrderNo.Text = pedidoID;
                lblOrderDiaNo.Text = ordenDiaID;
            }
            if (mesaID != string.Empty)
            {
                lblMesaLabel.Visible = true;
                lblMesaNo.Visible = true;
                lblMesaNo.Text = mesaID;
            }
            if (lblTipoVenta.Text == AppConstant.TipoVenta.Delivery)
            {
                var sWhere = "cliente_id = " + clienteID + "";
                txtCliente.Text = DataUtil.FindSingleRow("cliente", "Cliente_apellidos", sWhere);
                txtCliente_Leave(null, null);
            }

            txtSubTotal.Text = subTotal;
            txtTotalDescuento.Text = descuentoTotal;
            txtIGV.Text = igvTotal;
            txtTotalGeneral.Text = totalGeneral;
            txtVuelto.Text = totalGeneral;
            GetTurnInfo();
            DataUtil.FillComboBoxValues(cbEstacion.Items,
                "SELECT Estacion_descripcion, Estacion_id FROM Estacion WHERE Estacion_id IN (SELECT Estacion_id FROM turno_estacion WHERE Turno_id = " +
                lblTurno.Text + ") ORDER BY Estacion_descripcion", string.Empty);
            if (AppConstant.EmployeeInfo.Codigo != "1")
            {
                var sqlCommand = "SELECT Estacion.Estacion_descripcion, Turno.Estado, turno_estacion.* " +
                                 "  FROM Turno INNER JOIN (Estacion INNER JOIN turno_estacion ON Estacion.Estacion_id = turno_estacion.Estacion_id) ON Turno.Turno_id = turno_estacion.Turno_id" +
                                 " WHERE (((turno_estacion.estacion_id)=(SELECT estacion_id FROM estacion WHERE persona_asignada = " +
                                 AppConstant.EmployeeInfo.Codigo +
                                 " AND estado = 'ACTIVO') AND Turno.Estado = 'ABIERTO'))";
                var dsTurnoEstacion = DataUtil.FillDataSet(sqlCommand, "Estacion");
                if (dsTurnoEstacion.Tables[0].Rows.Count > 0)
                {
                    cbEstacion.Text = DataUtil.GetString(dsTurnoEstacion.Tables[0].Rows[0], "Estacion_Descripcion");
                    cbEstacion.Enabled = false;
                }
                else
                {
                    MessageBox.Show(@"No tiene una estacion asignada.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            if (pedidoOrigen != string.Empty)
            {
                lblOrdenOrigenLabel.Visible = true;
                lblOrdenOrigenValue.Visible = true;
                lblOrdenOrigenValue.Text = pedidoOrigen;
            }
        }

        #region Eventos

        private void txtContado_Leave(object sender, EventArgs e)
        {
            double totalG = DataUtil.GetDouble(txtTotalGeneral.Text);
            double contado = DataUtil.GetDouble(txtContado.Text);
            double vuelto = (totalG - contado) * -1;
            txtVuelto.Text = DataUtil.GetString(vuelto);
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            lblCodigoCliente.Text = string.Empty;
            lblRUC.Text = string.Empty;

            if (txtCliente.Text != string.Empty)
            {
                var stringSql = "c.cliente_id AS Codigo, " +
                                   "c.Tipo_documento AS [Tipo documento], " +
                                   "c.Documento, " +
                                   "IIf(c.Tipo_documento='RUC',c.cliente_apellidos,c.cliente_apellidos+', '+c.cliente_nombres) AS Cliente," +
                                   "c.Cliente_direccion AS Direccion, " +
                                   "c.Telefono_casa AS [Telefono fijo], " +
                                   "c.Telefono_celular AS Celular, " +
                                   "c.Telefono_trabajo AS [Telefono trabajo], " +
                                   "c.Email_principal AS [Email Principal]," +
                                   "c.Comentario, " +
                                   "c.Fecha_creacion AS [Fecha creacion], " +
                                   "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                                   "c.Fecha_actualizacion AS [Fecha actualizacion]," +
                                   "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]" +
                                   "  FROM (cliente AS c LEFT JOIN empleado AS cr ON c.creado_por=cr.codigo_empleado)" +
                                   "  LEFT JOIN empleado AS up ON c.actualizado_por=up.codigo_empleado";

                var stringWhere = string.Empty;

                var dsSearch = DataUtil.FillDataSet("SELECT " + stringSql + " WHERE c.cliente_apellidos like '%" + txtCliente.Text.Trim() + "%'" +
                        stringWhere + " ORDER BY c.cliente_apellidos", "cliente");
                if (dsSearch.Tables[0].Rows.Count == 1)
                {
                    txtCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Cliente");
                    lblCodigoCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Codigo");
                    lblRUC.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Documento");
                }
                else if (dsSearch.Tables[0].Rows.Count > 1)
                {
                    var frmCustomerSearchForm = new frmCustomerSearch();
                    frmCustomerSearchForm.ApellidoSearch = txtCliente.Text;
                    frmCustomerSearchForm.DsSearchCliente = dsSearch;
                    if (rbFactura.Checked)
                        frmCustomerSearchForm.ExtraWhere = stringWhere;
                    frmCustomerSearchForm.ShowDialog();
                    SetCustomerValues();
                }
                else
                {
                    var result = MessageBox.Show(@"No existe el cliente. Desea crear el cliente?", @"Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var frmCustomerAdd = new frmCustomer();
                        frmCustomerAdd.adding = true;
                        frmCustomerAdd.CreateSpecial = true;
                        frmCustomerAdd.ClienteApellido = txtCliente.Text.Trim();
                        frmCustomerAdd.CustomerRUC = true;
                        frmCustomerAdd.formTitle = "Cliente - Agregar";
                        frmCustomerAdd.ShowDialog();
                        SetCustomerValues();
                    }
                    else
                        txtCliente.Focus();
                }
            }
        }

        private void rbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rbContado.Checked || rbGratis.Checked)
            {
                lblContadoLabel.Visible = true;
                lblVueltoLabel.Visible = true;
                txtContado.Visible = true;
                txtVuelto.Visible = true;
                txtContado.Focus();
            }
            else
            {
                lblContadoLabel.Visible = false;
                lblVueltoLabel.Visible = false;
                txtContado.Visible = false;
                txtVuelto.Visible = false;
                txtContado.Text = @"0.00";
                txtVuelto.Text = @"0.00";
            }

            if (rbCheque.Checked || rbTarjetaCredito.Checked)
            {
                txtDocumento.Visible = true;
                txtDocumento.Focus();
            }
            else
            {
                txtDocumento.Visible = false;
                txtDocumento.Text = string.Empty;
            }            
        }

        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
            txtCliente.Text = string.Empty;
            lblCodigoCliente.Text = string.Empty;
            lblRUC.Text = string.Empty;            

            lblDocumentoLabel.Text = rbFactura.Checked ? @"RUC:" : @"DNI:";
        }

        private void txtContado_DoubleClick(object sender, EventArgs e)
        {
            AppConstant.Calculator.textIN = string.Empty;
            var frmCalculatorForm = new frmCalculator();
            frmCalculatorForm.ShowDialog();
            if (AppConstant.Calculator.textOUT != string.Empty)
                txtContado.Text = AppConstant.Calculator.textOUT;

            AppConstant.Calculator.textIN = string.Empty;
            AppConstant.Calculator.textOUT = string.Empty;
        }

        private void txtDocumento_DoubleClick(object sender, EventArgs e)
        {
            txtDocumento.Text = GotoKeyboard(string.Empty);
        }

        private void txtCliente_DoubleClick(object sender, EventArgs e)
        {
            txtCliente.Text = GotoKeyboard(string.Empty);
        }

        #endregion

        #region Metodos privados

        private void SetCustomerValues()
        {
            if (AppConstant.Customer.ClienteNombre != string.Empty)
            {
                txtCliente.Text = AppConstant.Customer.ClienteNombre;
                lblCodigoCliente.Text = AppConstant.Customer.ClienteCodigo;
                lblRUC.Text = AppConstant.Customer.ClienteDocumento;
                lblDocumentoLabel.Text = AppConstant.Customer.ClienteTipoDocumento;

                AppConstant.Customer.ClienteNombre = string.Empty;
                AppConstant.Customer.ClienteCodigo = string.Empty;
                AppConstant.Customer.ClienteDocumento = string.Empty;
                AppConstant.Customer.ClienteTipoDocumento = string.Empty;
            }
        }

        private bool IsReadyToSave()
        {
            var valueResult = true;

            if (rbBoleta.Checked)
            {
                lastBoletaPrinted = DataUtil.FindSingleRow("configuracion_general", "Ultima_boleta", string.Empty);
                if (lastBoletaPrinted.Equals(string.Empty))
                {
                    MessageBox.Show(@"Deber configuar el numero de la ultima boleta impresa en la tabla de configuracion.",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                prefijoBoleta = DataUtil.FindSingleRow("configuracion_general", "Prefijo_Boleta", string.Empty);
                if (prefijoBoleta.Equals(string.Empty))
                {
                    MessageBox.Show(@"Deber configuar el prefijo de la boleta en la tabla de configuracion.", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (DataUtil.GetInt(lastBoletaPrinted) > 99999999)
                {
                    MessageBox.Show(@"El numero de la ultima boleta impresa llego a su limite revisar la tabla de configuracion.",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (lblCodigoCliente.Text.Equals(string.Empty))
                {
                    txtCliente.Focus();
                    MessageBox.Show(@"Deber ingresar un cliente valido.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (lblRUC.Text.Equals(string.Empty))
                {
                    txtCliente.Focus();
                    MessageBox.Show(@"Deber ingresar un cliente que tenga DNI.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (rbFactura.Checked)
            {
                lastFacturaPrinted = DataUtil.FindSingleRow("configuracion_general", "Ultima_factura", string.Empty);
                if (lastFacturaPrinted.Equals(string.Empty))
                {
                    MessageBox.Show(@"Deber configuar el numero de la ultima factura impresa en la tabla de configuracion.",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                prefijoFactura = DataUtil.FindSingleRow("configuracion_general", "Prefijo_Factura", string.Empty);
                if (prefijoFactura.Equals(string.Empty))
                {
                    MessageBox.Show(@"Deber configuar el prefijo de la factura en la tabla de configuracion.", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (DataUtil.GetInt(lastFacturaPrinted) > 99999999)
                {
                    MessageBox.Show(@"El numero de la ultima factura impresa llego a su limite revisar la tabla de configuracion.",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (lblCodigoCliente.Text.Equals(string.Empty))
                {
                    txtCliente.Focus();
                    MessageBox.Show(@"Deber ingresar un cliente valido.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (lblRUC.Text.Equals(string.Empty))
                {
                    txtCliente.Focus();
                    MessageBox.Show(@"Deber ingresar un cliente que tenga RUC.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (rbNotaCredito.Checked)
            {
                lastNotaCreditoPrinted = DataUtil.FindSingleRow("configuracion_general", "Ultima_Nota_Credito", string.Empty);
                if (lastNotaCreditoPrinted.Equals(string.Empty))
                {
                    MessageBox.Show(@"Deber configuar el numero de la ultima Nota de Credito impresa en la tabla de configuracion.",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                prefijoNotaCredito = DataUtil.FindSingleRow("configuracion_general", "Prefijo_Nota_Credito", string.Empty);
                if (prefijoNotaCredito.Equals(string.Empty))
                {
                    MessageBox.Show(@"Deber configuar el prefijo de la Nota de Credito en la tabla de configuracion.", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (DataUtil.GetInt(lastNotaCreditoPrinted) > 99999999)
                {
                    MessageBox.Show(@"El numero de la ultima Nota de Credito impresa llego a su limite revisar la tabla de configuracion.",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (lblCodigoCliente.Text.Equals(string.Empty))
                {
                    txtCliente.Focus();
                    MessageBox.Show(@"Deber ingresar un cliente valido.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (lblRUC.Text.Equals(string.Empty))
                {
                    txtCliente.Focus();
                    MessageBox.Show(@"Deber ingresar un cliente que tenga DNI.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (rbNotaDebito.Checked)
            {
                lastNotaDebitoPrinted = DataUtil.FindSingleRow("configuracion_general", "Ultima_Nota_Debito", string.Empty);
                if (lastNotaDebitoPrinted.Equals(string.Empty))
                {
                    MessageBox.Show(@"Deber configuar el numero de la ultima Nota de Debito impresa en la tabla de configuracion.",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                prefijoNotaDebito = DataUtil.FindSingleRow("configuracion_general", "Prefijo_Nota_Debito", string.Empty);
                if (prefijoNotaDebito.Equals(string.Empty))
                {
                    MessageBox.Show(@"Deber configuar el prefijo de la Nota de Debito en la tabla de configuracion.", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (DataUtil.GetInt(lastNotaDebitoPrinted) > 99999999)
                {
                    MessageBox.Show(@"El numero de la ultima Nota de Debito impresa llego a su limite revisar la tabla de configuracion.",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (lblCodigoCliente.Text.Equals(string.Empty))
                {
                    txtCliente.Focus();
                    MessageBox.Show(@"Deber ingresar un cliente valido.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (lblRUC.Text.Equals(string.Empty))
                {
                    txtCliente.Focus();
                    MessageBox.Show(@"Deber ingresar un cliente que tenga DNI.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (rbCheque.Checked || rbTarjetaCredito.Checked)
            {
                if (txtDocumento.Text.Equals(string.Empty))
                {
                    txtDocumento.Focus();
                    if (rbCheque.Checked)
                        MessageBox.Show(@"Deber ingresar el numero de cheque.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (rbTarjetaCredito.Checked)
                        MessageBox.Show(@"Deber ingresar el numero de la tarjeta de credito.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if (DataUtil.GetDouble(txtContado.Text) < 1)
                {
                    txtContado.Focus();
                    MessageBox.Show(@"Deber ingresar el monto en efectivo.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (DataUtil.GetDouble(txtVuelto.Text) < 0)
                {
                    txtContado.Focus();
                    MessageBox.Show(@"Falta efectivo no cubre el total de la cuenta.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (dgwCuenta.Rows.Count.Equals(0))
            {
                MessageBox.Show(@"Agregar al menos un producto.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valueResult = false;
            }

            if (cbEstacion.Text.Equals(string.Empty))
            {
                MessageBox.Show(@"Debe elegir una estacion de pago.", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                valueResult = false;
            }

            return valueResult;
        }

        private void GetCustomerValues()
        {
            string stringSQL = "c.cliente_id AS Codigo, " +
                               "c.Tipo_documento AS [Tipo documento], " +
                               "c.Documento, " +
                               "IIf(c.Tipo_documento='RUC',c.cliente_apellidos,c.cliente_apellidos+', '+c.cliente_nombres) AS Cliente," +
                               "c.Cliente_direccion AS Direccion, " +
                               "c.Telefono_casa AS [Telefono fijo], " +
                               "c.Telefono_celular AS Celular, " +
                               "c.Telefono_trabajo AS [Telefono trabajo], " +
                               "c.Email_principal AS [Email Principal]," +
                               "c.Comentario, " +
                               "c.Fecha_creacion AS [Fecha creacion], " +
                               "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                               "c.Fecha_actualizacion AS [Fecha actualizacion]," +
                               "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]" +
                               "  FROM (cliente AS c LEFT JOIN empleado AS cr ON c.creado_por=cr.codigo_empleado)" +
                               "  LEFT JOIN empleado AS up ON c.actualizado_por=up.codigo_empleado";

            DataSet dsSearch =
                DataUtil.FillDataSet(
                    "SELECT " + stringSQL + " WHERE c.cliente_id = " + lblCodigoCliente.Text.Trim() +
                    " ORDER BY c.cliente_apellidos", "cliente");
            if (dsSearch.Tables[0].Rows.Count == 1)
            {
                txtCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Cliente");
                lblCodigoCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Codigo");
                lblRUC.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Documento");
            }
        }

        private void GetTurnInfo()
        {
            if (AppConstant.Turno.Codigo != string.Empty)
            {
                lblTurno.Text = AppConstant.Turno.Codigo;
                lblTurnoFecha.Text = AppConstant.Turno.FechaHora;
            }
            else
            {
                lblTurno.Text = string.Empty;
                lblTurnoFecha.Text = string.Empty;
            }
        }

        private string GotoKeyboard(string textIn)
        {
            string returnValue = string.Empty;
            AppConstant.Calculator.textIN = textIn;
            var frmKeyboardForm = new frmKeyboard();
            frmKeyboardForm.ShowDialog();
            if (AppConstant.Calculator.textOUT != string.Empty)
                returnValue = AppConstant.Calculator.textOUT;

            AppConstant.Calculator.textIN = string.Empty;
            AppConstant.Calculator.textOUT = string.Empty;
            return returnValue;
        }

        private void ReducirStock(int productoId, int cantidadReducir)
        {
            var sWhere = "producto_id = " + productoId + "";
            if (DataUtil.FindSingleRow("producto", "Alerta_fuera_stock", sWhere) == "1")
            {
                string sqlUpdate = "UPDATE producto SET " +
                                   "Cantidad_actual = (Cantidad_actual - " + cantidadReducir + ")" +
                                   " WHERE producto_id = " + productoId + "";

                DataUtil.Update(sqlUpdate);
            }
        }

        #endregion

        #region Botones

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (IsReadyToSave())
            {
                btnSale.Enabled = false;

                var documentNumber = string.Empty;
                var ventaDocumentoTipo = string.Empty;
                var tipoDocumento = string.Empty;

                if (rbFactura.Checked)
                {
                    documentPrinted = DataUtil.GetInt(lastFacturaPrinted) + 1;
                    documentNumber = prefijoFactura + '-' + string.Format("{0:00000000}", documentPrinted);
                    ventaDocumentoTipo = AppConstant.DocumentVenta.Factura;
                    tipoDocumento = "01";
                }
                if (rbBoleta.Checked)
                {
                    documentPrinted = DataUtil.GetInt(lastBoletaPrinted) + 1;
                    documentNumber = prefijoBoleta + '-' + string.Format("{0:00000000}", documentPrinted);
                    ventaDocumentoTipo = AppConstant.DocumentVenta.Boleta;
                    tipoDocumento = "03";
                }
                if (rbNotaCredito.Checked)
                {
                    documentPrinted = DataUtil.GetInt(lastNotaCreditoPrinted) + 1;
                    documentNumber = prefijoNotaCredito + '-' + string.Format("{0:00000000}", documentPrinted);
                    ventaDocumentoTipo = AppConstant.DocumentVenta.NotaCredito;
                    tipoDocumento = "07";
                }
                if (rbNotaDebito.Checked)
                {
                    documentPrinted = DataUtil.GetInt(lastNotaDebitoPrinted) + 1;
                    documentNumber = prefijoNotaDebito + '-' + string.Format("{0:00000000}", documentPrinted);
                    ventaDocumentoTipo = AppConstant.DocumentVenta.NotaDebito;
                    tipoDocumento = "08";
                }
                

                try
                {
                    var codigoCliente = lblCodigoCliente.Text;

                    if (pedidoID.Equals(string.Empty))
                        pedidoID = "null";
                    if (ordenDiaID.Equals(string.Empty))
                        ordenDiaID = "null";

                    if (mesaID.Equals(string.Empty))
                        mesaID = "null";
                    else
                    {
                        var sWhere = "Mesa_descripcion = '" + mesaID + "'";
                        mesaID = DataUtil.FindSingleRow("mesa", "mesa_id", sWhere);
                    }

                    if (codigoCliente.Equals(string.Empty))
                        codigoCliente = "null";                    

                    var tipoPago = AppConstant.TipoPago.Contado;
                    if (rbGratis.Checked)
                        tipoPago = AppConstant.TipoPago.VentaGratuita;
                    if (rbCheque.Checked)
                        tipoPago = AppConstant.TipoPago.Cheque;
                    if (rbTarjetaCredito.Checked)
                        tipoPago = AppConstant.TipoPago.TarjetaCredito;

                    var ventaId = DataUtil.GetNewId("venta");

                    var sqlForExecute = "INSERT INTO venta (" +
                                        "Venta_id," +
                                        "Turno_id," +
                                        "Estacion_id," +
                                        "Venta_documento_tipo," +
                                        "Venta_documento," +
                                        "Last_line," +
                                        "Atendido_por," +
                                        "Mesa_id," +
                                        "Cliente_id," +
                                        "Pedido_id," +
                                        "Orden_turno," +
                                        "Fecha_pedido," +

                                        "Monto_total," +
                                        "Sub_total," +
                                        "IGV_total," +
                                        "Monto_descuento," +
                                        "Monto_efectivo," +

                                        "Tipo_pago," +
                                        "Numero_documento_pago," +
                                        "Fecha_pago," +
                                        "Tipo_venta)" +
                                        " VALUES (" +
                                        ventaId + "," +
                                        "" + lblTurno.Text + "," +
                                        "" + ((System.Web.UI.WebControls.ListItem) (cbEstacion.SelectedItem)).Value +
                                        "," +
                                        "'" + ventaDocumentoTipo + "'," +
                                        "'" + documentNumber + "'," +
                                        "'" + ultimaLinea + "'," +
                                        "" + atendidoPor + "," +
                                        "" + mesaID + "," +
                                        "" + codigoCliente + "," +
                                        "" + pedidoID + "," +
                                        "" + ordenDiaID + "," +
                                        "'" + fechaPedido + "'," +

                                        "'" + totalGeneral + "'," +
                                        "'" + subTotal + "'," +
                                        "'" + igvTotal + "'," +
                                        "'" + descuentoTotal + "'," +
                                        "'" + txtContado.Text + "'," +

                                        "'" + tipoPago + "'," +
                                        "'" + txtDocumento.Text + "'," +
                                        "'" + DateTime.Now + "'," +
                                        "'" + tipoVenta + "'" +
                                        ")";

                    DataUtil.UpdateThrow(sqlForExecute);

                    string alegraDetails = string.Empty;
                    var count = 0;
                    foreach (DataGridViewRow row in dgwCuenta.Rows)
                    {
                        count += 1;
                        var descuentoValue = DataUtil.GetString(row.Cells[gridDescuento].Value);
                        var descuentoAlegra = 0;
                        if (descuentoValue.Equals(string.Empty))                        
                            descuentoValue = "null";
                        else
                            descuentoAlegra = DataUtil.GetInt(descuentoValue);
                        var descuentoMontoValue = DataUtil.GetString(row.Cells[gridDescuentoMonto].Value);
                        if (descuentoMontoValue.Equals(string.Empty))
                            descuentoMontoValue = "null";

                        var cantidadValue = DataUtil.GetString(row.Cells[gridCantidad].Value);
                        var precioProducto = DataUtil.GetString(row.Cells[gridPrecio].Value);

                        alegraDetails = alegraDetails + "{\"id\":\"1\"," +
                                                         "\"price\":\""+ precioProducto + "\"," +
                                                         "\"quantity\":\""+ cantidadValue + "\"," +
                                                         "\"tax\": [{\"id\":1}]," +
                                                         "\"discount\":\"" + descuentoAlegra + "\"}";
                        if (dgwCuenta.Rows.Count != count)
                            alegraDetails = alegraDetails + ",";

                        sqlForExecute = "INSERT INTO venta_detalle (" +
                                        "venta_detalle_id," +
                                        "venta_id," +
                                        "Linea," +
                                        "Codigo_Producto," +
                                        "Descripcion_Producto," +
                                        "Cantidad," +
                                        "Descuento," +
                                        "Precio_final," +
                                        "Precio_unitario," +
                                        "Precio_costo," +
                                        "Descuento_monto" +
                                        ")" +
                                        " VALUES (" +
                                        DataUtil.GetNewId("venta_detalle") + "," +
                                        ventaId + "," +
                                        "'" + DataUtil.GetString(row.Cells[gridLineaNumero].Value) + "'," +
                                        "'" + DataUtil.GetString(row.Cells[gridProdCodigo].Value) + "'," +
                                        "'" + DataUtil.GetString(row.Cells[gridProdDescripcion].Value).Replace("'", "''") + "'," +
                                        "" + cantidadValue + "," +
                                        "" + descuentoValue + "," +
                                        "'" + precioProducto + "'," +
                                        "'" + DataUtil.GetString(row.Cells[gridPrecioUnitario].Value) + "'," +
                                        "'" + DataUtil.GetString(row.Cells[gridPrecioProveedor].Value) + "'," +
                                        "" + descuentoMontoValue + "" +
                                        ")";
                        DataUtil.UpdateThrow(sqlForExecute);
                        ReducirStock(DataUtil.GetInt(row.Cells[gridProdCodigo].Value), DataUtil.GetInt(row.Cells[gridCantidad].Value));
                    }

                    if (pedidoOrigen == string.Empty)
                    {
                        if (mesaID != "null")
                        {
                            sqlForExecute = "UPDATE mesa SET " +
                                            "       Mesa_estado = 'LIBRE'," +
                                            "       Pedido_id = null" +
                                            " WHERE mesa_id = " + mesaID;
                            DataUtil.UpdateThrow(sqlForExecute);
                        }
                    }

                    if (pedidoID != "null")
                    {
                        sqlForExecute = "UPDATE pedido SET " +
                                        "  Estado = 'F'" +
                                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                                        " WHERE Pedido_id = " + pedidoID;
                        DataUtil.UpdateThrow(sqlForExecute);
                    }

                    if (rbFactura.Checked)
                    {
                        sqlForExecute = "UPDATE configuracion_general SET Ultima_factura = '" + documentPrinted + "'";
                    }
                    if (rbBoleta.Checked)
                    {
                        sqlForExecute = "UPDATE configuracion_general SET Ultima_boleta = '" + documentPrinted + "'";
                    }
                    if (rbNotaCredito.Checked)
                    {
                        sqlForExecute = "UPDATE configuracion_general SET Ultima_Nota_Credito = '" + documentPrinted + "'";
                    }
                    if (rbNotaDebito.Checked)
                    {
                        sqlForExecute = "UPDATE configuracion_general SET Ultima_Nota_Debito = '" + documentPrinted + "'";
                    }                                                                
                    DataUtil.UpdateThrow(sqlForExecute);

                    lblNoDocumento.Visible = true;
                    lblNoDocumento.Text = documentNumber;

                    PrintBill(ventaId);

                    btnSale.Visible = false;
                    txtContado.ReadOnly = true;
                    txtDocumento.ReadOnly = true;
                    txtCliente.ReadOnly = true;
                    btnEdit.Visible = false;
                    gbTipoDocumento.Enabled = false;
                    gbTipoPago.Enabled = false;
                    cbEstacion.Enabled = false;
                    btnSale.Enabled = true;
                    AppConstant.Pay.paySuccesfully = true;
                    txtTotalGeneral.Focus();
                    MessageBox.Show(@"Pago registrado correctamente.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (rbFactura.Checked)
                    {
                        var paymentMethod = "cash";
                        if (rbCheque.Checked)
                            paymentMethod = "check";
                        if (rbTarjetaCredito.Checked)
                            paymentMethod = "credit-card";

                        EnviarFacturaAlegra(paymentMethod, alegraDetails);
                    }                      
                    Close();
                }
                catch (Exception ex)
                {
                    btnSale.Enabled = true;
                    DataUtil.Update("DELETE FROM venta WHERE venta_id = '" + ventaID + "'");
                    MessageBox.Show(@"Error en Grabar: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lblCodigoCliente.Text.Trim() != string.Empty)
            {
                var frmCustomerEdit = new frmCustomer
                {
                    adding = false,
                    formTitle = "Cliente - Modificar",
                    formId = lblCodigoCliente.Text
                };
                frmCustomerEdit.ShowDialog();
                GetCustomerValues();
            }
            else
            {
                txtCliente.Focus();
                MessageBox.Show(@"Debe ingresar un cliente valido.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            var frmCustomerSearchForm = new frmCustomerSearch();
            frmCustomerSearchForm.ShowDialog();
            SetCustomerValues();
        }

        #endregion

        #region Reporte

        private void PrintBill(int ventaId)
        {
            string sqlCuenta = "SELECT Venta.Venta_id, " +
                               "       Venta.venta_documento_tipo," +
                               "       Venta.venta_documento," +
                               "       Empleado.Nombres_empleado+', '+Empleado.Apellidos_empleado AS AtendidoPor," +
                               "       Venta.Mesa_id," +
                               "       IIf(Cliente.Tipo_documento='RUC',Cliente.cliente_apellidos,Cliente.cliente_apellidos+', '+Cliente.cliente_nombres) AS Cliente," +
                               "       Cliente.Documento," +
                               "       Cliente.Cliente_direccion," +
                               "       Venta.Pedido_id," +
                               "       Venta.Fecha_Pedido," +
                               "       Venta.Monto_total," +
                               "       Venta.Sub_total," +
                               "       Venta.IGV_total," +
                               "       Venta.Monto_descuento," +
                               "       Venta.Monto_efectivo," +
                               "       Venta.Tipo_pago," +
                               "       Venta.Numero_documento_pago," +
                               "       Venta.Fecha_pago," +
                               "       Venta.Tipo_venta," +
                               "       Producto.Producto_categoria_id," +
                               "       Producto.Precio_proveedor," +
                               "       Venta_detalle.Codigo_Producto," +
                               "       Venta_detalle.Descripcion_Producto," +
                               "       Venta_detalle.Descuento," +
                               "       SUM(Venta_detalle.Cantidad) AS Venta_cantidad,";

            sqlCuenta = sqlCuenta + "       ROUND((SUM(Venta_detalle.Precio_final) * 1.18)) AS Producto_precio ";

            sqlCuenta = sqlCuenta + "  FROM Cliente " +
                        " RIGHT JOIN (Producto  " +
                        " INNER JOIN (Empleado " +
                        " INNER JOIN (Venta " +
                        " INNER JOIN Venta_detalle ON Venta.Venta_id = Venta_detalle.Venta_id) " +
                        "    ON Empleado.Codigo_empleado = Venta.Atendido_por) " +
                        "    ON Producto.Producto_id = Venta_detalle.Codigo_Producto) ON Cliente.Cliente_id = Venta.Cliente_id " +
                        " WHERE Venta.Venta_id = " + ventaId + "" +
                        " GROUP BY Venta.Venta_id, " +
                        "          Venta.venta_documento_tipo," +
                        "          Venta.venta_documento," +
                        "          Empleado.Nombres_empleado," +
                        "          Empleado.Apellidos_empleado," +
                        "          Venta.Mesa_id," +
                        "          Cliente.Tipo_documento," +
                        "          Cliente.cliente_apellidos," +
                        "          Cliente.cliente_nombres," +
                        "          Cliente.Documento," +
                        "          Venta.Pedido_id," +
                        "          Venta.Fecha_Pedido," +
                        "          Venta.Monto_total," +
                        "          Venta.Sub_total," +
                        "          Venta.IGV_total," +
                        "          Venta.Monto_descuento," +
                        "          Venta.Monto_efectivo," +
                        "          Venta.Tipo_pago," +
                        "          Venta.Numero_documento_pago," +
                        "          Venta.Fecha_pago," +
                        "          Venta.Tipo_venta," +
                        "          Producto.Producto_categoria_id," +
                        "          Producto.Precio_proveedor," +
                        "          Venta_detalle.Codigo_Producto," +
                        "          Venta_detalle.Descripcion_Producto," +
                        "          Venta_detalle.Descuento," +
                        "          Cliente.Cliente_direccion";
            var reportTitle = AppConstant.Reportes.Boleta;
            if (rbFactura.Checked)
                reportTitle = AppConstant.Reportes.Boleta;

            var reportViewerForm = new ReportViewer
            {
                dsReport = DataUtil.FillDataSet(sqlCuenta, "venta_detalle"),
                reporteName = reportTitle,
                tableNameReport = "venta_detalle",
                printerName = string.Empty
            };

            if (AppConstant.GeneralInfo.Impresora.Boleta != string.Empty)
            {
                reportViewerForm.printerName = AppConstant.GeneralInfo.Impresora.Boleta;
                reportViewerForm.ShowDialog();
            }
            else
                MessageBox.Show(@"La impresora de Boletas no esta configurada.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Alegra

        private void EnviarFacturaAlegra(string paymentMethod, string alegraDetails)
        {
            try
            {
                if (AppConstant.GeneralInfo.AlegraUsuario != string.Empty && AppConstant.GeneralInfo.AlegraToken != string.Empty)
                {
                    if (CheckForInternetConnection())
                    {
                        var base64Code = Base64Encode(AppConstant.GeneralInfo.AlegraUsuario + ":" + AppConstant.GeneralInfo.AlegraToken);

                        //Busca el cliente en Alegra por ID para asociar la factura 
                        var urlAlegra = string.Format("https://app.alegra.com/api/v1/contacts/?identification=40853312");
                        WebRequest requestObject = WebRequest.Create(urlAlegra);
                        requestObject.Headers.Add("Authorization", "Basic " + base64Code);
                        requestObject.Method = "GET";
                        HttpWebResponse responseObject = null;
                        responseObject = (HttpWebResponse)requestObject.GetResponse();
                        if (responseObject.StatusCode == HttpStatusCode.OK)
                        {
                            string getData = null;
                            using (Stream stream = responseObject.GetResponseStream())
                            {
                                StreamReader sr = new StreamReader(stream);
                                getData = sr.ReadToEnd();
                                sr.Close();
                            }
                            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                            List<AlegraCliente.Client> objList = serializer.Deserialize<List<AlegraCliente.Client>>(getData);
                            string clientId = string.Empty;
                            foreach (AlegraCliente.Client obj in objList)
                            {
                                clientId = obj.id;
                            }
                            if (clientId != string.Empty)
                            {
                                //Crea la factura en Alegra
                                urlAlegra = string.Format("https://app.alegra.com/api/v1/invoices");
                                WebRequest requestObjectPost = WebRequest.Create(urlAlegra);
                                requestObjectPost.Headers.Add("Authorization", "Basic " + base64Code);
                                requestObjectPost.Method = "POST";
                                requestObjectPost.ContentType = "application/json";

                                var dateAndTime = DateTime.Now;
                                var date = dateAndTime.Date;
                                var sDateTime = date.ToString("yyyy-MM-dd");

                                string postData = "{\"date\":\"" + sDateTime + "\"," +
                                                   "\"dueDate\":\"" + sDateTime + "\"," +
                                                   "\"client\":\"" + clientId + "\"," +
                                                   "\"items\":[" +
                                                   alegraDetails +
                                                   "]," +
                                                   "\"paymentMethod (México)\":\"" + paymentMethod + "\"," +
                                                   "\"accountNumber (México)\": \"1\"}";
                                using (var streamWriter = new StreamWriter(requestObjectPost.GetRequestStream()))
                                {
                                    streamWriter.Write(postData);
                                    streamWriter.Flush();
                                    streamWriter.Close();

                                    var httpResponse = (HttpWebResponse)requestObjectPost.GetResponse();
                                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                                    {
                                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                                        {
                                            var result2 = streamReader.ReadToEnd();
                                        }
                                    }
                                    httpResponse.Close();
                                }
                                MessageBox.Show(@"Documento creado en Alegra correctamente.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show(@"El cliente de la factura no se encuentra en Alegra.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        responseObject.Close();
                    }
                    else
                        MessageBox.Show(@"No se pudo crear el documento en Alegra porque no tienes internet.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (WebException e)
            {
                MessageBox.Show(string.Format("\r\nWebException Raised. The following error occurred : {0}", e.Status), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("\nThe following Exception was raised : {0}", e.Message), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
