namespace RestaurantNet
{
  partial class frmDelivery
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
      this.lblTipo = new System.Windows.Forms.Label();
      this.dgwCuenta = new System.Windows.Forms.DataGridView();
      this.PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtNumeroCliente = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblCodigoCliente = new System.Windows.Forms.Label();
      this.btnAddOrder = new System.Windows.Forms.Button();
      this.gbType = new System.Windows.Forms.GroupBox();
      this.rbPickup = new System.Windows.Forms.RadioButton();
      this.rbDelivery = new System.Windows.Forms.RadioButton();
      this.btnClose = new System.Windows.Forms.Button();
      this.lblNombreCliente = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnEdit = new System.Windows.Forms.Button();
      this.lblDireccion = new System.Windows.Forms.Label();
      this.txtDireccion = new System.Windows.Forms.TextBox();
      this.btnSearchProduct = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgwCuenta)).BeginInit();
      this.gbType.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTipo
      // 
      this.lblTipo.AutoSize = true;
      this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTipo.Location = new System.Drawing.Point(12, 23);
      this.lblTipo.Name = "lblTipo";
      this.lblTipo.Size = new System.Drawing.Size(169, 18);
      this.lblTipo.TabIndex = 26;
      this.lblTipo.Text = "Pedidos en proceso :";
      // 
      // dgwCuenta
      // 
      this.dgwCuenta.AllowUserToAddRows = false;
      this.dgwCuenta.AllowUserToDeleteRows = false;
      this.dgwCuenta.AllowUserToOrderColumns = true;
      this.dgwCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgwCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PEDIDO,
            this.TURNO,
            this.HORA,
            this.CLIENTE,
            this.TELEFONO,
            this.TIPO,
            this.DIRECCION});
      this.dgwCuenta.Location = new System.Drawing.Point(10, 51);
      this.dgwCuenta.MultiSelect = false;
      this.dgwCuenta.Name = "dgwCuenta";
      this.dgwCuenta.ReadOnly = true;
      this.dgwCuenta.Size = new System.Drawing.Size(868, 323);
      this.dgwCuenta.TabIndex = 4;
      this.dgwCuenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCuenta_CellDoubleClick);
      // 
      // PEDIDO
      // 
      this.PEDIDO.HeaderText = "PEDIDO";
      this.PEDIDO.Name = "PEDIDO";
      this.PEDIDO.ReadOnly = true;
      this.PEDIDO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.PEDIDO.Width = 50;
      // 
      // TURNO
      // 
      this.TURNO.HeaderText = "TURNO";
      this.TURNO.Name = "TURNO";
      this.TURNO.ReadOnly = true;
      this.TURNO.Width = 50;
      // 
      // HORA
      // 
      this.HORA.HeaderText = "HORA";
      this.HORA.Name = "HORA";
      this.HORA.ReadOnly = true;
      this.HORA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // CLIENTE
      // 
      this.CLIENTE.HeaderText = "CLIENTE";
      this.CLIENTE.Name = "CLIENTE";
      this.CLIENTE.ReadOnly = true;
      this.CLIENTE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.CLIENTE.Width = 250;
      // 
      // TELEFONO
      // 
      this.TELEFONO.HeaderText = "TELEFONO";
      this.TELEFONO.Name = "TELEFONO";
      this.TELEFONO.ReadOnly = true;
      this.TELEFONO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.TELEFONO.Width = 70;
      // 
      // TIPO
      // 
      this.TIPO.HeaderText = "TIPO";
      this.TIPO.Name = "TIPO";
      this.TIPO.ReadOnly = true;
      this.TIPO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // DIRECCION
      // 
      this.DIRECCION.HeaderText = "DIRECCION";
      this.DIRECCION.Name = "DIRECCION";
      this.DIRECCION.ReadOnly = true;
      this.DIRECCION.Width = 200;
      // 
      // txtNumeroCliente
      // 
      this.txtNumeroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNumeroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNumeroCliente.Location = new System.Drawing.Point(134, 422);
      this.txtNumeroCliente.MaxLength = 100;
      this.txtNumeroCliente.Name = "txtNumeroCliente";
      this.txtNumeroCliente.Size = new System.Drawing.Size(140, 22);
      this.txtNumeroCliente.TabIndex = 0;
      this.txtNumeroCliente.DoubleClick += new System.EventHandler(this.txtCliente_DoubleClick);
      this.txtNumeroCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 483);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 16);
      this.label1.TabIndex = 84;
      this.label1.Text = "Cliente (Apellido) :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 457);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(102, 16);
      this.label2.TabIndex = 85;
      this.label2.Text = "Codigo Cliente :";
      // 
      // lblCodigoCliente
      // 
      this.lblCodigoCliente.AutoSize = true;
      this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCodigoCliente.Location = new System.Drawing.Point(121, 457);
      this.lblCodigoCliente.Name = "lblCodigoCliente";
      this.lblCodigoCliente.Size = new System.Drawing.Size(40, 16);
      this.lblCodigoCliente.TabIndex = 86;
      this.lblCodigoCliente.Text = "0001";
      // 
      // btnAddOrder
      // 
      this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddOrder.Image = global::RestaurantNet.RestautantResource.nuevo;
      this.btnAddOrder.Location = new System.Drawing.Point(633, 483);
      this.btnAddOrder.Name = "btnAddOrder";
      this.btnAddOrder.Size = new System.Drawing.Size(114, 82);
      this.btnAddOrder.TabIndex = 2;
      this.btnAddOrder.Text = "Agregar Orden";
      this.btnAddOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnAddOrder.UseVisualStyleBackColor = false;
      this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
      // 
      // gbType
      // 
      this.gbType.Controls.Add(this.rbPickup);
      this.gbType.Controls.Add(this.rbDelivery);
      this.gbType.Location = new System.Drawing.Point(10, 380);
      this.gbType.Name = "gbType";
      this.gbType.Size = new System.Drawing.Size(264, 36);
      this.gbType.TabIndex = 1;
      this.gbType.TabStop = false;
      // 
      // rbPickup
      // 
      this.rbPickup.AutoSize = true;
      this.rbPickup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbPickup.Location = new System.Drawing.Point(144, 13);
      this.rbPickup.Name = "rbPickup";
      this.rbPickup.Size = new System.Drawing.Size(93, 20);
      this.rbPickup.TabIndex = 1;
      this.rbPickup.Text = "RECOGER";
      this.rbPickup.UseVisualStyleBackColor = true;
      // 
      // rbDelivery
      // 
      this.rbDelivery.AutoSize = true;
      this.rbDelivery.Checked = true;
      this.rbDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbDelivery.Location = new System.Drawing.Point(27, 13);
      this.rbDelivery.Name = "rbDelivery";
      this.rbDelivery.Size = new System.Drawing.Size(92, 20);
      this.rbDelivery.TabIndex = 0;
      this.rbDelivery.TabStop = true;
      this.rbDelivery.Text = "DELIVERY";
      this.rbDelivery.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.home;
      this.btnClose.Location = new System.Drawing.Point(753, 483);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(116, 82);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Menu Principal";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // lblNombreCliente
      // 
      this.lblNombreCliente.AutoSize = true;
      this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNombreCliente.Location = new System.Drawing.Point(131, 483);
      this.lblNombreCliente.Name = "lblNombreCliente";
      this.lblNombreCliente.Size = new System.Drawing.Size(140, 16);
      this.lblNombreCliente.TabIndex = 91;
      this.lblNombreCliente.Text = "NOMBRE CLIENTE";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 425);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(112, 16);
      this.label4.TabIndex = 90;
      this.label4.Text = "Telefono Cliente :";
      // 
      // btnEdit
      // 
      this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEdit.Location = new System.Drawing.Point(293, 403);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(81, 41);
      this.btnEdit.TabIndex = 92;
      this.btnEdit.Text = "Editar Cliente";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // lblDireccion
      // 
      this.lblDireccion.AutoSize = true;
      this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDireccion.Location = new System.Drawing.Point(13, 513);
      this.lblDireccion.Name = "lblDireccion";
      this.lblDireccion.Size = new System.Drawing.Size(71, 16);
      this.lblDireccion.TabIndex = 93;
      this.lblDireccion.Text = "Direccion :";
      // 
      // txtDireccion
      // 
      this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDireccion.Location = new System.Drawing.Point(90, 510);
      this.txtDireccion.MaxLength = 200;
      this.txtDireccion.Multiline = true;
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.ReadOnly = true;
      this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtDireccion.Size = new System.Drawing.Size(317, 55);
      this.txtDireccion.TabIndex = 94;
      // 
      // btnSearchProduct
      // 
      this.btnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearchProduct.Image = global::RestaurantNet.RestautantResource.clientes;
      this.btnSearchProduct.Location = new System.Drawing.Point(380, 403);
      this.btnSearchProduct.Name = "btnSearchProduct";
      this.btnSearchProduct.Size = new System.Drawing.Size(120, 41);
      this.btnSearchProduct.TabIndex = 107;
      this.btnSearchProduct.Text = "Lista Clientes";
      this.btnSearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnSearchProduct.UseVisualStyleBackColor = true;
      this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
      // 
      // frmDelivery
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(881, 577);
      this.Controls.Add(this.btnSearchProduct);
      this.Controls.Add(this.txtDireccion);
      this.Controls.Add(this.lblDireccion);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.lblNombreCliente);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.gbType);
      this.Controls.Add(this.btnAddOrder);
      this.Controls.Add(this.lblCodigoCliente);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtNumeroCliente);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgwCuenta);
      this.Controls.Add(this.lblTipo);
      this.Name = "frmDelivery";
      this.Text = "Restaurant Net - Para Llevar";
      this.Load += new System.EventHandler(this.frmDelivery_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgwCuenta)).EndInit();
      this.gbType.ResumeLayout(false);
      this.gbType.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTipo;
    public System.Windows.Forms.DataGridView dgwCuenta;
    private System.Windows.Forms.TextBox txtNumeroCliente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblCodigoCliente;
    private System.Windows.Forms.Button btnAddOrder;
    private System.Windows.Forms.GroupBox gbType;
    private System.Windows.Forms.RadioButton rbDelivery;
    private System.Windows.Forms.RadioButton rbPickup;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblNombreCliente;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Label lblDireccion;
    private System.Windows.Forms.TextBox txtDireccion;
    private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDO;
    private System.Windows.Forms.DataGridViewTextBoxColumn TURNO;
    private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
    private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
    private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
    private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
    private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
    private System.Windows.Forms.Button btnSearchProduct;
  }
}