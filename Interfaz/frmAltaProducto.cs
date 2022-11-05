using Logica;
using Logica.Productos;
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
using static Logica.Producto;
using static Logica.Productos.Bebida;

namespace Tp___AppCook2._0
{
    public partial class frmAltaProducto : Form
    {
        private bool camposLLenos;
        private bool campoCategoriaLLeno;
        private bool campoTipoBebida;
        //private string Id { get; set; } //si este es null => quiere decir que El producto no existe(No apreto en editar)

        private ControlTipiadoYCampos controlTipiado { get; set; }
        
        public frmAltaProducto()
        {
            InitializeComponent();
            txtCODIGO.Text = null;
            btnGuardarNuevoProducto.Enabled = false;
            panelTipoBebida.Visible = false;
        }
        public frmAltaProducto(string codigoUsuario)
        {

            InitializeComponent();
            //this.Id = codigoUsuario;
            txtCODIGO.Text = codigoUsuario;
            btnGuardarNuevoProducto.Enabled = false;
            panelTipoBebida.Visible = false;

        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            controlTipiado = new ControlTipiadoYCampos(); //instancio para que me ermita validar nuevamente los campos editados

            if (!string.IsNullOrEmpty(txtCODIGO.Text))// => No es null
            {
                //Quiere decir que apreto "Editar" en un producto

                Despensa despensa = new Despensa();
                string codigoDeElementoAEditar = txtCODIGO.Text;
                MedidaProducto medida = despensa.GetMedidaFiltradaPorId(codigoDeElementoAEditar);

                //MedidaProducto medida = despensa.GetMedidaPorFiltradaCategoria();

                if (medida is MedidaProducto.XBebida)
                {
                    cbTipoBebida.Enabled = false; //NO PERMITO QUE SE PUEDAN EDITAR
                    Bebida productoB = (Bebida)despensa.GetObjetoProductoPorId(codigoDeElementoAEditar);
                    CargarCamposGenerales(productoB.Stock, productoB.Id, productoB.Precio, productoB.Nombre, productoB.StockMinimo, productoB.Categoria);

                    cbTipoBebida.Text = productoB.Tipo.ToString();
                    cbTipoBebida.Visible = true;



                }
                if (medida is MedidaProducto.XCantidad)
                {
                    PorCantidad productoC = (PorCantidad)despensa.GetObjetoProductoPorId(codigoDeElementoAEditar);
                    CargarCamposGenerales(productoC.Stock, productoC.Id, productoC.Precio, productoC.Nombre, productoC.StockMinimo, productoC.Categoria);
                }
                if (medida is MedidaProducto.XKilo)
                {
                    PorKilo productoK = (PorKilo)despensa.GetObjetoProductoPorId(codigoDeElementoAEditar);
                    CargarCamposGenerales(productoK.Stock, productoK.Id, productoK.Precio, productoK.Nombre, productoK.StockMinimo, productoK.Categoria);
                }
                if (medida is MedidaProducto.XKilo)
                {
                    PorLitro productoL = (PorLitro)despensa.GetObjetoProductoPorId(codigoDeElementoAEditar);
                    CargarCamposGenerales(productoL.Stock, productoL.Id, productoL.Precio, productoL.Nombre, productoL.StockMinimo, productoL.Categoria);
                }
            }
        }
        private void CargarCamposGenerales(string stock, string pId, decimal pPrecio, string nombre, int stockMinimo, TipoCategoria categoria)
        {
            txtCODIGO.Text = pId;
            txtPrecio.Text = pPrecio.ToString();
            txtNombre.Text = nombre;
            txtStock.Text = stock;
            txtStockMinimo.Text = stockMinimo.ToString();
            cbSeleccionCategoria.Text = categoria.ToString();
            cbSeleccionCategoria.Enabled = false;   //NO PERMITO QUE SE PUEDAN EDITAR
        }

        private void btnGuardarNuevoProducto_Click(object sender, EventArgs e)
        {
            Despensa despensa = new Despensa();
            TipoCategoria tipoCategoria = (TipoCategoria)cbSeleccionCategoria.SelectedIndex;//1=Fruta
            MedidaProducto tipoMedida = despensa.GetMedidaPorFiltradaCategoria(tipoCategoria);
            if (Convert.ToDouble(txtStock.Text) > Convert.ToInt16(txtStockMinimo.Text))
            {

                this.AgregarProductoSegunMedida(tipoMedida, tipoCategoria);
                MessageBox.Show("Carga de Producto Exitosa!!!");
                this.Close();
            }
            else
            {
                //Lo iba  aser de esta forma y desp comprobar en la carga si se trataba 
                //DialogResult result = MessageBox.Show("El Stock no puede ser menor a la alerta de stock que usted ingreso... \\¿Quiere Guardarlo de este Modo y que se agregue a lista de Super paa luego comrprar?", "ALERTAAA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //IBA A SERLO DE MANERA QUE ME CARGUE EL PRODUCTO IGUALMENTE Y QUE LUEGO PUEDA COMPRAR
                //PERO NO VOY A LLEGAR A LA ENTREGA DE ESA FORMA
                MessageBox.Show("El Stock no puede ser menor a la alerta de stock que usted ingreso... ", "ALERTAAA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void AgregarProductoSegunMedida(MedidaProducto medidaProducto, TipoCategoria tipoCategoria)
        {
            Despensa despensa = new Despensa();
            if (medidaProducto is MedidaProducto.XCantidad)
            {
                string stock = Convert.ToInt32(txtStock.Text).ToString();

                Producto producto = new PorCantidad(txtCODIGO.Text, medidaProducto, tipoCategoria, txtNombre.Text, stock, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt16(txtStockMinimo.Text));
                //codigo, medida, categoria, nombre, cantidad, precio, stockMinimo
                despensa.AgregarModificarProducto(producto);

            }
            if (medidaProducto is MedidaProducto.XBebida)//0=bebida
            {

                Bebidas tipoBebida = (Bebidas)cbTipoBebida.SelectedIndex;
                string stock = Convert.ToDouble(txtStock.Text).ToString();
                panelTipoBebida.Visible = true;
                Producto producto = new Bebida(tipoBebida, txtCODIGO.Text, medidaProducto, tipoCategoria, txtNombre.Text, stock, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt16(txtStockMinimo.Text));
                despensa.AgregarModificarProducto(producto);
            }
            if (medidaProducto is MedidaProducto.XKilo)
            {
                string stock = Convert.ToDouble(txtStock.Text).ToString();

                Producto producto = new PorKilo(txtCODIGO.Text, medidaProducto, tipoCategoria, txtNombre.Text, stock, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt16(txtStockMinimo.Text));
                despensa.AgregarModificarProducto(producto);
            }
            if (medidaProducto is MedidaProducto.XLitro)
            {
                string stock = Convert.ToDouble(txtStock.Text).ToString();

                Producto producto = new PorLitro(txtCODIGO.Text, medidaProducto, tipoCategoria, txtNombre.Text, stock, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt16(txtStockMinimo.Text));
                despensa.AgregarModificarProducto(producto);
            }

        }

        #region Validaciones

        private void cbTipoBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            campoCategoriaLLeno = controlTipiado.VerificarSeleccion(cbSeleccionCategoria.SelectedIndex);
            campoTipoBebida = controlTipiado.VerificarSeleccion(cbTipoBebida.SelectedIndex = 0);
            
            if (cbSeleccionCategoria.SelectedIndex == 0)
            {
                panelTipoBebida.Visible = true;
                if (campoCategoriaLLeno && camposLLenos)
                {
                    btnGuardarNuevoProducto.Enabled = true;
                }
                else
                {
                    btnGuardarNuevoProducto.Enabled = true;
                }
            }
            else
            {
                panelTipoBebida.Visible = false;
                if (campoCategoriaLLeno && camposLLenos)
                {
                    btnGuardarNuevoProducto.Enabled = true;
                }
                else
                {
                    btnGuardarNuevoProducto.Enabled = false;
                }               
            }
            ValidarCampo();
        }
        private void cbSeleccionCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            campoCategoriaLLeno = controlTipiado.VerificarSeleccion(cbSeleccionCategoria.SelectedIndex);
            campoTipoBebida = controlTipiado.VerificarSeleccion(cbTipoBebida.SelectedIndex = 0);
            if (cbSeleccionCategoria.SelectedIndex == 0)
            {

                panelTipoBebida.Visible = true;
                if (campoCategoriaLLeno && camposLLenos)
                {
                    btnGuardarNuevoProducto.Enabled = true;
                }
                else
                {
                    btnGuardarNuevoProducto.Enabled = false;
                }
            }
            else
            {
                panelTipoBebida.Visible = false;
                if (campoCategoriaLLeno && camposLLenos)
                {
                    btnGuardarNuevoProducto.Enabled = true;
                }
                else
                {
                    btnGuardarNuevoProducto.Enabled = false;
                }

            }
            }
           
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlTipiado.SoloLetras(e);
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlTipiado.SoloNumerosDecimales(e, txtPrecio.Text);
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlTipiado.SoloNumerosEnteros(e);
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlTipiado.SoloNumerosDecimales(e, txtStock.Text);
        }
            
        private void ValidarCampo()
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtPrecio.Text) &&
                !string.IsNullOrEmpty(txtStockMinimo.Text) &&
                !string.IsNullOrEmpty(txtStock.Text))
            {
                camposLLenos = true;
            }
            else
            {
                camposLLenos = false;
                btnGuardarNuevoProducto.Enabled = false;
            }
            if (camposLLenos)
            {
                camposLLenos = true;
                if (campoCategoriaLLeno)
                {
                    campoCategoriaLLeno = true;
                    btnGuardarNuevoProducto.Enabled = true;
                }
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();

        }
        private void txtStockMinimo_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }
        #endregion



        
    }

}

