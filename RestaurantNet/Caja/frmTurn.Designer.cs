namespace RestaurantNet
{
  partial class frmTurn
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
      this.label2 = new System.Windows.Forms.Label();
      this.txtFondoInicialTotal = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.cbEstado = new System.Windows.Forms.ComboBox();
      this.label12 = new System.Windows.Forms.Label();
      this.lblFechaCierre = new System.Windows.Forms.Label();
      this.lblFechaApetura = new System.Windows.Forms.Label();
      this.dtpFechaApetura = new System.Windows.Forms.DateTimePicker();
      this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
      this.gbEstaciones = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnBorrar = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.txtLinea = new System.Windows.Forms.TextBox();
      this.dgwCuenta = new System.Windows.Forms.DataGridView();
      this.LINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ESTACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MONTO_INICIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ESTACION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label3 = new System.Windows.Forms.Label();
      this.txtMontoInicial = new System.Windows.Forms.TextBox();
      this.btnAddCargo = new System.Windows.Forms.Button();
      this.cbEstacion = new System.Windows.Forms.ComboBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtVentaTotal = new System.Windows.Forms.TextBox();
      this.btnDetalle = new Telerik.WinControls.UI.RadButton();
      this.label6 = new System.Windows.Forms.Label();
      this.txtOrdenes = new System.Windows.Forms.TextBox();
      this.gbEstaciones.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwCuenta)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnDetalle)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(364, 12);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "Abrir Turno";
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(444, 12);
      this.btnClose.TabIndex = 4;
      this.btnClose.Text = "Salir";
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(284, 12);
      this.btnDelete.TabIndex = 2;
      this.btnDelete.Text = "Cerrar Turno";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(13, 179);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(124, 16);
      this.label2.TabIndex = 33;
      this.label2.Text = "Fondo Inicial Total :";
      // 
      // txtFondoInicialTotal
      // 
      this.txtFondoInicialTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtFondoInicialTotal.Enabled = false;
      this.txtFondoInicialTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFondoInicialTotal.Location = new System.Drawing.Point(142, 176);
      this.txtFondoInicialTotal.MaxLength = 100;
      this.txtFondoInicialTotal.Name = "txtFondoInicialTotal";
      this.txtFondoInicialTotal.Size = new System.Drawing.Size(141, 22);
      this.txtFondoInicialTotal.TabIndex = 31;
      this.txtFondoInicialTotal.Text = "0";
      this.txtFondoInicialTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 66);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 16);
      this.label1.TabIndex = 32;
      this.label1.Text = "Codigo :";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Enabled = false;
      this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCodigo.Location = new System.Drawing.Point(76, 63);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(100, 22);
      this.txtCodigo.TabIndex = 34;
      // 
      // cbEstado
      // 
      this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEstado.Enabled = false;
      this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEstado.FormattingEnabled = true;
      this.cbEstado.Items.AddRange(new object[] {
            "ABIERTO",
            "CERRADO"});
      this.cbEstado.Location = new System.Drawing.Point(76, 91);
      this.cbEstado.Name = "cbEstado";
      this.cbEstado.Size = new System.Drawing.Size(121, 24);
      this.cbEstado.TabIndex = 0;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(13, 94);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(57, 16);
      this.label12.TabIndex = 36;
      this.label12.Text = "Estado :";
      // 
      // lblFechaCierre
      // 
      this.lblFechaCierre.AutoSize = true;
      this.lblFechaCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFechaCierre.Location = new System.Drawing.Point(13, 152);
      this.lblFechaCierre.Name = "lblFechaCierre";
      this.lblFechaCierre.Size = new System.Drawing.Size(91, 16);
      this.lblFechaCierre.TabIndex = 40;
      this.lblFechaCierre.Text = "Fecha Cierre :";
      this.lblFechaCierre.Visible = false;
      // 
      // lblFechaApetura
      // 
      this.lblFechaApetura.AutoSize = true;
      this.lblFechaApetura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFechaApetura.Location = new System.Drawing.Point(13, 126);
      this.lblFechaApetura.Name = "lblFechaApetura";
      this.lblFechaApetura.Size = new System.Drawing.Size(106, 16);
      this.lblFechaApetura.TabIndex = 39;
      this.lblFechaApetura.Text = "Fecha Apertura :";
      this.lblFechaApetura.Visible = false;
      // 
      // dtpFechaApetura
      // 
      this.dtpFechaApetura.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpFechaApetura.CustomFormat = "dd/MM/yyyy HH:mm";
      this.dtpFechaApetura.Enabled = false;
      this.dtpFechaApetura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpFechaApetura.Location = new System.Drawing.Point(142, 124);
      this.dtpFechaApetura.Name = "dtpFechaApetura";
      this.dtpFechaApetura.Size = new System.Drawing.Size(124, 20);
      this.dtpFechaApetura.TabIndex = 37;
      this.dtpFechaApetura.Visible = false;
      // 
      // dtpFechaCierre
      // 
      this.dtpFechaCierre.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpFechaCierre.CustomFormat = "dd/MM/yyyy HH:mm";
      this.dtpFechaCierre.Enabled = false;
      this.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpFechaCierre.Location = new System.Drawing.Point(142, 150);
      this.dtpFechaCierre.Name = "dtpFechaCierre";
      this.dtpFechaCierre.Size = new System.Drawing.Size(124, 20);
      this.dtpFechaCierre.TabIndex = 38;
      this.dtpFechaCierre.Visible = false;
      // 
      // gbEstaciones
      // 
      this.gbEstaciones.Controls.Add(this.label5);
      this.gbEstaciones.Controls.Add(this.groupBox2);
      this.gbEstaciones.Controls.Add(this.dgwCuenta);
      this.gbEstaciones.Controls.Add(this.label3);
      this.gbEstaciones.Controls.Add(this.txtMontoInicial);
      this.gbEstaciones.Controls.Add(this.btnAddCargo);
      this.gbEstaciones.Controls.Add(this.cbEstacion);
      this.gbEstaciones.Controls.Add(this.label13);
      this.gbEstaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbEstaciones.Location = new System.Drawing.Point(16, 204);
      this.gbEstaciones.Name = "gbEstaciones";
      this.gbEstaciones.Size = new System.Drawing.Size(509, 358);
      this.gbEstaciones.TabIndex = 1;
      this.gbEstaciones.TabStop = false;
      this.gbEstaciones.Text = "Estaciones Asociadas";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(196, 59);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(43, 16);
      this.label5.TabIndex = 52;
      this.label5.Text = "Soles";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnBorrar);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.txtLinea);
      this.groupBox2.Location = new System.Drawing.Point(332, 13);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(170, 65);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      // 
      // btnBorrar
      // 
      this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBorrar.Location = new System.Drawing.Point(81, 21);
      this.btnBorrar.Name = "btnBorrar";
      this.btnBorrar.Size = new System.Drawing.Size(83, 33);
      this.btnBorrar.TabIndex = 1;
      this.btnBorrar.Text = "Borrar";
      this.btnBorrar.UseVisualStyleBackColor = true;
      this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(6, 14);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(47, 16);
      this.label7.TabIndex = 37;
      this.label7.Text = "Linea :";
      // 
      // txtLinea
      // 
      this.txtLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLinea.Location = new System.Drawing.Point(9, 37);
      this.txtLinea.Name = "txtLinea";
      this.txtLinea.Size = new System.Drawing.Size(63, 22);
      this.txtLinea.TabIndex = 0;
      this.txtLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // dgwCuenta
      // 
      this.dgwCuenta.AllowUserToAddRows = false;
      this.dgwCuenta.AllowUserToDeleteRows = false;
      this.dgwCuenta.AllowUserToOrderColumns = true;
      this.dgwCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgwCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LINEA,
            this.ESTACION,
            this.MONTO_INICIAL,
            this.ESTACION_ID});
      this.dgwCuenta.Location = new System.Drawing.Point(6, 87);
      this.dgwCuenta.MultiSelect = false;
      this.dgwCuenta.Name = "dgwCuenta";
      this.dgwCuenta.ReadOnly = true;
      this.dgwCuenta.Size = new System.Drawing.Size(497, 265);
      this.dgwCuenta.TabIndex = 51;
      this.dgwCuenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCuenta_CellDoubleClick);
      // 
      // LINEA
      // 
      this.LINEA.HeaderText = "LINEA";
      this.LINEA.Name = "LINEA";
      this.LINEA.ReadOnly = true;
      this.LINEA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.LINEA.Width = 50;
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
      // ESTACION_ID
      // 
      this.ESTACION_ID.HeaderText = "ESTACION_ID";
      this.ESTACION_ID.Name = "ESTACION_ID";
      this.ESTACION_ID.ReadOnly = true;
      this.ESTACION_ID.Visible = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(6, 59);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(91, 16);
      this.label3.TabIndex = 50;
      this.label3.Text = "Monto  Inicial :";
      // 
      // txtMontoInicial
      // 
      this.txtMontoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMontoInicial.Location = new System.Drawing.Point(103, 56);
      this.txtMontoInicial.Name = "txtMontoInicial";
      this.txtMontoInicial.Size = new System.Drawing.Size(87, 22);
      this.txtMontoInicial.TabIndex = 1;
      // 
      // btnAddCargo
      // 
      this.btnAddCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddCargo.Location = new System.Drawing.Point(251, 54);
      this.btnAddCargo.Name = "btnAddCargo";
      this.btnAddCargo.Size = new System.Drawing.Size(75, 27);
      this.btnAddCargo.TabIndex = 47;
      this.btnAddCargo.Text = "Agregar";
      this.btnAddCargo.UseVisualStyleBackColor = true;
      this.btnAddCargo.Click += new System.EventHandler(this.btnAddCargo_Click);
      // 
      // cbEstacion
      // 
      this.cbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEstacion.FormattingEnabled = true;
      this.cbEstacion.Location = new System.Drawing.Point(103, 24);
      this.cbEstacion.MaxLength = 20;
      this.cbEstacion.Name = "cbEstacion";
      this.cbEstacion.Size = new System.Drawing.Size(211, 24);
      this.cbEstacion.TabIndex = 0;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(6, 27);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(66, 16);
      this.label13.TabIndex = 48;
      this.label13.Text = "Estacion :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(294, 179);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(83, 16);
      this.label4.TabIndex = 48;
      this.label4.Text = "Venta Total :";
      // 
      // txtVentaTotal
      // 
      this.txtVentaTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtVentaTotal.Enabled = false;
      this.txtVentaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVentaTotal.Location = new System.Drawing.Point(383, 176);
      this.txtVentaTotal.MaxLength = 100;
      this.txtVentaTotal.Name = "txtVentaTotal";
      this.txtVentaTotal.Size = new System.Drawing.Size(141, 22);
      this.txtVentaTotal.TabIndex = 47;
      this.txtVentaTotal.Text = "0";
      this.txtVentaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // btnDetalle
      // 
      this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
      this.btnDetalle.Location = new System.Drawing.Point(429, 91);
      this.btnDetalle.Name = "btnDetalle";
      this.btnDetalle.Size = new System.Drawing.Size(89, 62);
      this.btnDetalle.TabIndex = 49;
      this.btnDetalle.Text = "Ver Detalle";
      this.btnDetalle.Visible = false;
      this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(281, 126);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(97, 16);
      this.label6.TabIndex = 50;
      this.label6.Text = "Total Ordenes:";
      // 
      // txtOrdenes
      // 
      this.txtOrdenes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtOrdenes.Enabled = false;
      this.txtOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtOrdenes.Location = new System.Drawing.Point(378, 124);
      this.txtOrdenes.MaxLength = 100;
      this.txtOrdenes.Name = "txtOrdenes";
      this.txtOrdenes.Size = new System.Drawing.Size(48, 22);
      this.txtOrdenes.TabIndex = 51;
      this.txtOrdenes.TabStop = false;
      this.txtOrdenes.Text = "0";
      this.txtOrdenes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // frmTurn
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(536, 571);
      this.Controls.Add(this.txtOrdenes);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.btnDetalle);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtVentaTotal);
      this.Controls.Add(this.gbEstaciones);
      this.Controls.Add(this.dtpFechaCierre);
      this.Controls.Add(this.lblFechaCierre);
      this.Controls.Add(this.dtpFechaApetura);
      this.Controls.Add(this.lblFechaApetura);
      this.Controls.Add(this.cbEstado);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtFondoInicialTotal);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCodigo);
      this.Name = "frmTurn";
      this.Tag = "v";
      this.Load += new System.EventHandler(this.frmTurn_Load);
      this.Controls.SetChildIndex(this.txtCodigo, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.txtFondoInicialTotal, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.label12, 0);
      this.Controls.SetChildIndex(this.cbEstado, 0);
      this.Controls.SetChildIndex(this.lblFechaApetura, 0);
      this.Controls.SetChildIndex(this.dtpFechaApetura, 0);
      this.Controls.SetChildIndex(this.lblFechaCierre, 0);
      this.Controls.SetChildIndex(this.dtpFechaCierre, 0);
      this.Controls.SetChildIndex(this.btnClose, 0);
      this.Controls.SetChildIndex(this.btnDelete, 0);
      this.Controls.SetChildIndex(this.btnSave, 0);
      this.Controls.SetChildIndex(this.gbEstaciones, 0);
      this.Controls.SetChildIndex(this.txtVentaTotal, 0);
      this.Controls.SetChildIndex(this.label4, 0);
      this.Controls.SetChildIndex(this.btnDetalle, 0);
      this.Controls.SetChildIndex(this.label6, 0);
      this.Controls.SetChildIndex(this.txtOrdenes, 0);
      this.gbEstaciones.ResumeLayout(false);
      this.gbEstaciones.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwCuenta)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnDetalle)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtFondoInicialTotal;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.ComboBox cbEstado;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label lblFechaCierre;
    private System.Windows.Forms.Label lblFechaApetura;
    private System.Windows.Forms.DateTimePicker dtpFechaApetura;
    private System.Windows.Forms.DateTimePicker dtpFechaCierre;
    private System.Windows.Forms.GroupBox gbEstaciones;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMontoInicial;
    private System.Windows.Forms.Button btnAddCargo;
    private System.Windows.Forms.ComboBox cbEstacion;
    private System.Windows.Forms.Label label13;
    public System.Windows.Forms.DataGridView dgwCuenta;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnBorrar;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtLinea;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtVentaTotal;
    private Telerik.WinControls.UI.RadButton btnDetalle;
    private System.Windows.Forms.DataGridViewTextBoxColumn LINEA;
    private System.Windows.Forms.DataGridViewTextBoxColumn ESTACION;
    private System.Windows.Forms.DataGridViewTextBoxColumn MONTO_INICIAL;
    private System.Windows.Forms.DataGridViewTextBoxColumn ESTACION_ID;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtOrdenes;
  }
}
