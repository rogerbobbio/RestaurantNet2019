namespace RestaurantNet
{
  partial class frmOutStock
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
      this.btnClose = new System.Windows.Forms.Button();
      this.dgwResult = new System.Windows.Forms.DataGridView();
      this.lblNo = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.home;
      this.btnClose.Location = new System.Drawing.Point(827, 385);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(131, 55);
      this.btnClose.TabIndex = 8;
      this.btnClose.Text = "Menu Principal";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // dgwResult
      // 
      this.dgwResult.AllowUserToAddRows = false;
      this.dgwResult.AllowUserToDeleteRows = false;
      this.dgwResult.AllowUserToOrderColumns = true;
      this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgwResult.Location = new System.Drawing.Point(6, 3);
      this.dgwResult.MultiSelect = false;
      this.dgwResult.Name = "dgwResult";
      this.dgwResult.ReadOnly = true;
      this.dgwResult.Size = new System.Drawing.Size(952, 376);
      this.dgwResult.TabIndex = 19;
      this.dgwResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwResult_CellDoubleClick);
      // 
      // lblNo
      // 
      this.lblNo.AutoSize = true;
      this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNo.Location = new System.Drawing.Point(161, 385);
      this.lblNo.Name = "lblNo";
      this.lblNo.Size = new System.Drawing.Size(32, 16);
      this.lblNo.TabIndex = 28;
      this.lblNo.Text = "999";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 385);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(143, 16);
      this.label1.TabIndex = 27;
      this.label1.Text = "Numeros de registros :";
      // 
      // frmOutStock
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(965, 452);
      this.Controls.Add(this.lblNo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgwResult);
      this.Controls.Add(this.btnClose);
      this.Name = "frmOutStock";
      this.Text = "Productos fuera de Stock";
      this.Load += new System.EventHandler(this.frmOutStock_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    public System.Windows.Forms.DataGridView dgwResult;
    private System.Windows.Forms.Label lblNo;
    private System.Windows.Forms.Label label1;
  }
}