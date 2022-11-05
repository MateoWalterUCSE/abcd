using Logica;
using Logica.Productos;
using LogicaDeNegocio.Productos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;

namespace LogicaDeNegocio.Productos
{
    public class Archivo
    {
        public Despensa despensa { get; set; }
        public static string RUTA;

        public const string ArchivoProductoXBebida = "\\ArchivoProductoBebida.txt";
        public const string ArchivoProductoXCantidad = "\\ArchivoProductoPorCantidad.txt";
        public const string ArchivoProductoXKilo = "\\ArchivoProductoPorKilo.txt";
        public const string ArchivoProductoXLitro = "\\ArchivoProductoPorLitro.txt";
        public const string ArchivoProductosBajoStock = "\\ArchivoProductoBajoStock.txt";
        public const string ArchivoDeRecetas = "\\ArchivoDeRecetas.txt";
        public const string ArchivoDeComidas = "\\ArchivoDeComidas.txt";
        
        public Archivo(){  }
        
        /// <summary>
        /// Inicializo todas las listas con archivos en base de datos
        /// </summary>
        public static void InicializadorDeListas()
        {
            
                

            


            Archivo archivo = new Archivo();


            List<PorCantidad> ListaXCantidades = new List<PorCantidad>();
            List<PorLitro> ListaXLitros = new List<PorLitro>();
            List<PorKilo> ListaXKilos = new List<PorKilo>();
            List<Bebida> ListaXBebidas = new List<Bebida>();
            List<Producto> ListaXSupermercado = new List<Producto>();
            List<Comida> ListaXComidas = new List<Comida>();
            List<Receta> ListaXRecetas = new List<Receta>();

            
            

            string jsDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos");
            RUTA = jsDatos;
            if (!Directory.Exists(jsDatos))  //no existe => creo Archivos de cada tipo
            {
                Directory.CreateDirectory(jsDatos);
                Despensa despensa = new Despensa();
                
                Escribir(jsDatos + ArchivoProductoXBebida, archivo.EscribirListaTipo(ListaXBebidas));
                Escribir(jsDatos + ArchivoProductoXCantidad, archivo.EscribirListaTipo(ListaXCantidades));
                Escribir(jsDatos + ArchivoProductoXKilo, archivo.EscribirListaTipo(ListaXKilos));
                Escribir(jsDatos + ArchivoProductoXLitro, archivo.EscribirListaTipo(ListaXLitros));
                Escribir(jsDatos + ArchivoProductosBajoStock, archivo.EscribirListaTipo(ListaXSupermercado));
                Escribir(jsDatos + ArchivoDeComidas, archivo.EscribirListaTipo(ListaXKilos));
                Escribir(jsDatos + ArchivoDeRecetas, archivo.EscribirListaTipo(ListaXLitros));
                despensa.CargarFiltros();

            }
            else  //ya existe "Datos" => cargo las listas
            {
                archivo.LeerProductoBebidaEnArchivo(RUTA + ArchivoProductoXBebida, ListaXBebidas);
                archivo.LeerProductoCantidadEnArchivo(RUTA + ArchivoProductoXCantidad, ListaXCantidades);
                archivo.LeerProductoKiloEnArchivo(RUTA + ArchivoProductoXKilo, ListaXKilos);
                archivo.LeerProductoLitroEnArchivo(RUTA + ArchivoProductoXLitro, ListaXLitros);
                archivo.LeerSuperEnArchivo(RUTA + ArchivoProductosBajoStock);
                archivo.LeerComidasEnArchivo(RUTA + ArchivoDeComidas);
                archivo.LeerRecetasEnArchivo(RUTA + ArchivoDeRecetas);



            }


        }

        

        public static void Escribir(string rutaAGuardar, string ListaYaSerializada)
        {
            using (StreamWriter Escribir = new StreamWriter(rutaAGuardar, false))
            {
                Escribir.Write(ListaYaSerializada);
            }
        }
        #region DivisionYSerializacionDeProductos
        protected List<Bebida> RellenarListaSegunXBebida(List<Producto> productos)
        {
            return productos.Where(x => x is Bebida).Select(x => x as Bebida).ToList();
        }
        protected List<PorCantidad> RellenarListaSegunXCantidad(List<Producto> productos)
        {
            return productos.Where(x => x is PorCantidad).Select(x => x as PorCantidad).ToList();
        }
        protected List<PorKilo> RellenarListaSegunXKilo(List<Producto> productos)
        {
            return productos.Where(x => x is PorKilo).Select(x => x as PorKilo).ToList();
        }
        protected List<PorLitro> RellenarListaSegunXLitro(List<Producto> productos)
        {
            return productos.Where(x => x is PorLitro).Select(x => x as PorLitro).ToList();
        }
        
        protected string EscribirListaTipo(List<Bebida> listaBebida) => JsonConvert.SerializeObject(listaBebida);
        protected string EscribirListaTipo(List<PorCantidad> listaCantidad) => JsonConvert.SerializeObject(listaCantidad);
        protected string EscribirListaTipo(List<PorKilo> listaKilo) => JsonConvert.SerializeObject(listaKilo);
        protected string EscribirListaTipo(List<PorLitro> listaLitro) => JsonConvert.SerializeObject(listaLitro);
        protected string EscribirListaTipo(List<Producto> listaSuper) => JsonConvert.SerializeObject(listaSuper);
        protected string EscribirListaTipo(List<Receta> listaReceta) => JsonConvert.SerializeObject(listaReceta);
        protected string EscribirListaTipo(List<Comida> listaComida) => JsonConvert.SerializeObject(listaComida);
        #endregion

        /// <summary>
        /// Region donde Cargo todas las listas de todo
        /// </summary>
        /// <param name="rutaxTipo"></param>
        /// <param name="listaPorTipo"></param>
        #region DeserealizacionDeArchivos
        private void LeerProductoBebidaEnArchivo(string rutaBebida, List<Bebida> listaBebida)
        {
            using (StreamReader Lectura = new StreamReader(rutaBebida))
            {
                
                listaBebida = JsonConvert.DeserializeObject<List<Bebida>>(Lectura.ReadToEnd());
                Despensa.ListaDeProductos = listaBebida.Select(x => x as Bebida).ToList<Producto>();
            }

        }
        private void LeerProductoLitroEnArchivo(string rutaBLitro, List<PorLitro> listaLitro)
        {
            using (StreamReader Lectura = new StreamReader(rutaBLitro))
            {
                
                listaLitro = JsonConvert.DeserializeObject<List<PorLitro>>(Lectura.ReadToEnd());
                Despensa.ListaDeProductos.AddRange(listaLitro.Select(x => x as PorLitro).ToList<Producto>());
            }
        }
        private void LeerProductoKiloEnArchivo(string rutaKilo, List<PorKilo> ListaKilos)
        {
            using (StreamReader Lectura = new StreamReader(rutaKilo))
            {
               
                ListaKilos = JsonConvert.DeserializeObject<List<PorKilo>>(Lectura.ReadToEnd());
                Despensa.ListaDeProductos.AddRange(ListaKilos.Select(x => x as PorKilo).ToList<Producto>());
            }
        }
        private void LeerProductoCantidadEnArchivo(string rutaCantidad, List<PorCantidad> listaCantidad)
        {
            using (StreamReader Lectura = new StreamReader(rutaCantidad))
            {
                
                listaCantidad = JsonConvert.DeserializeObject<List<PorCantidad>>(Lectura.ReadToEnd());
                Despensa.ListaDeProductos.AddRange(listaCantidad.Select(x => x as PorCantidad).ToList<Producto>());
            }
        }
        private void LeerRecetasEnArchivo(string rutaRecetas)
        {
            using (StreamReader Lectura = new StreamReader(rutaRecetas))
            {
                List<Receta> recetas = new List<Receta>();
                recetas = (JsonConvert.DeserializeObject<List<Receta>>(Lectura.ReadToEnd()).ToList());
            }
        }

        private void LeerComidasEnArchivo(string rutaComidas)
        {
            using (StreamReader Lectura = new StreamReader(rutaComidas))
            {
                List<Comida> comidas = new List<Comida>();
                comidas = (JsonConvert.DeserializeObject<List<Comida>>(Lectura.ReadToEnd()).ToList());
            }
        }

        private void LeerSuperEnArchivo(string rutaSuper)
        {
            using (StreamReader Lectura = new StreamReader(rutaSuper))
            {
                List<Producto> ListaSuper = new List<Producto>();
                //ListaSuper = (JsonConvert.DeserializeObject<List<Producto>>(Lectura.ReadToEnd()).ToList());
            }
        }

        #endregion
        
    }
}