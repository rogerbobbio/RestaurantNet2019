namespace RestaurantNet
{
  partial class frmSupplier
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
      this.txtDocumento = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.cbEstado = new System.Windows.Forms.ComboBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.txtComentarios = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtFax = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtTelefono = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.lblNombres = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.lblTitulo = new System.Windows.Forms.Label();
      this.txtWeb = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtContacto = new System.Windows.Forms.TextBox();
      this.epRUC = new System.Windows.Forms.ErrorProvider(this.components);
      this.epRazonSocial = new System.Windows.Forms.ErrorProvider(this.components);
      this.epTelefono = new System.Windows.Forms.ErrorProvider(this.components);
      this.epVendedor = new System.Windows.Forms.ErrorProvider(this.components);
      this.label3 = new System.Windows.Forms.Label();
      this.txtDireccion = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.epRUC)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epRazonSocial)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epVendedor)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(297, 12);
      this.btnSave.TabIndex = 10;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(377, 12);
      this.btnClose.TabIndex = 11;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(217, 12);
      // 
      // txtDocumento
      // 
      this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDocumento.Location = new System.Drawing.Point(104, 99);
      this.txtDocumento.MaxLength = 11;
      this.txtDocumento.Name = "txtDocumento";
      this.txtDocumento.Size = new System.Drawing.Size(189, 22);
      this.txtDocumento.TabIndex = 0;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(13, 102);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(43, 16);
      this.label10.TabIndex = 95;
      this.label10.Text = "RUC :";
      // 
      // cbEstado
      // 
      this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEstado.FormattingEnabled = true;
      this.cbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
      this.cbEstado.Location = new System.Drawing.Point(104, 379);
      this.cbEstado.Name = "cbEstado";
      this.cbEstado.Size = new System.Drawing.Size(121, 24);
      this.cbEstado.TabIndex = 7;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(13, 382);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(57, 16);
      this.label12.TabIndex = 93;
      this.label12.Text = "Estado :";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(13, 407);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(90, 16);
      this.label11.TabIndex = 92;
      this.label11.Text = "Comentarios :";
      // 
      // txtComentarios
      // 
      this.txtComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtComentarios.Location = new System.Drawing.Point(16, 426);
      this.txtComentarios.MaxLength = 1000;
      this.txtComentarios.Multiline = true;
      this.txtComentarios.Name = "txtComentarios";
      this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtComentarios.Size = new System.Drawing.Size(397, 83);
      this.txtComentarios.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(247, 216);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(36, 16);
      this.label5.TabIndex = 88;
      this.label5.Text = "Fax :";
      // 
      // txtFax
      // 
      this.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFax.Location = new System.Drawing.Point(289, 213);
      this.txtFax.MaxLength = 50;
      this.txtFax.Name = "txtFax";
      this.txtFax.Size = new System.Drawing.Size(159, 22);
      this.txtFax.TabIndex = 4;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(13, 216);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(68, 16);
      this.label6.TabIndex = 87;
      this.label6.Text = "Telefono :";
      // 
      // txtTelefono
      // 
      this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTelefono.Location = new System.Drawing.Point(104, 213);
      this.txtTelefono.MaxLength = 50;
      this.txtTelefono.Name = "txtTelefono";
      this.txtTelefono.Size = new System.Drawing.Size(132, 22);
      this.txtTelefono.TabIndex = 2;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(13, 348);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 16);
      this.label4.TabIndex = 86;
      this.label4.Text = "Email :";
      // 
      // txtEmail
      // 
      this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEmail.Location = new System.Drawing.Point(104, 347);
      this.txtEmail.MaxLength = 200;
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(290, 22);
      this.txtEmail.TabIndex = 6;
      // 
      // lblNombres
      // 
      this.lblNombres.AutoSize = true;
      this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNombres.Location = new System.Drawing.Point(13, 313);
      this.lblNombres.Name = "lblNombres";
      this.lblNombres.Size = new System.Drawing.Size(43, 16);
      this.lblNombres.TabIndex = 85;
      this.lblNombres.Text = "Web :";
      // 
      // txtNombre
      // 
      this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNombre.Location = new System.Drawing.Point(104, 131);
      this.txtNombre.MaxLength = 100;
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(290, 22);
      this.txtNombre.TabIndex = 1;
      // 
      // lblTitulo
      // 
      this.lblTitulo.AutoSize = true;
      this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitulo.Location = new System.Drawing.Point(12, 134);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(91, 16);
      this.lblTitulo.TabIndex = 84;
      this.lblTitulo.Text = "Razon Social:";
      // 
      // txtWeb
      // 
      this.txtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtWeb.Location = new System.Drawing.Point(104, 310);
      this.txtWeb.MaxLength = 100;
      this.txtWeb.Name = "txtWeb";
      this.txtWeb.Size = new System.Drawing.Size(290, 22);
      this.txtWeb.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 63);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 16);
      this.label1.TabIndex = 83;
      this.label1.Text = "Codigo :";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Enabled = false;
      this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCodigo.Location = new System.Drawing.Point(104, 60);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(100, 22);
      this.txtCodigo.TabIndex = 91;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(13, 248);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 16);
      this.label2.TabIndex = 97;
      this.label2.Text = "Vendedor :";
      // 
      // txtContacto
      // 
      this.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtContacto.Location = new System.Drawing.Point(104, 245);
      this.txtContacto.MaxLength = 100;
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new System.Drawing.Size(290, 22);
      this.txtContacto.TabIndex = 3;
      // 
      // epRUC
      // 
      this.epRUC.ContainerControl = this;
      // 
      // epRazonSocial
      // 
      this.epRazonSocial.ContainerControl = this;
      // 
      // epTelefono
      // 
      this.epTelefono.ContainerControl = this;
      // 
      // epVendedor
      // 
      this.epVendedor.ContainerControl = this;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(13, 165);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 16);
      this.label3.TabIndex = 99;
      this.label3.Text = "Direccion:";
      // 
      // txtDireccion
      // 
      this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDireccion.Location = new System.Drawing.Point(103, 162);
      this.txtDireccion.MaxLength = 2000;
      this.txtDireccion.Multiline = true;
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtDireccion.Size = new System.Drawing.Size(345, 45);
      this.txtDireccion.TabIndex = 98;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(13, 281);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(57, 16);
      this.label7.TabIndex = 101;
      this.label7.Text = "Credito :";
      // 
      // textBox1
      // 
      this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(104, 278);
      this.textBox1.MaxLength = 50;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(66, 22);
      this.textBox1.TabIndex = 100;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(176, 281);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(39, 16);
      this.label8.TabIndex = 102;
      this.label8.Text = "Dias.";
      // 
      // frmSupplier
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(460, 521);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtDireccion);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtContacto);
      this.Controls.Add(this.txtDocumento);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.cbEstado);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.txtComentarios);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtFax);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtTelefono);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.lblNombres);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.lblTitulo);
      this.Controls.Add(this.txtWeb);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCodigo);
      this.Name = "frmSupplier";
      this.Load += new System.EventHandler(this.frmSupplier_Load);
      this.Controls.SetChildIndex(this.btnClose, 0);
      this.Controls.SetChildIndex(this.btnDelete, 0);
      this.Controls.SetChildIndex(this.btnSave, 0);
      this.Controls.SetChildIndex(this.txtCodigo, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.txtWeb, 0);
      this.Controls.SetChildIndex(this.lblTitulo, 0);
      this.Controls.SetChildIndex(this.txtNombre, 0);
      this.Controls.SetChildIndex(this.lblNombres, 0);
      this.Controls.SetChildIndex(this.txtEmail, 0);
      this.Controls.SetChildIndex(this.label4, 0);
      this.Controls.SetChildIndex(this.txtTelefono, 0);
      this.Controls.SetChildIndex(this.label6, 0);
      this.Controls.SetChildIndex(this.txtFax, 0);
      this.Controls.SetChildIndex(this.label5, 0);
      this.Controls.SetChildIndex(this.txtComentarios, 0);
      this.Controls.SetChildIndex(this.label11, 0);
      this.Controls.SetChildIndex(this.label12, 0);
      this.Controls.SetChildIndex(this.cbEstado, 0);
      this.Controls.SetChildIndex(this.label10, 0);
      this.Controls.SetChildIndex(this.txtDocumento, 0);
      this.Controls.SetChildIndex(this.txtContacto, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.txtDireccion, 0);
      this.Controls.SetChildIndex(this.label3, 0);
      this.Controls.SetChildIndex(this.textBox1, 0);
      this.Controls.SetChildIndex(this.label7, 0);
      this.Controls.SetChildIndex(this.label8, 0);
      ((System.ComponentModel.ISupportInitialize)(this.epRUC)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epRazonSocial)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epVendedor)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtDocumento;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox cbEstado;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtComentarios;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtFax;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblNombres;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.TextBox txtWeb;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtContacto;
    private System.Windows.Forms.ErrorProvider epRUC;
    private System.Windows.Forms.ErrorProvider epRazonSocial;
    private System.Windows.Forms.ErrorProvider epTelefono;
    private System.Windows.Forms.ErrorProvider epVendedor;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDireccion;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label8;
  }
}
