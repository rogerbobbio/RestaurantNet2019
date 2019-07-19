namespace RestaurantNet
{
  partial class frmProductMargen
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
      this.btnCalcular = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.txtPrecioProveedor = new System.Windows.Forms.TextBox();
      this.txtMargen = new System.Windows.Forms.TextBox();
      this.lblTitulo = new System.Windows.Forms.Label();
      this.lblNombres = new System.Windows.Forms.Label();
      this.txtPrecioFinal = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.epPrecioProveedor = new System.Windows.Forms.ErrorProvider(this.components);
      this.epPrecioFinal = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.epPrecioProveedor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epPrecioFinal)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCalcular
      // 
      this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCalcular.Location = new System.Drawing.Point(81, 104);
      this.btnCalcular.Name = "btnCalcular";
      this.btnCalcular.Size = new System.Drawing.Size(74, 70);
      this.btnCalcular.TabIndex = 2;
      this.btnCalcular.Text = "Calcular";
      this.btnCalcular.UseVisualStyleBackColor = true;
      this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(161, 104);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(74, 70);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Cerrar";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // txtPrecioProveedor
      // 
      this.txtPrecioProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtPrecioProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPrecioProveedor.Location = new System.Drawing.Point(138, 9);
      this.txtPrecioProveedor.MaxLength = 10;
      this.txtPrecioProveedor.Name = "txtPrecioProveedor";
      this.txtPrecioProveedor.Size = new System.Drawing.Size(85, 22);
      this.txtPrecioProveedor.TabIndex = 0;
      this.txtPrecioProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtMargen
      // 
      this.txtMargen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMargen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMargen.Location = new System.Drawing.Point(138, 78);
      this.txtMargen.MaxLength = 6;
      this.txtMargen.Name = "txtMargen";
      this.txtMargen.ReadOnly = true;
      this.txtMargen.Size = new System.Drawing.Size(85, 22);
      this.txtMargen.TabIndex = 87;
      this.txtMargen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblTitulo
      // 
      this.lblTitulo.AutoSize = true;
      this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitulo.Location = new System.Drawing.Point(12, 9);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(120, 16);
      this.lblTitulo.TabIndex = 89;
      this.lblTitulo.Text = "Precio Proveedor :";
      // 
      // lblNombres
      // 
      this.lblNombres.AutoSize = true;
      this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNombres.Location = new System.Drawing.Point(12, 78);
      this.lblNombres.Name = "lblNombres";
      this.lblNombres.Size = new System.Drawing.Size(80, 16);
      this.lblNombres.TabIndex = 90;
      this.lblNombres.Text = "Margen (%):";
      // 
      // txtPrecioFinal
      // 
      this.txtPrecioFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPrecioFinal.Location = new System.Drawing.Point(138, 45);
      this.txtPrecioFinal.MaxLength = 10;
      this.txtPrecioFinal.Name = "txtPrecioFinal";
      this.txtPrecioFinal.Size = new System.Drawing.Size(85, 22);
      this.txtPrecioFinal.TabIndex = 1;
      this.txtPrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 45);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(85, 16);
      this.label4.TabIndex = 91;
      this.label4.Text = "Precio Final :";
      // 
      // epPrecioProveedor
      // 
      this.epPrecioProveedor.ContainerControl = this;
      // 
      // epPrecioFinal
      // 
      this.epPrecioFinal.ContainerControl = this;
      // 
      // frmMarkup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(247, 186);
      this.Controls.Add(this.txtPrecioProveedor);
      this.Controls.Add(this.txtMargen);
      this.Controls.Add(this.lblTitulo);
      this.Controls.Add(this.lblNombres);
      this.Controls.Add(this.txtPrecioFinal);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnCalcular);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmMarkup";
      this.Text = "Calculo de Margen (%)";
      ((System.ComponentModel.ISupportInitialize)(this.epPrecioProveedor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epPrecioFinal)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.Button btnCalcular;
    public System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TextBox txtPrecioProveedor;
    private System.Windows.Forms.TextBox txtMargen;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblNombres;
    private System.Windows.Forms.TextBox txtPrecioFinal;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ErrorProvider epPrecioProveedor;
    private System.Windows.Forms.ErrorProvider epPrecioFinal;
  }
}