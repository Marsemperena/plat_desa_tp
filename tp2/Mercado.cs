using Slc_Mercado;
using System;
using System.Collections.Generic;
using System.Linq;
using Slc_Mercado;



namespace tp1
{
    public class Mercado
    {

       public const int MAX_CATEGORIAS  = 5;
       public int cantCategorias { get; set; }

       public List<Categoria> categorias= new List<Categoria>();

       public List<Producto> productos = new List<Producto>();

       public List<Usuario> usuarios = new List<Usuario>();     

       public List<Compra> compras ;

            public Mercado()
            {
                this.categorias = new List<Categoria>();
                this.usuarios = new List<Usuario>();
                this.compras = new List<Compra>();

                this.categorias.Add(new Categoria(2, "categ 0"));
                this.categorias.Add(new Categoria(3, "categ 1"));
                this.categorias.Add(new Categoria(5, "categ 2"));

                this.usuarios.Add(new Usuario(1,0, "Empresa 1", "test 0",  "mail@mail.com", "test 00", "Empresa", "20356489567"));//Empresa
                this.usuarios.Add(new Usuario(2, 30654951, "Cliente Final 1", "test 1",  "mail@gmail.com", "test 00", "Cliente Final","25320660785"));//Cliente Final

                this.productos.Add(new Producto(1,"producto 1", 1500, 10, this.categorias[0]));
                this.productos.Add(new Producto(2,"producto 2", 1, 10, this.categorias[1]));
                this.productos.Add(new Producto(4,"producto 2", 561, 10, this.categorias[1]));

            }
            
            public bool agregarProducto (string nombre, double precio, int cantidad, int id_Categoria)
            {
                int idActual = 0;
                foreach (Producto prod in productos)
                {
                    if (prod.id > idActual) { idActual = prod.id; }
                }
                try
                {
                    this.productos.Add(new Producto(idActual +1,nombre, precio, cantidad, this.categorias[id_Categoria]));
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
            foreach (Producto prod in productos)
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
                    for (var i = 0; i<productos.Count(); i++)
                    {
                        if (productos[i] != null && productos[i].id == id)
                        {
                             indice = productos.IndexOf(productos[i]);
                            productos.RemoveAt(indice);
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
                foreach(Producto pr in productos)
                {
                    if (pr.nombre.Contains(query))
                    {
                    Console.WriteLine(pr.toString());
                    }
                }
            }


            public void buscarProductosPorPrecio (string query) //ORDENADO POR PRECIO DE MENOR A MAYOR LOS PRODUCTOS QUE CONTIENEN EN SU NOMBRE LA CADENA INGRESADA
            {
                IEnumerable<Producto> aux = productos.OrderBy(pr => pr.precio);
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
                foreach (Producto pr in productos)
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

            
            public bool agregarUsuario (int dni, string nombre, string apellido, string mail, string password, string cuit_Cuil, string tipo)
            {
                //calcular id
                //(int id, int cuit, int dni, string nombre, string mail, string password)
                //int id, int cuit, int dni, string nombre, string mail, string password
                Usuario us;
                int idActual = 0;
                int erroresDeIngreso = verificarIngresoUsuario(idActual, dni, nombre, apellido, mail, password, cuit_Cuil, tipo);
                foreach (Usuario user in usuarios)
                {
                
                    if (user.id > idActual) { idActual = user.id; }
                }
                if (erroresDeIngreso > 0)
                {
                Console.WriteLine("usted tiene " + erroresDeIngreso + " errores que solucionar antes de poder crear su usuario");
                }

            us = new Usuario(idActual + 1, dni, nombre, apellido, mail, password, cuit_Cuil, tipo);
            usuarios.Add(us);

            return true;
            }


        public bool modificarUsuario(int id, int dni, string nombre, string apellido, string mail, string password, string cuit_Cuil, string tipo)
        {
            int contieneErrores = verificarIngresoUsuario(id, dni, nombre, apellido, mail, password, cuit_Cuil, tipo);
            if (contieneErrores > 0)
            {
                //UPDATE
                Console.WriteLine("usted tiene "+ contieneErrores + " errores que solucionar antes de poder modificar el usuario");
                return false;
            }
            return true;
        }

        private int verificarIngresoUsuario(int id, int dni, string nombre, string apellido, string mail, string password, string cuit_Cuil, string tipo)
        {
            int contadorErrores = 0;
            foreach (Usuario us in usuarios)
            {
                if (us.id == id)
                {
                    if (cuit_Cuil.Length == 11)
                    {
                        us.cuilCuit = cuit_Cuil;
                    }
                    else
                    {
                        Console.WriteLine("El Cuit/Cuil ingresado no es correcto, recuerde que debe tener 11 digitos");
                        contadorErrores += 1;
                    }

                    if (Math.Log10(dni) + 1 == 8)
                    {
                        us.dni = dni;
                    }
                    else
                    {
                        Console.WriteLine("El Dni ingresado no es correcto, recuerde que debe tener 8 digitos");
                        contadorErrores += 1;
                    }

                    if (!(string.IsNullOrEmpty(nombre)))
                    {
                        us.nombre = nombre;
                    }
                    else
                    {
                        Console.WriteLine("El Nombre ingresado no puede estar vacio");
                        contadorErrores += 1;
                    }

                    if (!(string.IsNullOrEmpty(apellido)))
                    {
                        us.apellido = apellido;
                    }
                    else
                    {
                        Console.WriteLine("El Apellido ingresado no puede estar vacio");
                        contadorErrores += 1;
                        break;
                    }

                    if (!(string.IsNullOrEmpty(mail)))
                    {
                        us.mail = mail;
                    }
                    else
                    {
                        Console.WriteLine("El Mail ingresado no es correcto");
                        contadorErrores += 1;
                    }

                    if (!(string.IsNullOrEmpty(password)) && password.Length > 6)
                    {
                        us.password = password;
                    }
                    else
                    {
                        Console.WriteLine("El Password ingresado no es correcto, recuerde que debe tener 6 digitos");
                        contadorErrores += 1;
                    }
                }
            }
            return contadorErrores;
        }

            public bool eliminarUsuario (int id)
            {
                bool flag = false;
                int indice;
                for (var i = 0; i < usuarios.Count(); i++)
                {
                    if (usuarios[i] != null && usuarios[i].id == id)
                    {
                         indice = usuarios.IndexOf(usuarios[i]);
                        usuarios.RemoveAt(indice);
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

            public List<Usuario> mostrarUsuarios () // MUESTRA TODOS LOS USUARIOS ORDENADOS POR DNI
            {
                usuarios = usuarios.OrderBy(o  =>  o.dni).ToList();
                return usuarios;     
            /*foreach(Usuario us in usuario)
                {
                    Console.WriteLine(us.toString());
                }*/
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


            public List<Categoria> mostrarCategorias() //MAL EN EL ENUNCIADO PERO MOSTRAR TODOS LAS CATEGORIAS ORDENADAS POR ID
            {
            categorias = categorias.OrderBy(o => o.id).ToList();
            return categorias;
            /*foreach (Categoria cat in categorias)
            {
                    Console.WriteLine(cat.toString());

            }*/
        }


        /* ESTOS SON OPCIONALES EN LA PRIMER ENTREGA
         
            public bool AgregarAlCarro (int id_Producto, int cantidad, int id_Usuario){}
            
            public bool QuitarDelCarro (int id_Producto, int Cantidad, int id_Usuario){}

            public bool VaciarCarro (int id_Usuario){}

            public bool Comprar(int id_Usuario){}

            public bool ModificarCompra ( int id, double total){}

            public bool EliminarCompra (int id){}

        */
            public List<Producto> mostrarTodosProductos()
        {
            productos.Sort((a, b) => a.id.CompareTo(b.id));
            return productos;
            /*foreach (Producto pr in producto)
            {
                Console.WriteLine(pr.toString());

            }*/

        }

            public void mostrarTodosProductosPorPrecio() //MUESTRA TODOS LOS PRODUCTOS DEL MERCADO, ORDENADO POR PRECIO
            {


            IEnumerable<Producto> aux = productos.OrderBy(pr => pr.precio);
            foreach (Producto pr in aux)
            {
                Console.WriteLine(pr.toString());
            }

        }


            public void mostrarTodosProductosPorCategoria() //MUESTRA TODAS LAS CATEGORIAS DEL MERCADO Y PARA CADA UNA DE ELLAS, LOS PRODUCTOS DENTRO DE LA MISMA.
            {
            IEnumerable<Producto> aux = productos.OrderBy(pr => pr.cat.id);
            foreach (Producto pr in aux)
            {
                Console.WriteLine(pr.toString());
            }
        }


    }
}
