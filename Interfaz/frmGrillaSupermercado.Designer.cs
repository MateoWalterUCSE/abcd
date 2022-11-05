namespace Interfaz
{
    partial class frmGrillaSupermercado
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
            this.dgvGrillaSuper = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRealizarCompra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaSuper)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrillaSuper
            // 
            this.dgvGrillaSuper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaSuper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Precio,
            this.StockMinimo,
            this.Comprar});
            this.dgvGrillaSuper.Location = new System.Drawing.Point(18, 99);
            this.dgvGrillaSuper.Name = "dgvGrillaSuper";
            this.dgvGrillaSuper.RowHeadersWidth = 51;
            this.dgvGrillaSuper.RowTemplate.Height = 24;
            this.dgvGrillaSuper.Size = new System.Drawing.Size(668, 235);
            this.dgvGrillaSuper.TabIndex = 0;
            this.dgvGrillaSuper.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrillaSuper_CellClick);
            this.dgvGrillaSuper.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrillaSuper_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo del Faltante";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre de producto Faltante";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // StockMinimo
            // 
            this.StockMinimo.DataPropertyName = "StockMinimo";
            this.StockMinimo.HeaderText = "Alerta De Stock";
            this.StockMinimo.MinimumWidth = 6;
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.ReadOnly = true;
            this.StockMinimo.Width = 125;
            // 
            // Comprar
            // 
            this.Comprar.DataPropertyName = "Comprar";
            this.Comprar.HeaderText = "Comprar";
            this.Comprar.MinimumWidth = 6;
            this.Comprar.Name = "Comprar";
            this.Comprar.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aprete la fila del Producto que desea Comprar";
            // 
            // btnRealizarCompra
            // 
            this.btnRealizarCompra.Location = new System.Drawing.Point(256, 354);
            this.btnRealizarCompra.Name = "btnRealizarCompra";
            this.btnRealizarCompra.Size = new System.Drawing.Size(164, 49);
            this.btnRealizarCompra.TabIndex = 2;
            this.btnRealizarCompra.Text = "RealizarCompra";
            this.btnRealizarCompra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Costo total de compra...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCostoTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(455, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 100);
            this.panel1.TabIndex = 4;
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Location = new System.Drawing.Point(25, 57);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(123, 22);
            this.txtCostoTotal.TabIndex = 4;
            // 
            // frmGrillaSupermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRealizarCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGrillaSuper);
            this.Name = "frmGrillaSupermercado";
            this.ShowInTaskbar = false;
            this.Text = "Comidas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaSuper)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrillaSuper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.Windows.Forms.DataGridViewButtonColumn Comprar;
        private System.Windows.Forms.Button btnRealizarCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCostoTotal;
    }
}