namespace RestaurantNet
{
  partial class frmSale
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.lblMesaTipo = new System.Windows.Forms.Label();
            this.gbVentaInfo = new System.Windows.Forms.GroupBox();
            this.lblOrderDiaNo = new System.Windows.Forms.Label();
            this.lblOrderDia = new System.Windows.Forms.Label();
            this.lblOrdenOrigenValue = new System.Windows.Forms.Label();
            this.lblOrdenOrigenLabel = new System.Windows.Forms.Label();
            this.lblTurnoFecha = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMesaNo = new System.Windows.Forms.Label();
            this.lblMesaLabel = new System.Windows.Forms.Label();
            this.lblTipoVenta = new System.Windows.Forms.Label();
            this.lblTipoVentaLabel = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblOrderLabel = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgwCuenta = new System.Windows.Forms.DataGridView();
            this.LINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_FINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSale = new System.Windows.Forms.GroupBox();
            this.txtTotalDescuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNoDocumento = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblRUC = new System.Windows.Forms.Label();
            this.lblDocumentoLabel = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.lblVueltoLabel = new System.Windows.Forms.Label();
            this.txtContado = new System.Windows.Forms.TextBox();
            this.lblContadoLabel = new System.Windows.Forms.Label();
            this.gbTipoDocumento = new System.Windows.Forms.GroupBox();
            this.rbNotaDebito = new System.Windows.Forms.RadioButton();
            this.rbNotaCredito = new System.Windows.Forms.RadioButton();
            this.rbFactura = new System.Windows.Forms.RadioButton();
            this.rbBoleta = new System.Windows.Forms.RadioButton();
            this.txtTotalGeneral = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.lblIGV = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTipoPago = new System.Windows.Forms.GroupBox();
            this.rbGratis = new System.Windows.Forms.RadioButton();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.rbTarjetaCredito = new System.Windows.Forms.RadioButton();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.rbContado = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbVentaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCuenta)).BeginInit();
            this.gbSale.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbTipoDocumento.SuspendLayout();
            this.gbTipoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMesaTipo
            // 
            this.lblMesaTipo.AutoSize = true;
            this.lblMesaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaTipo.Location = new System.Drawing.Point(-142, 202);
            this.lblMesaTipo.Name = "lblMesaTipo";
            this.lblMesaTipo.Size = new System.Drawing.Size(48, 16);
            this.lblMesaTipo.TabIndex = 90;
            this.lblMesaTipo.Text = "Mesa :";
            this.lblMesaTipo.Visible = false;
            // 
            // gbVentaInfo
            // 
            this.gbVentaInfo.Controls.Add(this.lblOrderDiaNo);
            this.gbVentaInfo.Controls.Add(this.lblOrderDia);
            this.gbVentaInfo.Controls.Add(this.lblOrdenOrigenValue);
            this.gbVentaInfo.Controls.Add(this.lblOrdenOrigenLabel);
            this.gbVentaInfo.Controls.Add(this.lblTurnoFecha);
            this.gbVentaInfo.Controls.Add(this.label11);
            this.gbVentaInfo.Controls.Add(this.lblTurno);
            this.gbVentaInfo.Controls.Add(this.label9);
            this.gbVentaInfo.Controls.Add(this.lblMesaNo);
            this.gbVentaInfo.Controls.Add(this.lblMesaLabel);
            this.gbVentaInfo.Controls.Add(this.lblTipoVenta);
            this.gbVentaInfo.Controls.Add(this.lblTipoVentaLabel);
            this.gbVentaInfo.Controls.Add(this.lblOrderNo);
            this.gbVentaInfo.Controls.Add(this.lblOrderLabel);
            this.gbVentaInfo.Controls.Add(this.lblEmployee);
            this.gbVentaInfo.Controls.Add(this.label6);
            this.gbVentaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVentaInfo.Location = new System.Drawing.Point(12, 12);
            this.gbVentaInfo.Name = "gbVentaInfo";
            this.gbVentaInfo.Size = new System.Drawing.Size(662, 104);
            this.gbVentaInfo.TabIndex = 109;
            this.gbVentaInfo.TabStop = false;
            // 
            // lblOrderDiaNo
            // 
            this.lblOrderDiaNo.AutoSize = true;
            this.lblOrderDiaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDiaNo.Location = new System.Drawing.Point(247, 71);
            this.lblOrderDiaNo.Name = "lblOrderDiaNo";
            this.lblOrderDiaNo.Size = new System.Drawing.Size(36, 16);
            this.lblOrderDiaNo.TabIndex = 133;
            this.lblOrderDiaNo.Text = "9999";
            this.lblOrderDiaNo.Visible = false;
            // 
            // lblOrderDia
            // 
            this.lblOrderDia.AutoSize = true;
            this.lblOrderDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDia.Location = new System.Drawing.Point(161, 71);
            this.lblOrderDia.Name = "lblOrderDia";
            this.lblOrderDia.Size = new System.Drawing.Size(86, 16);
            this.lblOrderDia.TabIndex = 132;
            this.lblOrderDia.Text = "Orden Dia :";
            this.lblOrderDia.Visible = false;
            // 
            // lblOrdenOrigenValue
            // 
            this.lblOrdenOrigenValue.AutoSize = true;
            this.lblOrdenOrigenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenOrigenValue.Location = new System.Drawing.Point(504, 71);
            this.lblOrdenOrigenValue.Name = "lblOrdenOrigenValue";
            this.lblOrdenOrigenValue.Size = new System.Drawing.Size(112, 16);
            this.lblOrdenOrigenValue.TabIndex = 111;
            this.lblOrdenOrigenValue.Text = "ORDER ORIGEN";
            this.lblOrdenOrigenValue.Visible = false;
            // 
            // lblOrdenOrigenLabel
            // 
            this.lblOrdenOrigenLabel.AutoSize = true;
            this.lblOrdenOrigenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenOrigenLabel.Location = new System.Drawing.Point(395, 71);
            this.lblOrdenOrigenLabel.Name = "lblOrdenOrigenLabel";
            this.lblOrdenOrigenLabel.Size = new System.Drawing.Size(108, 16);
            this.lblOrdenOrigenLabel.TabIndex = 110;
            this.lblOrdenOrigenLabel.Text = "Orden Origen :";
            this.lblOrdenOrigenLabel.Visible = false;
            // 
            // lblTurnoFecha
            // 
            this.lblTurnoFecha.AutoSize = true;
            this.lblTurnoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoFecha.Location = new System.Drawing.Point(511, 43);
            this.lblTurnoFecha.Name = "lblTurnoFecha";
            this.lblTurnoFecha.Size = new System.Drawing.Size(105, 16);
            this.lblTurnoFecha.TabIndex = 109;
            this.lblTurnoFecha.Text = "FECHA TURNO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(364, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 16);
            this.label11.TabIndex = 108;
            this.label11.Text = "Apertura de Turno :";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(511, 16);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(113, 16);
            this.lblTurno.TabIndex = 107;
            this.lblTurno.Text = "TURNO ACTUAL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 106;
            this.label9.Text = "Turno Actual :";
            // 
            // lblMesaNo
            // 
            this.lblMesaNo.AutoSize = true;
            this.lblMesaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaNo.Location = new System.Drawing.Point(247, 43);
            this.lblMesaNo.Name = "lblMesaNo";
            this.lblMesaNo.Size = new System.Drawing.Size(46, 16);
            this.lblMesaNo.TabIndex = 105;
            this.lblMesaNo.Text = "MESA";
            this.lblMesaNo.Visible = false;
            // 
            // lblMesaLabel
            // 
            this.lblMesaLabel.AutoSize = true;
            this.lblMesaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaLabel.Location = new System.Drawing.Point(193, 43);
            this.lblMesaLabel.Name = "lblMesaLabel";
            this.lblMesaLabel.Size = new System.Drawing.Size(54, 16);
            this.lblMesaLabel.TabIndex = 104;
            this.lblMesaLabel.Text = "Mesa :";
            this.lblMesaLabel.Visible = false;
            // 
            // lblTipoVenta
            // 
            this.lblTipoVenta.AutoSize = true;
            this.lblTipoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVenta.Location = new System.Drawing.Point(105, 43);
            this.lblTipoVenta.Name = "lblTipoVenta";
            this.lblTipoVenta.Size = new System.Drawing.Size(39, 16);
            this.lblTipoVenta.TabIndex = 103;
            this.lblTipoVenta.Text = "TIPO";
            // 
            // lblTipoVentaLabel
            // 
            this.lblTipoVentaLabel.AutoSize = true;
            this.lblTipoVentaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVentaLabel.Location = new System.Drawing.Point(6, 43);
            this.lblTipoVentaLabel.Name = "lblTipoVentaLabel";
            this.lblTipoVentaLabel.Size = new System.Drawing.Size(92, 16);
            this.lblTipoVentaLabel.TabIndex = 102;
            this.lblTipoVentaLabel.Text = "Tipo Venta :";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNo.Location = new System.Drawing.Point(94, 71);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(36, 16);
            this.lblOrderNo.TabIndex = 101;
            this.lblOrderNo.Text = "9999";
            this.lblOrderNo.Visible = false;
            // 
            // lblOrderLabel
            // 
            this.lblOrderLabel.AutoSize = true;
            this.lblOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderLabel.Location = new System.Drawing.Point(6, 71);
            this.lblOrderLabel.Name = "lblOrderLabel";
            this.lblOrderLabel.Size = new System.Drawing.Size(82, 16);
            this.lblOrderLabel.TabIndex = 100;
            this.lblOrderLabel.Text = "Orden No :";
            this.lblOrderLabel.Visible = false;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(157, 16);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(150, 16);
            this.lblEmployee.TabIndex = 99;
            this.lblEmployee.Text = "EMPLEADO LOGEADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 98;
            this.label6.Text = "Empleado logeado :";
            // 
            // dgwCuenta
            // 
            this.dgwCuenta.AllowUserToAddRows = false;
            this.dgwCuenta.AllowUserToDeleteRows = false;
            this.dgwCuenta.AllowUserToOrderColumns = true;
            this.dgwCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LINEA,
            this.CODIGO,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.DESCUENTO,
            this.PRECIO_FINAL,
            this.PRECIO_DESCUENTO,
            this.PRECIO_UNITARIO,
            this.PRECIO_PROVEEDOR});
            this.dgwCuenta.Location = new System.Drawing.Point(13, 538);
            this.dgwCuenta.MultiSelect = false;
            this.dgwCuenta.Name = "dgwCuenta";
            this.dgwCuenta.ReadOnly = true;
            this.dgwCuenta.Size = new System.Drawing.Size(658, 264);
            this.dgwCuenta.TabIndex = 111;
            this.dgwCuenta.Visible = false;
            // 
            // LINEA
            // 
            this.LINEA.HeaderText = "LINEA";
            this.LINEA.Name = "LINEA";
            this.LINEA.ReadOnly = true;
            this.LINEA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LINEA.Width = 50;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "PROD. CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "PROD. DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DESCRIPCION.Width = 300;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CANTIDAD.Width = 50;
            // 
            // DESCUENTO
            // 
            this.DESCUENTO.HeaderText = "DESCUENTO %";
            this.DESCUENTO.Name = "DESCUENTO";
            this.DESCUENTO.ReadOnly = true;
            this.DESCUENTO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PRECIO_FINAL
            // 
            this.PRECIO_FINAL.HeaderText = "PRECIO";
            this.PRECIO_FINAL.Name = "PRECIO_FINAL";
            this.PRECIO_FINAL.ReadOnly = true;
            this.PRECIO_FINAL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PRECIO_DESCUENTO
            // 
            this.PRECIO_DESCUENTO.HeaderText = "DESCUENTO S/.";
            this.PRECIO_DESCUENTO.Name = "PRECIO_DESCUENTO";
            this.PRECIO_DESCUENTO.ReadOnly = true;
            // 
            // PRECIO_UNITARIO
            // 
            this.PRECIO_UNITARIO.HeaderText = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.ReadOnly = true;
            // 
            // PRECIO_PROVEEDOR
            // 
            this.PRECIO_PROVEEDOR.HeaderText = "PRECIO_PROVEEDOR";
            this.PRECIO_PROVEEDOR.Name = "PRECIO_PROVEEDOR";
            this.PRECIO_PROVEEDOR.ReadOnly = true;
            // 
            // gbSale
            // 
            this.gbSale.Controls.Add(this.txtTotalDescuento);
            this.gbSale.Controls.Add(this.label8);
            this.gbSale.Controls.Add(this.label1);
            this.gbSale.Controls.Add(this.cbEstacion);
            this.gbSale.Controls.Add(this.label4);
            this.gbSale.Controls.Add(this.lblNoDocumento);
            this.gbSale.Controls.Add(this.groupBox4);
            this.gbSale.Controls.Add(this.btnSale);
            this.gbSale.Controls.Add(this.txtVuelto);
            this.gbSale.Controls.Add(this.lblVueltoLabel);
            this.gbSale.Controls.Add(this.txtContado);
            this.gbSale.Controls.Add(this.lblContadoLabel);
            this.gbSale.Controls.Add(this.gbTipoDocumento);
            this.gbSale.Controls.Add(this.txtTotalGeneral);
            this.gbSale.Controls.Add(this.label5);
            this.gbSale.Controls.Add(this.txtIGV);
            this.gbSale.Controls.Add(this.lblIGV);
            this.gbSale.Controls.Add(this.txtSubTotal);
            this.gbSale.Controls.Add(this.label3);
            this.gbSale.Controls.Add(this.gbTipoPago);
            this.gbSale.Controls.Add(this.btnClose);
            this.gbSale.Location = new System.Drawing.Point(13, 122);
            this.gbSale.Name = "gbSale";
            this.gbSale.Size = new System.Drawing.Size(661, 411);
            this.gbSale.TabIndex = 118;
            this.gbSale.TabStop = false;
            // 
            // txtTotalDescuento
            // 
            this.txtTotalDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDescuento.Location = new System.Drawing.Point(167, 259);
            this.txtTotalDescuento.Name = "txtTotalDescuento";
            this.txtTotalDescuento.ReadOnly = true;
            this.txtTotalDescuento.Size = new System.Drawing.Size(191, 22);
            this.txtTotalDescuento.TabIndex = 137;
            this.txtTotalDescuento.Text = "0.00";
            this.txtTotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 138;
            this.label8.Text = "Total Desc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 136;
            this.label1.Text = "Documento Generado :";
            // 
            // cbEstacion
            // 
            this.cbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstacion.FormattingEnabled = true;
            this.cbEstacion.Location = new System.Drawing.Point(91, 13);
            this.cbEstacion.MaxLength = 20;
            this.cbEstacion.Name = "cbEstacion";
            this.cbEstacion.Size = new System.Drawing.Size(211, 24);
            this.cbEstacion.TabIndex = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 134;
            this.label4.Text = "Estacion :";
            // 
            // lblNoDocumento
            // 
            this.lblNoDocumento.AutoSize = true;
            this.lblNoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDocumento.Location = new System.Drawing.Point(510, 21);
            this.lblNoDocumento.Name = "lblNoDocumento";
            this.lblNoDocumento.Size = new System.Drawing.Size(123, 16);
            this.lblNoDocumento.TabIndex = 133;
            this.lblNoDocumento.Text = "lblNoDocumento";
            this.lblNoDocumento.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearchProduct);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.lblRUC);
            this.groupBox4.Controls.Add(this.lblDocumentoLabel);
            this.groupBox4.Controls.Add(this.lblCodigoCliente);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtCliente);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 84);
            this.groupBox4.TabIndex = 131;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion del Cliente";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.Image = global::RestaurantNet.RestautantResource.clientes;
            this.btnSearchProduct.Location = new System.Drawing.Point(430, 9);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(120, 41);
            this.btnSearchProduct.TabIndex = 106;
            this.btnSearchProduct.Text = "Lista Clientes";
            this.btnSearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(556, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 41);
            this.btnEdit.TabIndex = 98;
            this.btnEdit.Text = "Editar Cliente";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRUC.Location = new System.Drawing.Point(308, 21);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(64, 16);
            this.lblRUC.TabIndex = 97;
            this.lblRUC.Text = "9999999";
            // 
            // lblDocumentoLabel
            // 
            this.lblDocumentoLabel.AutoSize = true;
            this.lblDocumentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoLabel.Location = new System.Drawing.Point(219, 21);
            this.lblDocumentoLabel.Name = "lblDocumentoLabel";
            this.lblDocumentoLabel.Size = new System.Drawing.Size(83, 16);
            this.lblDocumentoLabel.TabIndex = 96;
            this.lblDocumentoLabel.Text = "Documento :";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(116, 21);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(40, 16);
            this.lblCodigoCliente.TabIndex = 95;
            this.lblCodigoCliente.Text = "0001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "Codigo Cliente :";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(130, 56);
            this.txtCliente.MaxLength = 100;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(507, 22);
            this.txtCliente.TabIndex = 92;
            this.txtCliente.DoubleClick += new System.EventHandler(this.txtCliente_DoubleClick);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 93;
            this.label7.Text = "Cliente (Apellido) :";
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Image = global::RestaurantNet.RestautantResource.pagar;
            this.btnSale.Location = new System.Drawing.Point(415, 268);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(114, 137);
            this.btnSale.TabIndex = 119;
            this.btnSale.Text = "Pagar e Imprimir Documento";
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // txtVuelto
            // 
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.Location = new System.Drawing.Point(167, 379);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.ReadOnly = true;
            this.txtVuelto.Size = new System.Drawing.Size(191, 26);
            this.txtVuelto.TabIndex = 129;
            this.txtVuelto.Text = "0.00";
            this.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVueltoLabel
            // 
            this.lblVueltoLabel.AutoSize = true;
            this.lblVueltoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVueltoLabel.Location = new System.Drawing.Point(11, 382);
            this.lblVueltoLabel.Name = "lblVueltoLabel";
            this.lblVueltoLabel.Size = new System.Drawing.Size(71, 20);
            this.lblVueltoLabel.TabIndex = 130;
            this.lblVueltoLabel.Text = "Vuelto :";
            // 
            // txtContado
            // 
            this.txtContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContado.Location = new System.Drawing.Point(167, 347);
            this.txtContado.Name = "txtContado";
            this.txtContado.Size = new System.Drawing.Size(191, 26);
            this.txtContado.TabIndex = 118;
            this.txtContado.Text = "0.00";
            this.txtContado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtContado.DoubleClick += new System.EventHandler(this.txtContado_DoubleClick);
            this.txtContado.Leave += new System.EventHandler(this.txtContado_Leave);
            // 
            // lblContadoLabel
            // 
            this.lblContadoLabel.AutoSize = true;
            this.lblContadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadoLabel.Location = new System.Drawing.Point(11, 350);
            this.lblContadoLabel.Name = "lblContadoLabel";
            this.lblContadoLabel.Size = new System.Drawing.Size(154, 20);
            this.lblContadoLabel.TabIndex = 128;
            this.lblContadoLabel.Text = "Efectivo Recibido:";
            // 
            // gbTipoDocumento
            // 
            this.gbTipoDocumento.Controls.Add(this.rbNotaDebito);
            this.gbTipoDocumento.Controls.Add(this.rbNotaCredito);
            this.gbTipoDocumento.Controls.Add(this.rbFactura);
            this.gbTipoDocumento.Controls.Add(this.rbBoleta);
            this.gbTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoDocumento.Location = new System.Drawing.Point(12, 44);
            this.gbTipoDocumento.Name = "gbTipoDocumento";
            this.gbTipoDocumento.Size = new System.Drawing.Size(643, 43);
            this.gbTipoDocumento.TabIndex = 127;
            this.gbTipoDocumento.TabStop = false;
            this.gbTipoDocumento.Text = "Tipo de documento";
            // 
            // rbNotaDebito
            // 
            this.rbNotaDebito.AutoSize = true;
            this.rbNotaDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotaDebito.Location = new System.Drawing.Point(298, 19);
            this.rbNotaDebito.Name = "rbNotaDebito";
            this.rbNotaDebito.Size = new System.Drawing.Size(120, 20);
            this.rbNotaDebito.TabIndex = 3;
            this.rbNotaDebito.Text = "Nota  de Debito";
            this.rbNotaDebito.UseVisualStyleBackColor = true;
            this.rbNotaDebito.CheckedChanged += new System.EventHandler(this.rbFactura_CheckedChanged);
            // 
            // rbNotaCredito
            // 
            this.rbNotaCredito.AutoSize = true;
            this.rbNotaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotaCredito.Location = new System.Drawing.Point(172, 19);
            this.rbNotaCredito.Name = "rbNotaCredito";
            this.rbNotaCredito.Size = new System.Drawing.Size(120, 20);
            this.rbNotaCredito.TabIndex = 2;
            this.rbNotaCredito.Text = "Nota de Credito";
            this.rbNotaCredito.UseVisualStyleBackColor = true;
            this.rbNotaCredito.CheckedChanged += new System.EventHandler(this.rbFactura_CheckedChanged);
            // 
            // rbFactura
            // 
            this.rbFactura.AutoSize = true;
            this.rbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFactura.Location = new System.Drawing.Point(95, 19);
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Size = new System.Drawing.Size(71, 20);
            this.rbFactura.TabIndex = 1;
            this.rbFactura.Text = "Factura";
            this.rbFactura.UseVisualStyleBackColor = true;
            this.rbFactura.CheckedChanged += new System.EventHandler(this.rbFactura_CheckedChanged);
            // 
            // rbBoleta
            // 
            this.rbBoleta.AutoSize = true;
            this.rbBoleta.Checked = true;
            this.rbBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBoleta.Location = new System.Drawing.Point(6, 19);
            this.rbBoleta.Name = "rbBoleta";
            this.rbBoleta.Size = new System.Drawing.Size(65, 20);
            this.rbBoleta.TabIndex = 0;
            this.rbBoleta.TabStop = true;
            this.rbBoleta.Text = "Boleta";
            this.rbBoleta.UseVisualStyleBackColor = true;
            this.rbBoleta.CheckedChanged += new System.EventHandler(this.rbFactura_CheckedChanged);
            // 
            // txtTotalGeneral
            // 
            this.txtTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeneral.Location = new System.Drawing.Point(167, 315);
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.ReadOnly = true;
            this.txtTotalGeneral.Size = new System.Drawing.Size(191, 26);
            this.txtTotalGeneral.TabIndex = 123;
            this.txtTotalGeneral.Text = "0.00";
            this.txtTotalGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 126;
            this.label5.Text = "Total :";
            // 
            // txtIGV
            // 
            this.txtIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGV.Location = new System.Drawing.Point(167, 287);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.ReadOnly = true;
            this.txtIGV.Size = new System.Drawing.Size(191, 22);
            this.txtIGV.TabIndex = 122;
            this.txtIGV.Text = "0.00";
            this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(12, 290);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(41, 16);
            this.lblIGV.TabIndex = 125;
            this.lblIGV.Text = "IGV :";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(167, 232);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(191, 22);
            this.txtSubTotal.TabIndex = 121;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 124;
            this.label3.Text = "Sub Total :";
            // 
            // gbTipoPago
            // 
            this.gbTipoPago.Controls.Add(this.rbGratis);
            this.gbTipoPago.Controls.Add(this.lblDocumento);
            this.gbTipoPago.Controls.Add(this.txtDocumento);
            this.gbTipoPago.Controls.Add(this.rbTarjetaCredito);
            this.gbTipoPago.Controls.Add(this.rbCheque);
            this.gbTipoPago.Controls.Add(this.rbContado);
            this.gbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoPago.Location = new System.Drawing.Point(12, 93);
            this.gbTipoPago.Name = "gbTipoPago";
            this.gbTipoPago.Size = new System.Drawing.Size(643, 43);
            this.gbTipoPago.TabIndex = 120;
            this.gbTipoPago.TabStop = false;
            this.gbTipoPago.Text = "Tipo de Pago";
            // 
            // rbGratis
            // 
            this.rbGratis.AutoSize = true;
            this.rbGratis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGratis.Location = new System.Drawing.Point(308, 19);
            this.rbGratis.Name = "rbGratis";
            this.rbGratis.Size = new System.Drawing.Size(61, 20);
            this.rbGratis.TabIndex = 4;
            this.rbGratis.Text = "Gratis";
            this.rbGratis.UseVisualStyleBackColor = true;
            this.rbGratis.CheckedChanged += new System.EventHandler(this.rbCheque_CheckedChanged);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(398, 19);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(42, 16);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "Doc. :";
            this.lblDocumento.Visible = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(446, 15);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(191, 22);
            this.txtDocumento.TabIndex = 3;
            this.txtDocumento.Visible = false;
            this.txtDocumento.DoubleClick += new System.EventHandler(this.txtDocumento_DoubleClick);
            // 
            // rbTarjetaCredito
            // 
            this.rbTarjetaCredito.AutoSize = true;
            this.rbTarjetaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjetaCredito.Location = new System.Drawing.Point(89, 19);
            this.rbTarjetaCredito.Name = "rbTarjetaCredito";
            this.rbTarjetaCredito.Size = new System.Drawing.Size(134, 20);
            this.rbTarjetaCredito.TabIndex = 2;
            this.rbTarjetaCredito.TabStop = true;
            this.rbTarjetaCredito.Text = "Tarjeta de Credito";
            this.rbTarjetaCredito.UseVisualStyleBackColor = true;
            this.rbTarjetaCredito.CheckedChanged += new System.EventHandler(this.rbCheque_CheckedChanged);
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCheque.Location = new System.Drawing.Point(229, 19);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(73, 20);
            this.rbCheque.TabIndex = 1;
            this.rbCheque.Text = "Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            this.rbCheque.CheckedChanged += new System.EventHandler(this.rbCheque_CheckedChanged);
            // 
            // rbContado
            // 
            this.rbContado.AutoSize = true;
            this.rbContado.Checked = true;
            this.rbContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContado.Location = new System.Drawing.Point(6, 19);
            this.rbContado.Name = "rbContado";
            this.rbContado.Size = new System.Drawing.Size(77, 20);
            this.rbContado.TabIndex = 0;
            this.rbContado.TabStop = true;
            this.rbContado.Text = "Contado";
            this.rbContado.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::RestaurantNet.RestautantResource.home;
            this.btnClose.Location = new System.Drawing.Point(535, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 137);
            this.btnClose.TabIndex = 132;
            this.btnClose.Text = "Menu Principal";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 536);
            this.Controls.Add(this.gbSale);
            this.Controls.Add(this.dgwCuenta);
            this.Controls.Add(this.gbVentaInfo);
            this.Controls.Add(this.lblMesaTipo);
            this.Name = "frmSale";
            this.Text = "Restaurant Net - Pago";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.gbVentaInfo.ResumeLayout(false);
            this.gbVentaInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCuenta)).EndInit();
            this.gbSale.ResumeLayout(false);
            this.gbSale.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbTipoDocumento.ResumeLayout(false);
            this.gbTipoDocumento.PerformLayout();
            this.gbTipoPago.ResumeLayout(false);
            this.gbTipoPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblMesaTipo;
    private System.Windows.Forms.GroupBox gbVentaInfo;
    private System.Windows.Forms.Label lblMesaNo;
    private System.Windows.Forms.Label lblMesaLabel;
    private System.Windows.Forms.Label lblTipoVenta;
    private System.Windows.Forms.Label lblTipoVentaLabel;
    private System.Windows.Forms.Label lblOrderNo;
    private System.Windows.Forms.Label lblOrderLabel;
    private System.Windows.Forms.Label lblEmployee;
    private System.Windows.Forms.Label label6;
    public System.Windows.Forms.DataGridView dgwCuenta;
    private System.Windows.Forms.Label lblTurnoFecha;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label lblTurno;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.GroupBox gbSale;
    private System.Windows.Forms.ComboBox cbEstacion;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblNoDocumento;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Label lblRUC;
    private System.Windows.Forms.Label lblDocumentoLabel;
    private System.Windows.Forms.Label lblCodigoCliente;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCliente;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnSale;
    private System.Windows.Forms.TextBox txtVuelto;
    private System.Windows.Forms.Label lblVueltoLabel;
    private System.Windows.Forms.TextBox txtContado;
    private System.Windows.Forms.Label lblContadoLabel;
    private System.Windows.Forms.GroupBox gbTipoDocumento;
    private System.Windows.Forms.RadioButton rbFactura;
    private System.Windows.Forms.RadioButton rbBoleta;
    private System.Windows.Forms.TextBox txtTotalGeneral;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtIGV;
    private System.Windows.Forms.Label lblIGV;
    private System.Windows.Forms.TextBox txtSubTotal;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox gbTipoPago;
    private System.Windows.Forms.Label lblDocumento;
    private System.Windows.Forms.TextBox txtDocumento;
    private System.Windows.Forms.RadioButton rbTarjetaCredito;
    private System.Windows.Forms.RadioButton rbCheque;
    private System.Windows.Forms.RadioButton rbContado;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblOrdenOrigenValue;
    private System.Windows.Forms.Label lblOrdenOrigenLabel;
    private System.Windows.Forms.Button btnSearchProduct;
    private System.Windows.Forms.Label lblOrderDiaNo;
    private System.Windows.Forms.Label lblOrderDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNotaDebito;
        private System.Windows.Forms.RadioButton rbNotaCredito;
        private System.Windows.Forms.RadioButton rbGratis;
        private System.Windows.Forms.TextBox txtTotalDescuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_FINAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_PROVEEDOR;
    }
}