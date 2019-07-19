namespace RestaurantNet
{
  partial class frmMovements
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.rbtnRetiro = new Telerik.WinControls.UI.RadRadioButton();
      this.rbtnDeposito = new Telerik.WinControls.UI.RadRadioButton();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblTurnoFecha = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.lblTurno = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.gbEstaciones = new System.Windows.Forms.GroupBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.txtConcepto = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtReferencia = new System.Windows.Forms.TextBox();
      this.lblTitulo = new System.Windows.Forms.Label();
      this.dgwCuenta = new System.Windows.Forms.DataGridView();
      this.Movimiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Tipo_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ImporteNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label3 = new System.Windows.Forms.Label();
      this.txtImporte = new System.Windows.Forms.TextBox();
      this.btnAddCargo = new System.Windows.Forms.Button();
      this.cbEstacion = new System.Windows.Forms.ComboBox();
      this.label13 = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.epEstacion = new System.Windows.Forms.ErrorProvider(this.components);
      this.epConcepto = new System.Windows.Forms.ErrorProvider(this.components);
      this.epImporte = new System.Windows.Forms.ErrorProvider(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.txtRetiro = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDepositro = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.rbtnRetiro)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbtnDeposito)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.gbEstaciones.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwCuenta)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epEstacion)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epConcepto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epImporte)).BeginInit();
      this.SuspendLayout();
      // 
      // rbtnRetiro
      // 
      this.rbtnRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbtnRetiro.Location = new System.Drawing.Point(20, 21);
      this.rbtnRetiro.Name = "rbtnRetiro";
      this.rbtnRetiro.Size = new System.Drawing.Size(82, 18);
      this.rbtnRetiro.TabIndex = 0;
      this.rbtnRetiro.Text = "RETIRO";
      this.rbtnRetiro.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
      // 
      // rbtnDeposito
      // 
      this.rbtnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbtnDeposito.Location = new System.Drawing.Point(108, 21);
      this.rbtnDeposito.Name = "rbtnDeposito";
      this.rbtnDeposito.Size = new System.Drawing.Size(93, 18);
      this.rbtnDeposito.TabIndex = 1;
      this.rbtnDeposito.Text = "DEPOSITO";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rbtnRetiro);
      this.groupBox1.Controls.Add(this.rbtnDeposito);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(215, 53);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tipo";
      // 
      // lblTurnoFecha
      // 
      this.lblTurnoFecha.AutoSize = true;
      this.lblTurnoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTurnoFecha.Location = new System.Drawing.Point(153, 32);
      this.lblTurnoFecha.Name = "lblTurnoFecha";
      this.lblTurnoFecha.Size = new System.Drawing.Size(105, 16);
      this.lblTurnoFecha.TabIndex = 107;
      this.lblTurnoFecha.Text = "FECHA TURNO";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(6, 32);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(141, 16);
      this.label11.TabIndex = 106;
      this.label11.Text = "Apertura de Turno :";
      // 
      // lblTurno
      // 
      this.lblTurno.AutoSize = true;
      this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTurno.Location = new System.Drawing.Point(153, 16);
      this.lblTurno.Name = "lblTurno";
      this.lblTurno.Size = new System.Drawing.Size(113, 16);
      this.lblTurno.TabIndex = 105;
      this.lblTurno.Text = "TURNO ACTUAL";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(6, 16);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(103, 16);
      this.label9.TabIndex = 104;
      this.label9.Text = "Turno Actual :";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label9);
      this.groupBox2.Controls.Add(this.lblTurnoFecha);
      this.groupBox2.Controls.Add(this.lblTurno);
      this.groupBox2.Controls.Add(this.label11);
      this.groupBox2.Location = new System.Drawing.Point(233, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(395, 53);
      this.groupBox2.TabIndex = 108;
      this.groupBox2.TabStop = false;
      // 
      // gbEstaciones
      // 
      this.gbEstaciones.Controls.Add(this.btnDelete);
      this.gbEstaciones.Controls.Add(this.txtConcepto);
      this.gbEstaciones.Controls.Add(this.label10);
      this.gbEstaciones.Controls.Add(this.txtReferencia);
      this.gbEstaciones.Controls.Add(this.lblTitulo);
      this.gbEstaciones.Controls.Add(this.dgwCuenta);
      this.gbEstaciones.Controls.Add(this.label3);
      this.gbEstaciones.Controls.Add(this.txtImporte);
      this.gbEstaciones.Controls.Add(this.btnAddCargo);
      this.gbEstaciones.Controls.Add(this.cbEstacion);
      this.gbEstaciones.Controls.Add(this.label13);
      this.gbEstaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbEstaciones.Location = new System.Drawing.Point(12, 71);
      this.gbEstaciones.Name = "gbEstaciones";
      this.gbEstaciones.Size = new System.Drawing.Size(616, 358);
      this.gbEstaciones.TabIndex = 109;
      this.gbEstaciones.TabStop = false;
      this.gbEstaciones.Text = "Detalle de Caja";
      // 
      // btnDelete
      // 
      this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.Image = global::RestaurantNet.RestautantResource.eliminar;
      this.btnDelete.Location = new System.Drawing.Point(480, 71);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(128, 54);
      this.btnDelete.TabIndex = 100;
      this.btnDelete.Text = "Eliminar";
      this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // txtConcepto
      // 
      this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtConcepto.Location = new System.Drawing.Point(115, 53);
      this.txtConcepto.MaxLength = 100;
      this.txtConcepto.Name = "txtConcepto";
      this.txtConcepto.Size = new System.Drawing.Size(290, 22);
      this.txtConcepto.TabIndex = 1;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(18, 56);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(72, 16);
      this.label10.TabIndex = 99;
      this.label10.Text = "Concepto :";
      // 
      // txtReferencia
      // 
      this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtReferencia.Location = new System.Drawing.Point(115, 78);
      this.txtReferencia.MaxLength = 100;
      this.txtReferencia.Name = "txtReferencia";
      this.txtReferencia.Size = new System.Drawing.Size(290, 22);
      this.txtReferencia.TabIndex = 2;
      // 
      // lblTitulo
      // 
      this.lblTitulo.AutoSize = true;
      this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitulo.Location = new System.Drawing.Point(18, 81);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(80, 16);
      this.lblTitulo.TabIndex = 98;
      this.lblTitulo.Text = "Referencia :";
      // 
      // dgwCuenta
      // 
      this.dgwCuenta.AllowUserToAddRows = false;
      this.dgwCuenta.AllowUserToDeleteRows = false;
      this.dgwCuenta.AllowUserToOrderColumns = true;
      this.dgwCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgwCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movimiento_id,
            this.Tipo_movimiento,
            this.Concepto,
            this.ImporteNeto,
            this.Fecha_creacion});
      this.dgwCuenta.Location = new System.Drawing.Point(6, 131);
      this.dgwCuenta.MultiSelect = false;
      this.dgwCuenta.Name = "dgwCuenta";
      this.dgwCuenta.ReadOnly = true;
      this.dgwCuenta.Size = new System.Drawing.Size(602, 221);
      this.dgwCuenta.TabIndex = 51;
      // 
      // Movimiento_id
      // 
      this.Movimiento_id.HeaderText = "Movimiento_id";
      this.Movimiento_id.Name = "Movimiento_id";
      this.Movimiento_id.ReadOnly = true;
      this.Movimiento_id.Visible = false;
      // 
      // Tipo_movimiento
      // 
      this.Tipo_movimiento.HeaderText = "Tipo Movimiento";
      this.Tipo_movimiento.Name = "Tipo_movimiento";
      this.Tipo_movimiento.ReadOnly = true;
      // 
      // Concepto
      // 
      this.Concepto.HeaderText = "Concepto";
      this.Concepto.Name = "Concepto";
      this.Concepto.ReadOnly = true;
      this.Concepto.Width = 200;
      // 
      // ImporteNeto
      // 
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.ImporteNeto.DefaultCellStyle = dataGridViewCellStyle1;
      this.ImporteNeto.HeaderText = "Importe";
      this.ImporteNeto.Name = "ImporteNeto";
      this.ImporteNeto.ReadOnly = true;
      // 
      // Fecha_creacion
      // 
      this.Fecha_creacion.HeaderText = "Realizado el";
      this.Fecha_creacion.Name = "Fecha_creacion";
      this.Fecha_creacion.ReadOnly = true;
      this.Fecha_creacion.Width = 150;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(18, 108);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(59, 16);
      this.label3.TabIndex = 50;
      this.label3.Text = "Importe :";
      // 
      // txtImporte
      // 
      this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtImporte.Location = new System.Drawing.Point(115, 103);
      this.txtImporte.Name = "txtImporte";
      this.txtImporte.Size = new System.Drawing.Size(100, 22);
      this.txtImporte.TabIndex = 3;
      // 
      // btnAddCargo
      // 
      this.btnAddCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnAddCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddCargo.Image = global::RestaurantNet.RestautantResource.nuevo;
      this.btnAddCargo.Location = new System.Drawing.Point(480, 11);
      this.btnAddCargo.Name = "btnAddCargo";
      this.btnAddCargo.Size = new System.Drawing.Size(128, 54);
      this.btnAddCargo.TabIndex = 4;
      this.btnAddCargo.Text = "Agregar";
      this.btnAddCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnAddCargo.UseVisualStyleBackColor = false;
      this.btnAddCargo.Click += new System.EventHandler(this.btnAddCargo_Click);
      // 
      // cbEstacion
      // 
      this.cbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEstacion.FormattingEnabled = true;
      this.cbEstacion.Location = new System.Drawing.Point(115, 24);
      this.cbEstacion.MaxLength = 20;
      this.cbEstacion.Name = "cbEstacion";
      this.cbEstacion.Size = new System.Drawing.Size(211, 24);
      this.cbEstacion.TabIndex = 0;
      this.cbEstacion.SelectedIndexChanged += new System.EventHandler(this.cbEstacion_SelectedIndexChanged);
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(18, 27);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(66, 16);
      this.label13.TabIndex = 48;
      this.label13.Text = "Estacion :";
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.home;
      this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnClose.Location = new System.Drawing.Point(499, 448);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(129, 57);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Menu Principal";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // epEstacion
      // 
      this.epEstacion.ContainerControl = this;
      // 
      // epConcepto
      // 
      this.epConcepto.ContainerControl = this;
      // 
      // epImporte
      // 
      this.epImporte.ContainerControl = this;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(251, 486);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(107, 16);
      this.label1.TabIndex = 110;
      this.label1.Text = "Total General:";
      // 
      // txtTotal
      // 
      this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTotal.Location = new System.Drawing.Point(364, 483);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new System.Drawing.Size(100, 22);
      this.txtTotal.TabIndex = 111;
      this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtRetiro
      // 
      this.txtRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRetiro.Location = new System.Drawing.Point(364, 429);
      this.txtRetiro.Name = "txtRetiro";
      this.txtRetiro.Size = new System.Drawing.Size(100, 22);
      this.txtRetiro.TabIndex = 113;
      this.txtRetiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(264, 432);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(94, 16);
      this.label2.TabIndex = 112;
      this.label2.Text = "Total Retiro:";
      // 
      // txtDepositro
      // 
      this.txtDepositro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDepositro.Location = new System.Drawing.Point(364, 455);
      this.txtDepositro.Name = "txtDepositro";
      this.txtDepositro.Size = new System.Drawing.Size(100, 22);
      this.txtDepositro.TabIndex = 115;
      this.txtDepositro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(243, 458);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(115, 16);
      this.label4.TabIndex = 114;
      this.label4.Text = "Total Deposito:";      
      // 
      // frmMovements
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 509);
      this.Controls.Add(this.txtDepositro);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtRetiro);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtTotal);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.gbEstaciones);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnClose);      
      this.Name = "frmMovements";
      this.Text = "Depositos y Retiros de efectivo en Caja";
      this.Load += new System.EventHandler(this.frmMovements_Load);
      ((System.ComponentModel.ISupportInitialize)(this.rbtnRetiro)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbtnDeposito)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.gbEstaciones.ResumeLayout(false);
      this.gbEstaciones.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwCuenta)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epEstacion)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epConcepto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epImporte)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Telerik.WinControls.UI.RadRadioButton rbtnRetiro;
    private Telerik.WinControls.UI.RadRadioButton rbtnDeposito;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lblTurnoFecha;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label lblTurno;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox gbEstaciones;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtImporte;
    private System.Windows.Forms.Button btnAddCargo;
    private System.Windows.Forms.ComboBox cbEstacion;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TextBox txtConcepto;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtReferencia;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.ErrorProvider epEstacion;
    private System.Windows.Forms.ErrorProvider epConcepto;
    private System.Windows.Forms.ErrorProvider epImporte;
    private System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnDelete;
    public System.Windows.Forms.DataGridView dgwCuenta;
    private System.Windows.Forms.DataGridViewTextBoxColumn Movimiento_id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_movimiento;
    private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
    private System.Windows.Forms.DataGridViewTextBoxColumn ImporteNeto;
    private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_creacion;
    private System.Windows.Forms.TextBox txtDepositro;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtRetiro;
    private System.Windows.Forms.Label label2;    
  }
}