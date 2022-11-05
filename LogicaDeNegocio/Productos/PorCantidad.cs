using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio.Productos
{
    public class PorCantidad : Producto
    {
        //public int Stock { get; set; }
        //public int MyProperty { get; set; }

        public PorCantidad(){ }
        public PorCantidad(int cantidad, int CantidadAAgregar, int IdDeProductoAEliminar)
        {

        }
        public PorCantidad(string codigo, MedidaProducto medida, TipoCategoria categoria, string nombre, string cantidad, decimal precio, int stockMinimo)
            : base(codigo, medida, categoria, nombre, cantidad, precio, stockMinimo)

        {
           //this.Stock = stock;
            
        }

    }
}
