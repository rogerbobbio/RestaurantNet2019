namespace RestaurantNet
{
  partial class frmAccountViewer
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
      this.btnAnuladas = new System.Windows.Forms.Button();
      this.btnNotaVenta = new System.Windows.Forms.Button();
      this.btnFacturada = new System.Windows.Forms.Button();
      this.btnOrdenCobrar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnAnuladas
      // 
      this.btnAnuladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAnuladas.Location = new System.Drawing.Point(12, 12);
      this.btnAnuladas.Name = "btnAnuladas";
      this.btnAnuladas.Size = new System.Drawing.Size(106, 70);
      this.btnAnuladas.TabIndex = 3;
      this.btnAnuladas.Text = "Ordenes Anuladas";
      this.btnAnuladas.UseVisualStyleBackColor = true;
      this.btnAnuladas.Click += new System.EventHandler(this.btnAnuladas_Click);
      // 
      // btnNotaVenta
      // 
      this.btnNotaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNotaVenta.Location = new System.Drawing.Point(163, 12);
      this.btnNotaVenta.Name = "btnNotaVenta";
      this.btnNotaVenta.Size = new System.Drawing.Size(106, 70);
      this.btnNotaVenta.TabIndex = 4;
      this.btnNotaVenta.Text = "Notas de Venta";
      this.btnNotaVenta.UseVisualStyleBackColor = true;
      this.btnNotaVenta.Click += new System.EventHandler(this.btnNotaVenta_Click);
      // 
      // btnFacturada
      // 
      this.btnFacturada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFacturada.Location = new System.Drawing.Point(318, 12);
      this.btnFacturada.Name = "btnFacturada";
      this.btnFacturada.Size = new System.Drawing.Size(106, 70);
      this.btnFacturada.TabIndex = 5;
      this.btnFacturada.Text = "Ordenes Pagadas";
      this.btnFacturada.UseVisualStyleBackColor = true;
      this.btnFacturada.Click += new System.EventHandler(this.btnFacturada_Click);
      // 
      // btnOrdenCobrar
      // 
      this.btnOrdenCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOrdenCobrar.Location = new System.Drawing.Point(457, 12);
      this.btnOrdenCobrar.Name = "btnOrdenCobrar";
      this.btnOrdenCobrar.Size = new System.Drawing.Size(106, 70);
      this.btnOrdenCobrar.TabIndex = 7;
      this.btnOrdenCobrar.Text = "Ordenes por Cobrar";
      this.btnOrdenCobrar.UseVisualStyleBackColor = true;
      this.btnOrdenCobrar.Click += new System.EventHandler(this.btnOrdenCobrar_Click);
      // 
      // frmAccountViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(575, 92);
      this.Controls.Add(this.btnOrdenCobrar);
      this.Controls.Add(this.btnFacturada);
      this.Controls.Add(this.btnNotaVenta);
      this.Controls.Add(this.btnAnuladas);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAccountViewer";
      this.Text = "Ordenes...";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAnuladas;
    private System.Windows.Forms.Button btnNotaVenta;
    private System.Windows.Forms.Button btnFacturada;
    private System.Windows.Forms.Button btnOrdenCobrar;
  }
}