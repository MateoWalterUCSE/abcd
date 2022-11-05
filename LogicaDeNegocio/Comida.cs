using LogicaDeNegocio.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Comida : Archivo
    {
        public string Id { get; set; }
        public Receta ComidaElegida { get; set; } //Receta ya creada
        public DateTime Fecha { get; set; }



    }
}
