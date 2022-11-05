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
            foreach (DataGridViewRow Fila in dgvRecetas.Rows)
            {
                if (Convert.ToBoolean(Fila.Cells[0].Value) == true)
                {
                    Comida Comida = new Comida();
                    Comida.Fecha = new DateTime();
                    int CodigoReceta = Convert.ToInt32(Fila.Cells[1]);
                    Logica.Comida.IngresarComida(CodigoReceta);
                    break;
                }
            }
        }

        private void dgvRecetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (Convert.ToBoolean(row.Cells[e.ColumnIndex].Value))
                {
                    row.Cells[e.ColumnIndex].Value = false;
                }
            }
            DataGridViewCheckBoxCell Celda = (DataGridViewCheckBoxCell)this.dgvRecetas.Rows[e.RowIndex].Cells[0];
            if (Convert.ToBoolean(Celda.Value) == true)
            {
                Celda.Value = false;
                dgvRecetas.Rows[e.RowIndex].Selected = false;
            }
            else
            {
                Celda.Value = true;
                dgvRecetas.Rows[e.RowIndex].Selected = true;
                DataGridViewRow RowFila = dgvRecetas.Rows[e.RowIndex];
            }
        }
    }
}
