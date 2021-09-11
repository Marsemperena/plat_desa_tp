using System;
using System.Collections.Generic;
using System.Linq;

namespace tp1
{
    public class Mercado
    {
    
            public int maxCategorias { get; set; }
            public int cantCategorias { get; set; }
            public Categoria[] categorias;

        public List<Producto> producto = new List<Producto>();

         

        public List<Usuario> usuario = new List<Usuario>();

           

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
            this.producto.Add(new Producto("producto 2", 1, 10, this.categorias[1]));
            this.producto.Add(new Producto("producto 2", 561, 10, this.categorias[1]));


        }
            
            public bool agregarProducto (string nombre, double precio, int cantidad, int id_Categoria)
            {

            try
            {
                this.producto.Add(new Producto(nombre, precio, cantidad, this.categorias[id_Categoria]));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un error al intentar dar de alta el producto, por favor intente nuevamente");
                return false;
            }
            }


        public bool modificarProducto(int id, string nombre, double precio, int cantidad, int id_Categoria)
        {
            foreach (Producto prod in producto)
            {
                if (prod.id == id)
                {
                    if (nombre != null)
                    {
                        prod.nombre = nombre;
                    }
                    if (precio > 0)
                    {
                        prod.precio = precio;
                    }
                    if (cantidad > 0)
                    {
                        prod.cantidad = cantidad;
                    }
                    if (id_Categoria >= 0 ) 
                   {
                        prod.cat.id= id_Categoria;
                    }
                    return true;
                }

            }
            return false;
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
                foreach(Producto pr in producto)
                {
                    if (pr.nombre.Contains(query))
                    {
                        Console.WriteLine(pr.toString());
                    }
                }
            }


            public void buscarProductosPorPrecio (string query) //ORDENADO POR PRECIO DE MENOR A MAYOR LOS PRODUCTOS QUE CONTIENEN EN SU NOMBRE LA CADENA INGRESADA
            {
                IEnumerable<Producto> aux = producto.OrderBy(pr => pr.precio);
                foreach (Producto pr in aux)
                {
                    if (pr.nombre.Contains(query))
                    {
                        Console.WriteLine(pr.toString());
                    }
            }
        }


            public void buscarProductosPorCategoria (int id_Categoria) //ORDENADO POR NOMBRE LOS PRODUCTOS QUE PERTENCEN A LA CATEGORIA CON EL ID INGRESADO
            {
            List<Producto> listProd = new List<Producto>();
            foreach (Producto pr in producto)
            {
                if(pr.cat.id == id_Categoria)
                {
                    listProd.Add(pr);
                }   
            }
            IEnumerable<Producto> resultado = listProd.OrderBy(pr => pr.nombre);
            foreach (Producto resul in resultado)
            {
                Console.WriteLine(resul);
            }    
            }

            
            public bool agregarUsuario (int dni, string nombre, string apellido, string mail, string password, int cuit_Cuil, bool esEmpresa)
            {
            //calcular id
            //(int id, int cuit, int dni, string nombre, string mail, string password)
            //int id, int cuit, int dni, string nombre, string mail, string password
            Usuario us;
            if (esEmpresa)
            {
               us = new Empresa(usuario.Last().id + 1, cuit_Cuil, dni, nombre, mail, password);

            }
            else
            {
              us =  new ClienteFinal(usuario.Last().id + 1, cuit_Cuil, dni, nombre, mail, password);
            }

            usuario.Add(us);
           
            return true;
            }


        public bool modificarUsuario(int id, int dni, string nombre, string apellido, string mail, string password, int cuit_Cuil, bool esEmpresa)
        {
            foreach (Usuario us in usuario)
            {
                if (us.id == id)
                {
                   if (dni > 0)
                     {
                      us.dni = dni;
                      }
                    if (nombre != null)
                    {
                        us.nombre = nombre;
                    }
                      
                    if (apellido != null)
                    {
                     us.apellido = apellido;
                    }
                    if (mail != null)
                    {
                        us.mail = mail;
                    }
                    if (password != null)
                    {
                        us.password = password;
                    }

                    if(us is Empresa)
                    {
                         us.cuit = cuit_Cuil;
                    }
                    else
                    {
                        us.cuil = cuit_Cuil;
                    }
                    /* if (cuit_Cuil != null) { //revisar
                     *
                         if (us.GetType() == Empresa)

                         {

                            (Empresa) us.cuit = cuit_Cuil;
                         }
                         else
                         {
                             us.cuil = cuit_Cuil;
                         }

                     }*/


                    if (dni > 0)
                    {
                        us.dni = dni;


                    }
                   
            }



               
            }
            return false;
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
            usuario = usuario.OrderBy(o  =>  o.dni).ToList();
             foreach(Usuario us in usuario)
            {
                us.ToString();
                
            }
        }

            
            public bool agregarCategoria (string nombre)
            {
            int id = 0;
            bool flag = false;
            for (var i = 0; i < categorias.Length; i++)
            {
                if (categorias[i].nombre == nombre || maxCategorias == cantCategorias) {
                    Console.WriteLine("La categoria ya existe");
                    break;
                
                } else
                {
                    for (var a = 0; a < categorias.Length; a++)
                    {
                        if (categorias[a] == null)
                        {
                            for (var c = 0; c < categorias.Length; c++)
                            {
                                if(categorias[c].id >= id)
                                {
                                    id = categorias[c].id;
                                }

                            }
                            categorias[a] = new Categoria(id+1,nombre);
                            cantCategorias +=1;
                            flag = true;
                            break;
                        }

                    }

                }
           
                if ( flag == true)
                {
                    break;
                }
            
            }

                return flag;
        }


            public bool modificarCategoria (int id, string nombre)
            {
                bool flag = false;

                for(var i = 0; i < categorias.Length; i++)
                {
                    if (categorias[i].id == id)
                    {
                        categorias[i].nombre = nombre;
                        flag = true;
                    }
                }

                return flag;
            }


            public bool eliminarCategoria (int id)
            {
            bool flag = false;
            for(var i = 0; i < categorias.Length; i++)
            {
                if (categorias[i].id == id)
                {
                    categorias[i] = null;
                    cantCategorias -= 1;
                    flag = true;
                }

            }

            return flag;
        }


            public void mostrarCategoria() //MAL EN EL ENUNCIADO PERO MOSTRAR TODOS LAS CATEGORIAS ORDENADAS POR ID
            {
            Categoria temp;
            String cats = "";
            for (int i = 0; i < categorias.Length - 1; i++) { 

                for (int j = i + 1; j < categorias.Length; j++) { 

                if (categorias[i].id > categorias[j].id)
                    {

                        temp = categorias[i];
                        categorias[i] = categorias[j];
                        categorias[j] = temp;
                    }
                }
            }

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
            public void mostrarTodosProductos()
        {
            producto.Sort((a, b) => a.id.CompareTo(b.id));
            foreach (Producto pr in producto)
            {
                Console.WriteLine(pr.toString());

            }

        }

            public void mostrarTodosProductosPorPrecio() //MUESTRA TODOS LOS PRODUCTOS DEL MERCADO, ORDENADO POR PRECIO
            {


            IEnumerable<Producto> aux = producto.OrderBy(pr => pr.precio);
            foreach (Producto pr in aux)
            {
                Console.WriteLine(pr.toString());
            }

        }


            public void mostrarTodosProductosPorCategoria() //MUESTRA TODAS LAS CATEGORIAS DEL MERCADO Y PARA CADA UNA DE ELLAS, LOS PRODUCTOS DENTRO DE LA MISMA.
            {
            IEnumerable<Producto> aux = producto.OrderBy(pr => pr.cat.id);
            foreach (Producto pr in aux)
            {
                Console.WriteLine(pr.toString());
            }
        }


    }
}
