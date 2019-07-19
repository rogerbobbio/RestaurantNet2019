namespace RestaurantNet
{
  partial class frmInsumoPresentacion
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
      this.cbProveedor = new System.Windows.Forms.ComboBox();
      this.label18 = new System.Windows.Forms.Label();
      this.txtUltimoCosto = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.cbEstado = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtDescripcion = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.cbGrupo = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.cbInsumoBase = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.txtCostoPromedio = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtIGV = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtCostoImpuesto = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtRendimiento = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtRendimientoUnidad = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.epDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
      this.epGrupo = new System.Windows.Forms.ErrorProvider(this.components);
      this.epUltimoCosto = new System.Windows.Forms.ErrorProvider(this.components);
      this.epIGV = new System.Windows.Forms.ErrorProvider(this.components);
      this.epCostoImpuesto = new System.Windows.Forms.ErrorProvider(this.components);
      this.epRendimiento = new System.Windows.Forms.ErrorProvider(this.components);
      this.epUnidad = new System.Windows.Forms.ErrorProvider(this.components);
      this.btnCalculo = new System.Windows.Forms.Button();
      this.label11 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epGrupo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epUltimoCosto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epIGV)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epCostoImpuesto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epRendimiento)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.epUnidad)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.TabIndex = 13;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.TabIndex = 14;
      // 
      // btnDelete
      // 
      this.btnDelete.TabIndex = 12;
      // 
      // cbProveedor
      // 
      this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbProveedor.FormattingEnabled = true;
      this.cbProveedor.Location = new System.Drawing.Point(114, 181);
      this.cbProveedor.MaxLength = 20;
      this.cbProveedor.Name = "cbProveedor";
      this.cbProveedor.Size = new System.Drawing.Size(294, 24);
      this.cbProveedor.TabIndex = 5;
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.Location = new System.Drawing.Point(12, 184);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(78, 16);
      this.label18.TabIndex = 116;
      this.label18.Text = "Proveedor :";
      // 
      // txtUltimoCosto
      // 
      this.txtUltimoCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUltimoCosto.Location = new System.Drawing.Point(114, 211);
      this.txtUltimoCosto.MaxLength = 44;
      this.txtUltimoCosto.Name = "txtUltimoCosto";
      this.txtUltimoCosto.Size = new System.Drawing.Size(100, 22);
      this.txtUltimoCosto.TabIndex = 6;
      this.txtUltimoCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtUltimoCosto.TextChanged += new System.EventHandler(this.txtUltimoCosto_TextChanged);
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(11, 214);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(90, 16);
      this.label14.TabIndex = 115;
      this.label14.Text = "Ultimo Costo :";
      // 
      // cbEstado
      // 
      this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEstado.FormattingEnabled = true;
      this.cbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
      this.cbEstado.Location = new System.Drawing.Point(377, 91);
      this.cbEstado.Name = "cbEstado";
      this.cbEstado.Size = new System.Drawing.Size(121, 24);
      this.cbEstado.TabIndex = 2;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(314, 97);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(57, 16);
      this.label8.TabIndex = 114;
      this.label8.Text = "Estado :";
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDescripcion.Location = new System.Drawing.Point(114, 121);
      this.txtDescripcion.MaxLength = 100;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new System.Drawing.Size(384, 22);
      this.txtDescripcion.TabIndex = 3;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(11, 124);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(86, 16);
      this.label7.TabIndex = 112;
      this.label7.Text = "Descripcion :";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(12, 153);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(92, 16);
      this.label10.TabIndex = 111;
      this.label10.Text = "Insumo Base :";
      // 
      // cbGrupo
      // 
      this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbGrupo.FormattingEnabled = true;
      this.cbGrupo.Items.AddRange(new object[] {
            "NORMAL",
            "ADICIONAL",
            "PERSONALIZADO"});
      this.cbGrupo.Location = new System.Drawing.Point(114, 91);
      this.cbGrupo.Name = "cbGrupo";
      this.cbGrupo.Size = new System.Drawing.Size(180, 24);
      this.cbGrupo.TabIndex = 1;
      this.cbGrupo.SelectedValueChanged += new System.EventHandler(this.cbGrupo_SelectedValueChanged);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(11, 94);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(51, 16);
      this.label9.TabIndex = 110;
      this.label9.Text = "Grupo :";
      // 
      // cbInsumoBase
      // 
      this.cbInsumoBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbInsumoBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbInsumoBase.FormattingEnabled = true;
      this.cbInsumoBase.Location = new System.Drawing.Point(114, 150);
      this.cbInsumoBase.MaxLength = 20;
      this.cbInsumoBase.Name = "cbInsumoBase";
      this.cbInsumoBase.Size = new System.Drawing.Size(294, 24);
      this.cbInsumoBase.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(11, 63);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 16);
      this.label1.TabIndex = 109;
      this.label1.Text = "Codigo :";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Enabled = false;
      this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCodigo.Location = new System.Drawing.Point(114, 63);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(100, 22);
      this.txtCodigo.TabIndex = 0;
      // 
      // txtCostoPromedio
      // 
      this.txtCostoPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCostoPromedio.Location = new System.Drawing.Point(114, 239);
      this.txtCostoPromedio.MaxLength = 44;
      this.txtCostoPromedio.Name = "txtCostoPromedio";
      this.txtCostoPromedio.Size = new System.Drawing.Size(100, 22);
      this.txtCostoPromedio.TabIndex = 7;
      this.txtCostoPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(11, 242);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(111, 16);
      this.label2.TabIndex = 118;
      this.label2.Text = "Costo Promedio :";
      // 
      // txtIGV
      // 
      this.txtIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtIGV.Location = new System.Drawing.Point(114, 267);
      this.txtIGV.MaxLength = 44;
      this.txtIGV.Name = "txtIGV";
      this.txtIGV.Size = new System.Drawing.Size(100, 22);
      this.txtIGV.TabIndex = 8;
      this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtIGV.TextChanged += new System.EventHandler(this.txtUltimoCosto_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 270);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(36, 16);
      this.label3.TabIndex = 120;
      this.label3.Text = "IGV :";
      // 
      // txtCostoImpuesto
      // 
      this.txtCostoImpuesto.Enabled = false;
      this.txtCostoImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCostoImpuesto.Location = new System.Drawing.Point(114, 295);
      this.txtCostoImpuesto.MaxLength = 44;
      this.txtCostoImpuesto.Name = "txtCostoImpuesto";
      this.txtCostoImpuesto.ReadOnly = true;
      this.txtCostoImpuesto.Size = new System.Drawing.Size(100, 22);
      this.txtCostoImpuesto.TabIndex = 9;
      this.txtCostoImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 298);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(107, 16);
      this.label4.TabIndex = 122;
      this.label4.Text = "Costo Impuesto :";
      // 
      // txtRendimiento
      // 
      this.txtRendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRendimiento.Location = new System.Drawing.Point(114, 323);
      this.txtRendimiento.MaxLength = 44;
      this.txtRendimiento.Name = "txtRendimiento";
      this.txtRendimiento.Size = new System.Drawing.Size(100, 22);
      this.txtRendimiento.TabIndex = 10;
      this.txtRendimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(11, 326);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(90, 16);
      this.label5.TabIndex = 124;
      this.label5.Text = "Rendimiento :";
      // 
      // txtRendimientoUnidad
      // 
      this.txtRendimientoUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRendimientoUnidad.Location = new System.Drawing.Point(114, 361);
      this.txtRendimientoUnidad.MaxLength = 44;
      this.txtRendimientoUnidad.Name = "txtRendimientoUnidad";
      this.txtRendimientoUnidad.Size = new System.Drawing.Size(100, 22);
      this.txtRendimientoUnidad.TabIndex = 11;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(220, 270);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(28, 16);
      this.label6.TabIndex = 126;
      this.label6.Text = "(%)";
      // 
      // epDescripcion
      // 
      this.epDescripcion.ContainerControl = this;
      // 
      // epGrupo
      // 
      this.epGrupo.ContainerControl = this;
      // 
      // epUltimoCosto
      // 
      this.epUltimoCosto.ContainerControl = this;
      // 
      // epIGV
      // 
      this.epIGV.ContainerControl = this;
      // 
      // epCostoImpuesto
      // 
      this.epCostoImpuesto.ContainerControl = this;
      // 
      // epRendimiento
      // 
      this.epRendimiento.ContainerControl = this;
      // 
      // epUnidad
      // 
      this.epUnidad.ContainerControl = this;
      // 
      // btnCalculo
      // 
      this.btnCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCalculo.Location = new System.Drawing.Point(227, 293);
      this.btnCalculo.Name = "btnCalculo";
      this.btnCalculo.Size = new System.Drawing.Size(169, 27);
      this.btnCalculo.TabIndex = 127;
      this.btnCalculo.Text = "Calcular Costo Impuesto";
      this.btnCalculo.UseVisualStyleBackColor = true;
      this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
      // 
      // label11
      // 
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(12, 356);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(90, 33);
      this.label11.TabIndex = 128;
      this.label11.Text = "Rendimiento Unidad :";
      // 
      // frmInsumoPresentacion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(510, 395);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.btnCalculo);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtRendimiento);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtCostoImpuesto);
      this.Controls.Add(this.txtRendimientoUnidad);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtIGV);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtCostoPromedio);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cbProveedor);
      this.Controls.Add(this.label18);
      this.Controls.Add(this.txtUltimoCosto);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.cbEstado);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.txtDescripcion);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.cbGrupo);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.cbInsumoBase);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCodigo);
      this.Name = "frmInsumoPresentacion";
      this.Text = "frmInsumoPresentacion";
      this.Load += new System.EventHandler(this.frmInsumoPresentacion_Load);
      this.Controls.SetChildIndex(this.txtCodigo, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.cbInsumoBase, 0);
      this.Controls.SetChildIndex(this.label9, 0);
      this.Controls.SetChildIndex(this.cbGrupo, 0);
      this.Controls.SetChildIndex(this.label10, 0);
      this.Controls.SetChildIndex(this.label7, 0);
      this.Controls.SetChildIndex(this.txtDescripcion, 0);
      this.Controls.SetChildIndex(this.label8, 0);
      this.Controls.SetChildIndex(this.cbEstado, 0);
      this.Controls.SetChildIndex(this.label14, 0);
      this.Controls.SetChildIndex(this.txtUltimoCosto, 0);
      this.Controls.SetChildIndex(this.label18, 0);
      this.Controls.SetChildIndex(this.cbProveedor, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.txtCostoPromedio, 0);
      this.Controls.SetChildIndex(this.label3, 0);
      this.Controls.SetChildIndex(this.txtIGV, 0);
      this.Controls.SetChildIndex(this.label4, 0);
      this.Controls.SetChildIndex(this.txtRendimientoUnidad, 0);
      this.Controls.SetChildIndex(this.txtCostoImpuesto, 0);
      this.Controls.SetChildIndex(this.label5, 0);
      this.Controls.SetChildIndex(this.txtRendimiento, 0);
      this.Controls.SetChildIndex(this.label6, 0);
      this.Controls.SetChildIndex(this.btnCalculo, 0);
      this.Controls.SetChildIndex(this.btnClose, 0);
      this.Controls.SetChildIndex(this.btnDelete, 0);
      this.Controls.SetChildIndex(this.btnSave, 0);
      this.Controls.SetChildIndex(this.label11, 0);
      ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epGrupo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epUltimoCosto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epIGV)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epCostoImpuesto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epRendimiento)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.epUnidad)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cbProveedor;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.TextBox txtUltimoCosto;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.ComboBox cbEstado;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox cbGrupo;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox cbInsumoBase;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.TextBox txtCostoPromedio;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtIGV;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtCostoImpuesto;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtRendimiento;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtRendimientoUnidad;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ErrorProvider epDescripcion;
    private System.Windows.Forms.ErrorProvider epGrupo;
    private System.Windows.Forms.ErrorProvider epUltimoCosto;
    private System.Windows.Forms.ErrorProvider epIGV;
    private System.Windows.Forms.ErrorProvider epCostoImpuesto;
    private System.Windows.Forms.ErrorProvider epRendimiento;
    private System.Windows.Forms.ErrorProvider epUnidad;
    private System.Windows.Forms.Button btnCalculo;
    private System.Windows.Forms.Label label11;
  }
}