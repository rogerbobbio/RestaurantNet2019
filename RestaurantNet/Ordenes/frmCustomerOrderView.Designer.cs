namespace RestaurantNet
{
  partial class frmCustomerOrderView
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
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.lblOrdenOrigenValue = new System.Windows.Forms.Label();
      this.lblOrdenOrigen = new System.Windows.Forms.Label();
      this.lblEstado = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblTurnoEstadoTexto = new System.Windows.Forms.Label();
      this.lblTurnoEstado = new System.Windows.Forms.Label();
      this.lblTurno = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.lblTipoOrden = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lblEmployee = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.dgwCuenta = new System.Windows.Forms.DataGridView();
      this.LINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PRECIO_FINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnClose = new System.Windows.Forms.Button();
      this.txtComentarios = new System.Windows.Forms.TextBox();
      this.lblTipoMotivo = new System.Windows.Forms.Label();
      this.lblFechaAnulacion = new System.Windows.Forms.Label();
      this.lblFecha = new System.Windows.Forms.Label();
      this.btnReprint = new System.Windows.Forms.Button();
      this.lblVentaNo = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwCuenta)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.lblVentaNo);
      this.groupBox4.Controls.Add(this.label4);
      this.groupBox4.Controls.Add(this.lblOrdenOrigenValue);
      this.groupBox4.Controls.Add(this.lblOrdenOrigen);
      this.groupBox4.Controls.Add(this.lblEstado);
      this.groupBox4.Controls.Add(this.label2);
      this.groupBox4.Controls.Add(this.lblTurnoEstadoTexto);
      this.groupBox4.Controls.Add(this.lblTurnoEstado);
      this.groupBox4.Controls.Add(this.lblTurno);
      this.groupBox4.Controls.Add(this.label9);
      this.groupBox4.Controls.Add(this.lblTipoOrden);
      this.groupBox4.Controls.Add(this.label1);
      this.groupBox4.Controls.Add(this.lblEmployee);
      this.groupBox4.Controls.Add(this.label6);
      this.groupBox4.Location = new System.Drawing.Point(12, 12);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(853, 105);
      this.groupBox4.TabIndex = 108;
      this.groupBox4.TabStop = false;
      // 
      // lblOrdenOrigenValue
      // 
      this.lblOrdenOrigenValue.AutoSize = true;
      this.lblOrdenOrigenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOrdenOrigenValue.Location = new System.Drawing.Point(561, 16);
      this.lblOrdenOrigenValue.Name = "lblOrdenOrigenValue";
      this.lblOrdenOrigenValue.Size = new System.Drawing.Size(29, 16);
      this.lblOrdenOrigenValue.TabIndex = 120;
      this.lblOrdenOrigenValue.Text = "999";
      this.lblOrdenOrigenValue.Visible = false;
      // 
      // lblOrdenOrigen
      // 
      this.lblOrdenOrigen.AutoSize = true;
      this.lblOrdenOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOrdenOrigen.Location = new System.Drawing.Point(466, 16);
      this.lblOrdenOrigen.Name = "lblOrdenOrigen";
      this.lblOrdenOrigen.Size = new System.Drawing.Size(91, 16);
      this.lblOrdenOrigen.TabIndex = 119;
      this.lblOrdenOrigen.Text = "Orden Origen:";
      this.lblOrdenOrigen.Visible = false;
      // 
      // lblEstado
      // 
      this.lblEstado.AutoSize = true;
      this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEstado.ForeColor = System.Drawing.Color.Red;
      this.lblEstado.Location = new System.Drawing.Point(141, 16);
      this.lblEstado.Name = "lblEstado";
      this.lblEstado.Size = new System.Drawing.Size(128, 16);
      this.lblEstado.TabIndex = 118;
      this.lblEstado.Text = "ORDEN ESTADO";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(8, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(127, 16);
      this.label2.TabIndex = 117;
      this.label2.Text = "Estado de la Orden:";
      // 
      // lblTurnoEstadoTexto
      // 
      this.lblTurnoEstadoTexto.AutoSize = true;
      this.lblTurnoEstadoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTurnoEstadoTexto.ForeColor = System.Drawing.Color.Red;
      this.lblTurnoEstadoTexto.Location = new System.Drawing.Point(584, 70);
      this.lblTurnoEstadoTexto.Name = "lblTurnoEstadoTexto";
      this.lblTurnoEstadoTexto.Size = new System.Drawing.Size(128, 16);
      this.lblTurnoEstadoTexto.TabIndex = 116;
      this.lblTurnoEstadoTexto.Text = "ESTADO TURNO";
      this.lblTurnoEstadoTexto.Visible = false;
      // 
      // lblTurnoEstado
      // 
      this.lblTurnoEstado.AutoSize = true;
      this.lblTurnoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTurnoEstado.Location = new System.Drawing.Point(466, 70);
      this.lblTurnoEstado.Name = "lblTurnoEstado";
      this.lblTurnoEstado.Size = new System.Drawing.Size(109, 16);
      this.lblTurnoEstado.TabIndex = 115;
      this.lblTurnoEstado.Text = "Turno Estado :";
      this.lblTurnoEstado.Visible = false;
      // 
      // lblTurno
      // 
      this.lblTurno.AutoSize = true;
      this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTurno.Location = new System.Drawing.Point(609, 43);
      this.lblTurno.Name = "lblTurno";
      this.lblTurno.Size = new System.Drawing.Size(29, 16);
      this.lblTurno.TabIndex = 112;
      this.lblTurno.Text = "999";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(466, 43);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(141, 16);
      this.label9.TabIndex = 111;
      this.label9.Text = "Turno de la Orden :";
      // 
      // lblTipoOrden
      // 
      this.lblTipoOrden.AutoSize = true;
      this.lblTipoOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTipoOrden.ForeColor = System.Drawing.Color.Red;
      this.lblTipoOrden.Location = new System.Drawing.Point(93, 70);
      this.lblTipoOrden.Name = "lblTipoOrden";
      this.lblTipoOrden.Size = new System.Drawing.Size(43, 16);
      this.lblTipoOrden.TabIndex = 110;
      this.lblTipoOrden.Text = "TIPO";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(6, 70);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(82, 16);
      this.label1.TabIndex = 109;
      this.label1.Text = "Tipo Orden :";
      // 
      // lblEmployee
      // 
      this.lblEmployee.AutoSize = true;
      this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEmployee.Location = new System.Drawing.Point(96, 43);
      this.lblEmployee.Name = "lblEmployee";
      this.lblEmployee.Size = new System.Drawing.Size(90, 16);
      this.lblEmployee.TabIndex = 108;
      this.lblEmployee.Text = "EMPLEADO";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(6, 43);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(87, 16);
      this.label6.TabIndex = 107;
      this.label6.Text = "Atentido Por :";
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DESCUENTO,
            this.PRECIO_FINAL});
      this.dgwCuenta.Location = new System.Drawing.Point(12, 123);
      this.dgwCuenta.MultiSelect = false;
      this.dgwCuenta.Name = "dgwCuenta";
      this.dgwCuenta.ReadOnly = true;
      this.dgwCuenta.Size = new System.Drawing.Size(451, 399);
      this.dgwCuenta.TabIndex = 109;
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
      this.CODIGO.Visible = false;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "PROD. DESCRIPCION";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn2.Width = 250;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "CANTIDAD";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn3.Width = 50;
      // 
      // DESCUENTO
      // 
      this.DESCUENTO.HeaderText = "DESCT%";
      this.DESCUENTO.Name = "DESCUENTO";
      this.DESCUENTO.ReadOnly = true;
      this.DESCUENTO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.DESCUENTO.Width = 50;
      // 
      // PRECIO_FINAL
      // 
      this.PRECIO_FINAL.HeaderText = "PRECIO";
      this.PRECIO_FINAL.Name = "PRECIO_FINAL";
      this.PRECIO_FINAL.ReadOnly = true;
      this.PRECIO_FINAL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.PRECIO_FINAL.Visible = false;
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.salir;
      this.btnClose.Location = new System.Drawing.Point(751, 439);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(114, 83);
      this.btnClose.TabIndex = 110;
      this.btnClose.Text = "Salir ";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // txtComentarios
      // 
      this.txtComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtComentarios.Location = new System.Drawing.Point(481, 187);
      this.txtComentarios.MaxLength = 1000;
      this.txtComentarios.Multiline = true;
      this.txtComentarios.Name = "txtComentarios";
      this.txtComentarios.ReadOnly = true;
      this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtComentarios.Size = new System.Drawing.Size(384, 246);
      this.txtComentarios.TabIndex = 111;
      // 
      // lblTipoMotivo
      // 
      this.lblTipoMotivo.AutoSize = true;
      this.lblTipoMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTipoMotivo.Location = new System.Drawing.Point(481, 166);
      this.lblTipoMotivo.Name = "lblTipoMotivo";
      this.lblTipoMotivo.Size = new System.Drawing.Size(171, 18);
      this.lblTipoMotivo.TabIndex = 112;
      this.lblTipoMotivo.Text = "Motivos de la anulacion :";
      // 
      // lblFechaAnulacion
      // 
      this.lblFechaAnulacion.AutoSize = true;
      this.lblFechaAnulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFechaAnulacion.Location = new System.Drawing.Point(656, 137);
      this.lblFechaAnulacion.Name = "lblFechaAnulacion";
      this.lblFechaAnulacion.Size = new System.Drawing.Size(133, 16);
      this.lblFechaAnulacion.TabIndex = 116;
      this.lblFechaAnulacion.Text = "FECHA ANULACION";
      // 
      // lblFecha
      // 
      this.lblFecha.AutoSize = true;
      this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFecha.Location = new System.Drawing.Point(480, 137);
      this.lblFecha.Name = "lblFecha";
      this.lblFecha.Size = new System.Drawing.Size(170, 16);
      this.lblFecha.TabIndex = 115;
      this.lblFecha.Text = "Fecha de la Anulacion :";
      // 
      // btnReprint
      // 
      this.btnReprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReprint.Location = new System.Drawing.Point(599, 439);
      this.btnReprint.Name = "btnReprint";
      this.btnReprint.Size = new System.Drawing.Size(140, 83);
      this.btnReprint.TabIndex = 117;
      this.btnReprint.Text = "Re-Imprimir Cuenta";
      this.btnReprint.UseVisualStyleBackColor = true;
      this.btnReprint.Click += new System.EventHandler(this.btnReprint_Click);
      // 
      // lblVentaNo
      // 
      this.lblVentaNo.AutoSize = true;
      this.lblVentaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVentaNo.Location = new System.Drawing.Point(793, 16);
      this.lblVentaNo.Name = "lblVentaNo";
      this.lblVentaNo.Size = new System.Drawing.Size(29, 16);
      this.lblVentaNo.TabIndex = 122;
      this.lblVentaNo.Text = "999";
      this.lblVentaNo.Visible = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(720, 16);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(67, 16);
      this.label4.TabIndex = 121;
      this.label4.Text = "Venta No:";
      this.label4.Visible = false;
      // 
      // frmCustomerOrderView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(875, 534);
      this.Controls.Add(this.btnReprint);
      this.Controls.Add(this.lblFechaAnulacion);
      this.Controls.Add(this.lblFecha);
      this.Controls.Add(this.txtComentarios);
      this.Controls.Add(this.lblTipoMotivo);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.dgwCuenta);
      this.Controls.Add(this.groupBox4);
      this.Name = "frmCustomerOrderView";
      this.Text = "Restaurant Net - Ver Orden";
      this.Load += new System.EventHandler(this.frmCustomerOrderView_Load);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwCuenta)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label lblEstado;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblTurnoEstadoTexto;
    private System.Windows.Forms.Label lblTurnoEstado;
    private System.Windows.Forms.Label lblTurno;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblTipoOrden;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblEmployee;
    private System.Windows.Forms.Label label6;
    public System.Windows.Forms.DataGridView dgwCuenta;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TextBox txtComentarios;
    private System.Windows.Forms.Label lblTipoMotivo;
    private System.Windows.Forms.Label lblFechaAnulacion;
    private System.Windows.Forms.Label lblFecha;
    private System.Windows.Forms.Label lblOrdenOrigenValue;
    private System.Windows.Forms.Label lblOrdenOrigen;
    private System.Windows.Forms.DataGridViewTextBoxColumn LINEA;
    private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTO;
    private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_FINAL;
    private System.Windows.Forms.Button btnReprint;
    private System.Windows.Forms.Label lblVentaNo;
    private System.Windows.Forms.Label label4;
  }
}