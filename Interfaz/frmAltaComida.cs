using Logica;
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
    public partial class frmAltaComida : Form
    {
        private Despensa despensa { get; set; }
        public frmAltaComida()
        {
            InitializeComponent();
        }

        private void frmAltaComida_Load(object sender, EventArgs e)
        {
            dgvRecetas.AutoGenerateColumns = false;
            despensa = new Despensa();
            dgvRecetas.DataSource = null;
            dgvRecetas.DataSource = Despensa.ListaDeRecetas;
        }

        private void ButtonElegirReceta_Click(object sender, EventArgs e)
        {

        }
    }
}
