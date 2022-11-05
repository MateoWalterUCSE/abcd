using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Producto
    {
        public enum MedidaProducto {XBebida, XCantidad, XKilo, XLitro}
        public enum TipoCategoria
        {
            Bebida = 0,
            Fruta,
            HortalizasYVerdura,
            Queso,
            Lacteo,
            Carne,
            Pescado,
            Panaderia
        }
        public MedidaProducto TipoMedida { get; set; }
        public string Id { get; set; } //No lo ingresa el usuario
        public TipoCategoria Categoria { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Stock { get; set; }
        public int StockMinimo { get; set; } //El stockMinimo lo define el usuario en su primer ingreso del mismo producto
        public Producto() { }
        
        public Producto(string codigo, MedidaProducto medida, TipoCategoria categoria, string nombre,  string cant, decimal precio, int stockMinimo)
        {
            TipoMedida = medida;
            Id = codigo;
            Nombre = nombre.ToUpper();
            Categoria = categoria;
            Precio= precio;
            Stock = cant;
            StockMinimo = stockMinimo;
        }



    }
}
