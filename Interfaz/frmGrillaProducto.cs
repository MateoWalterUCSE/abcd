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

namespace Tp___AppCook2._0
{
    public partial class frmGrillaProducto : Form
    {
        private Despensa despensa { get; set; }
        public ControlTipiadoYCampos controlTipiado { get; set; }
        
        public frmGrillaProducto()
        {
            
            InitializeComponent();
            this.ActualizarGrilla();
        }
        private void frmGrillaProducto_Load(object sender, EventArgs e)
        {
            dgvProductos.AutoGenerateColumns = false;
            controlTipiado = new ControlTipiadoYCampos();
            despensa = new Despensa();
            this.ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Despensa.ListaDeProductos;
        }

        private void ActualizarGrilla(string codigo)
        {
            
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = null;
            dgvProductos.DataSource =  despensa.ObtenerListaProductoPorId(codigo);
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            frmAltaProducto FormularioNuevoProducto = new frmAltaProducto();
            FormularioNuevoProducto.Owner = this;
            FormularioNuevoProducto.ShowDialog();
            this.ActualizarGrilla();
        }

        private void dgvProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UtilidadesDeGrillas.CargarAccionesDeGrilla(dgvProductos);
            
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceColumnaEditar = UtilidadesDeGrillas.ObtenerIndice(dgvProductos, "Editar");
            int indiceColumnaEliminar = UtilidadesDeGrillas.ObtenerIndice(dgvProductos, "Eliminar");
            var fila = dgvProductos.Rows[e.RowIndex];
            //if(fila == null|| Convert.ToInt16(fila)<0)
            //{
            //    throw new Exception("Fila No Invocable");
            //}
            if (indiceColumnaEditar == e.ColumnIndex)  //EDITAR
            {
                var indiceColumnaIdentificador = UtilidadesDeGrillas.ObtenerIndice(dgvProductos, "Id");  //devuelve la columna de la celda con ese Id
                var codigoProducto = dgvProductos.Rows[e.RowIndex].Cells[indiceColumnaIdentificador].Value.ToString(); //Busco el Id para luego pasarlo por parametro

                frmAltaProducto formCarga = new frmAltaProducto(codigoProducto);

                formCarga.ShowDialog(this);
                this.ActualizarGrilla();
            }

            if (indiceColumnaEliminar == e.ColumnIndex)  //ELIMINAR
            {
                
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "ELIMINAR REGISTRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (resultado == DialogResult.OK)
                {
                    string codigoDeProductoAEliminar = (string)dgvProductos.Rows[fila.Index].Cells[Id.Index].Value;
                    
                    Despensa despensa = new Despensa();
                    despensa.EliminarProducto(codigoDeProductoAEliminar);

                    ActualizarGrilla();
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ActualizarGrilla(this.txtBusqueda.Text);
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlTipiado.SoloNumerosEnteros(e);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

