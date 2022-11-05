using LogicaDeNegocio;
using LogicaDeNegocio.Productos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Receta : Archivo
    {
        public enum MomentoComida {
            Desayuno,
            Almuerzo,
            Merienda,
            Cena
        }
        public string Id { get; set; }
        public MomentoComida Momento { get; set; }
        public bool Saludable { get; set; }
        public string Nombre { get; set; }
        //public int CantidadPersonas { get; set; } //Me dice para cuantas personas es la receta
        // public List<CodigoCantidad> Ingredientes { get; set; }
        public List<string> ID { get; set; }
        //public List<Receta> ListaDeRecetas { get; set; }
        //public List<Producto> Productos { get; set; }
        //public List<int> CodigosProductos { get; set; }
        public Receta(){}
        
        public Receta(string pId, MomentoComida pMomento, bool pSaludable, string pNombre, int  pCantPersonas, List<CodigoCantidad> CodigoCantidad)
        {
            this.Id = pId;
            this.Momento = pMomento;
            this.Saludable = pSaludable;
            this.Nombre = pNombre;
            //this.CantidadPersonas = pCantPersonas;
            //this.Ingredientes = CodigoCantidad;
        }

        //public void AgregarNuevoProductoAReceta(CodigoCantidad codigoCantidad)
        //{
        //    Ingredientes.Add(codigoCantidad );
        //}
    }
}
