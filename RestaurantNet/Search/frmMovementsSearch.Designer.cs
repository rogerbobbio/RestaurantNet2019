namespace RestaurantNet
{
  partial class frmMovementsSearch
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.radmccbTurno = new Telerik.WinControls.UI.RadMultiColumnComboBox();
      this.btnClean = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.cbEstacion = new System.Windows.Forms.ComboBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cbTipoMovimiento = new System.Windows.Forms.ComboBox();
      this.dgwResult = new System.Windows.Forms.DataGridView();
      this.lblNo = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.Turno_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Estacion_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Tipo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl.MasterGridViewTemplate)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
      this.SuspendLayout();
      // 
      // radmccbTurno
      // 
      this.radmccbTurno.AutoFilter = true;
      // 
      // radmccbTurno.NestedRadGridView
      // 
      this.radmccbTurno.EditorControl.BackColor = System.Drawing.SystemColors.Window;
      this.radmccbTurno.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radmccbTurno.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
      this.radmccbTurno.EditorControl.Location = new System.Drawing.Point(0, 0);
      // 
      // 
      // 
      this.radmccbTurno.EditorControl.MasterGridViewTemplate.AllowAddNewRow = false;
      this.radmccbTurno.EditorControl.MasterGridViewTemplate.AllowCellContextMenu = false;
      this.radmccbTurno.EditorControl.MasterGridViewTemplate.AllowColumnChooser = false;
      this.radmccbTurno.EditorControl.MasterGridViewTemplate.EnableFiltering = true;
      this.radmccbTurno.EditorControl.MasterGridViewTemplate.EnableGrouping = false;
      this.radmccbTurno.EditorControl.MasterGridViewTemplate.ShowFilteringRow = false;
      this.radmccbTurno.EditorControl.Name = "NestedRadGridView";
      this.radmccbTurno.EditorControl.ReadOnly = true;
      this.radmccbTurno.EditorControl.ShowGroupPanel = false;
      this.radmccbTurno.EditorControl.Size = new System.Drawing.Size(240, 150);
      this.radmccbTurno.EditorControl.TabIndex = 0;
      this.radmccbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radmccbTurno.ForeColor = System.Drawing.Color.Black;
      this.radmccbTurno.Location = new System.Drawing.Point(84, 22);
      this.radmccbTurno.Name = "radmccbTurno";
      // 
      // 
      // 
      this.radmccbTurno.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
      this.radmccbTurno.RootElement.ForeColor = System.Drawing.Color.Black;
      this.radmccbTurno.Size = new System.Drawing.Size(167, 22);
      this.radmccbTurno.TabIndex = 0;
      // 
      // btnClean
      // 
      this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClean.Image = global::RestaurantNet.RestautantResource.limpiar;
      this.btnClean.Location = new System.Drawing.Point(498, 22);
      this.btnClean.Name = "btnClean";
      this.btnClean.Size = new System.Drawing.Size(80, 65);
      this.btnClean.TabIndex = 112;
      this.btnClean.Text = "Limpiar";
      this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClean.UseVisualStyleBackColor = true;
      this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Image = global::RestaurantNet.RestautantResource.buscar;
      this.btnSearch.Location = new System.Drawing.Point(412, 22);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(80, 65);
      this.btnSearch.TabIndex = 111;
      this.btnSearch.Text = "Buscar";
      this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.salir;
      this.btnClose.Location = new System.Drawing.Point(584, 22);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(80, 65);
      this.btnClose.TabIndex = 110;
      this.btnClose.Text = "Cerrar";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(12, 25);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(49, 16);
      this.label9.TabIndex = 113;
      this.label9.Text = "Turno :";
      // 
      // cbEstacion
      // 
      this.cbEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEstacion.FormattingEnabled = true;
      this.cbEstacion.Location = new System.Drawing.Point(84, 50);
      this.cbEstacion.MaxLength = 20;
      this.cbEstacion.Name = "cbEstacion";
      this.cbEstacion.Size = new System.Drawing.Size(211, 24);
      this.cbEstacion.TabIndex = 114;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(12, 53);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(66, 16);
      this.label13.TabIndex = 115;
      this.label13.Text = "Estacion :";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 83);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 16);
      this.label1.TabIndex = 116;
      this.label1.Text = "Tipo :";
      // 
      // cbTipoMovimiento
      // 
      this.cbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbTipoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbTipoMovimiento.FormattingEnabled = true;
      this.cbTipoMovimiento.Items.AddRange(new object[] {
            "",
            "RETIRO",
            "DEPOSITO"});
      this.cbTipoMovimiento.Location = new System.Drawing.Point(84, 80);
      this.cbTipoMovimiento.MaxLength = 20;
      this.cbTipoMovimiento.Name = "cbTipoMovimiento";
      this.cbTipoMovimiento.Size = new System.Drawing.Size(211, 24);
      this.cbTipoMovimiento.TabIndex = 117;
      // 
      // dgwResult
      // 
      this.dgwResult.AllowUserToAddRows = false;
      this.dgwResult.AllowUserToDeleteRows = false;
      this.dgwResult.AllowUserToOrderColumns = true;
      this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgwResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turno_id,
            this.Estacion_descripcion,
            this.Tipo_Movimiento,
            this.Concepto,
            this.Importe,
            this.Fecha_creacion});
      this.dgwResult.Location = new System.Drawing.Point(15, 135);
      this.dgwResult.MultiSelect = false;
      this.dgwResult.Name = "dgwResult";
      this.dgwResult.ReadOnly = true;
      this.dgwResult.Size = new System.Drawing.Size(649, 328);
      this.dgwResult.TabIndex = 118;
      // 
      // lblNo
      // 
      this.lblNo.AutoSize = true;
      this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNo.Location = new System.Drawing.Point(293, 116);
      this.lblNo.Name = "lblNo";
      this.lblNo.Size = new System.Drawing.Size(29, 16);
      this.lblNo.TabIndex = 120;
      this.lblNo.Text = "999";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 116);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(275, 16);
      this.label2.TabIndex = 119;
      this.label2.Text = "Numeros de registro(s) encontrado(s) :";
      // 
      // txtTotal
      // 
      this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTotal.Location = new System.Drawing.Point(564, 469);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new System.Drawing.Size(100, 22);
      this.txtTotal.TabIndex = 122;
      this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(506, 472);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 16);
      this.label3.TabIndex = 121;
      this.label3.Text = "Total :";
      // 
      // Turno_id
      // 
      this.Turno_id.HeaderText = "Turno Code";
      this.Turno_id.Name = "Turno_id";
      this.Turno_id.ReadOnly = true;
      // 
      // Estacion_descripcion
      // 
      this.Estacion_descripcion.HeaderText = "Estacion";
      this.Estacion_descripcion.Name = "Estacion_descripcion";
      this.Estacion_descripcion.ReadOnly = true;
      // 
      // Tipo_Movimiento
      // 
      this.Tipo_Movimiento.HeaderText = "Tipo Movimiento";
      this.Tipo_Movimiento.Name = "Tipo_Movimiento";
      this.Tipo_Movimiento.ReadOnly = true;
      // 
      // Concepto
      // 
      this.Concepto.HeaderText = "Concepto";
      this.Concepto.Name = "Concepto";
      this.Concepto.ReadOnly = true;
      // 
      // Importe
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.Importe.DefaultCellStyle = dataGridViewCellStyle2;
      this.Importe.HeaderText = "Importe";
      this.Importe.Name = "Importe";
      this.Importe.ReadOnly = true;
      // 
      // Fecha_creacion
      // 
      this.Fecha_creacion.HeaderText = "Realizado el";
      this.Fecha_creacion.Name = "Fecha_creacion";
      this.Fecha_creacion.ReadOnly = true;
      // 
      // frmMovementsSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(673, 501);
      this.Controls.Add(this.txtTotal);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lblNo);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dgwResult);
      this.Controls.Add(this.cbTipoMovimiento);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbEstacion);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.btnClean);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.radmccbTurno);
      this.Name = "frmMovementsSearch";
      this.Text = "Restaurant Net - Consulta de Movimientos";
      this.Load += new System.EventHandler(this.frmMovementsSearch_Load);
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl.MasterGridViewTemplate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Telerik.WinControls.UI.RadMultiColumnComboBox radmccbTurno;
    private System.Windows.Forms.Button btnClean;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox cbEstacion;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbTipoMovimiento;
    public System.Windows.Forms.DataGridView dgwResult;
    private System.Windows.Forms.Label lblNo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Turno_id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Estacion_descripcion;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Movimiento;
    private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
    private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_creacion;
  }
}