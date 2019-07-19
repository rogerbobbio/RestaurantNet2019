namespace RestaurantNet
{
  partial class frmInsumoGroupClassification
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
      this.cbEstado = new System.Windows.Forms.ComboBox();
      this.label12 = new System.Windows.Forms.Label();
      this.txtDescripcion = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.epDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.TabIndex = 4;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.TabIndex = 5;
      // 
      // btnDelete
      // 
      this.btnDelete.TabIndex = 3;
      // 
      // cbEstado
      // 
      this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEstado.FormattingEnabled = true;
      this.cbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
      this.cbEstado.Location = new System.Drawing.Point(123, 145);
      this.cbEstado.Name = "cbEstado";
      this.cbEstado.Size = new System.Drawing.Size(121, 24);
      this.cbEstado.TabIndex = 2;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(21, 148);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(57, 16);
      this.label12.TabIndex = 105;
      this.label12.Text = "Estado :";
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDescripcion.Location = new System.Drawing.Point(123, 102);
      this.txtDescripcion.MaxLength = 100;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new System.Drawing.Size(290, 22);
      this.txtDescripcion.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(21, 105);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(86, 16);
      this.label7.TabIndex = 104;
      this.label7.Text = "Descripcion :";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(21, 62);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 16);
      this.label1.TabIndex = 102;
      this.label1.Text = "Codigo :";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Enabled = false;
      this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCodigo.Location = new System.Drawing.Point(123, 62);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(100, 22);
      this.txtCodigo.TabIndex = 0;
      // 
      // epDescripcion
      // 
      this.epDescripcion.ContainerControl = this;
      // 
      // frmInsumoGroupClassification
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(510, 188);
      this.Controls.Add(this.cbEstado);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.txtDescripcion);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCodigo);
      this.Name = "frmInsumoGroupClassification";
      this.Text = "frmInsumoGroupClassification";
      this.Load += new System.EventHandler(this.frmInsumoGroupClassification_Load);
      this.Controls.SetChildIndex(this.btnClose, 0);
      this.Controls.SetChildIndex(this.btnDelete, 0);
      this.Controls.SetChildIndex(this.btnSave, 0);
      this.Controls.SetChildIndex(this.txtCodigo, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.label7, 0);
      this.Controls.SetChildIndex(this.txtDescripcion, 0);
      this.Controls.SetChildIndex(this.label12, 0);
      this.Controls.SetChildIndex(this.cbEstado, 0);
      ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cbEstado;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.ErrorProvider epDescripcion;
  }
}