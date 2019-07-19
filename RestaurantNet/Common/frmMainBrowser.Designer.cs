namespace RestaurantNet
{
  partial class frmMainBrowser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainBrowser));
      this.dgwResult = new System.Windows.Forms.DataGridView();
      this.lblCampo = new System.Windows.Forms.Label();
      this.cbField = new System.Windows.Forms.ComboBox();
      this.lblValor = new System.Windows.Forms.Label();
      this.txtValue = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblNo = new System.Windows.Forms.Label();
      this.epCampo = new System.Windows.Forms.ErrorProvider(this.components);
      this.epValor = new System.Windows.Forms.ErrorProvider(this.components);
      this.btnClean = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnModify = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.lblCategoria = new System.Windows.Forms.Label();
      this.cbCategoria = new System.Windows.Forms.ComboBox();
      this.cbSubCategoria = new System.Windows.Forms.ComboBox();
      this.lblSubCategoria = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epCampo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epValor)).BeginInit();
      this.SuspendLayout();
      // 
      // dgwResult
      // 
      this.dgwResult.AllowUserToAddRows = false;
      this.dgwResult.AllowUserToDeleteRows = false;
      this.dgwResult.AllowUserToOrderColumns = true;
      this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgwResult.Location = new System.Drawing.Point(12, 149);
      this.dgwResult.MultiSelect = false;
      this.dgwResult.Name = "dgwResult";
      this.dgwResult.ReadOnly = true;
      this.dgwResult.Size = new System.Drawing.Size(952, 332);
      this.dgwResult.TabIndex = 0;
      this.dgwResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwResult_CellDoubleClick);
      // 
      // lblCampo
      // 
      this.lblCampo.AutoSize = true;
      this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCampo.Location = new System.Drawing.Point(51, 15);
      this.lblCampo.Name = "lblCampo";
      this.lblCampo.Size = new System.Drawing.Size(58, 16);
      this.lblCampo.TabIndex = 8;
      this.lblCampo.Text = "Campo :";
      this.lblCampo.Visible = false;
      // 
      // cbField
      // 
      this.cbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbField.FormattingEnabled = true;
      this.cbField.Location = new System.Drawing.Point(115, 12);
      this.cbField.Name = "cbField";
      this.cbField.Size = new System.Drawing.Size(234, 24);
      this.cbField.TabIndex = 9;
      this.cbField.Visible = false;
      // 
      // lblValor
      // 
      this.lblValor.AutoSize = true;
      this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblValor.Location = new System.Drawing.Point(63, 45);
      this.lblValor.Name = "lblValor";
      this.lblValor.Size = new System.Drawing.Size(46, 16);
      this.lblValor.TabIndex = 10;
      this.lblValor.Text = "Valor :";
      this.lblValor.Visible = false;
      // 
      // txtValue
      // 
      this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtValue.Location = new System.Drawing.Point(115, 42);
      this.txtValue.Name = "txtValue";
      this.txtValue.Size = new System.Drawing.Size(327, 22);
      this.txtValue.TabIndex = 11;
      this.txtValue.Visible = false;
      this.txtValue.DoubleClick += new System.EventHandler(this.txtValue_DoubleClick);
      this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 130);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(143, 16);
      this.label1.TabIndex = 13;
      this.label1.Text = "Numeros de registros :";
      // 
      // lblNo
      // 
      this.lblNo.AutoSize = true;
      this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNo.Location = new System.Drawing.Point(161, 130);
      this.lblNo.Name = "lblNo";
      this.lblNo.Size = new System.Drawing.Size(32, 16);
      this.lblNo.TabIndex = 14;
      this.lblNo.Text = "999";
      // 
      // epCampo
      // 
      this.epCampo.ContainerControl = this;
      // 
      // epValor
      // 
      this.epValor.ContainerControl = this;
      // 
      // btnClean
      // 
      this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClean.Image = global::RestaurantNet.RestautantResource.deshacer;
      this.btnClean.Location = new System.Drawing.Point(529, 12);
      this.btnClean.Name = "btnClean";
      this.btnClean.Size = new System.Drawing.Size(75, 52);
      this.btnClean.TabIndex = 17;
      this.btnClean.Text = "Limpiar";
      this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClean.UseVisualStyleBackColor = true;
      this.btnClean.Visible = false;
      this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Image = global::RestaurantNet.RestautantResource.nuevo;
      this.btnAdd.Location = new System.Drawing.Point(679, 12);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(91, 86);
      this.btnAdd.TabIndex = 16;
      this.btnAdd.Text = "Agregar Registro";
      this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnModify
      // 
      this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
      this.btnModify.Location = new System.Drawing.Point(776, 12);
      this.btnModify.Name = "btnModify";
      this.btnModify.Size = new System.Drawing.Size(91, 86);
      this.btnModify.TabIndex = 15;
      this.btnModify.Text = "Editar Registro";
      this.btnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnModify.UseVisualStyleBackColor = true;
      this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
      this.btnSearch.Location = new System.Drawing.Point(448, 12);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 52);
      this.btnSearch.TabIndex = 12;
      this.btnSearch.Text = "Buscar";
      this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Visible = false;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.home;
      this.btnClose.Location = new System.Drawing.Point(873, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(91, 87);
      this.btnClose.TabIndex = 7;
      this.btnClose.Text = "Menu Principal";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // lblCategoria
      // 
      this.lblCategoria.AutoSize = true;
      this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCategoria.Location = new System.Drawing.Point(36, 73);
      this.lblCategoria.Name = "lblCategoria";
      this.lblCategoria.Size = new System.Drawing.Size(73, 16);
      this.lblCategoria.TabIndex = 95;
      this.lblCategoria.Text = "Categoria :";
      this.lblCategoria.Visible = false;
      // 
      // cbCategoria
      // 
      this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbCategoria.FormattingEnabled = true;
      this.cbCategoria.Location = new System.Drawing.Point(115, 70);
      this.cbCategoria.MaxLength = 20;
      this.cbCategoria.Name = "cbCategoria";
      this.cbCategoria.Size = new System.Drawing.Size(294, 24);
      this.cbCategoria.TabIndex = 94;
      this.cbCategoria.Visible = false;
      this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
      // 
      // cbSubCategoria
      // 
      this.cbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbSubCategoria.FormattingEnabled = true;
      this.cbSubCategoria.Location = new System.Drawing.Point(115, 100);
      this.cbSubCategoria.MaxLength = 20;
      this.cbSubCategoria.Name = "cbSubCategoria";
      this.cbSubCategoria.Size = new System.Drawing.Size(294, 24);
      this.cbSubCategoria.TabIndex = 132;
      // 
      // lblSubCategoria
      // 
      this.lblSubCategoria.AutoSize = true;
      this.lblSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSubCategoria.Location = new System.Drawing.Point(9, 103);
      this.lblSubCategoria.Name = "lblSubCategoria";
      this.lblSubCategoria.Size = new System.Drawing.Size(100, 16);
      this.lblSubCategoria.TabIndex = 131;
      this.lblSubCategoria.Text = "Sub Categoria :";
      // 
      // frmMainBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(976, 493);
      this.Controls.Add(this.cbSubCategoria);
      this.Controls.Add(this.lblSubCategoria);
      this.Controls.Add(this.lblCategoria);
      this.Controls.Add(this.cbCategoria);
      this.Controls.Add(this.btnClean);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.btnModify);
      this.Controls.Add(this.lblNo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtValue);
      this.Controls.Add(this.lblValor);
      this.Controls.Add(this.cbField);
      this.Controls.Add(this.lblCampo);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.dgwResult);
      this.Name = "frmMainBrowser";
      this.Text = "frmMainBrowser";
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epCampo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epValor)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblCampo;
    private System.Windows.Forms.ComboBox cbField;
    private System.Windows.Forms.Label lblValor;
    private System.Windows.Forms.TextBox txtValue;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblNo;
    public System.Windows.Forms.DataGridView dgwResult;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.ErrorProvider epCampo;
    private System.Windows.Forms.ErrorProvider epValor;
    private System.Windows.Forms.Button btnClean;
    public System.Windows.Forms.Button btnModify;
    public System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Label lblCategoria;
    private System.Windows.Forms.ComboBox cbCategoria;
    private System.Windows.Forms.ComboBox cbSubCategoria;
    private System.Windows.Forms.Label lblSubCategoria;
  }
}