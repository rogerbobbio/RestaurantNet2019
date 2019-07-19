namespace RestaurantNet
{
  partial class frmCustomer
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
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.cbEmail = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTrabajo = new System.Windows.Forms.TextBox();
            this.epRUC = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNombres = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epRUC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(287, 12);
            this.btnSave.TabIndex = 14;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(367, 12);
            this.btnClose.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(207, 12);
            this.btnDelete.TabIndex = 13;
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmail.Location = new System.Drawing.Point(327, 375);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(75, 27);
            this.btnAddEmail.TabIndex = 9;
            this.btnAddEmail.Text = "Agregar";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // cbEmail
            // 
            this.cbEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmail.FormattingEnabled = true;
            this.cbEmail.Location = new System.Drawing.Point(112, 378);
            this.cbEmail.MaxLength = 20;
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(211, 24);
            this.cbEmail.TabIndex = 8;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbEstado.Location = new System.Drawing.Point(112, 414);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 64;
            this.label12.Text = "Estado :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Comentarios :";
            // 
            // txtComentarios
            // 
            this.txtComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentarios.Location = new System.Drawing.Point(15, 467);
            this.txtComentarios.MaxLength = 1000;
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentarios.Size = new System.Drawing.Size(397, 83);
            this.txtComentarios.TabIndex = 12;
            this.txtComentarios.DoubleClick += new System.EventHandler(this.txtComentarios_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Celular :";
            // 
            // txtCelular
            // 
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(112, 310);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(132, 22);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.DoubleClick += new System.EventHandler(this.txtCelular_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Telefono :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(112, 276);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 22);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.DoubleClick += new System.EventHandler(this.txtTelefono_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Direccion :";
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(112, 229);
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(290, 41);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.DoubleClick += new System.EventHandler(this.txtDireccion_DoubleClick);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(12, 196);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(70, 16);
            this.lblNombres.TabIndex = 54;
            this.lblNombres.Text = "Nombres :";
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(112, 161);
            this.txtApellidos.MaxLength = 100;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(290, 22);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.DoubleClick += new System.EventHandler(this.txtApellidos_DoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 162);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(94, 16);
            this.lblTitulo.TabIndex = 51;
            this.lblTitulo.Text = "Razon Social :";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(112, 195);
            this.txtNombres.MaxLength = 100;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(290, 22);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.DoubleClick += new System.EventHandler(this.txtNombres_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Codigo :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(86, 60);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 61;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
            this.cbTipo.Location = new System.Drawing.Point(86, 92);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 24);
            this.cbTipo.TabIndex = 0;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "Tipo Doc :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 67;
            this.label10.Text = "Documento :";
            // 
            // txtDocumento
            // 
            this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(112, 127);
            this.txtDocumento.MaxLength = 11;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(189, 22);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.DoubleClick += new System.EventHandler(this.txtDocumento_DoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 70;
            this.label13.Text = "Trabajo :";
            // 
            // txtTrabajo
            // 
            this.txtTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabajo.Location = new System.Drawing.Point(112, 344);
            this.txtTrabajo.MaxLength = 50;
            this.txtTrabajo.Name = "txtTrabajo";
            this.txtTrabajo.Size = new System.Drawing.Size(132, 22);
            this.txtTrabajo.TabIndex = 7;
            this.txtTrabajo.DoubleClick += new System.EventHandler(this.txtTrabajo_DoubleClick);
            // 
            // epRUC
            // 
            this.epRUC.ContainerControl = this;
            // 
            // epApellidos
            // 
            this.epApellidos.ContainerControl = this;
            // 
            // epNombres
            // 
            this.epNombres.ContainerControl = this;
            // 
            // epTelefono
            // 
            this.epTelefono.ContainerControl = this;
            // 
            // epDireccion
            // 
            this.epDireccion.ContainerControl = this;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(449, 558);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTrabajo);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddEmail);
            this.Controls.Add(this.cbEmail);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNombres, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtApellidos, 0);
            this.Controls.SetChildIndex(this.lblNombres, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtComentarios, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.cbEstado, 0);
            this.Controls.SetChildIndex(this.cbEmail, 0);
            this.Controls.SetChildIndex(this.btnAddEmail, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cbTipo, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtDocumento, 0);
            this.Controls.SetChildIndex(this.txtTrabajo, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            ((System.ComponentModel.ISupportInitialize)(this.epRUC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAddEmail;
    private System.Windows.Forms.ComboBox cbEmail;
    private System.Windows.Forms.ComboBox cbEstado;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtComentarios;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtCelular;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtDireccion;
    private System.Windows.Forms.Label lblNombres;
    private System.Windows.Forms.TextBox txtApellidos;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.TextBox txtNombres;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.ComboBox cbTipo;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtDocumento;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox txtTrabajo;
    private System.Windows.Forms.ErrorProvider epRUC;
    private System.Windows.Forms.ErrorProvider epApellidos;
    private System.Windows.Forms.ErrorProvider epNombres;
    private System.Windows.Forms.ErrorProvider epTelefono;
    private System.Windows.Forms.ErrorProvider epDireccion;
  }
}
