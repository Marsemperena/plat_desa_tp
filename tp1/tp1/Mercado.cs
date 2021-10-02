using System;
using System.Collections.Generic;
using System.Linq;



namespace tp1
{
    public class Mercado
    {

       public const int MAX_CATEGORIAS  = 5;
       public int cantCategorias { get; set; }

       public List<Categoria> categorias= new List<Categoria>();

       public List<Producto> producto = new List<Producto>();

         

       public List<Usuario> usuario = new List<Usuario>();

           

       public List<Compra> compra;

            public Mercado()
        {
            this.categorias = new List<Categoria>();
            this.usuario = new List<Usuario>();
            this.compra = new List<Compra>();

            this.categorias.Add(new Categoria(2, "categ 0"));
            this.categorias.Add(new Categoria(3, "categ 1"));
            this.categorias.Add(new Categoria(5, "categ 2"));

            this.usuario.Add(new Empresa(1,0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            this.usuario.Add(new ClienteFinal(2, 1, 234123, "test 1", "test 00", "mail@gmail.com", "pkjj11"));

            this.producto.Add(new Producto(1,"producto 1", 1500, 10, this.categorias[0]));
            this.producto.Add(new Producto(2,"producto 2", 1, 10, this.categorias[1]));
            this.producto.Add(new Producto(4,"producto 2", 561, 10, this.categorias[1]));


        }
            
            public bool agregarProducto (string nombre, double precio, int cantidad, int id_Categoria)
            {
                int idActual = 0;
                foreach (Producto prod in producto)
                {
                    if (prod.id > idActual) { idActual = prod.id; }
                }
                try
                {
                    this.producto.Add(new Producto(idActual +1,nombre, precio, cantidad, this.categorias[id_Categoria]));
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
                    if (!(string.IsNullOrEmpty(nombre)))
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
                public bool eliminarProducto (int id) { 
                bool flag = false;
                int indice;
                for (var i = 0; i<producto.Count(); i++)
                {
                    if (producto[i] != null && producto[i].id == id)
                    {
                         indice = producto.IndexOf(producto[i]);
                        producto.RemoveAt(indice);
                        flag = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El id es invalido");
                        break;
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
            int idActual = 0;
            foreach (Usuario user in usuario)
            {
                
                if (user.id > idActual) { idActual = user.id; }
            }
            if (esEmpresa)
            {   
               us = new Empresa(idActual + 1, cuit_Cuil, dni, nombre, apellido, mail, password);

            }
            else
            {
              us =  new ClienteFinal(idActual + 1, cuit_Cuil, dni, nombre, apellido, mail, password);
            }

            usuario.Add(us);
           
            return true;
            }


        public bool modificarUsuario(int id, int dni, string nombre, string apellido, string mail, string password, int cuit_Cuil, bool esEmpresa)
        {
            bool flag = false;
            foreach (Usuario us in usuario)
            {
                if (us.id == id)
                {

                    if (cuit_Cuil > 0)
                    {
                        if (esEmpresa == true)
                        {
                            if (us is Empresa)
                            {

                                ((Empresa)us).cuit = cuit_Cuil;

                            }
                            else
                            {
                                Console.WriteLine("El id ingresado no corresponde a una empresa");
                                flag = false;
                                break;
                            }
                        }

                        else
                        {
                            if (us is ClienteFinal)
                            {
                                ((ClienteFinal)us).cuil = cuit_Cuil;
                            }
                            else
                            {
                                Console.WriteLine("El id ingresado no corresponde a un ClienteFinal");
                                flag = false;
                                break;

                            }
                        }
                    }

                    if (dni > 0)
                     {
                      us.dni = dni;
                      }

                    if (!(string.IsNullOrEmpty(nombre)))
                    {
                        us.nombre = nombre;
                    }
                      
                    if (!(string.IsNullOrEmpty(apellido)))
                    {
                        us.apellido = apellido;
                    }
                    if (!(string.IsNullOrEmpty(mail)))
                    {
                        us.mail = mail;
                    }
                    if (!(string.IsNullOrEmpty(password)))
                    {
                        us.password = password;
                    }


                    flag = true;
                }
 
            }
            return flag;
        }


            public bool eliminarUsuario (int id)
            {
            bool flag = false;
            int indice;
            for (var i = 0; i < usuario.Count(); i++)
            {
                if (usuario[i] != null && usuario[i].id == id)
                {
                     indice = usuario.IndexOf(usuario[i]);
                    usuario.RemoveAt(indice);
                    flag = true;
                    break;
                }
                else
                {
                    Console.WriteLine("El id es invalido");
                    break;
                }

            }
            return flag;
        }


            public void mostrarUsuarios () // MUESTRA TODOS LOS USUARIOS ORDENADOS POR DNI
            {
            usuario = usuario.OrderBy(o  =>  o.dni).ToList();
             foreach(Usuario us in usuario)
            {
                if  (us is Empresa)
                {
                    Console.WriteLine(((Empresa)us).toString());
                }
                else
                {
                    Console.WriteLine(((ClienteFinal)us).toString());
                }

            }
        }

            
            public bool agregarCategoria (string nombre)
            {
            int idActual = 0;
            foreach (Categoria cat in categorias)
            {
                if (cat.id > idActual) { idActual = cat.id; }
            }
            try
            {
                this.categorias.Add(new Categoria(idActual + 1, nombre));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un error al intentar dar de alta la categoria, por favor intente nuevamente");
                return false;
            }
        }

            //private int verificarEspacio


            public bool modificarCategoria (int id, string nombre)
            {
            foreach (Categoria cat in categorias)
            {
                if (cat.id == id)
                {
                    if (!(string.IsNullOrEmpty(nombre)))
                    {
                        cat.nombre = nombre;
                    }
                    return true;
                }

            }
            return false;
        }


            public bool eliminarCategoria (int id)
            {
            bool flag = false;
            int indice;
            for (var i = 0; i < categorias.Count(); i++)
            {
                if (categorias[i] != null && categorias[i].id == id)
                {
                    indice = categorias.IndexOf(categorias[i]);
                    categorias.RemoveAt(indice);
                    flag = true;
                    break;
                }
                else
                {
                    Console.WriteLine("El id es invalido");
                    break;
                }

            }
            return flag;
        }


            public void mostrarCategoria() //MAL EN EL ENUNCIADO PERO MOSTRAR TODOS LAS CATEGORIAS ORDENADAS POR ID
            {
            categorias = categorias.OrderBy(o => o.id).ToList();
            foreach (Categoria cat in categorias)
            {
                    Console.WriteLine(cat.toString());

            }
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
