namespace RestaurantNet
{
  partial class frmProductSubCategory
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
      this.label2 = new System.Windows.Forms.Label();
      this.cbCategoria = new System.Windows.Forms.ComboBox();
      this.epDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
      this.epCategoria = new System.Windows.Forms.ErrorProvider(this.components);
      this.btnAddCategoria = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epCategoria)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.TabIndex = 5;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.TabIndex = 6;
      // 
      // btnDelete
      // 
      this.btnDelete.TabIndex = 7;
      // 
      // cbEstado
      // 
      this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEstado.FormattingEnabled = true;
      this.cbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
      this.cbEstado.Location = new System.Drawing.Point(122, 179);
      this.cbEstado.Name = "cbEstado";
      this.cbEstado.Size = new System.Drawing.Size(121, 24);
      this.cbEstado.TabIndex = 4;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(21, 182);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(57, 16);
      this.label12.TabIndex = 105;
      this.label12.Text = "Estado :";
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDescripcion.Location = new System.Drawing.Point(122, 99);
      this.txtDescripcion.MaxLength = 100;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new System.Drawing.Size(290, 22);
      this.txtDescripcion.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(20, 102);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(86, 16);
      this.label7.TabIndex = 104;
      this.label7.Text = "Descripcion :";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(21, 63);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 16);
      this.label1.TabIndex = 102;
      this.label1.Text = "Codigo :";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Enabled = false;
      this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCodigo.Location = new System.Drawing.Point(122, 60);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(100, 22);
      this.txtCodigo.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(21, 141);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 16);
      this.label2.TabIndex = 107;
      this.label2.Text = "Categoria :";
      // 
      // cbCategoria
      // 
      this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbCategoria.FormattingEnabled = true;
      this.cbCategoria.Location = new System.Drawing.Point(122, 138);
      this.cbCategoria.MaxLength = 20;
      this.cbCategoria.Name = "cbCategoria";
      this.cbCategoria.Size = new System.Drawing.Size(294, 24);
      this.cbCategoria.TabIndex = 2;
      // 
      // epDescripcion
      // 
      this.epDescripcion.ContainerControl = this;
      // 
      // epCategoria
      // 
      this.epCategoria.ContainerControl = this;
      // 
      // btnAddCategoria
      // 
      this.btnAddCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddCategoria.Location = new System.Drawing.Point(422, 126);
      this.btnAddCategoria.Name = "btnAddCategoria";
      this.btnAddCategoria.Size = new System.Drawing.Size(84, 47);
      this.btnAddCategoria.TabIndex = 3;
      this.btnAddCategoria.Text = "Agregar Categoria";
      this.btnAddCategoria.UseVisualStyleBackColor = true;
      this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
      // 
      // frmProductSubCategory
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(510, 234);
      this.Controls.Add(this.btnAddCategoria);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cbCategoria);
      this.Controls.Add(this.cbEstado);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.txtDescripcion);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCodigo);
      this.Name = "frmProductSubCategory";
      this.Text = "frmProductSubCategory";
      this.Load += new System.EventHandler(this.frmProductSubCategory_Load);
      this.Controls.SetChildIndex(this.btnClose, 0);
      this.Controls.SetChildIndex(this.btnDelete, 0);
      this.Controls.SetChildIndex(this.btnSave, 0);
      this.Controls.SetChildIndex(this.txtCodigo, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.label7, 0);
      this.Controls.SetChildIndex(this.txtDescripcion, 0);
      this.Controls.SetChildIndex(this.label12, 0);
      this.Controls.SetChildIndex(this.cbEstado, 0);
      this.Controls.SetChildIndex(this.cbCategoria, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.btnAddCategoria, 0);
      ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epCategoria)).EndInit();
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
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbCategoria;
    private System.Windows.Forms.ErrorProvider epDescripcion;
    private System.Windows.Forms.ErrorProvider epCategoria;
    private System.Windows.Forms.Button btnAddCategoria;
  }
}