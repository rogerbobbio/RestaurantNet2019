﻿namespace RestaurantNet
{
  partial class frmTurnBrowser
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
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(676, 130);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(288, 16);
      this.label2.TabIndex = 133;
      this.label2.Text = "(Solo se muestran 100 registros maximo)";
      // 
      // frmTurnBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(976, 493);
      this.Controls.Add(this.label2);
      this.Name = "frmTurnBrowser";
      this.Load += new System.EventHandler(this.frmTurnBrowser_Load);
      this.Controls.SetChildIndex(this.btnModify, 0);
      this.Controls.SetChildIndex(this.btnAdd, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
  }
}
