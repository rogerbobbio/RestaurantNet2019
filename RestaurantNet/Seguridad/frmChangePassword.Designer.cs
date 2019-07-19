namespace RestaurantNet
{
  partial class frmChangePassword
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
      this.label10 = new System.Windows.Forms.Label();
      this.txtOldPassword = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNewPassword = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtRePassword = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.epNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
      this.epRePassword = new System.Windows.Forms.ErrorProvider(this.components);
      this.epDiferents = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.epNewPassword)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epRePassword)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epDiferents)).BeginInit();
      this.SuspendLayout();
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(12, 33);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(119, 16);
      this.label10.TabIndex = 32;
      this.label10.Text = "Password Antiguo:";
      // 
      // txtOldPassword
      // 
      this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtOldPassword.Location = new System.Drawing.Point(156, 30);
      this.txtOldPassword.MaxLength = 50;
      this.txtOldPassword.Name = "txtOldPassword";
      this.txtOldPassword.PasswordChar = '*';
      this.txtOldPassword.ReadOnly = true;
      this.txtOldPassword.Size = new System.Drawing.Size(162, 22);
      this.txtOldPassword.TabIndex = 31;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(14, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(117, 16);
      this.label1.TabIndex = 34;
      this.label1.Text = "Nuevo Password :";
      // 
      // txtNewPassword
      // 
      this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNewPassword.Location = new System.Drawing.Point(156, 68);
      this.txtNewPassword.MaxLength = 50;
      this.txtNewPassword.Name = "txtNewPassword";
      this.txtNewPassword.PasswordChar = '*';
      this.txtNewPassword.Size = new System.Drawing.Size(162, 22);
      this.txtNewPassword.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 105);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(134, 16);
      this.label2.TabIndex = 36;
      this.label2.Text = "Confirmar Password :";
      // 
      // txtRePassword
      // 
      this.txtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRePassword.Location = new System.Drawing.Point(156, 102);
      this.txtRePassword.MaxLength = 50;
      this.txtRePassword.Name = "txtRePassword";
      this.txtRePassword.PasswordChar = '*';
      this.txtRePassword.Size = new System.Drawing.Size(162, 22);
      this.txtRePassword.TabIndex = 1;
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Location = new System.Drawing.Point(183, 142);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(74, 70);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Cambiar";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(263, 142);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(74, 70);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Cerrar";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // epNewPassword
      // 
      this.epNewPassword.ContainerControl = this;
      // 
      // epRePassword
      // 
      this.epRePassword.ContainerControl = this;
      // 
      // epDiferents
      // 
      this.epDiferents.ContainerControl = this;
      // 
      // frmChangePassword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(349, 224);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtRePassword);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtNewPassword);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.txtOldPassword);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmChangePassword";
      this.Text = "Cambiar Contraseña";
      this.Load += new System.EventHandler(this.frmChangePassword_Load);
      ((System.ComponentModel.ISupportInitialize)(this.epNewPassword)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epRePassword)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epDiferents)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtOldPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNewPassword;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtRePassword;
    public System.Windows.Forms.Button btnSave;
    public System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.ErrorProvider epNewPassword;
    private System.Windows.Forms.ErrorProvider epRePassword;
    private System.Windows.Forms.ErrorProvider epDiferents;
  }
}