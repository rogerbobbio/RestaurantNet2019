namespace DBAccessManagement
{
  partial class frmMain
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
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.btnCleanDB = new System.Windows.Forms.Button();
      this.btnSearchDB = new System.Windows.Forms.Button();
      this.txtDB = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btnClearAll = new System.Windows.Forms.Button();
      this.txtMensaje = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnRun = new System.Windows.Forms.Button();
      this.txtSentencia = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btnLimpiarDatos = new System.Windows.Forms.Button();
      this.btnVerDatos = new System.Windows.Forms.Button();
      this.dgwResult = new System.Windows.Forms.DataGridView();
      this.label5 = new System.Windows.Forms.Label();
      this.txtSentenciaDatos = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.lblNo = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.txtMensajeDatos = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // btnCleanDB
      // 
      this.btnCleanDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCleanDB.Location = new System.Drawing.Point(744, 9);
      this.btnCleanDB.Name = "btnCleanDB";
      this.btnCleanDB.Size = new System.Drawing.Size(75, 23);
      this.btnCleanDB.TabIndex = 4;
      this.btnCleanDB.Text = "Limpiar";
      this.btnCleanDB.UseVisualStyleBackColor = true;
      this.btnCleanDB.Click += new System.EventHandler(this.btnCleanDB_Click);
      // 
      // btnSearchDB
      // 
      this.btnSearchDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearchDB.Location = new System.Drawing.Point(663, 9);
      this.btnSearchDB.Name = "btnSearchDB";
      this.btnSearchDB.Size = new System.Drawing.Size(75, 23);
      this.btnSearchDB.TabIndex = 3;
      this.btnSearchDB.Text = "Buscar";
      this.btnSearchDB.UseVisualStyleBackColor = true;
      this.btnSearchDB.Click += new System.EventHandler(this.btnSearchDB_Click);
      // 
      // txtDB
      // 
      this.txtDB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDB.Location = new System.Drawing.Point(195, 9);
      this.txtDB.Name = "txtDB";
      this.txtDB.ReadOnly = true;
      this.txtDB.Size = new System.Drawing.Size(462, 22);
      this.txtDB.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(177, 20);
      this.label1.TabIndex = 5;
      this.label1.Text = "Ruta de Base de datos:";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabControl1.Location = new System.Drawing.Point(4, 38);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(815, 526);
      this.tabControl1.TabIndex = 12;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btnClearAll);
      this.tabPage1.Controls.Add(this.txtMensaje);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.btnRun);
      this.tabPage1.Controls.Add(this.txtSentencia);
      this.tabPage1.Location = new System.Drawing.Point(4, 29);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(807, 493);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Ejecucion de Sentencias";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // btnClearAll
      // 
      this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClearAll.Location = new System.Drawing.Point(285, 3);
      this.btnClearAll.Name = "btnClearAll";
      this.btnClearAll.Size = new System.Drawing.Size(182, 23);
      this.btnClearAll.TabIndex = 17;
      this.btnClearAll.Text = "Limpiar Todo";
      this.btnClearAll.UseVisualStyleBackColor = false;
      this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
      // 
      // txtMensaje
      // 
      this.txtMensaje.Location = new System.Drawing.Point(8, 426);
      this.txtMensaje.Multiline = true;
      this.txtMensaje.Name = "txtMensaje";
      this.txtMensaje.Size = new System.Drawing.Size(787, 61);
      this.txtMensaje.TabIndex = 16;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(6, 403);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 20);
      this.label3.TabIndex = 15;
      this.label3.Text = "Mensaje:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(6, 6);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(85, 20);
      this.label2.TabIndex = 14;
      this.label2.Text = "Sentencia:";
      // 
      // btnRun
      // 
      this.btnRun.BackColor = System.Drawing.Color.Yellow;
      this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRun.Location = new System.Drawing.Point(97, 3);
      this.btnRun.Name = "btnRun";
      this.btnRun.Size = new System.Drawing.Size(182, 23);
      this.btnRun.TabIndex = 13;
      this.btnRun.Text = "Ejecutar Sentencia";
      this.btnRun.UseVisualStyleBackColor = false;
      this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
      // 
      // txtSentencia
      // 
      this.txtSentencia.Location = new System.Drawing.Point(8, 29);
      this.txtSentencia.Multiline = true;
      this.txtSentencia.Name = "txtSentencia";
      this.txtSentencia.Size = new System.Drawing.Size(790, 371);
      this.txtSentencia.TabIndex = 12;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.txtMensajeDatos);
      this.tabPage2.Controls.Add(this.label7);
      this.tabPage2.Controls.Add(this.lblNo);
      this.tabPage2.Controls.Add(this.label6);
      this.tabPage2.Controls.Add(this.btnLimpiarDatos);
      this.tabPage2.Controls.Add(this.btnVerDatos);
      this.tabPage2.Controls.Add(this.dgwResult);
      this.tabPage2.Controls.Add(this.label5);
      this.tabPage2.Controls.Add(this.txtSentenciaDatos);
      this.tabPage2.Controls.Add(this.label4);
      this.tabPage2.Location = new System.Drawing.Point(4, 29);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(807, 493);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Ver Datos";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // btnLimpiarDatos
      // 
      this.btnLimpiarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLimpiarDatos.Location = new System.Drawing.Point(285, 0);
      this.btnLimpiarDatos.Name = "btnLimpiarDatos";
      this.btnLimpiarDatos.Size = new System.Drawing.Size(182, 23);
      this.btnLimpiarDatos.TabIndex = 21;
      this.btnLimpiarDatos.Text = "Limpiar Todo";
      this.btnLimpiarDatos.UseVisualStyleBackColor = false;
      this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
      // 
      // btnVerDatos
      // 
      this.btnVerDatos.BackColor = System.Drawing.Color.Yellow;
      this.btnVerDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnVerDatos.Location = new System.Drawing.Point(97, 0);
      this.btnVerDatos.Name = "btnVerDatos";
      this.btnVerDatos.Size = new System.Drawing.Size(182, 23);
      this.btnVerDatos.TabIndex = 20;
      this.btnVerDatos.Text = "Ejecutar Sentencia";
      this.btnVerDatos.UseVisualStyleBackColor = false;
      this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
      // 
      // dgwResult
      // 
      this.dgwResult.AllowUserToAddRows = false;
      this.dgwResult.AllowUserToDeleteRows = false;
      this.dgwResult.AllowUserToOrderColumns = true;
      this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgwResult.Location = new System.Drawing.Point(6, 132);
      this.dgwResult.MultiSelect = false;
      this.dgwResult.Name = "dgwResult";
      this.dgwResult.ReadOnly = true;
      this.dgwResult.Size = new System.Drawing.Size(787, 268);
      this.dgwResult.TabIndex = 19;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(6, 110);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(56, 20);
      this.label5.TabIndex = 17;
      this.label5.Text = "Datos:";
      // 
      // txtSentenciaDatos
      // 
      this.txtSentenciaDatos.Location = new System.Drawing.Point(3, 26);
      this.txtSentenciaDatos.Multiline = true;
      this.txtSentenciaDatos.Name = "txtSentenciaDatos";
      this.txtSentenciaDatos.Size = new System.Drawing.Size(790, 81);
      this.txtSentenciaDatos.TabIndex = 16;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(6, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(85, 20);
      this.label4.TabIndex = 15;
      this.label4.Text = "Sentencia:";
      // 
      // lblNo
      // 
      this.lblNo.AutoSize = true;
      this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNo.Location = new System.Drawing.Point(761, 113);
      this.lblNo.Name = "lblNo";
      this.lblNo.Size = new System.Drawing.Size(16, 16);
      this.lblNo.TabIndex = 28;
      this.lblNo.Text = "0";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(534, 114);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(221, 16);
      this.label6.TabIndex = 27;
      this.label6.Text = "Numeros de registros encontrados :";
      // 
      // txtMensajeDatos
      // 
      this.txtMensajeDatos.Location = new System.Drawing.Point(8, 426);
      this.txtMensajeDatos.Multiline = true;
      this.txtMensajeDatos.Name = "txtMensajeDatos";
      this.txtMensajeDatos.Size = new System.Drawing.Size(787, 61);
      this.txtMensajeDatos.TabIndex = 30;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(6, 403);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(73, 20);
      this.label7.TabIndex = 29;
      this.label7.Text = "Mensaje:";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(821, 568);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCleanDB);
      this.Controls.Add(this.btnSearchDB);
      this.Controls.Add(this.txtDB);
      this.Name = "frmMain";
      this.Text = "DB Access Managment";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button btnCleanDB;
    private System.Windows.Forms.Button btnSearchDB;
    private System.Windows.Forms.TextBox txtDB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button btnClearAll;
    private System.Windows.Forms.TextBox txtMensaje;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.TextBox txtSentencia;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox txtSentenciaDatos;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    public System.Windows.Forms.DataGridView dgwResult;
    private System.Windows.Forms.Button btnLimpiarDatos;
    private System.Windows.Forms.Button btnVerDatos;
    private System.Windows.Forms.Label lblNo;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtMensajeDatos;
    private System.Windows.Forms.Label label7;
  }
}

