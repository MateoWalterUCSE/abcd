using System;

namespace Interfaz
{
    partial class frmAltaRecetas
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
            this.dgvProductosEnStock = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProductosSeleccionados = new System.Windows.Forms.DataGridView();
            this.txtCODIGOreceta = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelCantidad = new System.Windows.Forms.Panel();
            this.txtCantidadProductoDeReceta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbSeleccionMomentoReceta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCantidadPersonas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.gbSeleccionSaludable = new System.Windows.Forms.GroupBox();
            this.rbSaludable = new System.Windows.Forms.RadioButton();
            this.rbConvencional = new System.Windows.Forms.RadioButton();
            this.btnAceptarProductosReceta = new System.Windows.Forms.Button();
            this.IdSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSeleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chek = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtNombreSeleccionReceta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnStock)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelCantidad.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbSeleccionSaludable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingredientes disponibles en tu despensa";
            // 
            // dgvProductosEnStock
            // 
            this.dgvProductosEnStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEnStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chek,
            this.Id,
            this.Categoria,
            this.Nombre,
            this.Stock,
            this.Seleccionar});
            this.dgvProductosEnStock.Location = new System.Drawing.Point(11, 115);
            this.dgvProductosEnStock.Name = "dgvProductosEnStock";
            this.dgvProductosEnStock.RowHeadersWidth = 51;
            this.dgvProductosEnStock.RowTemplate.Height = 24;
            this.dgvProductosEnStock.Size = new System.Drawing.Size(781, 247);
            this.dgvProductosEnStock.TabIndex = 2;
            this.dgvProductosEnStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosEnStock_CellContentClick);
            this.dgvProductosEnStock.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosEnStock_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProductosSeleccionados);
            this.panel1.Controls.Add(this.txtCODIGOreceta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAceptarProductosReceta);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 473);
            this.panel1.TabIndex = 4;
            
            // 
            // dgvProductosSeleccionados
            // 
            this.dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSeleccionado,
            this.NombreSeleccion,
            this.CantidadActual});
            this.dgvProductosSeleccionados.Location = new System.Drawing.Point(823, 337);
            this.dgvProductosSeleccionados.Name = "dgvProductosSeleccionados";
            this.dgvProductosSeleccionados.RowHeadersWidth = 51;
            this.dgvProductosSeleccionados.RowTemplate.Height = 24;
            this.dgvProductosSeleccionados.Size = new System.Drawing.Size(395, 117);
            this.dgvProductosSeleccionados.TabIndex = 6;
            this.dgvProductosSeleccionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosSeleccionados_CellContentClick);
            // 
            // txtCODIGOreceta
            // 
            this.txtCODIGOreceta.Location = new System.Drawing.Point(16, 421);
            this.txtCODIGOreceta.Name = "txtCODIGOreceta";
            this.txtCODIGOreceta.Size = new System.Drawing.Size(100, 22);
            this.txtCODIGOreceta.TabIndex = 1;
            this.txtCODIGOreceta.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelCantidad);
            this.panel3.Controls.Add(this.dgvProductosEnStock);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(16, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 385);
            this.panel3.TabIndex = 0;
            // 
            // panelCantidad
            // 
            this.panelCantidad.Controls.Add(this.txtNombreSeleccionReceta);
            this.panelCantidad.Controls.Add(this.txtCantidadProductoDeReceta);
            this.panelCantidad.Location = new System.Drawing.Point(391, 9);
            this.panelCantidad.Name = "panelCantidad";
            this.panelCantidad.Size = new System.Drawing.Size(383, 100);
            this.panelCantidad.TabIndex = 5;
            // 
            // txtCantidadProductoDeReceta
            // 
            this.txtCantidadProductoDeReceta.Location = new System.Drawing.Point(201, 70);
            this.txtCantidadProductoDeReceta.Name = "txtCantidadProductoDeReceta";
            this.txtCantidadProductoDeReceta.Size = new System.Drawing.Size(161, 22);
            this.txtCantidadProductoDeReceta.TabIndex = 1;
            this.txtCantidadProductoDeReceta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadProductoDeReceta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Click en los productos que deseas agregar a tu receta";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.gbSeleccionSaludable);
            this.panel2.Location = new System.Drawing.Point(839, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 321);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbSeleccionMomentoReceta);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(35, 202);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(351, 109);
            this.panel6.TabIndex = 9;
            // 
            // cbSeleccionMomentoReceta
            // 
            this.cbSeleccionMomentoReceta.AccessibleName = "";
            this.cbSeleccionMomentoReceta.FormattingEnabled = true;
            this.cbSeleccionMomentoReceta.Items.AddRange(new object[] {
            "Almuerzo",
            "Cena",
            "Desayuno",
            "Merienda"});
            this.cbSeleccionMomentoReceta.Location = new System.Drawing.Point(110, 31);
            this.cbSeleccionMomentoReceta.Name = "cbSeleccionMomentoReceta";
            this.cbSeleccionMomentoReceta.Size = new System.Drawing.Size(192, 24);
            this.cbSeleccionMomentoReceta.TabIndex = 2;
            this.cbSeleccionMomentoReceta.Tag = "";
            this.cbSeleccionMomentoReceta.Text = "Seleccion...";
            this.cbSeleccionMomentoReceta.SelectedIndexChanged += new System.EventHandler(this.cbSeleccionMomentoReceta_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Receta para un momento de: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtCantidadPersonas);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 36);
            this.panel5.TabIndex = 8;
            // 
            // txtCantidadPersonas
            // 
            this.txtCantidadPersonas.Location = new System.Drawing.Point(157, 9);
            this.txtCantidadPersonas.Name = "txtCantidadPersonas";
            this.txtCantidadPersonas.Size = new System.Drawing.Size(192, 22);
            this.txtCantidadPersonas.TabIndex = 1;
            this.txtCantidadPersonas.TextChanged += new System.EventHandler(this.txtCantidadPersonas_TextChanged);
            this.txtCantidadPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadPersonas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Para cuantas personas";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtNombreReceta);
            this.panel4.Location = new System.Drawing.Point(35, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 38);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre Receta";
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.Location = new System.Drawing.Point(130, 10);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Size = new System.Drawing.Size(221, 22);
            this.txtNombreReceta.TabIndex = 0;
            this.txtNombreReceta.TextChanged += new System.EventHandler(this.txtNombreReceta_TextChanged);
            this.txtNombreReceta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreReceta_KeyPress);
            // 
            // gbSeleccionSaludable
            // 
            this.gbSeleccionSaludable.Controls.Add(this.rbSaludable);
            this.gbSeleccionSaludable.Controls.Add(this.rbConvencional);
            this.gbSeleccionSaludable.Location = new System.Drawing.Point(3, 115);
            this.gbSeleccionSaludable.Name = "gbSeleccionSaludable";
            this.gbSeleccionSaludable.Size = new System.Drawing.Size(383, 81);
            this.gbSeleccionSaludable.TabIndex = 4;
            this.gbSeleccionSaludable.TabStop = false;
            this.gbSeleccionSaludable.Text = "Tipo de Receta";
            this.gbSeleccionSaludable.Enter += new System.EventHandler(this.gbSeleccionSaludable_Enter);
            // 
            // rbSaludable
            // 
            this.rbSaludable.AutoSize = true;
            this.rbSaludable.Location = new System.Drawing.Point(94, 48);
            this.rbSaludable.Name = "rbSaludable";
            this.rbSaludable.Size = new System.Drawing.Size(90, 20);
            this.rbSaludable.TabIndex = 1;
            this.rbSaludable.Text = "Saludable";
            this.rbSaludable.UseVisualStyleBackColor = true;
            // 
            // rbConvencional
            // 
            this.rbConvencional.AutoSize = true;
            this.rbConvencional.Checked = true;
            this.rbConvencional.Location = new System.Drawing.Point(94, 21);
            this.rbConvencional.Name = "rbConvencional";
            this.rbConvencional.Size = new System.Drawing.Size(110, 20);
            this.rbConvencional.TabIndex = 0;
            this.rbConvencional.TabStop = true;
            this.rbConvencional.Text = "Convencional";
            this.rbConvencional.UseVisualStyleBackColor = true;
            // 
            // btnAceptarProductosReceta
            // 
            this.btnAceptarProductosReceta.Location = new System.Drawing.Point(301, 411);
            this.btnAceptarProductosReceta.Name = "btnAceptarProductosReceta";
            this.btnAceptarProductosReceta.Size = new System.Drawing.Size(384, 43);
            this.btnAceptarProductosReceta.TabIndex = 5;
            this.btnAceptarProductosReceta.Text = "Agregar Productos a tu Receta";
            this.btnAceptarProductosReceta.UseVisualStyleBackColor = true;
            this.btnAceptarProductosReceta.Click += new System.EventHandler(this.btnAceptarProductosReceta_Click);
            // 
            // IdSeleccionado
            // 
            this.IdSeleccionado.DataPropertyName = "IdSeleccionado";
            this.IdSeleccionado.HeaderText = "Id";
            this.IdSeleccionado.MinimumWidth = 6;
            this.IdSeleccionado.Name = "IdSeleccionado";
            this.IdSeleccionado.ReadOnly = true;
            this.IdSeleccionado.Width = 125;
            // 
            // NombreSeleccion
            // 
            this.NombreSeleccion.HeaderText = "nombre";
            this.NombreSeleccion.MinimumWidth = 6;
            this.NombreSeleccion.Name = "NombreSeleccion";
            this.NombreSeleccion.Width = 125;
            // 
            // CantidadActual
            // 
            this.CantidadActual.DataPropertyName = "Cantidad";
            this.CantidadActual.HeaderText = "Cantidad";
            this.CantidadActual.MinimumWidth = 6;
            this.CantidadActual.Name = "CantidadActual";
            this.CantidadActual.ReadOnly = true;
            this.CantidadActual.Width = 125;
            // 
            // Chek
            // 
            this.Chek.DataPropertyName = "Check";
            this.Chek.HeaderText = "Ingredientes Agregados";
            this.Chek.MinimumWidth = 6;
            this.Chek.Name = "Chek";
            this.Chek.ReadOnly = true;
            this.Chek.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
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
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock Actual";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // Seleccionar
            // 
            this.Seleccionar.DataPropertyName = "Seleccionar";
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Width = 125;
            // 
            // txtNombreSeleccionReceta
            // 
            this.txtNombreSeleccionReceta.Location = new System.Drawing.Point(201, 18);
            this.txtNombreSeleccionReceta.Name = "txtNombreSeleccionReceta";
            this.txtNombreSeleccionReceta.Size = new System.Drawing.Size(161, 22);
            this.txtNombreSeleccionReceta.TabIndex = 2;
            // 
            // frmAltaRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 521);
            this.Controls.Add(this.panel1);
            this.Name = "frmAltaRecetas";
            this.Text = "frmProductosDisponibles";
            this.Load += new System.EventHandler(this.frmAltaRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelCantidad.ResumeLayout(false);
            this.panelCantidad.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbSeleccionSaludable.ResumeLayout(false);
            this.gbSeleccionSaludable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductosEnStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptarProductosReceta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCODIGOreceta;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.TextBox txtCantidadPersonas;
        private System.Windows.Forms.ComboBox cbSeleccionMomentoReceta;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbSeleccionSaludable;
        private System.Windows.Forms.RadioButton rbSaludable;
        private System.Windows.Forms.RadioButton rbConvencional;
        private System.Windows.Forms.Panel panelCantidad;
        private System.Windows.Forms.TextBox txtCantidadProductoDeReceta;
        private System.Windows.Forms.DataGridView dgvProductosSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadActual;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewLinkColumn Seleccionar;
        private System.Windows.Forms.TextBox txtNombreSeleccionReceta;
    }
}