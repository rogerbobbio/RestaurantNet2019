namespace RestaurantNet.Reports
{
  partial class frmPrinterTest
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbBar = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTestImpresora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Ver Impresoras Instaladas";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 41);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(567, 374);
            this.txtResult.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test Printer POS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Test Printer New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbBar
            // 
            this.cbBar.FormattingEnabled = true;
            this.cbBar.Location = new System.Drawing.Point(86, 421);
            this.cbBar.Name = "cbBar";
            this.cbBar.Size = new System.Drawing.Size(390, 21);
            this.cbBar.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 422);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 42;
            this.label16.Text = "Impresora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tamano de Hoja:";
            // 
            // txtAlto
            // 
            this.txtAlto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlto.Location = new System.Drawing.Point(270, 453);
            this.txtAlto.MaxLength = 15;
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(58, 22);
            this.txtAlto.TabIndex = 44;
            this.txtAlto.Text = "1169";
            // 
            // txtAncho
            // 
            this.txtAncho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAncho.Location = new System.Drawing.Point(270, 481);
            this.txtAncho.MaxLength = 15;
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(58, 22);
            this.txtAncho.TabIndex = 45;
            this.txtAncho.Text = "228";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Alto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Ancho:";
            // 
            // btnTestImpresora
            // 
            this.btnTestImpresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestImpresora.Location = new System.Drawing.Point(334, 460);
            this.btnTestImpresora.Name = "btnTestImpresora";
            this.btnTestImpresora.Size = new System.Drawing.Size(89, 47);
            this.btnTestImpresora.TabIndex = 56;
            this.btnTestImpresora.Text = "Probar Impresion";
            this.btnTestImpresora.UseVisualStyleBackColor = true;
            this.btnTestImpresora.Click += new System.EventHandler(this.btnTestImpresora_Click);
            // 
            // frmPrinterTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(591, 522);
            this.Controls.Add(this.btnTestImpresora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmPrinterTest";
            this.Text = "Printer Settings";
            this.Load += new System.EventHandler(this.frmPrinterTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbBar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestImpresora;
    }
}
