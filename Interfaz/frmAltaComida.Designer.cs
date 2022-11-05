namespace Interfaz
{
    partial class frmAltaComida
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
            this.dgvRecetas = new System.Windows.Forms.DataGridView();
            this.ButtonElegirReceta = new System.Windows.Forms.Button();
            this.labelClickReceta = new System.Windows.Forms.Label();
            this.ElegirReceta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Momento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecetas
            // 
            this.dgvRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ElegirReceta,
            this.Codigo,
            this.Nombre,
            this.Momento,
            this.Tipo});
            this.dgvRecetas.Location = new System.Drawing.Point(73, 53);
            this.dgvRecetas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRecetas.Name = "dgvRecetas";
            this.dgvRecetas.RowHeadersWidth = 51;
            this.dgvRecetas.RowTemplate.Height = 24;
            this.dgvRecetas.Size = new System.Drawing.Size(677, 258);
            this.dgvRecetas.TabIndex = 4;
            // 
            // ButtonElegirReceta
            // 
            this.ButtonElegirReceta.Location = new System.Drawing.Point(320, 328);
            this.ButtonElegirReceta.Name = "ButtonElegirReceta";
            this.ButtonElegirReceta.Size = new System.Drawing.Size(196, 46);
            this.ButtonElegirReceta.TabIndex = 5;
            this.ButtonElegirReceta.Text = "Elegir Receta";
            this.ButtonElegirReceta.UseVisualStyleBackColor = true;
            this.ButtonElegirReceta.Click += new System.EventHandler(this.ButtonElegirReceta_Click);
            // 
            // labelClickReceta
            // 
            this.labelClickReceta.AutoSize = true;
            this.labelClickReceta.Location = new System.Drawing.Point(275, 26);
            this.labelClickReceta.Name = "labelClickReceta";
            this.labelClickReceta.Size = new System.Drawing.Size(258, 13);
            this.labelClickReceta.TabIndex = 6;
            this.labelClickReceta.Text = "Click en la receta que desee utilizar para esta comida\r\n";
            // 
            // ElegirReceta
            // 
            this.ElegirReceta.HeaderText = "Elegir Receta";
            this.ElegirReceta.Name = "ElegirReceta";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Id";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Momento
            // 
            this.Momento.DataPropertyName = "Momento";
            this.Momento.HeaderText = "Momento";
            this.Momento.Name = "Momento";
            this.Momento.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Saludable";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // frmAltaComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 398);
            this.Controls.Add(this.labelClickReceta);
            this.Controls.Add(this.ButtonElegirReceta);
            this.Controls.Add(this.dgvRecetas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAltaComida";
            this.ShowInTaskbar = false;
            this.Text = "frmAltaComida";
            this.Load += new System.EventHandler(this.frmAltaComida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecetas;
        private System.Windows.Forms.Button ButtonElegirReceta;
        private System.Windows.Forms.Label labelClickReceta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ElegirReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Momento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}