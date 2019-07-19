namespace RestaurantNet
{
  partial class frmTableConfig
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
      this.txtDescripcion = new System.Windows.Forms.TextBox();
      this.lblTitulo = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lblTipo = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cbEstado = new System.Windows.Forms.ComboBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.epDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
      this.epDuplicado = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epDuplicado)).BeginInit();
      this.SuspendLayout();
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDescripcion.Location = new System.Drawing.Point(249, 43);
      this.txtDescripcion.MaxLength = 12;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new System.Drawing.Size(149, 22);
      this.txtDescripcion.TabIndex = 0;
      // 
      // lblTitulo
      // 
      this.lblTitulo.AutoSize = true;
      this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitulo.Location = new System.Drawing.Point(13, 46);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(227, 16);
      this.lblTitulo.TabIndex = 53;
      this.lblTitulo.Text = "Numero de Mesa o una descripcion :";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(98, 16);
      this.label1.TabIndex = 54;
      this.label1.Text = "Tipo de Mesa :";
      // 
      // lblTipo
      // 
      this.lblTipo.AutoSize = true;
      this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTipo.Location = new System.Drawing.Point(116, 12);
      this.lblTipo.Name = "lblTipo";
      this.lblTipo.Size = new System.Drawing.Size(112, 16);
      this.lblTipo.TabIndex = 55;
      this.lblTipo.Text = "Tipo de Mesa :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(246, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 16);
      this.label2.TabIndex = 56;
      this.label2.Text = "Habilitado :";
      // 
      // cbEstado
      // 
      this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEstado.FormattingEnabled = true;
      this.cbEstado.Items.AddRange(new object[] {
            "NO",
            "SI"});
      this.cbEstado.Location = new System.Drawing.Point(322, 9);
      this.cbEstado.Name = "cbEstado";
      this.cbEstado.Size = new System.Drawing.Size(76, 24);
      this.cbEstado.TabIndex = 1;
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Image = global::RestaurantNet.RestautantResource.grabar;
      this.btnSave.Location = new System.Drawing.Point(411, 10);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(74, 65);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Grabar";
      this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.deshacer;
      this.btnClose.Location = new System.Drawing.Point(491, 10);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(88, 65);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Cancelar";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // epDescripcion
      // 
      this.epDescripcion.ContainerControl = this;
      // 
      // epDuplicado
      // 
      this.epDuplicado.ContainerControl = this;
      // 
      // frmTableConfig
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(591, 83);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.cbEstado);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblTipo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtDescripcion);
      this.Controls.Add(this.lblTitulo);
      this.Name = "frmTableConfig";
      this.Text = "Informacion de Mesa";
      this.Load += new System.EventHandler(this.frmTableConfig_Load);
      ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epDuplicado)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbEstado;
    public System.Windows.Forms.Button btnSave;
    public System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.ErrorProvider epDescripcion;
    private System.Windows.Forms.ErrorProvider epDuplicado;
  }
}