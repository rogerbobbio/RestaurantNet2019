namespace RestaurantNet
{
  partial class frmCustomerSearch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerSearch));
      this.txtApellido = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.lblNo = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dgwResult = new System.Windows.Forms.DataGridView();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtTelefono = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtDocumento = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnClean = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnModify = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
      this.SuspendLayout();
      // 
      // txtApellido
      // 
      this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtApellido.Location = new System.Drawing.Point(102, 12);
      this.txtApellido.MaxLength = 100;
      this.txtApellido.Name = "txtApellido";
      this.txtApellido.Size = new System.Drawing.Size(290, 22);
      this.txtApellido.TabIndex = 0;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(13, 15);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(71, 16);
      this.label7.TabIndex = 112;
      this.label7.Text = "Apellidos :";
      // 
      // lblNo
      // 
      this.lblNo.AutoSize = true;
      this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNo.Location = new System.Drawing.Point(162, 143);
      this.lblNo.Name = "lblNo";
      this.lblNo.Size = new System.Drawing.Size(32, 16);
      this.lblNo.TabIndex = 106;
      this.lblNo.Text = "999";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 143);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(143, 16);
      this.label1.TabIndex = 105;
      this.label1.Text = "Numeros de registros :";
      // 
      // dgwResult
      // 
      this.dgwResult.AllowUserToAddRows = false;
      this.dgwResult.AllowUserToDeleteRows = false;
      this.dgwResult.AllowUserToOrderColumns = true;
      this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgwResult.Location = new System.Drawing.Point(12, 162);
      this.dgwResult.MultiSelect = false;
      this.dgwResult.Name = "dgwResult";
      this.dgwResult.ReadOnly = true;
      this.dgwResult.Size = new System.Drawing.Size(952, 376);
      this.dgwResult.TabIndex = 102;
      this.dgwResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwResult_CellDoubleClick);
      // 
      // txtNombre
      // 
      this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNombre.Location = new System.Drawing.Point(102, 42);
      this.txtNombre.MaxLength = 100;
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(290, 22);
      this.txtNombre.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 16);
      this.label2.TabIndex = 114;
      this.label2.Text = "Nombres :";
      // 
      // txtTelefono
      // 
      this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTelefono.Location = new System.Drawing.Point(102, 71);
      this.txtTelefono.MaxLength = 100;
      this.txtTelefono.Name = "txtTelefono";
      this.txtTelefono.Size = new System.Drawing.Size(144, 22);
      this.txtTelefono.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(13, 74);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 16);
      this.label3.TabIndex = 116;
      this.label3.Text = "Telefono :";
      // 
      // txtDocumento
      // 
      this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDocumento.Location = new System.Drawing.Point(102, 99);
      this.txtDocumento.MaxLength = 100;
      this.txtDocumento.Name = "txtDocumento";
      this.txtDocumento.Size = new System.Drawing.Size(144, 22);
      this.txtDocumento.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(13, 102);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(83, 16);
      this.label4.TabIndex = 118;
      this.label4.Text = "Documento :";
      // 
      // btnClean
      // 
      this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClean.Image = global::RestaurantNet.RestautantResource.deshacer;
      this.btnClean.Location = new System.Drawing.Point(483, 74);
      this.btnClean.Name = "btnClean";
      this.btnClean.Size = new System.Drawing.Size(75, 52);
      this.btnClean.TabIndex = 120;
      this.btnClean.Text = "Limpiar";
      this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClean.UseVisualStyleBackColor = true;
      this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
      this.btnSearch.Location = new System.Drawing.Point(402, 74);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 52);
      this.btnSearch.TabIndex = 119;
      this.btnSearch.Text = "Buscar";
      this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Image = global::RestaurantNet.RestautantResource.nuevo;
      this.btnAdd.Location = new System.Drawing.Point(679, 39);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(91, 86);
      this.btnAdd.TabIndex = 123;
      this.btnAdd.Text = "Agregar Registro";
      this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnModify
      // 
      this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
      this.btnModify.Location = new System.Drawing.Point(776, 39);
      this.btnModify.Name = "btnModify";
      this.btnModify.Size = new System.Drawing.Size(91, 86);
      this.btnModify.TabIndex = 122;
      this.btnModify.Text = "Editar Registro";
      this.btnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnModify.UseVisualStyleBackColor = true;
      this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.salir;
      this.btnClose.Location = new System.Drawing.Point(873, 39);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(91, 87);
      this.btnClose.TabIndex = 121;
      this.btnClose.Text = "Cerrar";
      this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmCustomerSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(978, 550);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.btnModify);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnClean);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtDocumento);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtTelefono);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtApellido);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.lblNo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgwResult);
      this.Name = "frmCustomerSearch";
      this.Text = "Busqueda de Cliente";
      this.Load += new System.EventHandler(this.frmCustomerSearch_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtApellido;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblNo;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.DataGridView dgwResult;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDocumento;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnClean;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnModify;
    private System.Windows.Forms.Button btnClose;
  }
}