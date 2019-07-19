namespace RestaurantNet
{
  partial class frmEmployee
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNombres = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtApellidos = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtDireccion = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtCelular = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtTelefono = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.txtComentarios = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.cbEstado = new System.Windows.Forms.ComboBox();
      this.cbCargo = new System.Windows.Forms.ComboBox();
      this.label13 = new System.Windows.Forms.Label();
      this.btnVerificar = new System.Windows.Forms.Button();
      this.btnAddCargo = new System.Windows.Forms.Button();
      this.btnChangePassword = new System.Windows.Forms.Button();
      this.epCargo = new System.Windows.Forms.ErrorProvider(this.components);
      this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
      this.epFechaIngreso = new System.Windows.Forms.ErrorProvider(this.components);
      this.epNombres = new System.Windows.Forms.ErrorProvider(this.components);
      this.epApellidos = new System.Windows.Forms.ErrorProvider(this.components);
      this.dtpFechaNacimiento = new Telerik.WinControls.UI.RadDateTimePicker();
      this.dtpFechaIngreso = new Telerik.WinControls.UI.RadDateTimePicker();
      ((System.ComponentModel.ISupportInitialize)(this.epCargo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epFechaIngreso)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epNombres)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epApellidos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(301, 14);
      this.btnSave.TabIndex = 18;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(381, 14);
      this.btnClose.TabIndex = 19;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(221, 14);
      this.btnDelete.TabIndex = 17;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(15, 62);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 16);
      this.label1.TabIndex = 12;
      this.label1.Text = "Codigo :";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Enabled = false;
      this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCodigo.Location = new System.Drawing.Point(95, 62);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(100, 22);
      this.txtCodigo.TabIndex = 30;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(15, 98);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 16);
      this.label2.TabIndex = 14;
      this.label2.Text = "Nombres :";
      // 
      // txtNombres
      // 
      this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNombres.Location = new System.Drawing.Point(95, 97);
      this.txtNombres.MaxLength = 100;
      this.txtNombres.Name = "txtNombres";
      this.txtNombres.Size = new System.Drawing.Size(290, 22);
      this.txtNombres.TabIndex = 0;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(15, 132);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 16);
      this.label3.TabIndex = 16;
      this.label3.Text = "Apellidos :";
      // 
      // txtApellidos
      // 
      this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtApellidos.Location = new System.Drawing.Point(95, 132);
      this.txtApellidos.MaxLength = 100;
      this.txtApellidos.Name = "txtApellidos";
      this.txtApellidos.Size = new System.Drawing.Size(290, 22);
      this.txtApellidos.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(15, 167);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(71, 16);
      this.label4.TabIndex = 18;
      this.label4.Text = "Direccion :";
      // 
      // txtDireccion
      // 
      this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDireccion.Location = new System.Drawing.Point(95, 167);
      this.txtDireccion.MaxLength = 200;
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new System.Drawing.Size(310, 22);
      this.txtDireccion.TabIndex = 2;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(15, 237);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(56, 16);
      this.label5.TabIndex = 22;
      this.label5.Text = "Celular :";
      // 
      // txtCelular
      // 
      this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCelular.Location = new System.Drawing.Point(95, 237);
      this.txtCelular.MaxLength = 50;
      this.txtCelular.Name = "txtCelular";
      this.txtCelular.Size = new System.Drawing.Size(132, 22);
      this.txtCelular.TabIndex = 4;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(15, 202);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(68, 16);
      this.label6.TabIndex = 20;
      this.label6.Text = "Telefono :";
      // 
      // txtTelefono
      // 
      this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTelefono.Location = new System.Drawing.Point(95, 202);
      this.txtTelefono.MaxLength = 50;
      this.txtTelefono.Name = "txtTelefono";
      this.txtTelefono.Size = new System.Drawing.Size(132, 22);
      this.txtTelefono.TabIndex = 3;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(15, 272);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(48, 16);
      this.label7.TabIndex = 24;
      this.label7.Text = "Email :";
      // 
      // txtEmail
      // 
      this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEmail.Location = new System.Drawing.Point(95, 272);
      this.txtEmail.MaxLength = 100;
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(310, 22);
      this.txtEmail.TabIndex = 5;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(15, 307);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(123, 16);
      this.label8.TabIndex = 26;
      this.label8.Text = "Fecha Nacimiento :";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(15, 342);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(100, 16);
      this.label9.TabIndex = 28;
      this.label9.Text = "Fecha Ingreso :";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(15, 377);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(74, 16);
      this.label10.TabIndex = 30;
      this.label10.Text = "Password :";
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Location = new System.Drawing.Point(95, 376);
      this.txtPassword.MaxLength = 50;
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(132, 22);
      this.txtPassword.TabIndex = 9;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(15, 473);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(90, 16);
      this.label11.TabIndex = 32;
      this.label11.Text = "Comentarios :";
      // 
      // txtComentarios
      // 
      this.txtComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtComentarios.Location = new System.Drawing.Point(18, 492);
      this.txtComentarios.MaxLength = 1000;
      this.txtComentarios.Multiline = true;
      this.txtComentarios.Name = "txtComentarios";
      this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtComentarios.Size = new System.Drawing.Size(402, 40);
      this.txtComentarios.TabIndex = 15;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(15, 411);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(57, 16);
      this.label12.TabIndex = 34;
      this.label12.Text = "Estado :";
      // 
      // cbEstado
      // 
      this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEstado.FormattingEnabled = true;
      this.cbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
      this.cbEstado.Location = new System.Drawing.Point(95, 408);
      this.cbEstado.Name = "cbEstado";
      this.cbEstado.Size = new System.Drawing.Size(121, 24);
      this.cbEstado.TabIndex = 12;
      // 
      // cbCargo
      // 
      this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbCargo.FormattingEnabled = true;
      this.cbCargo.Location = new System.Drawing.Point(95, 442);
      this.cbCargo.MaxLength = 20;
      this.cbCargo.Name = "cbCargo";
      this.cbCargo.Size = new System.Drawing.Size(211, 24);
      this.cbCargo.TabIndex = 13;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(15, 445);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(51, 16);
      this.label13.TabIndex = 36;
      this.label13.Text = "Cargo :";
      // 
      // btnVerificar
      // 
      this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnVerificar.Location = new System.Drawing.Point(236, 367);
      this.btnVerificar.Name = "btnVerificar";
      this.btnVerificar.Size = new System.Drawing.Size(81, 41);
      this.btnVerificar.TabIndex = 10;
      this.btnVerificar.Text = "Verificar Password";
      this.btnVerificar.UseVisualStyleBackColor = true;
      this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
      // 
      // btnAddCargo
      // 
      this.btnAddCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddCargo.Location = new System.Drawing.Point(312, 438);
      this.btnAddCargo.Name = "btnAddCargo";
      this.btnAddCargo.Size = new System.Drawing.Size(108, 31);
      this.btnAddCargo.TabIndex = 14;
      this.btnAddCargo.Text = "Agregar Cargo";
      this.btnAddCargo.UseVisualStyleBackColor = true;
      this.btnAddCargo.Click += new System.EventHandler(this.btnAddCargo_Click);
      // 
      // btnChangePassword
      // 
      this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnChangePassword.Location = new System.Drawing.Point(323, 367);
      this.btnChangePassword.Name = "btnChangePassword";
      this.btnChangePassword.Size = new System.Drawing.Size(82, 41);
      this.btnChangePassword.TabIndex = 11;
      this.btnChangePassword.Text = "Cambiar Password";
      this.btnChangePassword.UseVisualStyleBackColor = true;
      this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
      // 
      // epCargo
      // 
      this.epCargo.ContainerControl = this;
      // 
      // epPassword
      // 
      this.epPassword.ContainerControl = this;
      // 
      // epFechaIngreso
      // 
      this.epFechaIngreso.ContainerControl = this;
      // 
      // epNombres
      // 
      this.epNombres.ContainerControl = this;
      // 
      // epApellidos
      // 
      this.epApellidos.ContainerControl = this;
      // 
      // dtpFechaNacimiento
      // 
      this.dtpFechaNacimiento.AutoSize = true;
      this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaNacimiento.Location = new System.Drawing.Point(144, 307);
      this.dtpFechaNacimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
      this.dtpFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
      this.dtpFechaNacimiento.NullDate = new System.DateTime(((long)(0)));
      this.dtpFechaNacimiento.Size = new System.Drawing.Size(108, 22);
      this.dtpFechaNacimiento.TabIndex = 116;
      this.dtpFechaNacimiento.Text = "radDateTimePicker1";
      this.dtpFechaNacimiento.Value = new System.DateTime(((long)(0)));
      // 
      // dtpFechaIngreso
      // 
      this.dtpFechaIngreso.AutoSize = true;
      this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaIngreso.Location = new System.Drawing.Point(144, 342);
      this.dtpFechaIngreso.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
      this.dtpFechaIngreso.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dtpFechaIngreso.Name = "dtpFechaIngreso";
      this.dtpFechaIngreso.NullDate = new System.DateTime(((long)(0)));
      this.dtpFechaIngreso.Size = new System.Drawing.Size(108, 22);
      this.dtpFechaIngreso.TabIndex = 117;
      this.dtpFechaIngreso.Text = "radDateTimePicker1";
      this.dtpFechaIngreso.Value = new System.DateTime(((long)(0)));
      // 
      // frmEmployee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(463, 538);
      this.Controls.Add(this.dtpFechaIngreso);
      this.Controls.Add(this.dtpFechaNacimiento);
      this.Controls.Add(this.btnChangePassword);
      this.Controls.Add(this.btnAddCargo);
      this.Controls.Add(this.btnVerificar);
      this.Controls.Add(this.cbCargo);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.cbEstado);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.txtComentarios);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtCelular);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtTelefono);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtDireccion);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtApellidos);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtNombres);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCodigo);
      this.Name = "frmEmployee";
      this.Tag = "14";
      this.Load += new System.EventHandler(this.frmEmployee_Load);
      this.Controls.SetChildIndex(this.txtCodigo, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.txtNombres, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.txtApellidos, 0);
      this.Controls.SetChildIndex(this.label3, 0);
      this.Controls.SetChildIndex(this.txtDireccion, 0);
      this.Controls.SetChildIndex(this.label4, 0);
      this.Controls.SetChildIndex(this.txtTelefono, 0);
      this.Controls.SetChildIndex(this.label6, 0);
      this.Controls.SetChildIndex(this.txtCelular, 0);
      this.Controls.SetChildIndex(this.label5, 0);
      this.Controls.SetChildIndex(this.txtEmail, 0);
      this.Controls.SetChildIndex(this.label7, 0);
      this.Controls.SetChildIndex(this.label8, 0);
      this.Controls.SetChildIndex(this.label9, 0);
      this.Controls.SetChildIndex(this.txtPassword, 0);
      this.Controls.SetChildIndex(this.label10, 0);
      this.Controls.SetChildIndex(this.txtComentarios, 0);
      this.Controls.SetChildIndex(this.label11, 0);
      this.Controls.SetChildIndex(this.label12, 0);
      this.Controls.SetChildIndex(this.cbEstado, 0);
      this.Controls.SetChildIndex(this.label13, 0);
      this.Controls.SetChildIndex(this.cbCargo, 0);
      this.Controls.SetChildIndex(this.btnVerificar, 0);
      this.Controls.SetChildIndex(this.btnAddCargo, 0);
      this.Controls.SetChildIndex(this.btnChangePassword, 0);
      this.Controls.SetChildIndex(this.btnClose, 0);
      this.Controls.SetChildIndex(this.btnDelete, 0);
      this.Controls.SetChildIndex(this.btnSave, 0);
      this.Controls.SetChildIndex(this.dtpFechaNacimiento, 0);
      this.Controls.SetChildIndex(this.dtpFechaIngreso, 0);
      ((System.ComponentModel.ISupportInitialize)(this.epCargo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epFechaIngreso)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epNombres)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epApellidos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNombres;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtApellidos;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtDireccion;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtCelular;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtComentarios;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ComboBox cbEstado;
    private System.Windows.Forms.ComboBox cbCargo;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Button btnVerificar;
    private System.Windows.Forms.Button btnAddCargo;
    private System.Windows.Forms.Button btnChangePassword;
    private System.Windows.Forms.ErrorProvider epCargo;
    private System.Windows.Forms.ErrorProvider epPassword;
    private System.Windows.Forms.ErrorProvider epFechaIngreso;
    private System.Windows.Forms.ErrorProvider epNombres;
    private System.Windows.Forms.ErrorProvider epApellidos;
    private Telerik.WinControls.UI.RadDateTimePicker dtpFechaNacimiento;
    private Telerik.WinControls.UI.RadDateTimePicker dtpFechaIngreso;
  }
}
