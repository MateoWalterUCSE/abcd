using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp___AppCook2._0;

namespace Interfaz
{
    public partial class frmEspecificarCantidadReceta : Form
    {
        private bool camposLLenos;
        private double CantidadSeleccionadaYVerificada;

        private ControlTipiadoYCampos controlTipiado { get; set; }
        public frmEspecificarCantidadReceta(string nombreProdcuto)
        {
            InitializeComponent();
            btnAgregarCantidadReceta.Enabled = false;
            controlTipiado = new ControlTipiadoYCampos();
            lblNombreProductoSeleccion.Text = nombreProdcuto;
            
        }

        private void txtCantidadReceta_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void ValidarCampo()
        {
            if (!string.IsNullOrEmpty(txtCantidadReceta.Text))
            {
                camposLLenos = true;
                btnAgregarCantidadReceta.Enabled = true;
            }
            else
            {
                camposLLenos = false;
                btnAgregarCantidadReceta.Enabled = false;
            }
            if (camposLLenos)
            {
                camposLLenos = true;
                btnAgregarCantidadReceta.Enabled = true;
            } else btnAgregarCantidadReceta.Enabled = false;

        }

        //internal double ObternerCantidadVerificada()
        //{
        //    return CantidadSeleccionadaYVerificada;
        //}

        private void txtCantidadReceta_KeyPres(object sender, KeyPressEventArgs e)
        {
            controlTipiado.SoloNumerosEnterosYDecimales(e, txtCantidadReceta.Text);
        }

        private void btnAgregarCantidadReceta_Click(object sender, EventArgs e)
        {
            CantidadSeleccionadaYVerificada = Convert.ToDouble(txtCantidadReceta.Text);
            DialogResult result = MessageBox.Show("¿Estas seguro que deseas el producto "+ lblNombreProductoSeleccion.Text+" ?","ATENTOOO",  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                MessageBox.Show(" Compra Exitosa!!!!");
                this.Close();
            }

            
            
            
            
        }
    }
}
