using System;


using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using tp1;
using config;

namespace Slc_Mercado
{
	public class ProductoDAO
	{


		static string fileName = Path.Combine(LocalFileManager.userpath, "Producto.json");

		static ProductoDAO()
		{
		}

		public static List<Producto> getAll()
		{
			List<Producto> productos;
			try
			{
				productos = JsonConvert.DeserializeObject<List<Producto>>
	(File.ReadAllText(fileName));
			}
			catch (Exception ex)
			{
				Console.WriteLine("archivo no encontrado, se inicializa un objeto vacio para productos");
				productos = new List<Producto>();
				Categoria cat = new Categoria(0, "electro");
				Categoria cat2 = new Categoria(1, "deco");
				productos.Add(new Producto(0, "tv", 10, 10, cat));
				productos.Add(new Producto(0, "silla", 15, 30, cat2));
			}


			return productos;
		}

		public static void saveAll(List<Producto> producto)
		{
			try
			{
				File.WriteAllText(fileName, JsonConvert.SerializeObject(producto));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw new Exception("ocurrio un error al guardar los datos");
			}


		}

	}

}
