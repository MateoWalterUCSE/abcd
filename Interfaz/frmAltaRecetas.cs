using Logica;
using LogicaDeNegocio;
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
using Tp___AppCook2._0;
using static Logica.Receta;

namespace Interfaz
{
    public partial class frmAltaRecetas : Form
    {
       //public List<CodigoCantidad> codigoCantidad { get; set; }
        private ControlTipiadoYCampos controlTipiado { get; set; }
        //public int MyProperty { get; set; }
        private Producto producto { get; set; }
        bool saludable = false;
        private bool campoTipoRecetaLLeno;
        private bool camposLLenos;
        public int Fila { get; set; }

        public frmAltaRecetas()
        {
            InitializeComponent();
            btnAceptarProductosReceta.Enabled = false;
            panelCantidad.Visible = false;
            this.ActualizarGrilla();
            controlTipiado = new ControlTipiadoYCampos();
        }

        private void ActualizarGrilla()
        {
            dgvProductosEnStock.AutoGenerateColumns = false;
            dgvProductosEnStock.DataSource = null;
            dgvProductosEnStock.DataSource = Despensa.ListaDeProductos;
        }

        private void dgvProductosEnStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Columna = dgvProductosEnStock.Columns[e.ColumnIndex];
            if (e.RowIndex >= 0)
            {
                var Fila = dgvProductosEnStock.Rows[e.RowIndex];

                if (Columna.Name == "Seleccionar")
                {
                    txtCantidadProductoDeReceta.Text = string.Empty;
                    this.producto = Fila.DataBoundItem as Producto;
                    txtNombreSeleccionReceta.Text = producto.Nombre;
                }
            }
    
        }
        private void AcyalizarGrillaDeSeleccion()
        {

        }
        //if (indiceColumnaEliminar == e.ColumnIndex)  //ELIMINAR
        //{

        //    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "ELIMINAR REGISTRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

        //    if (resultado == DialogResult.OK)
        //    {
        //        string codigoDeRecetaAEliminar = (string)dgvProductosEnStock.Rows[fila.Index].Cells[Id.Index].Value;

        //        Despensa despensa = new Despensa();
        //        despensa.EliminarReceta(codigoDeProductoAEliminar);

        //        ActualizarGrilla();
        //    }
        //}
        //if(indiceColumnaAgregarCantidad == e.ColumnIndex)
        //{
        //    MessageBox.Show
        //}
    

        private void btnAceptarProductosReceta_Click(object sender, EventArgs e)
        {
            int totalSeleccion = dgvProductosEnStock.Rows.Cast<DataGridViewRow>(). //Me devuelve uun int con el total de selecciones
                Where(x => Convert.ToBoolean(x.Cells["Activo"].Value) == true).Count();


            if (totalSeleccion > 0)
            {
                
                DialogResult result = MessageBox.Show("msjEmergente", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                


                if (result == DialogResult.OK)
                {

                    Receta receta = new Receta();
                    foreach (DataGridViewRow fila in dgvProductosEnStock.Rows)
                    {
                        //if(fila.Cells["Cantidad"].Value)
                        //if (Convert.ToBoolean(fila.Cells["Activo"].Value) /*  == true  */)
                        //{
                        //    //List<CodigoCantidad> Lista = new List<CodigoCantidad>();
                        //    //POR CADA FILA DONDE ESTE ACTIVO SE GUARDA EL CodProducto y la CantidadQue el ingresa


                        //    //Falta Validar La columna De CANTIDAD si agrego o no valores 

                        //    //Falta verificar que haya seleccionado por lo menos algun producto sino que no aparezca el boton de AGREGAR

                        //    string codigoProductoSeleccionado = fila.Cells["Id"].Value.ToString();//guardo el id del producto de esa fila seleccionada
                        //    int cantidadDeProductosDeEseProducto = Convert.ToInt32(fila.Cells["Activo"].Value);

                        //    //VERIFICACIIONNNNNN.......................................
                        //    //List<string> ListaError = despensa.VerificacionDeStocks(codigoProductoSeleccionado, cantidadDeProductosDeEseProducto  );


                        //    //supongo que esta todo bien
                        //    //sigo.....
                        //    //List<CodigoCantidad> ListaCodigoCantidad = new List<CodigoCantidad>(codigoProductoSeleccionado, cantidadDeProductosDeEseProducto);

                        //    CodigoCantidad codigoCantidad = new CodigoCantidad();
                        //    codigoCantidad.CodigoIngrediente = codigoProductoSeleccionado;
                        //    codigoCantidad.Cantidad = cantidadDeProductosDeEseProducto;

                        //    receta.AgregarNuevoProductoAReceta(codigoCantidad);



                        //    //LLamo metodo para agregar

                        //}
                    }
                    MomentoComida momento = (MomentoComida)cbSeleccionMomentoReceta.SelectedIndex;
                    //receta = new Receta(txtCODIGOreceta.Text, momento, saludable, txtNombreReceta.Text, Convert.ToInt16(txtCantidadPersonas.Text));
                    Despensa despensa = new Despensa();
                    despensa.AgregarModificarReceta(receta);
                    MessageBox.Show("Carga de Producto Exitosa!!!");
                    this.Close();
                }
                else
                {

                }

            }
            else //No selecciono ninguna "AGREGAR"
            {
                //throw new Exception("No Apreto Ningun Agregar");
                MessageBox.Show("No Apreto Ningun Agregar. Vuelva a ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbSeleccionSaludable_Enter(object sender, EventArgs e)
        {

            if (rbConvencional.Checked == true && rbSaludable.Checked == false)
            {
                saludable = false;
                rbSaludable.Checked = false;
            }
            else
            {
                saludable = true;
                rbSaludable.Checked = true;
            }
        }

        private void cbSeleccionMomentoReceta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MomentoComida momento = (MomentoComida)cbSeleccionMomentoReceta.SelectedIndex;
            campoTipoRecetaLLeno = controlTipiado.VerificarSeleccion(cbSeleccionMomentoReceta.SelectedIndex);
            if (campoTipoRecetaLLeno)
            {

                btnAceptarProductosReceta.Enabled = true;
            }
            else
            {
                btnAceptarProductosReceta.Enabled = false;
            }
        }

        private void txtCantidadPersonas_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtNombreReceta_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void ValidarCampo()
        {
            if (!string.IsNullOrEmpty(txtCantidadPersonas.Text) &&
                !string.IsNullOrEmpty(txtNombreReceta.Text))
            {
                camposLLenos = true;
            }
            else
            {
                camposLLenos = false;
                btnAceptarProductosReceta.Enabled = false;
            }
            if (camposLLenos)
            {
                camposLLenos = true;
                if (campoTipoRecetaLLeno)
                {
                    campoTipoRecetaLLeno = true;
                    btnAceptarProductosReceta.Enabled = true;
                }
            }
        }

        private void txtNombreReceta_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlTipiado.SoloLetras(e);
        }

        private void txtCantidadPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlTipiado.SoloNumerosEnteros(e);
        }

        private void frmAltaRecetas_Load(object sender, EventArgs e)
        {
            controlTipiado = new ControlTipiadoYCampos(); //instancio para que me ermita validar nuevamente los campos editados
            //this.producto = new PorCantidad { Id="0"};
            this.ActualizarGrilla();
           
        }
        private void CargarCamposGenerales(bool saludable, string id, string nombreReceta, int cantidadPersonas, MomentoComida momento, List<CodigoCantidad> ingredientes)
        {
            txtCODIGOreceta.Text = id;
            gbSeleccionSaludable.Text = saludable.ToString();
            txtCantidadPersonas.Text = cantidadPersonas.ToString();
            txtNombreReceta.Text = nombreReceta;
            cbSeleccionMomentoReceta.Text = momento.ToString();
            dgvProductosEnStock.Text = ingredientes.ToString();
               
        }

        //private void txtCantidadProductoDeReceta_TextChanged(object sender, EventArgs e)
        //{

        //    if(txtCantidadProductoDeReceta.Text is null|| txtCantidadProductoDeReceta )
        //}

        private void txtCantidadProductoDeReceta_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlTipiado.SoloNumerosEnteros(e);
        }

        private void btnAgregarCantidad_Click(object sender, EventArgs e)
        {
            
            string cantidad = txtCantidadProductoDeReceta.Text;
            dgvProductosEnStock.Rows[Fila].Cells["Cantidad"].Value = cantidad;
            dgvProductosEnStock.Enabled = true;

            
        }

        private void dgvProductosSeleccionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var fila = dgvProductosEnStock
        }

        private void dgvProductosEnStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProductosEnStock.Columns[e.ColumnIndex].Name == "Agregar")
            {//apreto agregar


                DataGridViewRow fila = dgvProductosEnStock.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Agregar"] as DataGridViewCheckBoxCell;
                DataGridViewCell cellCantidad = fila.Cells["Cantidad"] as DataGridViewCell;
                if (Convert.ToBoolean(cellSeleccion.Value))
                {
                    if (cellCantidad.Value != null)
                    {
                        DataGridViewCell celdaCodigo = fila.Cells["Id"] as DataGridViewCell;
                        int codigo = Convert.ToInt32(celdaCodigo.Value);
                        DataGridViewCell celdaCantidad = fila.Cells["Cantidad"] as DataGridViewCell;
                        double cantidad = Convert.ToInt32(celdaCantidad.Value);
                        //logica.AgregarAListaCodigos(codigo, cantidad);
                    }
                }
            }
        }

    }
}