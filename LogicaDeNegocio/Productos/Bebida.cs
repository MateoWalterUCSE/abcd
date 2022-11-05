using LogicaDeNegocio.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logica.Producto;

namespace Logica.Productos
{
    public class Bebida : Producto
    {
        public enum Bebidas { Normales=0 , AltasEnAzucar, Alcohólicas}
        public Bebidas Tipo { get; set; }
        //public int Stock { get; set; }

        public Bebida() { }
        public Bebida(Bebidas tipo, string codigo, MedidaProducto medida, TipoCategoria categoria, string nombre, string cant, decimal precio, int stockMinimo)
            : base(codigo, medida, categoria, nombre, cant, precio, stockMinimo)
        {
            
            Tipo = tipo;
        }
            
    }
}
