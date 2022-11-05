namespace Interfaz
{
    partial class frmGrillaComidas
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
            this.dgvComida = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Momento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saludable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataTFechaComida = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComida)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComida
            // 
            this.dgvComida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Momento,
            this.Saludable});
            this.dgvComida.Location = new System.Drawing.Point(22, 50);
            this.dgvComida.Margin = new System.Windows.Forms.Padding(2);
            this.dgvComida.Name = "dgvComida";
            this.dgvComida.RowHeadersWidth = 51;
            this.dgvComida.RowTemplate.Height = 24;
            this.dgvComida.Size = new System.Drawing.Size(428, 209);
            this.dgvComida.TabIndex = 0;
            this.dgvComida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComida_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Receta";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Momento
            // 
            this.Momento.DataPropertyName = "Momento";
            this.Momento.HeaderText = "Momento";
            this.Momento.MinimumWidth = 6;
            this.Momento.Name = "Momento";
            this.Momento.Width = 125;
            // 
            // Saludable
            // 
            this.Saludable.DataPropertyName = "Saludable";
            this.Saludable.HeaderText = "Saludable";
            this.Saludable.MinimumWidth = 6;
            this.Saludable.Name = "Saludable";
            this.Saludable.ReadOnly = true;
            this.Saludable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Saludable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Saludable.Width = 125;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(505, 232);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(85, 27);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tus Comidas";
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.cbFiltro.Location = new System.Drawing.Point(655, 232);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(144, 21);
            this.cbFiltro.TabIndex = 4;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            this.cbFiltro.SelectionChangeCommitted += new System.EventHandler(this.cbFiltro_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(803, 232);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(49, 19);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataTFechaComida
            // 
            this.dataTFechaComida.Location = new System.Drawing.Point(496, 32);
            this.dataTFechaComida.Margin = new System.Windows.Forms.Padding(2);
            this.dataTFechaComida.Name = "dataTFechaComida";
            this.dataTFechaComida.Size = new System.Drawing.Size(226, 20);
            this.dataTFechaComida.TabIndex = 7;
            this.dataTFechaComida.ValueChanged += new System.EventHandler(this.dataTFechaComida_ValueChanged);
            // 
            // frmGrillaComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 421);
            this.Controls.Add(this.dataTFechaComida);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.dgvComida);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGrillaComidas";
            this.ShowInTaskbar = false;
            this.Text = "frmGrillaComidas";
            this.Load += new System.EventHandler(this.frmGrillaComidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComida;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Momento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Saludable;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dataTFechaComida;
    }
}