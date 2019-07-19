namespace RestaurantNet.Common
{
  partial class frmShowError
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
      this.label6 = new System.Windows.Forms.Label();
      this.txtMensajeError = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSentenciaError = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(12, 9);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(134, 16);
      this.label6.TabIndex = 108;
      this.label6.Text = "Mensaje de error :";
      // 
      // txtMensajeError
      // 
      this.txtMensajeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMensajeError.Location = new System.Drawing.Point(12, 28);
      this.txtMensajeError.Multiline = true;
      this.txtMensajeError.Name = "txtMensajeError";
      this.txtMensajeError.ReadOnly = true;
      this.txtMensajeError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtMensajeError.Size = new System.Drawing.Size(620, 99);
      this.txtMensajeError.TabIndex = 109;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 130);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(151, 16);
      this.label1.TabIndex = 110;
      this.label1.Text = "Sentencia con error :";
      // 
      // txtSentenciaError
      // 
      this.txtSentenciaError.Location = new System.Drawing.Point(15, 149);
      this.txtSentenciaError.Multiline = true;
      this.txtSentenciaError.Name = "txtSentenciaError";
      this.txtSentenciaError.ReadOnly = true;
      this.txtSentenciaError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtSentenciaError.Size = new System.Drawing.Size(620, 69);
      this.txtSentenciaError.TabIndex = 111;
      // 
      // frmShowError
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(644, 230);
      this.Controls.Add(this.txtSentenciaError);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtMensajeError);
      this.Controls.Add(this.label6);
      this.Name = "frmShowError";
      this.Text = "RestaurantNet - Error";
      this.Load += new System.EventHandler(this.frmShowError_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtMensajeError;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSentenciaError;
  }
}