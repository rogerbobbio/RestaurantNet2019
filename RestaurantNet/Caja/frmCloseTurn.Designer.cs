namespace RestaurantNet
{
  partial class frmCloseTurn
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.gbEstaciones = new System.Windows.Forms.GroupBox();
      this.dgwEstaciones = new System.Windows.Forms.DataGridView();
      this.ESTACION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ESTACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MONTO_INICIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblTurnoFecha = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.lblTurno = new System.Windows.Forms.Label();
      this.lblTurnoLabel = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtFondoInicialTotal = new System.Windows.Forms.TextBox();
      this.gbCuentas = new System.Windows.Forms.GroupBox();
      this.dgwCuentas = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.txtDetalleTotal = new System.Windows.Forms.TextBox();
      this.btnCerrarTurno = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.dgwExtra = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label3 = new System.Windows.Forms.Label();
      this.txtMovimientosTotal = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dgwMovimientos = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblCierreLabel = new System.Windows.Forms.Label();
      this.lblCierreValue = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtVentaTotal = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtBalance = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.btnVerProductosVendidos = new System.Windows.Forms.Button();
      this.gbEstaciones.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwEstaciones)).BeginInit();
      this.gbCuentas.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwCuentas)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwExtra)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwMovimientos)).BeginInit();
      this.SuspendLayout();
      // 
      // gbEstaciones
      // 
      this.gbEstaciones.Controls.Add(this.dgwEstaciones);
      this.gbEstaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbEstaciones.Location = new System.Drawing.Point(12, 41);
      this.gbEstaciones.Name = "gbEstaciones";
      this.gbEstaciones.Size = new System.Drawing.Size(509, 149);
      this.gbEstaciones.TabIndex = 2;
      this.gbEstaciones.TabStop = false;
      this.gbEstaciones.Text = "Estaciones Asociadas";
      // 
      // dgwEstaciones
      // 
      this.dgwEstaciones.AllowUserToAddRows = false;
      this.dgwEstaciones.AllowUserToDeleteRows = false;
      this.dgwEstaciones.AllowUserToOrderColumns = true;
      this.dgwEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgwEstaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESTACION_ID,
            this.ESTACION,
            this.MONTO_INICIAL});
      this.dgwEstaciones.Location = new System.Drawing.Point(6, 21);
      this.dgwEstaciones.MultiSelect = false;
      this.dgwEstaciones.Name = "dgwEstaciones";
      this.dgwEstaciones.ReadOnly = true;
      this.dgwEstaciones.Size = new System.Drawing.Size(497, 120);
      this.dgwEstaciones.TabIndex = 51;
      // 
      // ESTACION_ID
      // 
      this.ESTACION_ID.HeaderText = "CODIGO";
      this.ESTACION_ID.Name = "ESTACION_ID";
      this.ESTACION_ID.ReadOnly = true;
      this.ESTACION_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.ESTACION_ID.Width = 50;
      // 
      // ESTACION
      // 
      this.ESTACION.HeaderText = "ESTACION";
      this.ESTACION.Name = "ESTACION";
      this.ESTACION.ReadOnly = true;
      this.ESTACION.Width = 250;
      // 
      // MONTO_INICIAL
      // 
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Format = "N2";
      dataGridViewCellStyle1.NullValue = null;
      this.MONTO_INICIAL.DefaultCellStyle = dataGridViewCellStyle1;
      this.MONTO_INICIAL.HeaderText = "MONTO INICIAL";
      this.MONTO_INICIAL.Name = "MONTO_INICIAL";
      this.MONTO_INICIAL.ReadOnly = true;
      this.MONTO_INICIAL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.MONTO_INICIAL.Width = 150;
      // 
      // lblTurnoFecha
      // 
      this.lblTurnoFecha.AutoSize = true;
      this.lblTurnoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTurnoFecha.Location = new System.Drawing.Point(402, 9);
      this.lblTurnoFecha.Name = "lblTurnoFecha";
      this.lblTurnoFecha.Size = new System.Drawing.Size(105, 16);
      this.lblTurnoFecha.TabIndex = 107;
      this.lblTurnoFecha.Text = "FECHA TURNO";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(255, 9);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(141, 16);
      this.label11.TabIndex = 106;
      this.label11.Text = "Apertura de Turno :";
      // 
      // lblTurno
      // 
      this.lblTurno.AutoSize = true;
      this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTurno.Location = new System.Drawing.Point(118, 9);
      this.lblTurno.Name = "lblTurno";
      this.lblTurno.Size = new System.Drawing.Size(113, 16);
      this.lblTurno.TabIndex = 105;
      this.lblTurno.Text = "TURNO ACTUAL";
      // 
      // lblTurnoLabel
      // 
      this.lblTurnoLabel.AutoSize = true;
      this.lblTurnoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTurnoLabel.Location = new System.Drawing.Point(9, 9);
      this.lblTurnoLabel.Name = "lblTurnoLabel";
      this.lblTurnoLabel.Size = new System.Drawing.Size(103, 16);
      this.lblTurnoLabel.TabIndex = 104;
      this.lblTurnoLabel.Text = "Turno Actual :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(237, 199);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(124, 16);
      this.label2.TabIndex = 109;
      this.label2.Text = "Fondo Inicial Total :";
      // 
      // txtFondoInicialTotal
      // 
      this.txtFondoInicialTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtFondoInicialTotal.Enabled = false;
      this.txtFondoInicialTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFondoInicialTotal.Location = new System.Drawing.Point(366, 196);
      this.txtFondoInicialTotal.MaxLength = 100;
      this.txtFondoInicialTotal.Name = "txtFondoInicialTotal";
      this.txtFondoInicialTotal.Size = new System.Drawing.Size(141, 24);
      this.txtFondoInicialTotal.TabIndex = 108;
      this.txtFondoInicialTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // gbCuentas
      // 
      this.gbCuentas.Controls.Add(this.dgwCuentas);
      this.gbCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbCuentas.Location = new System.Drawing.Point(12, 230);
      this.gbCuentas.Name = "gbCuentas";
      this.gbCuentas.Size = new System.Drawing.Size(713, 210);
      this.gbCuentas.TabIndex = 110;
      this.gbCuentas.TabStop = false;
      this.gbCuentas.Text = "Detalle de Ordenes";
      // 
      // dgwCuentas
      // 
      this.dgwCuentas.AllowUserToAddRows = false;
      this.dgwCuentas.AllowUserToDeleteRows = false;
      this.dgwCuentas.AllowUserToOrderColumns = true;
      this.dgwCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgwCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.IMPORTE,
            this.dataGridViewTextBoxColumn4});
      this.dgwCuentas.Location = new System.Drawing.Point(6, 21);
      this.dgwCuentas.MultiSelect = false;
      this.dgwCuentas.Name = "dgwCuentas";
      this.dgwCuentas.ReadOnly = true;
      this.dgwCuentas.Size = new System.Drawing.Size(701, 183);
      this.dgwCuentas.TabIndex = 51;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "ESTACION";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 250;
      // 
      // DESCRIPCION
      // 
      this.DESCRIPCION.HeaderText = "DESCRIPCION";
      this.DESCRIPCION.Name = "DESCRIPCION";
      this.DESCRIPCION.ReadOnly = true;
      this.DESCRIPCION.Width = 200;
      // 
      // CANTIDAD
      // 
      this.CANTIDAD.HeaderText = "CANTIDAD";
      this.CANTIDAD.Name = "CANTIDAD";
      this.CANTIDAD.ReadOnly = true;
      // 
      // IMPORTE
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Format = "N2";
      dataGridViewCellStyle2.NullValue = null;
      this.IMPORTE.DefaultCellStyle = dataGridViewCellStyle2;
      this.IMPORTE.HeaderText = "IMPORTE";
      this.IMPORTE.Name = "IMPORTE";
      this.IMPORTE.ReadOnly = true;
      this.IMPORTE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.HeaderText = "ESTACION_ID";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Visible = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(563, 451);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 16);
      this.label1.TabIndex = 112;
      this.label1.Text = "Total :";
      // 
      // txtDetalleTotal
      // 
      this.txtDetalleTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDetalleTotal.Enabled = false;
      this.txtDetalleTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDetalleTotal.Location = new System.Drawing.Point(614, 446);
      this.txtDetalleTotal.MaxLength = 100;
      this.txtDetalleTotal.Name = "txtDetalleTotal";
      this.txtDetalleTotal.Size = new System.Drawing.Size(93, 24);
      this.txtDetalleTotal.TabIndex = 111;
      this.txtDetalleTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // btnCerrarTurno
      // 
      this.btnCerrarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnCerrarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCerrarTurno.Location = new System.Drawing.Point(826, 524);
      this.btnCerrarTurno.Name = "btnCerrarTurno";
      this.btnCerrarTurno.Size = new System.Drawing.Size(114, 83);
      this.btnCerrarTurno.TabIndex = 116;
      this.btnCerrarTurno.Text = "Cerrar Turno";
      this.btnCerrarTurno.UseVisualStyleBackColor = false;
      this.btnCerrarTurno.Click += new System.EventHandler(this.btnCerrarTurno_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.home;
      this.btnClose.Location = new System.Drawing.Point(826, 613);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(114, 87);
      this.btnClose.TabIndex = 117;
      this.btnClose.Text = "Menu Principal";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.dgwExtra);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(527, 41);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(413, 196);
      this.groupBox2.TabIndex = 118;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Informacion Extra";
      // 
      // dgwExtra
      // 
      this.dgwExtra.AllowUserToAddRows = false;
      this.dgwExtra.AllowUserToDeleteRows = false;
      this.dgwExtra.AllowUserToOrderColumns = true;
      this.dgwExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgwExtra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
      this.dgwExtra.Location = new System.Drawing.Point(8, 21);
      this.dgwExtra.MultiSelect = false;
      this.dgwExtra.Name = "dgwExtra";
      this.dgwExtra.ReadOnly = true;
      this.dgwExtra.Size = new System.Drawing.Size(399, 169);
      this.dgwExtra.TabIndex = 51;
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.HeaderText = "DESCRIPCION";
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.ReadOnly = true;
      this.dataGridViewTextBoxColumn11.Width = 250;
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.HeaderText = "CANTIDAD";
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.ReadOnly = true;
      this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(563, 687);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 16);
      this.label3.TabIndex = 121;
      this.label3.Text = "Total :";
      // 
      // txtMovimientosTotal
      // 
      this.txtMovimientosTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMovimientosTotal.Enabled = false;
      this.txtMovimientosTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMovimientosTotal.Location = new System.Drawing.Point(614, 682);
      this.txtMovimientosTotal.MaxLength = 100;
      this.txtMovimientosTotal.Name = "txtMovimientosTotal";
      this.txtMovimientosTotal.Size = new System.Drawing.Size(93, 24);
      this.txtMovimientosTotal.TabIndex = 120;
      this.txtMovimientosTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dgwMovimientos);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 468);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(713, 210);
      this.groupBox1.TabIndex = 119;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Gastos e Ingresos";
      // 
      // dgwMovimientos
      // 
      this.dgwMovimientos.AllowUserToAddRows = false;
      this.dgwMovimientos.AllowUserToDeleteRows = false;
      this.dgwMovimientos.AllowUserToOrderColumns = true;
      this.dgwMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgwMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
      this.dgwMovimientos.Location = new System.Drawing.Point(6, 21);
      this.dgwMovimientos.MultiSelect = false;
      this.dgwMovimientos.Name = "dgwMovimientos";
      this.dgwMovimientos.ReadOnly = true;
      this.dgwMovimientos.Size = new System.Drawing.Size(701, 183);
      this.dgwMovimientos.TabIndex = 51;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "ESTACION";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 250;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "DESCRIPCION";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 200;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.HeaderText = "CANTIDAD";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn6
      // 
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Format = "N2";
      dataGridViewCellStyle3.NullValue = null;
      this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridViewTextBoxColumn6.HeaderText = "IMPORTE";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.HeaderText = "ESTACION_ID";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.ReadOnly = true;
      this.dataGridViewTextBoxColumn7.Visible = false;
      // 
      // lblCierreLabel
      // 
      this.lblCierreLabel.AutoSize = true;
      this.lblCierreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCierreLabel.Location = new System.Drawing.Point(255, 25);
      this.lblCierreLabel.Name = "lblCierreLabel";
      this.lblCierreLabel.Size = new System.Drawing.Size(124, 16);
      this.lblCierreLabel.TabIndex = 122;
      this.lblCierreLabel.Text = "Cierre de Turno :";
      this.lblCierreLabel.Visible = false;
      // 
      // lblCierreValue
      // 
      this.lblCierreValue.AutoSize = true;
      this.lblCierreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCierreValue.Location = new System.Drawing.Point(402, 25);
      this.lblCierreValue.Name = "lblCierreValue";
      this.lblCierreValue.Size = new System.Drawing.Size(105, 16);
      this.lblCierreValue.TabIndex = 123;
      this.lblCierreValue.Text = "FECHA TURNO";
      this.lblCierreValue.Visible = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(743, 251);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(112, 20);
      this.label4.TabIndex = 125;
      this.label4.Text = "Venta Total :";
      // 
      // txtVentaTotal
      // 
      this.txtVentaTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtVentaTotal.Enabled = false;
      this.txtVentaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVentaTotal.Location = new System.Drawing.Point(747, 274);
      this.txtVentaTotal.MaxLength = 100;
      this.txtVentaTotal.Name = "txtVentaTotal";
      this.txtVentaTotal.Size = new System.Drawing.Size(141, 24);
      this.txtVentaTotal.TabIndex = 124;
      this.txtVentaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(743, 318);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(159, 20);
      this.label5.TabIndex = 127;
      this.label5.Text = "Balance de Cajas :";
      // 
      // txtBalance
      // 
      this.txtBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtBalance.Enabled = false;
      this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBalance.Location = new System.Drawing.Point(747, 341);
      this.txtBalance.MaxLength = 100;
      this.txtBalance.Name = "txtBalance";
      this.txtBalance.Size = new System.Drawing.Size(141, 24);
      this.txtBalance.TabIndex = 126;
      this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(744, 368);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(144, 37);
      this.label6.TabIndex = 128;
      this.label6.Text = "(Caja Chica + Venta + Depositos - Retiros)";
      // 
      // btnVerProductosVendidos
      // 
      this.btnVerProductosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnVerProductosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnVerProductosVendidos.Location = new System.Drawing.Point(826, 435);
      this.btnVerProductosVendidos.Name = "btnVerProductosVendidos";
      this.btnVerProductosVendidos.Size = new System.Drawing.Size(114, 83);
      this.btnVerProductosVendidos.TabIndex = 129;
      this.btnVerProductosVendidos.Text = "Ver Productos Vendidos";
      this.btnVerProductosVendidos.UseVisualStyleBackColor = false;
      this.btnVerProductosVendidos.Click += new System.EventHandler(this.btnVerProductosVendidos_Click);
      // 
      // frmCloseTurn
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(946, 712);
      this.Controls.Add(this.btnVerProductosVendidos);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtBalance);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtVentaTotal);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtDetalleTotal);
      this.Controls.Add(this.lblCierreValue);
      this.Controls.Add(this.lblCierreLabel);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtMovimientosTotal);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.btnCerrarTurno);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.gbCuentas);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtFondoInicialTotal);
      this.Controls.Add(this.lblTurnoFecha);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.lblTurno);
      this.Controls.Add(this.lblTurnoLabel);
      this.Controls.Add(this.gbEstaciones);
      this.Name = "frmCloseTurn";
      this.Text = "Cerrar Turno";
      this.Load += new System.EventHandler(this.frmCloseTurn_Load);
      this.gbEstaciones.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgwEstaciones)).EndInit();
      this.gbCuentas.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgwCuentas)).EndInit();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgwExtra)).EndInit();
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgwMovimientos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox gbEstaciones;
    public System.Windows.Forms.DataGridView dgwEstaciones;
    private System.Windows.Forms.Label lblTurnoFecha;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label lblTurno;
    private System.Windows.Forms.Label lblTurnoLabel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtFondoInicialTotal;
    private System.Windows.Forms.GroupBox gbCuentas;
    public System.Windows.Forms.DataGridView dgwCuentas;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtDetalleTotal;
    private System.Windows.Forms.Button btnCerrarTurno;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.GroupBox groupBox2;
    public System.Windows.Forms.DataGridView dgwExtra;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMovimientosTotal;
    private System.Windows.Forms.GroupBox groupBox1;
    public System.Windows.Forms.DataGridView dgwMovimientos;
    private System.Windows.Forms.DataGridViewTextBoxColumn ESTACION_ID;
    private System.Windows.Forms.DataGridViewTextBoxColumn ESTACION;
    private System.Windows.Forms.DataGridViewTextBoxColumn MONTO_INICIAL;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
    private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
    private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.Label lblCierreLabel;
    private System.Windows.Forms.Label lblCierreValue;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtVentaTotal;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtBalance;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnVerProductosVendidos;
  }
}