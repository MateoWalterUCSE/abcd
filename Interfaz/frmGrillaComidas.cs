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
using static Logica.Receta;

namespace Interfaz
{
    public partial class frmGrillaComidas : Form
    {
        private Despensa despensa { get; set; }
        public frmGrillaComidas()
        {
            InitializeComponent();
            despensa = new Despensa();
            ActualizarGrilla();
            //CalendarioComida.MaxDate = DateTime.Now;
            dgvComida.AutoGenerateColumns = false;
        }

        private void ActualizarGrilla()
        {
            dgvComida.AutoGenerateColumns = false;
            dgvComida.DataSource = null;
            dgvComida.DataSource = Despensa.ListaDeRecetas;
        }
        private void ActualizarGrilla(MomentoComida momentoComida)
        {
            dgvComida.AutoGenerateColumns = false;
            dgvComida.DataSource = null;
            dgvComida.DataSource = despensa.ObtenerListaRecetaFiltradaaProMomentoComida(momentoComida);
        }

        private void dgvComida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CalendarioComida_DateChanged(object sender, DateRangeEventArgs e)
        {
            //CalendarioComida.MaxDate = DateTime.Now;
        }


        private void cbFiltro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Enum.TryParse(cbFiltro.Text, true, out MomentoComida momento);
            ActualizarGrilla(momento);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataTFechaComida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmGrillaComidas_Load(object sender, EventArgs e)
        {

        }
    }
}
