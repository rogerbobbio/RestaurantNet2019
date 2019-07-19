namespace RestaurantNet
{
  partial class frmKeyboard
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
      this.txtInput = new System.Windows.Forms.TextBox();
      this.keyboardcontrol1 = new KeyboardClassLibrary.Keyboardcontrol();
      this.btnEnviar = new Telerik.WinControls.UI.RadButton();
      this.btnCancelar = new Telerik.WinControls.UI.RadButton();
      this.btnBorrar = new Telerik.WinControls.UI.RadButton();
      ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).BeginInit();
      this.SuspendLayout();
      // 
      // txtInput
      // 
      this.txtInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtInput.Location = new System.Drawing.Point(12, 12);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(344, 24);
      this.txtInput.TabIndex = 0;
      // 
      // keyboardcontrol1
      // 
      this.keyboardcontrol1.KeyboardType = KeyboardClassLibrary.BoW.Standard;
      this.keyboardcontrol1.Location = new System.Drawing.Point(1, 42);
      this.keyboardcontrol1.Name = "keyboardcontrol1";
      this.keyboardcontrol1.Size = new System.Drawing.Size(1036, 345);
      this.keyboardcontrol1.TabIndex = 1;
      this.keyboardcontrol1.UserKeyPressed += new KeyboardClassLibrary.KeyboardDelegate(this.keyboardcontrol1_UserKeyPressed);
      // 
      // btnEnviar
      // 
      this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEnviar.Location = new System.Drawing.Point(362, 8);
      this.btnEnviar.Name = "btnEnviar";
      this.btnEnviar.Size = new System.Drawing.Size(96, 28);
      this.btnEnviar.TabIndex = 2;
      this.btnEnviar.Text = "ENVIAR";
      this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancelar.Location = new System.Drawing.Point(464, 8);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(96, 28);
      this.btnCancelar.TabIndex = 3;
      this.btnCancelar.Text = "CANCELAR";
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnBorrar
      // 
      this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBorrar.Location = new System.Drawing.Point(566, 8);
      this.btnBorrar.Name = "btnBorrar";
      this.btnBorrar.Size = new System.Drawing.Size(96, 28);
      this.btnBorrar.TabIndex = 4;
      this.btnBorrar.Text = "BORRAR";
      this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
      // 
      // frmKeyboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1038, 388);
      this.Controls.Add(this.btnBorrar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnEnviar);
      this.Controls.Add(this.keyboardcontrol1);
      this.Controls.Add(this.txtInput);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmKeyboard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Teclado";
      this.Load += new System.EventHandler(this.frmKeyboard_Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKeyboard_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtInput;
    private KeyboardClassLibrary.Keyboardcontrol keyboardcontrol1;
    private Telerik.WinControls.UI.RadButton btnEnviar;
    private Telerik.WinControls.UI.RadButton btnCancelar;
    private Telerik.WinControls.UI.RadButton btnBorrar;
  }
}