namespace RestaurantNet
{
  partial class frmMainTable
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
      this.btnSave = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Image = global::RestaurantNet.RestautantResource.grabar2;
      this.btnSave.Location = new System.Drawing.Point(344, 12);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(74, 70);
      this.btnSave.TabIndex = 11;
      this.btnSave.Text = "Grabar";
      this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSave.UseVisualStyleBackColor = false;
      // 
      // btnDelete
      // 
      this.btnDelete.Enabled = false;
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.Image = global::RestaurantNet.RestautantResource.eliminar;
      this.btnDelete.Location = new System.Drawing.Point(264, 12);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(74, 70);
      this.btnDelete.TabIndex = 9;
      this.btnDelete.Text = "Borrar";
      this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.salir;
      this.btnClose.Location = new System.Drawing.Point(424, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(74, 70);
      this.btnClose.TabIndex = 8;
      this.btnClose.Text = "Cerrar";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmMainTable
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(510, 605);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnClose);
      this.Name = "frmMainTable";
      this.Text = "frmMainTable";
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.Button btnSave;
    public System.Windows.Forms.Button btnClose;
    public System.Windows.Forms.Button btnDelete;
  }
}