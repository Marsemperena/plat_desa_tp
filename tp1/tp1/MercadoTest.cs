using System;

namespace tp1
{
    public class MercadoTest
    {
        Mercado mercado;
        public MercadoTest()
        {

            //listas iniciales 
            mercado = new Mercado();
        }

        public void iniciar()
        {
            bool continuar = true;

            Console.WriteLine("mensaje inicial");

            string opcionesPrincipales = @"
                                1.Administrar
                                2.Comprar";


            string opcionesAdministrar = @"
                                1.Alta de categoría
                                2.Baja de categoría
                                3.Modificación de categoría
                                4.Mostrar categorías que existen en el sistema
                                5.Alta de usuario
                                6.Baja de usuario
                                7.Modificación de usuario
                                8.Mostrar usuarios que existen en el sistema
                                9.Alta de producto
                                10.Baja de producto
                                11.Modificación de producto
                                12.Mostrar productos que existen en el sistema
                                13.Mostrar productos que existen en el sistema ordenados por precio
                                14.Mostrar productos que existen en el sistema ordenados por categoría
                                15.Salir";

            while (continuar)
            {
                Console.WriteLine(opcionesPrincipales);

                Console.WriteLine("Ingrese su opcion:");

                string inputInicial = Console.ReadLine();

                
                    if (inputInicial == "1")
                    {
                        Console.WriteLine(opcionesAdministrar);
                        Console.WriteLine("Ingrese su opcion");
                        string inputUsuario = Console.ReadLine();
                        int id;
                        string nombre = "";
                        string nombreProducto;
                        double precio;
                        int cantidad;
                        int id_categ;
                        int dni = 0;
                        string apellido = "";
                        string mail = "";
                        string password = "";
                        string cuit_Cuil = "0";
                        string tipo = "";
                        string boolaux = "";

                        switch (inputUsuario)
                        {
                            case "1": //Agregar Categorias
                                Console.WriteLine("Ingrese el nombre de la categoría");
                                inputUsuario = Console.ReadLine();
                                comprobarFlag(mercado.agregarCategoria(inputUsuario));
                                break;
                            case "2": //Eliminar Categorias
                                Console.WriteLine("Ingrese el ID de la categoría a eliminar");
                                id = Convert.ToInt32(Console.ReadLine());
                                comprobarFlag(mercado.eliminarCategoria(id));
                                break;
                            case "3": //Modificar Categorias
                                Console.WriteLine("Ingrese el ID de la categoría a editar");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el nombre nuevo");
                                nombre = Console.ReadLine();
                                comprobarFlag(mercado.modificarCategoria(id, nombre));
                                break;
                            case "4": //Mostrar Categorias
                                Console.WriteLine("Las categorías son: ");
                                mercado.mostrarCategoria();
                                break;
                            case "5": //Agregar Usuarios
                                Console.WriteLine("Alta de usuario - Ingrese el dni");
                                dni = int.Parse(Console.ReadLine());
                                Console.WriteLine("Alta de usuario - Ingrese el nombre");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Alta de usuario - Ingrese el apellido");
                                apellido = Console.ReadLine();
                                Console.WriteLine("Alta de usuario - Ingrese el mail");
                                mail = Console.ReadLine();
                                Console.WriteLine("Alta de usuario - Ingrese el password");
                                password = Console.ReadLine();
                                Console.WriteLine("Alta de usuario - Ingrese el cuit/cuil ");
                                cuit_Cuil = Console.ReadLine();
                                Console.WriteLine("Alta de usuario - Ingrese: que tipo de usuario va a ser (Empresa o Cliente Final)");
                                tipo = Console.ReadLine();
                                comprobarFlag(mercado.agregarUsuario(dni, nombre, apellido, mail, password, cuit_Cuil, tipo));
                                break;
                            case "6": //Eliminar Usuarios
                                Console.WriteLine("Baja de usuario - Ingrese el ID del usuario a eliminar");
                                id = Convert.ToInt32(Console.ReadLine());
                                comprobarFlag(mercado.eliminarUsuario(id));
                                break;
                            case "7": //Modificar Usuarios
                                Console.WriteLine("Modificación de usuario - Ingrese el ID del usuario a modificar");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Modificación de usuario - Ingrese el dni para mantener actual ingrese -1");
                                dni = int.Parse(Console.ReadLine());
                                Console.WriteLine("Modificación de usuario - Ingrese el nombre");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Modificación de usuario - Ingrese el apellido");
                                apellido = Console.ReadLine();
                                Console.WriteLine("Modificación de usuario - Ingrese el mail");
                                mail = Console.ReadLine();
                                Console.WriteLine("Modificación de usuario - Ingrese el password");
                                password = Console.ReadLine();
                                Console.WriteLine("Modificación de usuario - Ingrese el cuit/cuil para mantener actual ingrese -1");
                                cuit_Cuil = Console.ReadLine();
                                Console.WriteLine("Alta de usuario - Ingrese: que tipo de usuario va a ser (Empresa o Cliente Final)");
                                tipo = Console.ReadLine();
                            
                                comprobarFlag(mercado.modificarUsuario(id, dni, nombre, apellido, mail, password, cuit_Cuil, tipo));
                                break;
                            case "8": //Mostrar Usuarios
                                Console.WriteLine("Los usuarios existentes son:");
                                mercado.mostrarUsuarios();
                                break;
                            case "9": //Agregar Productos
                                Console.WriteLine("Alta de producto - Ingrese el nombre");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Alta de producto - Ingrese el precio");
                                precio = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Alta de producto - Ingrese la cantidad");
                                cantidad = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Alta de producto - Ingrese el ID de la categoría");
                                id_categ = Convert.ToInt32(Console.ReadLine());
                                comprobarFlag(mercado.agregarProducto(nombre, precio, cantidad, id_categ));
                                break;
                            case "10": //Eliminar Productos
                                Console.WriteLine("Baja de producto - Ingrese el ID del producto a eliminar");
                                id = Convert.ToInt32(Console.ReadLine());
                                comprobarFlag(mercado.eliminarProducto(id));
                                break;
                            case "11": //Modificar Productos
                                Console.WriteLine("Modificación de producto - Ingrese el ID del producto a modificar");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Modificación de producto - Ingrese el nombre del producto");
                                nombreProducto = Console.ReadLine();
                                Console.WriteLine("Modificación de producto - Ingrese el precio para mantener actual ingrese -1");
                                precio = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Modificación de producto - Ingrese la cantidad para mantener actual ingrese -1");
                                cantidad = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Modificación de producto - Ingrese el ID de la categoría para mantener actual ingrese -1");
                                id_categ = Convert.ToInt32(Console.ReadLine());
                                comprobarFlag(mercado.modificarProducto(id, nombreProducto, precio, cantidad, id_categ));
                                break;
                            case "12": //Mostrar Productos
                                Console.WriteLine("Los productos son:");
                                mercado.mostrarTodosProductos();
                                break;
                            case "13": //Mostrar Productos x precio
                                Console.WriteLine("Productos ordenados por precio");
                                mercado.mostrarTodosProductosPorPrecio();
                                break;
                            case "14": //Mostrar Productos x categoria
                                Console.WriteLine("Productos ordenados por categoría");
                                mercado.mostrarTodosProductosPorCategoria();
                                break;
                            case "15": //Salir del sistema
                                Console.WriteLine("salir");
                                continuar = false;
                                break;
                            case "":
                                Console.WriteLine("Por favor seleccione una opcion");
                                break;

                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }

                    } else
                    {
                    Console.WriteLine("Bajo construcción, próximamente en TP2!");

                }
                }

             }

        public void comprobarFlag(bool flag)
        {
            if (flag == true)
            {
                Console.WriteLine("La operación se completó con éxito!");
            }
            else
            {
                Console.WriteLine("Ups! Un error inesperado");
            }
        }

         

       }

    }

