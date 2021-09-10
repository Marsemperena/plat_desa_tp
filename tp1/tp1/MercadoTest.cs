using System;

namespace tp1
{
    public class MercadoTest
    {
        public MercadoTest()
        {
            
            
            bool continuar = true;

            Console.WriteLine("mensaje inicial");


            string opciones = @"1. Alta de categoría
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
                switch (inputUsuario)
                {
                    case "1":
                        Console.WriteLine("Alta de categoría");
                        break;
                    case "2":
                        Console.WriteLine("Baja de categoría");
                        break;
                    case "3":
                        Console.WriteLine("Modificación de categoría");
                        break;
                    case "4":
                        Console.WriteLine("Mostrar categorías que existen en el sistema");
                        break;
                    case "5":
                        Console.WriteLine("Alta de usuario");
                        break;
                    case "6":
                        Console.WriteLine("Baja de usuario");
                        break;
                    case "7":
                        Console.WriteLine("Modificación de usuario");
                        break;
                    case "8":
                        Console.WriteLine("Mostrar usuarios que existen en el sistema");
                        break;
                    case "9":
                        Console.WriteLine("Alta de producto");
                        break;
                    case "10":
                        Console.WriteLine("Baja de producto");
                        break;
                    case "11":
                        Console.WriteLine("Modificación de producto");
                        break;
                    case "12":
                        Console.WriteLine("Mostrar productos que existen en el sistema");
                        break;
                    case "13":
                        Console.WriteLine("Mostrar productos que existen en el sistema ordenados por precio");
                        break;
                    case "14":
                        Console.WriteLine("Mostrar productos que existen en el sistema ordenados por categoría");
                        break;
                    case "15":
                        Console.WriteLine("salir");
                        continuar = false;
                        break;
                    case "":
                        Console.WriteLine("Por favor seleccione una opcion");
                        break;

                    default:
                        Console.WriteLine("opcion no valida");
                        break;
                }
            }
        }




    }

}

