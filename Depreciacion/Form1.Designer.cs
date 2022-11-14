namespace Depreciacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_FechaCompra = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_FechaDepreciacion = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TipoActico_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inmuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Depreciacion = new System.Windows.Forms.DataGridView();
            this.button_Depreciar = new System.Windows.Forms.Button();
            this.textBox_ValorCompra = new System.Windows.Forms.TextBox();
            this.textBox_TipoActivo = new System.Windows.Forms.TextBox();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Depreciacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor de Compra $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Depreciación";
            // 
            // dateTimePicker_FechaCompra
            // 
            this.dateTimePicker_FechaCompra.Location = new System.Drawing.Point(200, 88);
            this.dateTimePicker_FechaCompra.Name = "dateTimePicker_FechaCompra";
            this.dateTimePicker_FechaCompra.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FechaCompra.TabIndex = 4;
            // 
            // dateTimePicker_FechaDepreciacion
            // 
            this.dateTimePicker_FechaDepreciacion.Location = new System.Drawing.Point(441, 85);
            this.dateTimePicker_FechaDepreciacion.Name = "dateTimePicker_FechaDepreciacion";
            this.dateTimePicker_FechaDepreciacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FechaDepreciacion.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipoActico_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TipoActico_ToolStripMenuItem
            // 
            this.TipoActico_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculoToolStripMenuItem,
            this.inmuebleToolStripMenuItem});
            this.TipoActico_ToolStripMenuItem.Name = "TipoActico_ToolStripMenuItem";
            this.TipoActico_ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.TipoActico_ToolStripMenuItem.Text = "Tipo de Activo";
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.vehiculoToolStripMenuItem.Text = "Vehículo";
            this.vehiculoToolStripMenuItem.Click += new System.EventHandler(this.vehiculoToolStripMenuItem_Click);
            // 
            // inmuebleToolStripMenuItem
            // 
            this.inmuebleToolStripMenuItem.Name = "inmuebleToolStripMenuItem";
            this.inmuebleToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.inmuebleToolStripMenuItem.Text = "Inmueble";
            this.inmuebleToolStripMenuItem.Click += new System.EventHandler(this.inmuebleToolStripMenuItem_Click);
            // 
            // dataGridView_Depreciacion
            // 
            this.dataGridView_Depreciacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Depreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Depreciacion.Location = new System.Drawing.Point(12, 149);
            this.dataGridView_Depreciacion.Name = "dataGridView_Depreciacion";
            this.dataGridView_Depreciacion.RowHeadersWidth = 51;
            this.dataGridView_Depreciacion.Size = new System.Drawing.Size(629, 272);
            this.dataGridView_Depreciacion.TabIndex = 7;
            // 
            // button_Depreciar
            // 
            this.button_Depreciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Depreciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Depreciar.Location = new System.Drawing.Point(459, 120);
            this.button_Depreciar.Name = "button_Depreciar";
            this.button_Depreciar.Size = new System.Drawing.Size(91, 23);
            this.button_Depreciar.TabIndex = 0;
            this.button_Depreciar.Text = "DEPRECIAR";
            this.button_Depreciar.UseVisualStyleBackColor = true;
            this.button_Depreciar.Click += new System.EventHandler(this.button_Depreciar_Click);
            // 
            // textBox_ValorCompra
            // 
            this.textBox_ValorCompra.Location = new System.Drawing.Point(12, 91);
            this.textBox_ValorCompra.Name = "textBox_ValorCompra";
            this.textBox_ValorCompra.Size = new System.Drawing.Size(123, 20);
            this.textBox_ValorCompra.TabIndex = 8;
            // 
            // textBox_TipoActivo
            // 
            this.textBox_TipoActivo.Location = new System.Drawing.Point(111, 4);
            this.textBox_TipoActivo.Name = "textBox_TipoActivo";
            this.textBox_TipoActivo.ReadOnly = true;
            this.textBox_TipoActivo.Size = new System.Drawing.Size(136, 20);
            this.textBox_TipoActivo.TabIndex = 10;
            // 
            // button_limpiar
            // 
            this.button_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpiar.Location = new System.Drawing.Point(569, 120);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_limpiar.TabIndex = 11;
            this.button_limpiar.Text = "LIMPIAR";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.textBox_TipoActivo);
            this.Controls.Add(this.textBox_ValorCompra);
            this.Controls.Add(this.button_Depreciar);
            this.Controls.Add(this.dataGridView_Depreciacion);
            this.Controls.Add(this.dateTimePicker_FechaDepreciacion);
            this.Controls.Add(this.dateTimePicker_FechaCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPRECIACION DE ACTIVOS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Depreciacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaCompra;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaDepreciacion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TipoActico_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inmuebleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_Depreciacion;
        private System.Windows.Forms.Button button_Depreciar;
        private System.Windows.Forms.TextBox textBox_ValorCompra;
        private System.Windows.Forms.TextBox textBox_TipoActivo;
        private System.Windows.Forms.Button button_limpiar;
    }
}

