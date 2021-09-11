using System;
using System.Collections.Generic;

namespace tp1
{
    public class Mercado
    {
    
            public int maxCategorias { get; set; }
            public int cantCategorias { get; set; }
            public Categoria[] categorias;

        public List<Producto> producto = new List<Producto>();
               // new Productos() { nombre = "", precio = 42 },
               //new Productos() { nombre = "", precio = 34 },
              //  new Productos() { nombre = "", precio = 8 },
         

        public List<Usuario> usuario = new List<Usuario>();
               // new Usuarios() { nombre = "", apellido = "" },
               // new Usuarios() { nombre = "", apellido = "" },
               // new Usuarios() { nombre = "", apellido = "" },
           

       public List<Compra> compra;

            public Mercado()
        {
            this.categorias = new Categoria[5];
            this.usuario = new List<Usuario>();
            this.compra = new List<Compra>();

            this.categorias[0] = new Categoria(0, "categ 0");
            this.categorias[1] = new Categoria(0, "categ 1");

            this.usuario.Add(new Empresa(1,0, 234123, "test 0", "mail@mail.com", "pass"));
            this.usuario.Add(new ClienteFinal(2, 1, 234123, "test 1", "mail@gmail.com", "pkjj11"));

            this.producto.Add(new Producto("producto 1", 1500, 10, this.categorias[0]));
            this.producto.Add(new Producto("producto 2", 1500, 10, this.categorias[1]));


        }
            
            
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
            bool flag = false;
            foreach(Producto prod in producto)
            {
                if  (prod.id == id)
                {
                     producto.RemoveAt(producto.IndexOf(prod));
                     flag = true;
                }
            }
            return flag;
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
            //calcular id
            //(int id, int cuit, int dni, string nombre, string mail, string password)
            //int id, int cuit, int dni, string nombre, string mail, string password
            Usuario us;
            if (esEmpresa)
            {
               us = new Empresa(1, cuit_Cuil, dni, nombre, mail, password);

            }
            else
            {
              us =  new ClienteFinal(1, cuit_Cuil, dni, nombre, mail, password);
            }

            usuario.Add(us);
           
            return true;
            }


            public bool modificarUsuario (int id, int dni, string nombre, string apellido, string mail, string password, int cuit_Cuil, bool esEmpresa)
            {
            return true;
        }


            public bool eliminarUsuario (int id)
            {
            bool flag = false;
            foreach (Usuario us in usuario)
            {
                if (us.id == id)
                {
                    usuario.RemoveAt(usuario.IndexOf(us));
                    flag = true;
                }

            } 


            return flag;
        }


            public void mostrarUsuarios () // MUESTRA TODOS LOS USUARIOS ORDENADOS POR DNI
            {
             foreach(Usuario us in usuario)
            {
                us.ToString();
                
            }
        }

            
            public bool agregarCategoria (string nombre)
            {
            bool flag = true;
            for (var i = 0; i < categorias.Length; i++)
            {
                if (categorias[i].nombre == nombre) {
                    flag = false;
                    Console.WriteLine("La categoria ya existe");
                    break;
                
                } else
                {
                    for (var a = 0; a < categorias.Length; a++)
                    {
                        if (categorias[a] == null)
                        {
                            //Contructor de categorias
                            break;
                        }
                    }


                }
           
            
            }

                return true;
        }


            public bool modificarCategoria (int id, string nombre)
            {
            return true;
        }


            public bool eliminarCategoria (int id)
            {
            bool flag = false;
            for(var i = 0; i < categorias.Length; i++)
            {
                if (categorias[i].id == id)
                {
                    categorias[i] = null;
                    flag = true;
                }

            }

            return flag;
        }


            public void mostrarCategoria() //MAL EN EL ENUNCIADO PERO MOSTRAR TODOS LAS CATEGORIAS ORDENADAS POR ID
            {
            String cats = "";

            for (var i = 0; i < categorias.Length; i++)
            {
                if(categorias[i]!=null)
                cats += categorias[i].toString() + " \n";

            }

            Console.WriteLine(cats);
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
