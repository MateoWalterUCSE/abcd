using System;
using System.Windows.Forms;

namespace Tp___AppCook2._0
{
    partial class frmAltaProducto
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelTipoBebida = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoBebida = new System.Windows.Forms.ComboBox();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.panelCategoria = new System.Windows.Forms.Panel();
            this.lblCatgeoriaProducto = new System.Windows.Forms.Label();
            this.cbSeleccionCategoria = new System.Windows.Forms.ComboBox();
            this.btnGuardarNuevoProducto = new System.Windows.Forms.Button();
            this.panelStock = new System.Windows.Forms.Panel();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panelTipoBebida.SuspendLayout();
            this.panelCategoria.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelTipoBebida);
            this.panel6.Controls.Add(this.txtCODIGO);
            this.panel6.Controls.Add(this.panelCategoria);
            this.panel6.Controls.Add(this.btnGuardarNuevoProducto);
            this.panel6.Controls.Add(this.panelStock);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Location = new System.Drawing.Point(42, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(717, 385);
            this.panel6.TabIndex = 17;
            // 
            // panelTipoBebida
            // 
            this.panelTipoBebida.Controls.Add(this.label4);
            this.panelTipoBebida.Controls.Add(this.cbTipoBebida);
            this.panelTipoBebida.Location = new System.Drawing.Point(11, 256);
            this.panelTipoBebida.Name = "panelTipoBebida";
            this.panelTipoBebida.Size = new System.Drawing.Size(368, 85);
            this.panelTipoBebida.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Defini Tipo Categoria";
            // 
            // cbTipoBebida
            // 
            this.cbTipoBebida.FormattingEnabled = true;
            this.cbTipoBebida.Items.AddRange(new object[] {
            "Normales",
            "AltasEnAzucar",
            "Alcohólicas"});
            this.cbTipoBebida.Location = new System.Drawing.Point(196, 13);
            this.cbTipoBebida.Name = "cbTipoBebida";
            this.cbTipoBebida.Size = new System.Drawing.Size(148, 24);
            this.cbTipoBebida.TabIndex = 35;
            this.cbTipoBebida.SelectedIndexChanged += new System.EventHandler(this.cbTipoBebida_SelectedIndexChanged);
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(579, 349);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(56, 22);
            this.txtCODIGO.TabIndex = 34;
            this.txtCODIGO.Visible = false;
            // 
            // panelCategoria
            // 
            this.panelCategoria.Controls.Add(this.lblCatgeoriaProducto);
            this.panelCategoria.Controls.Add(this.cbSeleccionCategoria);
            this.panelCategoria.Location = new System.Drawing.Point(417, 17);
            this.panelCategoria.Name = "panelCategoria";
            this.panelCategoria.Size = new System.Drawing.Size(279, 199);
            this.panelCategoria.TabIndex = 32;
            // 
            // lblCatgeoriaProducto
            // 
            this.lblCatgeoriaProducto.AutoSize = true;
            this.lblCatgeoriaProducto.Location = new System.Drawing.Point(7, 12);
            this.lblCatgeoriaProducto.Name = "lblCatgeoriaProducto";
            this.lblCatgeoriaProducto.Size = new System.Drawing.Size(142, 16);
            this.lblCatgeoriaProducto.TabIndex = 12;
            this.lblCatgeoriaProducto.Text = "Categoria de Producto";
            // 
            // cbSeleccionCategoria
            // 
            this.cbSeleccionCategoria.FormattingEnabled = true;
            this.cbSeleccionCategoria.Items.AddRange(new object[] {
            "Bebida",
            "Fruta",
            "Hortaliza y Verduras"});
            this.cbSeleccionCategoria.Location = new System.Drawing.Point(10, 32);
            this.cbSeleccionCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbSeleccionCategoria.Name = "cbSeleccionCategoria";
            this.cbSeleccionCategoria.Size = new System.Drawing.Size(265, 24);
            this.cbSeleccionCategoria.TabIndex = 14;
            this.cbSeleccionCategoria.Text = "Seleccion..";
            this.cbSeleccionCategoria.SelectedIndexChanged += new System.EventHandler(this.cbSeleccionCategoria_SelectedIndexChanged);
            // 
            // btnGuardarNuevoProducto
            // 
            this.btnGuardarNuevoProducto.Location = new System.Drawing.Point(417, 256);
            this.btnGuardarNuevoProducto.Name = "btnGuardarNuevoProducto";
            this.btnGuardarNuevoProducto.Size = new System.Drawing.Size(279, 64);
            this.btnGuardarNuevoProducto.TabIndex = 11;
            this.btnGuardarNuevoProducto.Text = "Guardar";
            this.btnGuardarNuevoProducto.UseVisualStyleBackColor = true;
            this.btnGuardarNuevoProducto.Click += new System.EventHandler(this.btnGuardarNuevoProducto_Click);
            // 
            // panelStock
            // 
            this.panelStock.Controls.Add(this.txtStock);
            this.panelStock.Controls.Add(this.label3);
            this.panelStock.Location = new System.Drawing.Point(11, 180);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(368, 56);
            this.panelStock.TabIndex = 10;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(103, 14);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(89, 22);
            this.txtStock.TabIndex = 1;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad a Ingresar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtStockMinimo);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(11, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 61);
            this.panel5.TabIndex = 10;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(103, 18);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(89, 22);
            this.txtStockMinimo.TabIndex = 1;
            this.txtStockMinimo.TextChanged += new System.EventHandler(this.txtStockMinimo_TextChanged);
            this.txtStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMinimo_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 49);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alerta Minimo Stock";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 40);
            this.panel2.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(105, 9);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(258, 22);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 44);
            this.panel1.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(258, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // frmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 525);
            this.Controls.Add(this.panel6);
            this.Name = "frmAltaProducto";
            this.Tag = "";
            this.Text = "Agregar Nuevo Producto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAltaProducto_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelTipoBebida.ResumeLayout(false);
            this.panelTipoBebida.PerformLayout();
            this.panelCategoria.ResumeLayout(false);
            this.panelCategoria.PerformLayout();
            this.panelStock.ResumeLayout(false);
            this.panelStock.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelCategoria;
        private System.Windows.Forms.Label lblCatgeoriaProducto;
        private System.Windows.Forms.ComboBox cbSeleccionCategoria;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarNuevoProducto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private TextBox txtNombre;
        private TextBox txtCODIGO;
        private Panel panelTipoBebida;
        private Label label4;
        private ComboBox cbTipoBebida;
    }
}