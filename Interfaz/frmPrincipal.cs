using Interfaz;
using LogicaDeNegocio.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp___AppCook2._0
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Archivo.InicializadorDeListas();
            
        }

        private void vERPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrillaProducto formGrillaProducto = new frmGrillaProducto();
            formGrillaProducto.Owner = this;
            formGrillaProducto.ShowDialog(this);
            
        }

        private void vERPRODUCTOSSIPONIBLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void vERTUSCOMIDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrillaComidas formGrillaComidas = new frmGrillaComidas();
            formGrillaComidas.Owner = this;
            formGrillaComidas.ShowDialog(this);
        }

        private void aGREGARNUEVARECETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaRecetas formGrillaProductosDisponibles = new frmAltaRecetas();
            formGrillaProductosDisponibles.Owner = this;
            formGrillaProductosDisponibles.ShowDialog(this);
        }

        private void vERPRODUCTOSFALTANTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrillaSupermercado formGrillaSuper = new frmGrillaSupermercado();
            formGrillaSuper.Owner = this;
            formGrillaSuper.ShowDialog(this);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cOMIDASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAltaComida frmAltaComida = new frmAltaComida();
            frmAltaComida.Owner = this;
            frmAltaComida.ShowDialog(this);
        }
    }
}
