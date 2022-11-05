using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class AdminReceta 
    {
        public List<string> Id = new List<string>();
        public List<int> Cantidad = new List<int>();
        public List<Receta> Receta { get; set; }

        //public void AgregarReceta();


    }
}
