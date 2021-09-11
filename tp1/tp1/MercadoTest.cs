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


            string opciones = @"1.Alta de categoría
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
                Console.WriteLine(opciones);

                Console.WriteLine("ingrese su opcion");
                string inputUsuario = Console.ReadLine();
                string nombre = "";
                switch (inputUsuario)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre de la categoría");
                        inputUsuario = Console.ReadLine();
                        mercado.agregarCategoria(inputUsuario);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el ID de la categoría a eliminar");
                        inputUsuario = Console.ReadLine();
                        mercado.eliminarCategoria(Int32.Parse(inputUsuario));
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el ID de la categoría a editar y el NOMBRE nuevo");
                        inputUsuario = Console.ReadLine();
                        nombre = Console.ReadLine();
                        mercado.modificarCategoria(Int32.Parse(inputUsuario), nombre);
                        break;
                    case "4":
                        Console.WriteLine("Las categorías son: ");
                        mercado.mostrarCategoria();
                        break;
                    case "5":
                        Console.WriteLine("Alta de usuario - Ingrese: dni, nombre, apellido, mail, password, cuit/cuil y si es empresa o no");
                       // mercado.agregarUsuario(dni, nombre, apellido, mail, password, cuit_Cuil, cuild, esEmpresa);
                        break;
                    case "6":
                        Console.WriteLine("Baja de usuario - Ingrese el ID del usuario a eliminar");
                        break;
                    case "7":
                        Console.WriteLine("Modificación de usuario - Ingrese el ID del usuario a modificar, seguido de los siguientes datos: dni, nombre, apellido, mail, password, cuit/cuil, si es empresa o no");
                        break;
                    case "8":
                        Console.WriteLine("Mostrar usuarios que existen en el sistema");
                        break;
                    case "9":
                        Console.WriteLine("Alta de producto - Ingrese: nombre, precio, cantidad, id de categoría");

                        break;
                    case "10":
                        Console.WriteLine("Baja de producto - Ingrese el ID del producto a eliminar");
                        break;
                    case "11":
                        Console.WriteLine("Modificación de producto - Ingrese el ID del producto a modificar, seguido de: nombre, precio, cantidad, id de la categoría");
                        break;
                    case "12":
                        Console.WriteLine("Los productos son:");
                        break;
                    case "13":
                        Console.WriteLine("Productos ordenados por precio");
                        mercado.mostrarTodosProductosPorPrecio();
                        break;
                    case "14":
                        Console.WriteLine("Productos ordenados por categoría");
                        mercado.mostrarTodosProductosPorCategoria();
                        break;
                    case "15":
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
                }

             }

         

       }

    }

