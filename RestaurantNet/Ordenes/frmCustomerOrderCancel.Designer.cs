namespace RestaurantNet
{
  partial class frmCustomerOrderCancel
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
      this.lblTipo = new System.Windows.Forms.Label();
      this.epComentarios = new System.Windows.Forms.ErrorProvider(this.components);
      this.btnClose = new System.Windows.Forms.Button();
      this.txtComentarios = new System.Windows.Forms.TextBox();
      this.btnAnular = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.epComentarios)).BeginInit();
      this.SuspendLayout();
      // 
      // lblTipo
      // 
      this.lblTipo.AutoSize = true;
      this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTipo.Location = new System.Drawing.Point(12, 9);
      this.lblTipo.Name = "lblTipo";
      this.lblTipo.Size = new System.Drawing.Size(171, 18);
      this.lblTipo.TabIndex = 26;
      this.lblTipo.Text = "Motivos de la anulacion :";
      // 
      // epComentarios
      // 
      this.epComentarios.ContainerControl = this;
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.salir;
      this.btnClose.Location = new System.Drawing.Point(282, 181);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(114, 83);
      this.btnClose.TabIndex = 2;
      this.btnClose.Text = "Salir ";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
      this.txtComentarios.TabIndex = 0;
      this.txtComentarios.DoubleClick += new System.EventHandler(this.txtComentarios_DoubleClick);
      // 
      // btnAnular
      // 
      this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAnular.Location = new System.Drawing.Point(12, 181);
      this.btnAnular.Name = "btnAnular";
      this.btnAnular.Size = new System.Drawing.Size(114, 83);
      this.btnAnular.TabIndex = 1;
      this.btnAnular.Text = "Anular Orden";
      this.btnAnular.UseVisualStyleBackColor = false;
      this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
      // 
      // frmCustomerOrderCancel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(420, 276);
      this.Controls.Add(this.btnAnular);
      this.Controls.Add(this.txtComentarios);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.lblTipo);
      this.Name = "frmCustomerOrderCancel";
      this.Text = "Anular Orden";
      ((System.ComponentModel.ISupportInitialize)(this.epComentarios)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.ErrorProvider epComentarios;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnAnular;
    private System.Windows.Forms.TextBox txtComentarios;
  }
}