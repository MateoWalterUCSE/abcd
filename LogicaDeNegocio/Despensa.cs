using Logica.Productos;
using LogicaDeNegocio;
using LogicaDeNegocio.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logica.Producto;
using static Logica.Productos.Bebida;
using static Logica.Receta;

namespace Logica
{
    public class Despensa : Archivo
    {
        //List<string> IdProductoReceta = new List<string>();
        //List<int> CantidadProductoReceta = new List<int>();
        public static List<Producto> ListaDeProductos { get; set; }
        public static List<string> ListaDeSupermercado { get; set; }
        public List<Comida> ListaDeComidas { get; internal set; }
        public static List<Receta> ListaDeRecetas { get; set; }
        public Despensa()
        {

        }

        public List<Producto> GetListaDeProductosConBajoStock()
        {
            bool bandera = false;
            foreach (Producto producto in ListaDeProductos)
            {
                if (Convert.ToDouble(producto.Stock) < producto.StockMinimo)
                {
                    bandera = true;
                    return ListaDeProductos;
                }
            }
            if(bandera)
            {
                return null;
            }else
            {
                return ListaDeProductos;
            }

        }

        public List<Receta> ObtenerListaRecetaFiltradaaProMomentoComida(MomentoComida momentoComida)
        {
            try
            {
                return ListaDeRecetas.Where(x => x.Momento == momentoComida).ToList();
            }
            catch
            {
                new Exception("La lista De Recetas es null");
                return null;
            }


        }

        public List<Producto> ObtenerListaProductoPorId(string codigo)
        {
            return ListaDeProductos.Where(x=>x.Id==codigo).ToList();
        }

        //public List<Producto> ObtenerListaProducto()
        //{
        //    return ListaDeProductos;
        //}
        //private Super GetSuperPorId(string idProductoAAgregarASuper)
        //{
        //    Super super = ListaDeSupermercado.Where(x => x.Codigo == idProductoAAgregarASuper).FirstOrDefault();
        //    return super;
        //}
        public Producto GetObjetoProductoPorId(string codigoDeProducto)
        {
            Producto producto = ListaDeProductos.Where(x => x.Id == codigoDeProducto).FirstOrDefault();
            return producto;
        }
        
        private int GetIndiceProductoPorId(string idProducto)
        {
            return ListaDeProductos.FindIndex(x => x.Id == idProducto);
        }

        public void AgregarModificarProducto(Producto producto)
        {
            if (string.IsNullOrEmpty(producto.Id))// no existe => Creo Nuevo
            {
                int codigoAumentado = ListaDeProductos.Count + 1;

                ////if (Convert.ToInt32(producto.Stock) < producto.StockMinimo) //AGREGAR SUPER
                //{
                //    Super super = new Super();
                //    super.ProductoFaltante.Id = codigoAumentado.ToString();
                //if (ListaDeSupermercado is null)
                //{
                //    ListaDeSupermercado = new List<Super>();

                //}
                //    ListaDeSupermercado.Add(super);
                //    GuardarSuper();
                //}
                //else//AGREGAR PRODUCTO
                //{
                    producto.Id = codigoAumentado.ToString();
                    if (ListaDeProductos is null)
                    {
                        ListaDeProductos = new List<Producto>();
                    }
                    producto.Id = codigoAumentado.ToString();
                    ListaDeProductos.Add(producto);


                //}
            }
            else //Existe => Modifico y Verifico que ahora no sea menor el stock al stockMinimo
            {
                foreach(var productoActual in ListaDeProductos)
                {
                    if (productoActual.Id == producto.Id) //si el producto que recorro coincide el id => camibio valores
                    {                           //Va a pasar por alto verificar si el stock es menor a la alerta cuando apreta en editar
                                                //agrego desp caundo inicializo VerSuper
                        productoActual.Nombre = producto.Nombre;
                        productoActual.Precio = producto.Precio;
                        productoActual.StockMinimo = producto.StockMinimo;
                        productoActual.Stock = producto.Stock;
                        break;
                    }
                }
                
            }
            GuardarProducto();
            
            
        }
        //public void AgregarProductoBajoEnStock(Producto producto)
        //{

        //}

        public void ListaDeProductosConStockYCargaAlistaDeSuper()
        {
            //foreach(var producto in ListaDeProductos)
            //{
            //    double stock = Convert.ToDouble(producto.Stock);
            //    if( stock < producto.StockMinimo)
            //    {
            //        //EliminarProducto(producto.Id);
            //    }
            //    else
            //    {
            //        AgregarProductoAListaSuperYEliminarEnListaProducto(GetIndiceProductoPorId(producto.Id), producto.Id);
            //    }
            //}
            
        }
        private int GetIndiceDeListaSuperPorId(string idAEvaluar)
        {
            int indice = -1;
            foreach(var idEnSUper in ListaDeSupermercado)
            {
                indice++;
                if(idEnSUper == idAEvaluar)
                {
                    return indice;
                    
                }
                

            }
            return indice;

        }

        public void EliminarProducto(string codigoProductoAEliminar)
        {

            int index = ListaDeProductos.FindIndex(x => x.Id == codigoProductoAEliminar);
            ListaDeProductos.RemoveAt(index);
            GuardarProducto();
        }

        public void RestarCantidad(string idProductoADescontar, int cantidadPasadaParaRestar)
        {
            
            int indiceDeProductoAEliminarOAgregar = GetIndiceProductoPorId(idProductoADescontar);//indiceEnProducto
            double stockActual = Convert.ToDouble(ListaDeProductos[indiceDeProductoAEliminarOAgregar].Stock);
            if (stockActual < cantidadPasadaParaRestar)
            {
                AgregarProductoAListaSuperYEliminarEnListaProducto(indiceDeProductoAEliminarOAgregar, idProductoADescontar);
            }
            else
            {//se puede descontar => 
                int indiceSuperAEliminarValor = GetIndiceDeListaSuperPorId(idProductoADescontar);
                DescontarCantidad(indiceSuperAEliminarValor, indiceDeProductoAEliminarOAgregar, cantidadPasadaParaRestar );
                //int indiceListaAEliminarEnSuper = ListaDeSupermercado.FindIndex(x => x.Codigo == Convert.ToInt16(idProductoADescontar ));
                //DescontarCantidad(indiceListaAEliminarEnSuper, indiceDeElementoEnListaProducto, cantidadARestar);
            }
        }
        private void DescontarCantidad(int indiceListaADescontraEnSuper, int indiceDeProductoADescontar, double cantidadADescontar)
        {
            double stockDescontado = Convert.ToDouble(ListaDeProductos[indiceDeProductoADescontar].Stock);
            stockDescontado = -cantidadADescontar;
            ListaDeProductos[indiceDeProductoADescontar].Stock = stockDescontado.ToString();
            ListaDeSupermercado.RemoveAt(indiceListaADescontraEnSuper);
            GuardarProducto();
            
        }
        public List<Comida> FiltrarComidaPorMomento(MomentoComida momento)
        {
            return ListaDeComidas.Where(x=> x.ComidaElegida.Momento == momento).ToList();
        }
        //private int GetIndiceAEliminarEnSuper(string idProductoQueQuieroDescontar)
        //{
        //    foreach(int posicion in ListaDeSupermercado)
        //    {
        //        if(posicion == id)
        //    }
            
        //}



        private void GuardarProducto()
        {
            
            List<Bebida> ProductosPorBebida = RellenarListaSegunXBebida(ListaDeProductos);
            List<PorCantidad> ProductosPorCantidad = RellenarListaSegunXCantidad(ListaDeProductos);
            List<PorKilo> ProductosPorKilo = RellenarListaSegunXKilo(ListaDeProductos);
            List<PorLitro> ProductosPorLitro = RellenarListaSegunXLitro(ListaDeProductos);
            



            Escribir(RUTA + ArchivoProductoXBebida, EscribirListaTipo(ProductosPorBebida));
            Escribir(RUTA + ArchivoProductoXCantidad, EscribirListaTipo(ProductosPorCantidad));
            Escribir(RUTA + ArchivoProductoXKilo, EscribirListaTipo(ProductosPorKilo));
            Escribir(RUTA + ArchivoProductoXLitro, EscribirListaTipo(ProductosPorLitro));

        }
        /// <summary>
        /// SOBRE RECETAS_______________________________________________________________________________
        /// </summary>
        /// 
        public void AgregarModificarReceta(Receta receta)
        {
            if (string.IsNullOrEmpty(receta.Id))// no existe => Creo Nuevo
            {
                if (ListaDeRecetas is null)
                {
                    ListaDeRecetas = new List<Receta>();
                }
                int codigoAumentado = ListaDeRecetas.Count + 1;
                receta.Id = codigoAumentado.ToString();
                ListaDeRecetas.Add(receta);
            }
            else //Existe => Modifico 
            {
                foreach (var RecetaActual in ListaDeRecetas)
                {
                    if (RecetaActual.Id == receta.Id) //si el producto que recorro coincide el id => camibio valores
                    {

                        RecetaActual.Nombre = receta.Nombre;
                        //RecetaActual.CantidadPersonas = receta.CantidadPersonas;
                        RecetaActual.Momento = receta.Momento;
                        RecetaActual.Saludable = receta.Saludable;
                        break;
                    }
                }
            }
        }
        public void EliminarReceta(string codigoRecetaAEliminar)
        {
            int index = ListaDeRecetas.FindIndex(x => x.Id == codigoRecetaAEliminar);
            ListaDeProductos.RemoveAt(index);
            GuardarProducto();
        }


        //}
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        //AGREGAR A SUPER

        private void AgregarProductoAListaSuperYEliminarEnListaProducto(int indiceDeElementoEnListaProductoAEliminar, string idProductoAAgregarASuper)
        {
            Despensa despensa = new Despensa();
            ListaDeSupermercado = new List<string>();
            ListaDeSupermercado.Add(idProductoAAgregarASuper);
            ListaDeProductos.RemoveAt(indiceDeElementoEnListaProductoAEliminar);
            //Super.Codigo = Convert.ToInt16(idProductoAAgregarASuper);
            //Super.ProductoFaltante = ProductoBajoStock;
            //GetProductoPorId(idProductoBajoStock);
            //Super Id = GetSuperPorId(idProductoAAgregarASuper);

            //ListaDeSupermercado.Add(Id);
            //ListaDeProductos.RemoveAt(indiceDeElementoEnListaProducto);
            GuardarProducto();
            
        }



        public void Compro(Producto producto, string iDProductoQCompro, double cantidadQCompro)
        {//Lo hago de esta forma porq no llego con el tiempo
            bool sePuede = VerificarStock(iDProductoQCompro, cantidadQCompro);
            if (sePuede)
            {
                AgregarModificarProducto(producto);
            }
            else
            {
                throw new Exception("El Producto Que Compor no Sobrepasa EL stock Minimo");
            }
        }
        private bool VerificarStock(string iDProductoQCompro, double cantidadQCompro)
        {
            int indiceIdQCompro = GetIndiceProductoPorId(iDProductoQCompro);
            if (cantidadQCompro > ListaDeProductos[indiceIdQCompro].StockMinimo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public void GuardarComida()
        {
            List<Comida> ListaComida = new List<Comida>();
            Escribir(RUTA + ArchivoDeComidas, EscribirListaTipo(ListaComida));
        }



        public MedidaProducto GetMedidaFiltradaPorId(string id)
        {

            int indice = ListaDeProductos.FindIndex(x => x.Id == id);
            TipoCategoria tipoCategoria = ListaDeProductos[indice].Categoria;
            return GetMedidaPorFiltradaCategoria(tipoCategoria);

        }
        public MedidaProducto GetMedidaPorFiltradaCategoria(TipoCategoria tipoCategoriaFiltradoPorId)
        {
            if (tipoCategoriaFiltradoPorId is Producto.TipoCategoria.Bebida)
            {
                return MedidaProducto.XBebida;
            }
            else
            if (tipoCategoriaFiltradoPorId is TipoCategoria.Fruta ||
                tipoCategoriaFiltradoPorId is TipoCategoria.HortalizasYVerdura)
            {
                return MedidaProducto.XCantidad;
            }
            else
            if (tipoCategoriaFiltradoPorId is TipoCategoria.Lacteo)
            {
                return MedidaProducto.XLitro;
            }
            else return MedidaProducto.XKilo;
        }


        public void GuardarReceta()
        {
            List<Receta> Recetas = ListaDeRecetas;
            Escribir(RUTA + ArchivoDeRecetas, EscribirListaTipo(Recetas));
        }
        internal void CargarFiltros()
        {
            //FILTROS PRODUCTOS
            Producto producto1 = new PorCantidad("1", MedidaProducto.XCantidad, TipoCategoria.Fruta, "COCA COLA", "3", 300M, 1);
            Producto producto2 = new PorKilo("2", MedidaProducto.XKilo, TipoCategoria.Carne, "FALDA", "6.4", 19.9M, 5);
            Producto producto3 = new PorCantidad("3", MedidaProducto.XCantidad, TipoCategoria.Fruta, "MANZANA", "6", 190M, 5);
            Producto producto4 = new PorLitro("4", MedidaProducto.XLitro, TipoCategoria.Lacteo, "LECHE", "6", 190M, 8);
            Producto producto5 = new PorCantidad("5", MedidaProducto.XCantidad, TipoCategoria.Fruta, "BANANA", "3", 160.5M, 5);
            Producto producto6 = new PorKilo("6", MedidaProducto.XKilo, TipoCategoria.Pescado, "MERLUZA", "4", 1.500M, 5);
            Producto producto7 = new PorCantidad("7", MedidaProducto.XKilo, TipoCategoria.Panaderia, "PAN", "6", 235M, 5);
            Producto producto8 = new Bebida(Bebidas.AltasEnAzucar, "8", MedidaProducto.XBebida, TipoCategoria.Fruta, "COCA COLA", "3", 300, 1);
            ListaDeProductos = new List<Producto>();
            ListaDeProductos.Add(producto1);
            ListaDeProductos.Add(producto2);
            ListaDeProductos.Add(producto3);
            ListaDeProductos.Add(producto5);
            ListaDeProductos.Add(producto6);
            ListaDeProductos.Add(producto8);
            ListaDeProductos.Add(producto4);
            ListaDeProductos.Add(producto7);
            GuardarProducto();



            //FILTROS RECETAS=========================================================================================

            ListaDeRecetas = new List<Receta>();
            List<CodigoCantidad> CodigosCantidades = new List<CodigoCantidad>();
            CodigoCantidad codigoCantidad = new CodigoCantidad();
            codigoCantidad.CodigoIngrediente = "1";
            codigoCantidad.Cantidad = 2;
            CodigosCantidades.Add(codigoCantidad);
            Receta receta1 = new Receta("1", Receta.MomentoComida.Almuerzo, true, "TARTA DE MANZANA", 3, CodigosCantidades);
            ListaDeRecetas.Add(receta1);

            CodigoCantidad codigoCantidad2 = new CodigoCantidad();
            codigoCantidad.CodigoIngrediente = "1";
            codigoCantidad.Cantidad = 2;
            CodigosCantidades.Add(codigoCantidad);
            Receta receta2 = new Receta("2", Receta.MomentoComida.Cena, true, "Pastel de Chocolate", 2, CodigosCantidades);
            ListaDeRecetas.Add(receta2);
            GuardarReceta();

            
            //FILTROS SUPER====================================================================

            // Super super = new Super()




            //producto1.NombreProducto = "MANZANAS";
            //producto1.TipoMedida = Producto.MedidaProducto.XCantidad;
            //producto1.Precio = 150;
            //producto1.Categoria = Producto.TipoCategoria.Fruta;
            //producto1.Stock = "10";
            //producto1.StockMinimo = 4;



        }


            ////new List<Producto>().Add(producto1);
            //    //ListaDeProductos.Add(producto1);
            

            //Producto producto2 = new PorCantidad();
            //producto2.Id = "2";
            //producto2.NombreProducto = "BANANAS";
            //producto2.TipoMedida = Producto.MedidaProducto.XCantidad;
            //producto2.Precio = 100;
            //producto2.Categoria = Producto.TipoCategoria.Fruta;
            //producto2.Stock = "8";
            //producto2.StockMinimo = 4;
            ////ListaDeProductos.Add(producto2);
            
            //Producto producto3 = new PorCantidad();
            //producto3.Id = "3";
            //producto3.NombreProducto = "BANANAS";
            //producto3.TipoMedida = Producto.MedidaProducto.XCantidad;
            //producto3.Precio = 100;
            //producto3.Categoria = Producto.TipoCategoria.Fruta;
            //producto3.Stock = "8";
            //producto3.StockMinimo = 4;
            ////ListaDeProductos.Add(producto3);

            //Producto producto4 = new PorCantidad();
            //producto4.Id = "4";
            //producto4.NombreProducto = "BANANAS";
            //producto4.TipoMedida = Producto.MedidaProducto.XCantidad;
            //producto4.Precio = 100;
            //producto4.Categoria = Producto.TipoCategoria.Fruta;
            //producto4.Stock = "8";
            //producto4.StockMinimo = 4;
            ////ListaDeProductos.Add(producto4);

            //AgregarModificarProducto(producto1);
            //AgregarModificarProducto(producto2);
            //AgregarModificarProducto(producto3);
            //AgregarModificarProducto(producto4);

            

            ///////////////////////////////////////////////////////////////////////////////////////////////
            //Receta receta1 = new Receta();
            //receta1.CodigoReceta = "";
            //receta1.NombreReceta = "";
            //receta1.CantidadPersonas = 3;
            //receta1.Momento = Receta.MomentoComida.almuerzo;
            //receta1.Stock = "8";
            //receta1.StockMinimo = 4;
        
    }
}