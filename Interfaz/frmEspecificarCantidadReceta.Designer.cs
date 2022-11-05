namespace Interfaz
{
    partial class frmEspecificarCantidadReceta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreProductoSeleccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCantidadReceta = new System.Windows.Forms.Button();
            this.txtCantidadReceta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNombreProductoSeleccion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAgregarCantidadReceta);
            this.panel1.Controls.Add(this.txtCantidadReceta);
            this.panel1.Location = new System.Drawing.Point(95, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 198);
            this.panel1.TabIndex = 0;
            // 
            // lblNombreProductoSeleccion
            // 
            this.lblNombreProductoSeleccion.AutoSize = true;
            this.lblNombreProductoSeleccion.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProductoSeleccion.Location = new System.Drawing.Point(281, 44);
            this.lblNombreProductoSeleccion.Name = "lblNombreProductoSeleccion";
            this.lblNombreProductoSeleccion.Size = new System.Drawing.Size(55, 22);
            this.lblNombreProductoSeleccion.TabIndex = 5;
            this.lblNombreProductoSeleccion.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese la cantidad de: ";
            // 
            // btnAgregarCantidadReceta
            // 
            this.btnAgregarCantidadReceta.Location = new System.Drawing.Point(153, 162);
            this.btnAgregarCantidadReceta.Name = "btnAgregarCantidadReceta";
            this.btnAgregarCantidadReceta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCantidadReceta.TabIndex = 3;
            this.btnAgregarCantidadReceta.Text = "Aceptar";
            this.btnAgregarCantidadReceta.UseVisualStyleBackColor = true;
            this.btnAgregarCantidadReceta.Click += new System.EventHandler(this.btnAgregarCantidadReceta_Click);
            // 
            // txtCantidadReceta
            // 
            this.txtCantidadReceta.Location = new System.Drawing.Point(64, 115);
            this.txtCantidadReceta.Name = "txtCantidadReceta";
            this.txtCantidadReceta.Size = new System.Drawing.Size(211, 22);
            this.txtCantidadReceta.TabIndex = 1;
            this.txtCantidadReceta.TextChanged += new System.EventHandler(this.txtCantidadReceta_TextChanged);
            this.txtCantidadReceta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadReceta_KeyPres);
            // 
            // frmEspecificarCantidadReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 324);
            this.Controls.Add(this.panel1);
            this.Name = "frmEspecificarCantidadReceta";
            this.ShowInTaskbar = false;
            this.Text = "EspecificarCantidadReceta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCantidadReceta;
        
        private System.Windows.Forms.Button btnAgregarCantidadReceta;
        private System.Windows.Forms.Label lblNombreProductoSeleccion;
        private System.Windows.Forms.Label label1;
    }
}