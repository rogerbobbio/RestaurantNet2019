namespace RestaurantNet
{
    partial class frmTurnProduct
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
          this.dgwProducto = new System.Windows.Forms.DataGridView();
          this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.gbOrdenadoPor = new System.Windows.Forms.GroupBox();
          this.rbCantidad = new System.Windows.Forms.RadioButton();
          this.rbPorDescripcion = new System.Windows.Forms.RadioButton();
          ((System.ComponentModel.ISupportInitialize)(this.dgwProducto)).BeginInit();
          this.gbOrdenadoPor.SuspendLayout();
          this.SuspendLayout();
          // 
          // dgwProducto
          // 
          this.dgwProducto.AllowUserToAddRows = false;
          this.dgwProducto.AllowUserToDeleteRows = false;
          this.dgwProducto.AllowUserToOrderColumns = true;
          this.dgwProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
          this.dgwProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
          this.dgwProducto.Location = new System.Drawing.Point(12, 65);
          this.dgwProducto.MultiSelect = false;
          this.dgwProducto.Name = "dgwProducto";
          this.dgwProducto.ReadOnly = true;
          this.dgwProducto.Size = new System.Drawing.Size(559, 504);
          this.dgwProducto.TabIndex = 52;
          // 
          // dataGridViewTextBoxColumn11
          // 
          this.dataGridViewTextBoxColumn11.HeaderText = "DESCRIPCION";
          this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
          this.dataGridViewTextBoxColumn11.ReadOnly = true;
          this.dataGridViewTextBoxColumn11.Width = 400;
          // 
          // dataGridViewTextBoxColumn12
          // 
          this.dataGridViewTextBoxColumn12.HeaderText = "CANTIDAD";
          this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
          this.dataGridViewTextBoxColumn12.ReadOnly = true;
          this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
          // 
          // gbOrdenadoPor
          // 
          this.gbOrdenadoPor.Controls.Add(this.rbPorDescripcion);
          this.gbOrdenadoPor.Controls.Add(this.rbCantidad);
          this.gbOrdenadoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.gbOrdenadoPor.Location = new System.Drawing.Point(12, 12);
          this.gbOrdenadoPor.Name = "gbOrdenadoPor";
          this.gbOrdenadoPor.Size = new System.Drawing.Size(559, 47);
          this.gbOrdenadoPor.TabIndex = 53;
          this.gbOrdenadoPor.TabStop = false;
          this.gbOrdenadoPor.Text = "Ordenado por";
          // 
          // rbCantidad
          // 
          this.rbCantidad.AutoSize = true;
          this.rbCantidad.Checked = true;
          this.rbCantidad.Location = new System.Drawing.Point(119, 19);
          this.rbCantidad.Name = "rbCantidad";
          this.rbCantidad.Size = new System.Drawing.Size(112, 22);
          this.rbCantidad.TabIndex = 0;
          this.rbCantidad.TabStop = true;
          this.rbCantidad.Text = "Por Cantidad";
          this.rbCantidad.UseVisualStyleBackColor = true;
          this.rbCantidad.CheckedChanged += new System.EventHandler(this.rbCantidad_CheckedChanged);
          // 
          // rbPorDescripcion
          // 
          this.rbPorDescripcion.AutoSize = true;
          this.rbPorDescripcion.Location = new System.Drawing.Point(358, 19);
          this.rbPorDescripcion.Name = "rbPorDescripcion";
          this.rbPorDescripcion.Size = new System.Drawing.Size(133, 22);
          this.rbPorDescripcion.TabIndex = 1;
          this.rbPorDescripcion.Text = "Por Descripcion";
          this.rbPorDescripcion.UseVisualStyleBackColor = true;
          // 
          // frmTurnProduct
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(583, 581);
          this.Controls.Add(this.gbOrdenadoPor);
          this.Controls.Add(this.dgwProducto);
          this.Name = "frmTurnProduct";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "Productos Vendidos por Turno";
          this.Load += new System.EventHandler(this.frmTurnProduct_Load);
          ((System.ComponentModel.ISupportInitialize)(this.dgwProducto)).EndInit();
          this.gbOrdenadoPor.ResumeLayout(false);
          this.gbOrdenadoPor.PerformLayout();
          this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgwProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.GroupBox gbOrdenadoPor;
        private System.Windows.Forms.RadioButton rbPorDescripcion;
        private System.Windows.Forms.RadioButton rbCantidad;
    }
}