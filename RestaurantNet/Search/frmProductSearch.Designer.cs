namespace RestaurantNet
{
  partial class frmProductSearch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductSearch));
      this.lblNo = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dgwResult = new System.Windows.Forms.DataGridView();
      this.txtDescripcion = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.cbTipo = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.cbCategoria = new System.Windows.Forms.ComboBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnModify = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnClean = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.cbSubCategoria = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
      this.SuspendLayout();
      // 
      // lblNo
      // 
      this.lblNo.AutoSize = true;
      this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNo.Location = new System.Drawing.Point(160, 150);
      this.lblNo.Name = "lblNo";
      this.lblNo.Size = new System.Drawing.Size(32, 16);
      this.lblNo.TabIndex = 26;
      this.lblNo.Text = "999";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(11, 150);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(143, 16);
      this.label1.TabIndex = 25;
      this.label1.Text = "Numeros de registros :";
      // 
      // dgwResult
      // 
      this.dgwResult.AllowUserToAddRows = false;
      this.dgwResult.AllowUserToDeleteRows = false;
      this.dgwResult.AllowUserToOrderColumns = true;
      this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgwResult.Location = new System.Drawing.Point(11, 172);
      this.dgwResult.MultiSelect = false;
      this.dgwResult.Name = "dgwResult";
      this.dgwResult.ReadOnly = true;
      this.dgwResult.Size = new System.Drawing.Size(952, 376);
      this.dgwResult.TabIndex = 18;
      this.dgwResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwResult_CellDoubleClick);
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDescripcion.Location = new System.Drawing.Point(114, 56);
      this.txtDescripcion.MaxLength = 100;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new System.Drawing.Size(290, 22);
      this.txtDescripcion.TabIndex = 101;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(12, 59);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(86, 16);
      this.label7.TabIndex = 100;
      this.label7.Text = "Descripcion :";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(12, 93);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(73, 16);
      this.label10.TabIndex = 99;
      this.label10.Text = "Categoria :";
      // 
      // cbTipo
      // 
      this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbTipo.FormattingEnabled = true;
      this.cbTipo.Items.AddRange(new object[] {
            "",
            "NORMAL",
            "ADICIONAL",
            "PERSONALIZADO",
            "SERVICIO"});
      this.cbTipo.Location = new System.Drawing.Point(114, 20);
      this.cbTipo.Name = "cbTipo";
      this.cbTipo.Size = new System.Drawing.Size(121, 24);
      this.cbTipo.TabIndex = 96;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(12, 23);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(77, 16);
      this.label9.TabIndex = 98;
      this.label9.Text = "Tipo Prod. :";
      // 
      // cbCategoria
      // 
      this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbCategoria.FormattingEnabled = true;
      this.cbCategoria.Location = new System.Drawing.Point(114, 90);
      this.cbCategoria.MaxLength = 20;
      this.cbCategoria.Name = "cbCategoria";
      this.cbCategoria.Size = new System.Drawing.Size(294, 24);
      this.cbCategoria.TabIndex = 97;
      this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Image = global::RestaurantNet.RestautantResource.nuevo;
      this.btnAdd.Location = new System.Drawing.Point(678, 58);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(91, 86);
      this.btnAdd.TabIndex = 128;
      this.btnAdd.Text = "Agregar Registro";
      this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnModify
      // 
      this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
      this.btnModify.Location = new System.Drawing.Point(775, 58);
      this.btnModify.Name = "btnModify";
      this.btnModify.Size = new System.Drawing.Size(91, 86);
      this.btnModify.TabIndex = 127;
      this.btnModify.Text = "Editar Registro";
      this.btnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnModify.UseVisualStyleBackColor = true;
      this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.salir;
      this.btnClose.Location = new System.Drawing.Point(872, 58);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(91, 87);
      this.btnClose.TabIndex = 126;
      this.btnClose.Text = "Cerrar";
      this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnClean
      // 
      this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClean.Image = global::RestaurantNet.RestautantResource.deshacer;
      this.btnClean.Location = new System.Drawing.Point(496, 93);
      this.btnClean.Name = "btnClean";
      this.btnClean.Size = new System.Drawing.Size(75, 52);
      this.btnClean.TabIndex = 125;
      this.btnClean.Text = "Limpiar";
      this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClean.UseVisualStyleBackColor = true;
      this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
      this.btnSearch.Location = new System.Drawing.Point(415, 93);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 52);
      this.btnSearch.TabIndex = 124;
      this.btnSearch.Text = "Buscar";
      this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 124);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 16);
      this.label2.TabIndex = 129;
      this.label2.Text = "Sub Categoria :";
      // 
      // cbSubCategoria
      // 
      this.cbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbSubCategoria.FormattingEnabled = true;
      this.cbSubCategoria.Location = new System.Drawing.Point(114, 121);
      this.cbSubCategoria.MaxLength = 20;
      this.cbSubCategoria.Name = "cbSubCategoria";
      this.cbSubCategoria.Size = new System.Drawing.Size(294, 24);
      this.cbSubCategoria.TabIndex = 130;
      // 
      // frmProductSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(979, 560);
      this.Controls.Add(this.cbSubCategoria);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.btnModify);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnClean);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtDescripcion);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.cbTipo);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.cbCategoria);
      this.Controls.Add(this.lblNo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgwResult);
      this.Name = "frmProductSearch";
      this.Text = "Busqueda de Producto";
      this.Load += new System.EventHandler(this.frmProductSearch_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblNo;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.DataGridView dgwResult;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox cbTipo;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox cbCategoria;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnModify;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnClean;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbSubCategoria;
  }
}