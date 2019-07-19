namespace RestaurantNet
{
  partial class frmBillSearch
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.radmccbTurno = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.cbSunat = new System.Windows.Forms.CheckBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl.MasterGridViewTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(827, 504);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(130, 22);
            this.txtTotal.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(779, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 147;
            this.label2.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.lblFechaInicio);
            this.groupBox1.Controls.Add(this.lblFechaFin);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.cbAll);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 90);
            this.groupBox1.TabIndex = 143;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turno";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(181, 27);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(100, 22);
            this.dtpFechaInicio.TabIndex = 129;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 30);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(132, 16);
            this.lblFechaInicio.TabIndex = 130;
            this.lblFechaInicio.Text = "Fecha Venta (Inicio) :";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(12, 58);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(119, 16);
            this.lblFechaFin.TabIndex = 132;
            this.lblFechaFin.Text = "Fecha Venta (Fin) :";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(181, 55);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(100, 22);
            this.dtpFechaFin.TabIndex = 131;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAll.Location = new System.Drawing.Point(60, 0);
            this.cbAll.Name = "cbAll";
            this.cbAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAll.Size = new System.Drawing.Size(120, 20);
            this.cbAll.TabIndex = 133;
            this.cbAll.Text = "Cualquier fecha";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.Click += new System.EventHandler(this.cbAll_Click);
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(687, 81);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(40, 16);
            this.lblCodigoCliente.TabIndex = 142;
            this.lblCodigoCliente.Text = "0001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(579, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 141;
            this.label6.Text = "Codigo Cliente :";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(142, 78);
            this.txtCliente.MaxLength = 100;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(422, 22);
            this.txtCliente.TabIndex = 139;
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 140;
            this.label5.Text = "Cliente (Apellido) :";
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Items.AddRange(new object[] {
            "TODOS",
            "CONTADO",
            "CHEQUE",
            "TARJETA DE CREDITO",
            "VENTA GRATUITA"});
            this.cbTipoPago.Location = new System.Drawing.Point(142, 43);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(216, 24);
            this.cbTipoPago.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 137;
            this.label4.Text = "Tipo de pago :";
            // 
            // txtDocumento
            // 
            this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(437, 8);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(217, 22);
            this.txtDocumento.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 135;
            this.label3.Text = "Numero de documento :";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Items.AddRange(new object[] {
            "TODOS",
            "FACTURA",
            "BOLETA",
            "NOTA CREDITO",
            "NOTA DEBITO"});
            this.cbTipoDoc.Location = new System.Drawing.Point(142, 8);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(121, 24);
            this.cbTipoDoc.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 127;
            this.label7.Text = "Tipo de documento :";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(154, 219);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(32, 16);
            this.lblNo.TabIndex = 125;
            this.lblNo.Text = "999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 124;
            this.label1.Text = "Numeros de registros :";
            // 
            // dgwResult
            // 
            this.dgwResult.AllowUserToAddRows = false;
            this.dgwResult.AllowUserToDeleteRows = false;
            this.dgwResult.AllowUserToOrderColumns = true;
            this.dgwResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgwResult.Location = new System.Drawing.Point(5, 238);
            this.dgwResult.MultiSelect = false;
            this.dgwResult.Name = "dgwResult";
            this.dgwResult.ReadOnly = true;
            this.dgwResult.Size = new System.Drawing.Size(952, 260);
            this.dgwResult.TabIndex = 121;
            this.dgwResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwResult_CellContentClick);
            this.dgwResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwResult_CellDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Enviar SUNAT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "ENVIAR";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(382, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 146;
            this.label9.Text = "Turno :";
            // 
            // radmccbTurno
            // 
            this.radmccbTurno.AutoFilter = true;
            // 
            // 
            // 
            this.radmccbTurno.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.radmccbTurno.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmccbTurno.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radmccbTurno.EditorControl.Location = new System.Drawing.Point(437, 65);
            // 
            // 
            // 
            this.radmccbTurno.EditorControl.MasterGridViewTemplate.AllowAddNewRow = false;
            this.radmccbTurno.EditorControl.MasterGridViewTemplate.AllowCellContextMenu = false;
            this.radmccbTurno.EditorControl.MasterGridViewTemplate.AllowColumnChooser = false;
            this.radmccbTurno.EditorControl.MasterGridViewTemplate.EnableFiltering = true;
            this.radmccbTurno.EditorControl.MasterGridViewTemplate.EnableGrouping = false;
            this.radmccbTurno.EditorControl.MasterGridViewTemplate.ShowFilteringRow = false;
            this.radmccbTurno.EditorControl.Name = "NestedRadGridView";
            this.radmccbTurno.EditorControl.ReadOnly = true;
            this.radmccbTurno.EditorControl.ShowGroupPanel = false;
            this.radmccbTurno.EditorControl.TabIndex = 144;
            this.radmccbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmccbTurno.ForeColor = System.Drawing.Color.Black;
            this.radmccbTurno.Location = new System.Drawing.Point(437, 43);
            this.radmccbTurno.Name = "radmccbTurno";
            // 
            // 
            // 
            this.radmccbTurno.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radmccbTurno.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radmccbTurno.Size = new System.Drawing.Size(167, 22);
            this.radmccbTurno.TabIndex = 145;
            // 
            // cbSunat
            // 
            this.cbSunat.AutoSize = true;
            this.cbSunat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSunat.Location = new System.Drawing.Point(385, 119);
            this.cbSunat.Name = "cbSunat";
            this.cbSunat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSunat.Size = new System.Drawing.Size(138, 20);
            this.cbSunat.TabIndex = 149;
            this.cbSunat.Text = "Enviado a SUNAT";
            this.cbSunat.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Image = global::RestaurantNet.RestautantResource.limpiar;
            this.btnClean.Location = new System.Drawing.Point(866, 65);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(91, 54);
            this.btnClean.TabIndex = 126;
            this.btnClean.Text = "Limpiar";
            this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::RestaurantNet.RestautantResource.buscar;
            this.btnSearch.Location = new System.Drawing.Point(866, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 56);
            this.btnSearch.TabIndex = 123;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::RestaurantNet.RestautantResource.salir;
            this.btnClose.Location = new System.Drawing.Point(866, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 84);
            this.btnClose.TabIndex = 122;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBillSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 532);
            this.Controls.Add(this.cbSunat);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipoPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoDoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgwResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radmccbTurno);
            this.Name = "frmBillSearch";
            this.Text = "Busqueda de cuentas pagadas";
            this.Load += new System.EventHandler(this.frmBillSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl.MasterGridViewTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox cbAll;
    private System.Windows.Forms.DateTimePicker dtpFechaFin;
    private System.Windows.Forms.Label lblFechaFin;
    private System.Windows.Forms.DateTimePicker dtpFechaInicio;
    private System.Windows.Forms.Label lblFechaInicio;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnClean;
    private System.Windows.Forms.Label lblNo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnClose;
    public System.Windows.Forms.DataGridView dgwResult;
    private System.Windows.Forms.ComboBox cbTipoDoc;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDocumento;
    private System.Windows.Forms.ComboBox cbTipoPago;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtCliente;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblCodigoCliente;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label9;
    private Telerik.WinControls.UI.RadMultiColumnComboBox radmccbTurno;
    private System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSunat;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}