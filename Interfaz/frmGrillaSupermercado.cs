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
    public partial class frmGrillaSupermercado : Form
    {
        public Despensa despensa1 { get; set; }
        public frmGrillaSupermercado()
        {
            InitializeComponent();
            dgvGrillaSuper.AutoGenerateColumns = false;
            despensa1 = new Despensa();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            Despensa despensa = new Despensa();
            despensa.ListaDeProductosConStockYCargaAlistaDeSuper();
            dgvGrillaSuper.DataSource = null;
            dgvGrillaSuper.DataSource = despensa.GetListaDeProductosConBajoStock();
        }

        private void dgvGrillaSuper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvGrillaSuper_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var fila = dgvGrillaSuper.Rows[e.RowIndex];//Fila donde Clickeo
            if(fila == null)
            {
                throw new Exception("Fila null");
            }
            int indiceColumnaComprar = UtilidadesDeGrillas.ObtenerIndice(dgvGrillaSuper, "Comprar");
            int indiceColumnaIdentificador = UtilidadesDeGrillas.ObtenerIndice(dgvGrillaSuper, "Id");
            var codigoUsuario = dgvGrillaSuper.Rows[fila.Index].Cells[indiceColumnaIdentificador].Value.ToString();
            string nombreProductoAgregarCantidad = dgvGrillaSuper.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            string iDdelProductoQueCompro = dgvGrillaSuper.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            //string nombreProductoAlerta = dgvGrillaSuper.Rows[e.RowIndex].Cells["StockMinimo"].Value.ToString();
            frmEspecificarCantidadReceta frmEspecificarCantidad = new frmEspecificarCantidadReceta(nombreProductoAgregarCantidad);
            frmEspecificarCantidad.Owner = this;
            frmEspecificarCantidad.ShowDialog(this);

            //decimal precioUnitario = dgvGrillaSuper.Rows[fila.Index].Cells["Precio"].Value;

            //decimal total =  Convert.ToDecimal(txtCostoTotal.Text) + precioUnitario; 


            //despensa1.Compro(iDdelProductoQueCompro);

            //Hasta aquitengo el Id del producto a comprar y la cantidad que compro
            //Despensa despensa = new Despensa();
            //despensa.Compro()


        }
    }


}
