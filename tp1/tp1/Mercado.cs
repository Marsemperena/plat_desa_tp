using System;
using System.Collections.Generic;

namespace tp1
{
    class Mercado
    {
    
            public int maxCategorias { get; set; }
            public int cantCategorias { get; set; }
            public Categoria[] categorias;

            List<Producto> producto = new List<Producto>() {
               // new Productos() { nombre = "", precio = 42 },
//new Productos() { nombre = "", precio = 34 },
              //  new Productos() { nombre = "", precio = 8 },
            };

            List<Usuario> usuario = new List<Usuario>() {
               // new Usuarios() { nombre = "", apellido = "" },
               // new Usuarios() { nombre = "", apellido = "" },
               // new Usuarios() { nombre = "", apellido = "" },
            };

            List<Compra> compra = new List<Compra>() {
               // new Compras() { id = 1, comprador = 1, total = 32, producto ????????? }, //ARRAY DE PRODUCTOS?
               // new Compras() { id = 2, comprador = 2, total = 232, producto ????????? },
//new Compras() { id = 3, comprador = 3, total = 132, producto ????????? },
            };

            
            public bool agregarProducto (string nombre, double precio, int cantidad, int id_Categoria)
            {
            return true;
            }


            public bool modificarProducto (int id, string nombre, double precio, int cantidad, int id_Categoria)
            {
            return true;
        }

            
            public bool eliminarProducto (int id)
            {
            return true;
        }

            
            public void buscarProductos (string query) // ORDENADO POR NOMBRE LOS PRODUCTOS QUE CONTIENEN EN SU NOMBRE LA CADENA INGRESADA
            {
            
        }


            public void buscarProductosPorPrecio (string query) //ORDENADO POR PRECIO DE MENOR A MAYOR LOS PRODUCTOS QUE CONTIENEN EN SU NOMBRE LA CADENA INGRESADA
            {
         
        }


            public void buscarProductosPorCategoria (int id_Categoria) //ORDENADO POR NOMBRE LOS PRODUCTOS QUE PERTENCEN A LA CATEGORIA CON EL ID INGRESADO
            {
            
        }

            
            public bool agregarUsuario (int dni, string nombre, string apellido, string mail, string password, int cuit_Cuil, bool esEmpresa)
            {
            return true;
        }


            public bool modificarUsuario (int id, int dni, string nombre, string apellido, string mail, string password, int cuit_Cuil, bool esEmpresa)
            {
            return true;
        }


            public bool eliminarUsuario (int id)
            {
            return true;
        }


            public void mostrarUsuarios () // MUESTRA TODOS LOS USUARIOS ORDENADOS POR DNI
            {
          
        }

            
            public bool agregarCategoria (string nombre)
            {
            return true;
        }


            public bool modificarCategoria (int id, string nombre)
            {
            return true;
        }


            public bool eliminarCategoria (int id)
            {
            return true;
            }


            public void mostrarCategoria() //MAL EN EL ENUNCIADO PERO MOSTRAR TODOS LAS CATEGORIAS ORDENADAS POR ID
            {

            }


        /* ESTOS SON OPCIONALES EN LA PRIMER ENTREGA
         
            public bool AgregarAlCarro (int id_Producto, int cantidad, int id_Usuario){}
            
            public bool QuitarDelCarro (int id_Producto, int Cantidad, int id_Usuario){}

            public bool VaciarCarro (int id_Usuario){}

            public bool Comprar(int id_Usuario){}

            public bool ModificarCompra ( int id, double total){}

            public bool EliminarCompra (int id){}

        */

            public void mostrarTodosProductosPorPrecio() //MUESTRA TODOS LOS PRODUCTOS DEL MERCADO, ORDENADO POR PRECIO
            {

            }


            public void mostrarTodosProductosPorCategoria() //MUESTRA TODAS LAS CATEGORIAS DEL MERCADO Y PARA CADA UNA DE ELLAS, LOS PRODUCTOS DENTRO DE LA MISMA.
            { 
        
            }


    }
}
