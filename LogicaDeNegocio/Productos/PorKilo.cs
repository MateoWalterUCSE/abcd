using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Productos
{
    public class PorKilo : Producto
    {
        public PorKilo(string codigo, MedidaProducto medida, TipoCategoria categoria, string nombre, string cantidad, decimal precio, int stockMinimo) :
            base(codigo, medida, categoria, nombre, cantidad, precio, stockMinimo)
        {
        }
    }
}
