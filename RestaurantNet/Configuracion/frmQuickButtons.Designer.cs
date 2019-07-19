namespace RestaurantNet
{
  partial class frmQuickButtons
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
      this.txtProducto = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtDescripcion = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtRuta = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnAssociate = new System.Windows.Forms.Button();
      this.btnDisassociate = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblTipo = new System.Windows.Forms.Label();
      this.lblCategoria = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.lblBoton = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.epProducto = new System.Windows.Forms.ErrorProvider(this.components);
      this.epDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
      this.btnSaveEdit = new System.Windows.Forms.Button();
      this.btnClean = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label6 = new System.Windows.Forms.Label();
      this.lblSubCategoria = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.epProducto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtProducto
      // 
      this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtProducto.Location = new System.Drawing.Point(100, 162);
      this.txtProducto.MaxLength = 100;
      this.txtProducto.Name = "txtProducto";
      this.txtProducto.Size = new System.Drawing.Size(328, 22);
      this.txtProducto.TabIndex = 0;
      this.txtProducto.Leave += new System.EventHandler(this.txtProducto_Leave);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(20, 165);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 16);
      this.label1.TabIndex = 45;
      this.label1.Text = "Producto :";
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDescripcion.Location = new System.Drawing.Point(171, 205);
      this.txtDescripcion.MaxLength = 44;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new System.Drawing.Size(307, 22);
      this.txtDescripcion.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(20, 208);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(145, 16);
      this.label2.TabIndex = 47;
      this.label2.Text = "Descripcion del boton :";
      // 
      // txtRuta
      // 
      this.txtRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRuta.Location = new System.Drawing.Point(10, 58);
      this.txtRuta.MaxLength = 1000;
      this.txtRuta.Name = "txtRuta";
      this.txtRuta.ReadOnly = true;
      this.txtRuta.Size = new System.Drawing.Size(362, 22);
      this.txtRuta.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(7, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(90, 16);
      this.label3.TabIndex = 49;
      this.label3.Text = "Ruta Imagen :";
      // 
      // btnAssociate
      // 
      this.btnAssociate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnAssociate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAssociate.Location = new System.Drawing.Point(292, 12);
      this.btnAssociate.Name = "btnAssociate";
      this.btnAssociate.Size = new System.Drawing.Size(101, 70);
      this.btnAssociate.TabIndex = 4;
      this.btnAssociate.Text = "Asociar";
      this.btnAssociate.UseVisualStyleBackColor = false;
      this.btnAssociate.Click += new System.EventHandler(this.btnAssociate_Click);
      // 
      // btnDisassociate
      // 
      this.btnDisassociate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnDisassociate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDisassociate.Location = new System.Drawing.Point(189, 12);
      this.btnDisassociate.Name = "btnDisassociate";
      this.btnDisassociate.Size = new System.Drawing.Size(101, 70);
      this.btnDisassociate.TabIndex = 3;
      this.btnDisassociate.Text = "Desasociar";
      this.btnDisassociate.UseVisualStyleBackColor = false;
      this.btnDisassociate.Click += new System.EventHandler(this.btnDisassociate_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.salir;
      this.btnClose.Location = new System.Drawing.Point(480, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(79, 70);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Salir";
      this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(20, 99);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(73, 16);
      this.label4.TabIndex = 53;
      this.label4.Text = "Categoria :";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(20, 66);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(42, 16);
      this.label5.TabIndex = 54;
      this.label5.Text = "Tipo :";
      // 
      // lblTipo
      // 
      this.lblTipo.AutoSize = true;
      this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTipo.Location = new System.Drawing.Point(99, 66);
      this.lblTipo.Name = "lblTipo";
      this.lblTipo.Size = new System.Drawing.Size(71, 16);
      this.lblTipo.TabIndex = 55;
      this.lblTipo.Text = "NORMAL";
      // 
      // lblCategoria
      // 
      this.lblCategoria.AutoSize = true;
      this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCategoria.Location = new System.Drawing.Point(126, 99);
      this.lblCategoria.Name = "lblCategoria";
      this.lblCategoria.Size = new System.Drawing.Size(95, 16);
      this.lblCategoria.TabIndex = 56;
      this.lblCategoria.Text = "CATEGORIA";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(20, 24);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(100, 16);
      this.label8.TabIndex = 57;
      this.label8.Text = "Boton Numero :";
      // 
      // lblBoton
      // 
      this.lblBoton.AutoSize = true;
      this.lblBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblBoton.Location = new System.Drawing.Point(126, 24);
      this.lblBoton.Name = "lblBoton";
      this.lblBoton.Size = new System.Drawing.Size(16, 16);
      this.lblBoton.TabIndex = 58;
      this.lblBoton.Text = "1";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(459, 88);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(100, 20);
      this.txtCodigo.TabIndex = 59;
      this.txtCodigo.Visible = false;
      // 
      // btnSearch
      // 
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Location = new System.Drawing.Point(380, 57);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 23);
      this.btnSearch.TabIndex = 60;
      this.btnSearch.Text = "Buscar";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.ICO)|*.BMP;*.JPG;*.GIF;*.ICO";
      this.openFileDialog1.InitialDirectory = "\"c:\\\\\"";
      // 
      // epProducto
      // 
      this.epProducto.ContainerControl = this;
      // 
      // epDescripcion
      // 
      this.epDescripcion.ContainerControl = this;
      // 
      // btnSaveEdit
      // 
      this.btnSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSaveEdit.Image = global::RestaurantNet.RestautantResource.grabar2;
      this.btnSaveEdit.Location = new System.Drawing.Point(399, 12);
      this.btnSaveEdit.Name = "btnSaveEdit";
      this.btnSaveEdit.Size = new System.Drawing.Size(79, 70);
      this.btnSaveEdit.TabIndex = 61;
      this.btnSaveEdit.Text = "Grabar";
      this.btnSaveEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSaveEdit.UseVisualStyleBackColor = true;
      this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
      // 
      // btnClean
      // 
      this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClean.Location = new System.Drawing.Point(457, 57);
      this.btnClean.Name = "btnClean";
      this.btnClean.Size = new System.Drawing.Size(75, 23);
      this.btnClean.TabIndex = 62;
      this.btnClean.Text = "Limpiar";
      this.btnClean.UseVisualStyleBackColor = true;
      this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnClean);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtRuta);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(23, 234);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(536, 109);
      this.groupBox1.TabIndex = 63;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Imagen del Producto";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(20, 130);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(100, 16);
      this.label6.TabIndex = 64;
      this.label6.Text = "Sub Categoria :";
      // 
      // lblSubCategoria
      // 
      this.lblSubCategoria.AutoSize = true;
      this.lblSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSubCategoria.Location = new System.Drawing.Point(126, 130);
      this.lblSubCategoria.Name = "lblSubCategoria";
      this.lblSubCategoria.Size = new System.Drawing.Size(130, 16);
      this.lblSubCategoria.TabIndex = 65;
      this.lblSubCategoria.Text = "SUB CATEGORIA";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(103, 183);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(235, 15);
      this.label7.TabIndex = 66;
      this.label7.Text = "Para buscar todos los productos usar : \' * \'";
      // 
      // frmQuickButtons
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(571, 352);
      this.Controls.Add(this.txtProducto);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.lblSubCategoria);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnSaveEdit);
      this.Controls.Add(this.txtCodigo);
      this.Controls.Add(this.lblBoton);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.lblCategoria);
      this.Controls.Add(this.lblTipo);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnAssociate);
      this.Controls.Add(this.btnDisassociate);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.txtDescripcion);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmQuickButtons";
      this.Text = "Configurar Boton";
      this.Load += new System.EventHandler(this.frmQuickButtons_Load);
      ((System.ComponentModel.ISupportInitialize)(this.epProducto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtProducto;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtRuta;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.Button btnAssociate;
    public System.Windows.Forms.Button btnDisassociate;
    public System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.Label lblCategoria;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblBoton;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ErrorProvider epProducto;
    private System.Windows.Forms.ErrorProvider epDescripcion;
    public System.Windows.Forms.Button btnSaveEdit;
    private System.Windows.Forms.Button btnClean;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lblSubCategoria;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}