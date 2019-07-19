namespace RestaurantNet
{
  partial class frmCustomerOrderSaleNote
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
      this.btnAnular = new System.Windows.Forms.Button();
      this.txtComentarios = new System.Windows.Forms.TextBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.lblTipo = new System.Windows.Forms.Label();
      this.epComentarios = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.epComentarios)).BeginInit();
      this.SuspendLayout();
      // 
      // btnAnular
      // 
      this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAnular.Location = new System.Drawing.Point(12, 181);
      this.btnAnular.Name = "btnAnular";
      this.btnAnular.Size = new System.Drawing.Size(114, 83);
      this.btnAnular.TabIndex = 28;
      this.btnAnular.Text = "Nota de Venta";
      this.btnAnular.UseVisualStyleBackColor = false;
      this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
      // 
      // txtComentarios
      // 
      this.txtComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtComentarios.Location = new System.Drawing.Point(12, 30);
      this.txtComentarios.MaxLength = 1000;
      this.txtComentarios.Multiline = true;
      this.txtComentarios.Name = "txtComentarios";
      this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtComentarios.Size = new System.Drawing.Size(384, 145);
      this.txtComentarios.TabIndex = 27;
      this.txtComentarios.DoubleClick += new System.EventHandler(this.txtComentarios_DoubleClick);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.salir;
      this.btnClose.Location = new System.Drawing.Point(282, 181);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(114, 83);
      this.btnClose.TabIndex = 29;
      this.btnClose.Text = "Salir ";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // lblTipo
      // 
      this.lblTipo.AutoSize = true;
      this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTipo.Location = new System.Drawing.Point(12, 9);
      this.lblTipo.Name = "lblTipo";
      this.lblTipo.Size = new System.Drawing.Size(196, 18);
      this.lblTipo.TabIndex = 30;
      this.lblTipo.Text = "Motivos de la nota de venta :";
      // 
      // epComentarios
      // 
      this.epComentarios.ContainerControl = this;
      // 
      // frmCustomerOrderSaleNote
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(420, 270);
      this.Controls.Add(this.btnAnular);
      this.Controls.Add(this.txtComentarios);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.lblTipo);
      this.Name = "frmCustomerOrderSaleNote";
      this.Text = "Nota de Venta";
      ((System.ComponentModel.ISupportInitialize)(this.epComentarios)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAnular;
    private System.Windows.Forms.TextBox txtComentarios;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.ErrorProvider epComentarios;
  }
}