namespace RestaurantNet
{
  partial class frmMonitorSales
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cbTipoVentas = new System.Windows.Forms.ComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtVentaTotal = new System.Windows.Forms.TextBox();
      this.txtVentaDescuentos = new System.Windows.Forms.TextBox();
      this.txtVentaSubtotal = new System.Windows.Forms.TextBox();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.txtVentaOtros = new System.Windows.Forms.TextBox();
      this.txtVentaAlimentos = new System.Windows.Forms.TextBox();
      this.txtVentaBedidas = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtVentaTotalPorTipo = new System.Windows.Forms.TextBox();
      this.textBox12 = new System.Windows.Forms.TextBox();
      this.textBox13 = new System.Windows.Forms.TextBox();
      this.textBox14 = new System.Windows.Forms.TextBox();
      this.txtVentaRapida = new System.Windows.Forms.TextBox();
      this.txtVentaDelivery = new System.Windows.Forms.TextBox();
      this.txtVentaSalon = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.txtVentaConIGV = new System.Windows.Forms.TextBox();
      this.txtVentaIGV = new System.Windows.Forms.TextBox();
      this.label17 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.txtOrdenesPagadas = new System.Windows.Forms.TextBox();
      this.txtOrdenesAbiertas = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.txtVentaCheque = new System.Windows.Forms.TextBox();
      this.label19 = new System.Windows.Forms.Label();
      this.txtVentaTarjetaCredito = new System.Windows.Forms.TextBox();
      this.txtVentaContado = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.radmccbTurno = new Telerik.WinControls.UI.RadMultiColumnComboBox();
      this.btnVerProductosVendidos = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl.MasterGridViewTemplate)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(23, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 16);
      this.label1.TabIndex = 119;
      this.label1.Text = "Turno :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(475, 26);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 16);
      this.label2.TabIndex = 120;
      this.label2.Text = "Ventas :";
      // 
      // cbTipoVentas
      // 
      this.cbTipoVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbTipoVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbTipoVentas.FormattingEnabled = true;
      this.cbTipoVentas.Items.AddRange(new object[] {
            "TODAS",
            "COBRADAS",
            "POR COBRAR"});
      this.cbTipoVentas.Location = new System.Drawing.Point(537, 22);
      this.cbTipoVentas.MaxLength = 20;
      this.cbTipoVentas.Name = "cbTipoVentas";
      this.cbTipoVentas.Size = new System.Drawing.Size(165, 24);
      this.cbTipoVentas.TabIndex = 121;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtVentaTotal);
      this.groupBox1.Controls.Add(this.txtVentaDescuentos);
      this.groupBox1.Controls.Add(this.txtVentaSubtotal);
      this.groupBox1.Controls.Add(this.textBox6);
      this.groupBox1.Controls.Add(this.textBox5);
      this.groupBox1.Controls.Add(this.textBox4);
      this.groupBox1.Controls.Add(this.txtVentaOtros);
      this.groupBox1.Controls.Add(this.txtVentaAlimentos);
      this.groupBox1.Controls.Add(this.txtVentaBedidas);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(24, 62);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(353, 239);
      this.groupBox1.TabIndex = 122;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Venta (Sin IGV)";
      // 
      // txtVentaTotal
      // 
      this.txtVentaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVentaTotal.Location = new System.Drawing.Point(139, 187);
      this.txtVentaTotal.Name = "txtVentaTotal";
      this.txtVentaTotal.ReadOnly = true;
      this.txtVentaTotal.Size = new System.Drawing.Size(100, 22);
      this.txtVentaTotal.TabIndex = 132;
      this.txtVentaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtVentaDescuentos
      // 
      this.txtVentaDescuentos.Location = new System.Drawing.Point(139, 163);
      this.txtVentaDescuentos.Name = "txtVentaDescuentos";
      this.txtVentaDescuentos.ReadOnly = true;
      this.txtVentaDescuentos.Size = new System.Drawing.Size(100, 22);
      this.txtVentaDescuentos.TabIndex = 131;
      this.txtVentaDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtVentaSubtotal
      // 
      this.txtVentaSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVentaSubtotal.Location = new System.Drawing.Point(139, 138);
      this.txtVentaSubtotal.Name = "txtVentaSubtotal";
      this.txtVentaSubtotal.ReadOnly = true;
      this.txtVentaSubtotal.Size = new System.Drawing.Size(100, 22);
      this.txtVentaSubtotal.TabIndex = 130;
      this.txtVentaSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(245, 73);
      this.textBox6.Name = "textBox6";
      this.textBox6.ReadOnly = true;
      this.textBox6.Size = new System.Drawing.Size(47, 22);
      this.textBox6.TabIndex = 129;
      this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(245, 49);
      this.textBox5.Name = "textBox5";
      this.textBox5.ReadOnly = true;
      this.textBox5.Size = new System.Drawing.Size(47, 22);
      this.textBox5.TabIndex = 128;
      this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(245, 24);
      this.textBox4.Name = "textBox4";
      this.textBox4.ReadOnly = true;
      this.textBox4.Size = new System.Drawing.Size(47, 22);
      this.textBox4.TabIndex = 127;
      this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtVentaOtros
      // 
      this.txtVentaOtros.Location = new System.Drawing.Point(139, 73);
      this.txtVentaOtros.Name = "txtVentaOtros";
      this.txtVentaOtros.ReadOnly = true;
      this.txtVentaOtros.Size = new System.Drawing.Size(100, 22);
      this.txtVentaOtros.TabIndex = 126;
      this.txtVentaOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtVentaAlimentos
      // 
      this.txtVentaAlimentos.Location = new System.Drawing.Point(139, 49);
      this.txtVentaAlimentos.Name = "txtVentaAlimentos";
      this.txtVentaAlimentos.ReadOnly = true;
      this.txtVentaAlimentos.Size = new System.Drawing.Size(100, 22);
      this.txtVentaAlimentos.TabIndex = 125;
      this.txtVentaAlimentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtVentaBedidas
      // 
      this.txtVentaBedidas.Location = new System.Drawing.Point(139, 24);
      this.txtVentaBedidas.Name = "txtVentaBedidas";
      this.txtVentaBedidas.ReadOnly = true;
      this.txtVentaBedidas.Size = new System.Drawing.Size(100, 22);
      this.txtVentaBedidas.TabIndex = 124;
      this.txtVentaBedidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(17, 190);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(96, 16);
      this.label8.TabIndex = 122;
      this.label8.Text = "Venta Total :";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(21, 166);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(93, 16);
      this.label7.TabIndex = 121;
      this.label7.Text = "- Descuentos :";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(51, 141);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(63, 16);
      this.label6.TabIndex = 120;
      this.label6.Text = "Subtotal :";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(48, 76);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(46, 16);
      this.label5.TabIndex = 119;
      this.label5.Text = "Otros :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(21, 52);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(73, 16);
      this.label4.TabIndex = 118;
      this.label4.Text = "Alimentos :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(29, 27);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(65, 16);
      this.label3.TabIndex = 117;
      this.label3.Text = "Bebidas :";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtVentaTotalPorTipo);
      this.groupBox2.Controls.Add(this.textBox12);
      this.groupBox2.Controls.Add(this.textBox13);
      this.groupBox2.Controls.Add(this.textBox14);
      this.groupBox2.Controls.Add(this.txtVentaRapida);
      this.groupBox2.Controls.Add(this.txtVentaDelivery);
      this.groupBox2.Controls.Add(this.txtVentaSalon);
      this.groupBox2.Controls.Add(this.label10);
      this.groupBox2.Controls.Add(this.label11);
      this.groupBox2.Controls.Add(this.label12);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(383, 62);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(353, 152);
      this.groupBox2.TabIndex = 123;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Venta Por Tipo de Servicio (Incluye IGV)";
      // 
      // txtVentaTotalPorTipo
      // 
      this.txtVentaTotalPorTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVentaTotalPorTipo.Location = new System.Drawing.Point(113, 119);
      this.txtVentaTotalPorTipo.Name = "txtVentaTotalPorTipo";
      this.txtVentaTotalPorTipo.ReadOnly = true;
      this.txtVentaTotalPorTipo.Size = new System.Drawing.Size(100, 22);
      this.txtVentaTotalPorTipo.TabIndex = 136;
      this.txtVentaTotalPorTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // textBox12
      // 
      this.textBox12.Location = new System.Drawing.Point(219, 73);
      this.textBox12.Name = "textBox12";
      this.textBox12.ReadOnly = true;
      this.textBox12.Size = new System.Drawing.Size(47, 22);
      this.textBox12.TabIndex = 135;
      this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // textBox13
      // 
      this.textBox13.Location = new System.Drawing.Point(219, 49);
      this.textBox13.Name = "textBox13";
      this.textBox13.ReadOnly = true;
      this.textBox13.Size = new System.Drawing.Size(47, 22);
      this.textBox13.TabIndex = 134;
      this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // textBox14
      // 
      this.textBox14.Location = new System.Drawing.Point(219, 24);
      this.textBox14.Name = "textBox14";
      this.textBox14.ReadOnly = true;
      this.textBox14.Size = new System.Drawing.Size(47, 22);
      this.textBox14.TabIndex = 133;
      this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtVentaRapida
      // 
      this.txtVentaRapida.Location = new System.Drawing.Point(113, 73);
      this.txtVentaRapida.Name = "txtVentaRapida";
      this.txtVentaRapida.ReadOnly = true;
      this.txtVentaRapida.Size = new System.Drawing.Size(100, 22);
      this.txtVentaRapida.TabIndex = 132;
      this.txtVentaRapida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtVentaDelivery
      // 
      this.txtVentaDelivery.Location = new System.Drawing.Point(113, 49);
      this.txtVentaDelivery.Name = "txtVentaDelivery";
      this.txtVentaDelivery.ReadOnly = true;
      this.txtVentaDelivery.Size = new System.Drawing.Size(100, 22);
      this.txtVentaDelivery.TabIndex = 131;
      this.txtVentaDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtVentaSalon
      // 
      this.txtVentaSalon.Location = new System.Drawing.Point(113, 24);
      this.txtVentaSalon.Name = "txtVentaSalon";
      this.txtVentaSalon.ReadOnly = true;
      this.txtVentaSalon.Size = new System.Drawing.Size(100, 22);
      this.txtVentaSalon.TabIndex = 130;
      this.txtVentaSalon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(22, 76);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(59, 16);
      this.label10.TabIndex = 122;
      this.label10.Text = "Rapida :";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(17, 52);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(64, 16);
      this.label11.TabIndex = 121;
      this.label11.Text = "Delivery :";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(32, 27);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(49, 16);
      this.label12.TabIndex = 120;
      this.label12.Text = "Salon :";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.txtVentaConIGV);
      this.groupBox3.Controls.Add(this.txtVentaIGV);
      this.groupBox3.Controls.Add(this.label17);
      this.groupBox3.Controls.Add(this.label18);
      this.groupBox3.Location = new System.Drawing.Point(24, 307);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(353, 89);
      this.groupBox3.TabIndex = 124;
      this.groupBox3.TabStop = false;
      // 
      // txtVentaConIGV
      // 
      this.txtVentaConIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVentaConIGV.Location = new System.Drawing.Point(139, 53);
      this.txtVentaConIGV.Name = "txtVentaConIGV";
      this.txtVentaConIGV.ReadOnly = true;
      this.txtVentaConIGV.Size = new System.Drawing.Size(100, 22);
      this.txtVentaConIGV.TabIndex = 134;
      this.txtVentaConIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtVentaIGV
      // 
      this.txtVentaIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVentaIGV.Location = new System.Drawing.Point(139, 24);
      this.txtVentaIGV.Name = "txtVentaIGV";
      this.txtVentaIGV.ReadOnly = true;
      this.txtVentaIGV.Size = new System.Drawing.Size(100, 22);
      this.txtVentaIGV.TabIndex = 133;
      this.txtVentaIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.Location = new System.Drawing.Point(3, 56);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(130, 16);
      this.label17.TabIndex = 123;
      this.label17.Text = "Ventas incluido IGV :";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.Location = new System.Drawing.Point(12, 27);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(121, 16);
      this.label18.TabIndex = 122;
      this.label18.Text = "IGV Sobre Ventas :";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.txtOrdenesPagadas);
      this.groupBox4.Controls.Add(this.txtOrdenesAbiertas);
      this.groupBox4.Controls.Add(this.label14);
      this.groupBox4.Controls.Add(this.label15);
      this.groupBox4.Location = new System.Drawing.Point(383, 324);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(353, 72);
      this.groupBox4.TabIndex = 125;
      this.groupBox4.TabStop = false;
      // 
      // txtOrdenesPagadas
      // 
      this.txtOrdenesPagadas.Location = new System.Drawing.Point(199, 41);
      this.txtOrdenesPagadas.Name = "txtOrdenesPagadas";
      this.txtOrdenesPagadas.ReadOnly = true;
      this.txtOrdenesPagadas.Size = new System.Drawing.Size(47, 20);
      this.txtOrdenesPagadas.TabIndex = 137;
      this.txtOrdenesPagadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtOrdenesAbiertas
      // 
      this.txtOrdenesAbiertas.Location = new System.Drawing.Point(199, 15);
      this.txtOrdenesAbiertas.Name = "txtOrdenesAbiertas";
      this.txtOrdenesAbiertas.ReadOnly = true;
      this.txtOrdenesAbiertas.Size = new System.Drawing.Size(47, 20);
      this.txtOrdenesAbiertas.TabIndex = 136;
      this.txtOrdenesAbiertas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(68, 41);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(125, 16);
      this.label14.TabIndex = 121;
      this.label14.Text = "Ordenes Pagadas :";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.Location = new System.Drawing.Point(17, 16);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(176, 16);
      this.label15.TabIndex = 120;
      this.label15.Text = "Ordenes de Salon Abiertas :";
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.txtVentaCheque);
      this.groupBox5.Controls.Add(this.label19);
      this.groupBox5.Controls.Add(this.txtVentaTarjetaCredito);
      this.groupBox5.Controls.Add(this.txtVentaContado);
      this.groupBox5.Controls.Add(this.label13);
      this.groupBox5.Controls.Add(this.label16);
      this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox5.Location = new System.Drawing.Point(386, 217);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(350, 101);
      this.groupBox5.TabIndex = 126;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Venta por Tipo de Pago  (Incluye IGV)";
      // 
      // txtVentaCheque
      // 
      this.txtVentaCheque.Location = new System.Drawing.Point(196, 73);
      this.txtVentaCheque.Name = "txtVentaCheque";
      this.txtVentaCheque.ReadOnly = true;
      this.txtVentaCheque.Size = new System.Drawing.Size(93, 22);
      this.txtVentaCheque.TabIndex = 149;
      this.txtVentaCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label19.Location = new System.Drawing.Point(129, 74);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(61, 16);
      this.label19.TabIndex = 148;
      this.label19.Text = "Cheque :";
      // 
      // txtVentaTarjetaCredito
      // 
      this.txtVentaTarjetaCredito.Location = new System.Drawing.Point(196, 46);
      this.txtVentaTarjetaCredito.Name = "txtVentaTarjetaCredito";
      this.txtVentaTarjetaCredito.ReadOnly = true;
      this.txtVentaTarjetaCredito.Size = new System.Drawing.Size(93, 22);
      this.txtVentaTarjetaCredito.TabIndex = 147;
      this.txtVentaTarjetaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtVentaContado
      // 
      this.txtVentaContado.Location = new System.Drawing.Point(196, 20);
      this.txtVentaContado.Name = "txtVentaContado";
      this.txtVentaContado.ReadOnly = true;
      this.txtVentaContado.Size = new System.Drawing.Size(93, 22);
      this.txtVentaContado.TabIndex = 146;
      this.txtVentaContado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(68, 47);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(122, 16);
      this.label13.TabIndex = 145;
      this.label13.Text = "Tarjeta de Credito :";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.Location = new System.Drawing.Point(125, 21);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(65, 16);
      this.label16.TabIndex = 144;
      this.label16.Text = "Contado :";
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
      this.radmccbTurno.EditorControl.Location = new System.Drawing.Point(185, 4);
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
      this.radmccbTurno.EditorControl.TabIndex = 127;
      this.radmccbTurno.EditorControl.Visible = false;
      this.radmccbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radmccbTurno.ForeColor = System.Drawing.Color.Black;
      this.radmccbTurno.Location = new System.Drawing.Point(78, 24);
      this.radmccbTurno.Name = "radmccbTurno";
      // 
      // 
      // 
      this.radmccbTurno.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
      this.radmccbTurno.RootElement.ForeColor = System.Drawing.Color.Black;
      this.radmccbTurno.Size = new System.Drawing.Size(167, 22);
      this.radmccbTurno.TabIndex = 128;
      // 
      // btnVerProductosVendidos
      // 
      this.btnVerProductosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
      this.btnVerProductosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnVerProductosVendidos.Location = new System.Drawing.Point(742, 161);
      this.btnVerProductosVendidos.Name = "btnVerProductosVendidos";
      this.btnVerProductosVendidos.Size = new System.Drawing.Size(89, 61);
      this.btnVerProductosVendidos.TabIndex = 130;
      this.btnVerProductosVendidos.Text = "Ver Productos Vendidos";
      this.btnVerProductosVendidos.UseVisualStyleBackColor = false;
      this.btnVerProductosVendidos.Click += new System.EventHandler(this.btnVerProductosVendidos_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Image = global::RestaurantNet.RestautantResource.actualizar;
      this.btnSearch.Location = new System.Drawing.Point(742, 12);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(89, 72);
      this.btnSearch.TabIndex = 114;
      this.btnSearch.Text = "Actualizar";
      this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnClose
      // 
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = global::RestaurantNet.RestautantResource.salir;
      this.btnClose.Location = new System.Drawing.Point(742, 90);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(89, 65);
      this.btnClose.TabIndex = 113;
      this.btnClose.Text = "Cerrar";
      this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmMonitorSales
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(840, 406);
      this.Controls.Add(this.btnVerProductosVendidos);
      this.Controls.Add(this.radmccbTurno);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.cbTipoVentas);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.btnClose);
      this.Name = "frmMonitorSales";
      this.Text = "Restaurant Net - Monitor de Ventas";
      this.Load += new System.EventHandler(this.frmMonitorSales_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl.MasterGridViewTemplate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno.EditorControl)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radmccbTurno)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbTipoVentas;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.TextBox txtVentaTotal;
    private System.Windows.Forms.TextBox txtVentaDescuentos;
    private System.Windows.Forms.TextBox txtVentaSubtotal;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox txtVentaOtros;
    private System.Windows.Forms.TextBox txtVentaAlimentos;
    private System.Windows.Forms.TextBox txtVentaBedidas;
    private System.Windows.Forms.TextBox txtVentaConIGV;
    private System.Windows.Forms.TextBox txtVentaIGV;
    private System.Windows.Forms.TextBox textBox12;
    private System.Windows.Forms.TextBox textBox13;
    private System.Windows.Forms.TextBox textBox14;
    private System.Windows.Forms.TextBox txtVentaRapida;
    private System.Windows.Forms.TextBox txtVentaDelivery;
    private System.Windows.Forms.TextBox txtVentaSalon;
    private System.Windows.Forms.TextBox txtVentaTotalPorTipo;
    private System.Windows.Forms.TextBox txtOrdenesPagadas;
    private System.Windows.Forms.TextBox txtOrdenesAbiertas;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.TextBox txtVentaCheque;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.TextBox txtVentaTarjetaCredito;
    private System.Windows.Forms.TextBox txtVentaContado;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label16;
    private Telerik.WinControls.UI.RadMultiColumnComboBox radmccbTurno;
    private System.Windows.Forms.Button btnVerProductosVendidos;
  }
}