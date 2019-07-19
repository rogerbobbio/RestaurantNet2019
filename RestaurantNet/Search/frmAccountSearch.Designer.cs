namespace RestaurantNet
{
  partial class frmAccountSearch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountSearch));
      this.txtCuenta = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.btnClean = new System.Windows.Forms.Button();
      this.lblNo = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.dgwResult = new System.Windows.Forms.DataGridView();
      this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
      this.lblFechaInicio = new System.Windows.Forms.Label();
      this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
      this.lblFechaFin = new System.Windows.Forms.Label();
      this.cbAll = new System.Windows.Forms.CheckBox();
      this.txtCuentaPadre = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label9 = new System.Windows.Forms.Label();
      this.radmccbTurno = new Telerik.WinControls.UI.RadMultiColumnComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl.MasterGridViewTemplate)).BeginInit();
      this.SuspendLayout();
      // 
      // txtCuenta
      // 
      this.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCuenta.Location = new System.Drawing.Point(140, 23);
      this.txtCuenta.MaxLength = 100;
      this.txtCuenta.Name = "txtCuenta";
      this.txtCuenta.Size = new System.Drawing.Size(93, 22);
      this.txtCuenta.TabIndex = 0;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(9, 26);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(119, 16);
      this.label7.TabIndex = 114;
      this.label7.Text = "Numero de orden :";
      // 
      // btnClean
      // 
      this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClean.Image = global::RestaurantNet.RestautantResource.deshacer;
      this.btnClean.Location = new System.Drawing.Point(798, 65);
      this.btnClean.Name = "btnClean";
      this.btnClean.Size = new System.Drawing.Size(80, 59);
      this.btnClean.TabIndex = 4;
      this.btnClean.Text = "Limpiar";
      this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClean.UseVisualStyleBackColor = true;
      this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
      // 
      // lblNo
      // 
      this.lblNo.AutoSize = true;
      this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNo.Location = new System.Drawing.Point(289, 127);
      this.lblNo.Name = "lblNo";
      this.lblNo.Size = new System.Drawing.Size(29, 16);
      this.lblNo.TabIndex = 106;
      this.lblNo.Text = "999";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(8, 127);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(275, 16);
      this.label1.TabIndex = 105;
      this.label1.Text = "Numeros de registro(s) encontrado(s) :";
      // 
      // btnSearch
      // 
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
      this.btnSearch.Location = new System.Drawing.Point(712, 65);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(80, 59);
      this.btnSearch.TabIndex = 3;
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
      this.btnClose.Location = new System.Drawing.Point(881, 65);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(80, 59);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Cerrar";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // dgwResult
      // 
      this.dgwResult.AllowUserToAddRows = false;
      this.dgwResult.AllowUserToDeleteRows = false;
      this.dgwResult.AllowUserToOrderColumns = true;
      this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgwResult.Location = new System.Drawing.Point(9, 146);
      this.dgwResult.MultiSelect = false;
      this.dgwResult.Name = "dgwResult";
      this.dgwResult.ReadOnly = true;
      this.dgwResult.Size = new System.Drawing.Size(952, 378);
      this.dgwResult.TabIndex = 6;
      this.dgwResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwResult_CellDoubleClick);
      // 
      // dtpFechaInicio
      // 
      this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaInicio.Location = new System.Drawing.Point(254, 28);
      this.dtpFechaInicio.Name = "dtpFechaInicio";
      this.dtpFechaInicio.Size = new System.Drawing.Size(100, 22);
      this.dtpFechaInicio.TabIndex = 1;
      // 
      // lblFechaInicio
      // 
      this.lblFechaInicio.AutoSize = true;
      this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFechaInicio.Location = new System.Drawing.Point(13, 31);
      this.lblFechaInicio.Name = "lblFechaInicio";
      this.lblFechaInicio.Size = new System.Drawing.Size(141, 16);
      this.lblFechaInicio.TabIndex = 117;
      this.lblFechaInicio.Text = "Fecha Pedido (Inicio) :";
      // 
      // dtpFechaFin
      // 
      this.dtpFechaFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaFin.Location = new System.Drawing.Point(254, 55);
      this.dtpFechaFin.Name = "dtpFechaFin";
      this.dtpFechaFin.Size = new System.Drawing.Size(100, 22);
      this.dtpFechaFin.TabIndex = 2;
      // 
      // lblFechaFin
      // 
      this.lblFechaFin.AutoSize = true;
      this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFechaFin.Location = new System.Drawing.Point(14, 55);
      this.lblFechaFin.Name = "lblFechaFin";
      this.lblFechaFin.Size = new System.Drawing.Size(128, 16);
      this.lblFechaFin.TabIndex = 119;
      this.lblFechaFin.Text = "Fecha Pedido (Fin) :";
      // 
      // cbAll
      // 
      this.cbAll.AutoSize = true;
      this.cbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbAll.Location = new System.Drawing.Point(63, 0);
      this.cbAll.Name = "cbAll";
      this.cbAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.cbAll.Size = new System.Drawing.Size(120, 20);
      this.cbAll.TabIndex = 0;
      this.cbAll.Text = "Cualquier fecha";
      this.cbAll.UseVisualStyleBackColor = true;
      this.cbAll.Click += new System.EventHandler(this.cbAll_Click);
      // 
      // txtCuentaPadre
      // 
      this.txtCuentaPadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCuentaPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCuentaPadre.Location = new System.Drawing.Point(140, 51);
      this.txtCuentaPadre.MaxLength = 100;
      this.txtCuentaPadre.Name = "txtCuentaPadre";
      this.txtCuentaPadre.Size = new System.Drawing.Size(93, 22);
      this.txtCuentaPadre.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(9, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(94, 16);
      this.label2.TabIndex = 122;
      this.label2.Text = "Orden Origen :";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lblFechaInicio);
      this.groupBox1.Controls.Add(this.dtpFechaInicio);
      this.groupBox1.Controls.Add(this.lblFechaFin);
      this.groupBox1.Controls.Add(this.cbAll);
      this.groupBox1.Controls.Add(this.dtpFechaFin);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(255, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(374, 93);
      this.groupBox1.TabIndex = 121;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Fecha";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(9, 87);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(49, 16);
      this.label9.TabIndex = 126;
      this.label9.Text = "Turno :";
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
      this.radmccbTurno.EditorControl.Location = new System.Drawing.Point(66, 108);
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
      this.radmccbTurno.EditorControl.TabIndex = 124;
      this.radmccbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radmccbTurno.ForeColor = System.Drawing.Color.Black;
      this.radmccbTurno.Location = new System.Drawing.Point(66, 83);
      this.radmccbTurno.Name = "radmccbTurno";
      // 
      // 
      // 
      this.radmccbTurno.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
      this.radmccbTurno.RootElement.ForeColor = System.Drawing.Color.Black;
      this.radmccbTurno.Size = new System.Drawing.Size(167, 22);
      this.radmccbTurno.TabIndex = 2;
      // 
      // frmAccountSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 534);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.radmccbTurno);
      this.Controls.Add(this.txtCuentaPadre);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.txtCuenta);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.btnClean);
      this.Controls.Add(this.lblNo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.dgwResult);
      this.Name = "frmAccountSearch";
      this.Text = "Busqueda de...";
      this.Load += new System.EventHandler(this.frmAccountSearch_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl.MasterGridViewTemplate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtCuenta;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnClean;
    private System.Windows.Forms.Label lblNo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnClose;
    public System.Windows.Forms.DataGridView dgwResult;
    private System.Windows.Forms.DateTimePicker dtpFechaInicio;
    private System.Windows.Forms.Label lblFechaInicio;
    private System.Windows.Forms.DateTimePicker dtpFechaFin;
    private System.Windows.Forms.Label lblFechaFin;
    private System.Windows.Forms.CheckBox cbAll;
    private System.Windows.Forms.TextBox txtCuentaPadre;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label9;
    private Telerik.WinControls.UI.RadMultiColumnComboBox radmccbTurno;
  }
}