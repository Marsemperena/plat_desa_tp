using System;

using Plataforma_TP2;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using tp1;

namespace Slc_Mercado
{
	public class CategoriaDAO
	{


		static string fileName = Path.Combine(Environment.GetFolderPath(
		   Environment.SpecialFolder.ApplicationData), "Categoria.json");

		static CategoriaDAO()
		{
		}

		public static List<Categoria> getAll()
		{
			List<Categoria> categorias;
			try
			{
				categorias = JsonConvert.DeserializeObject<List<Categoria>>
   (File.ReadAllText(fileName));
			}
			catch (Exception ex)
			{
				Console.WriteLine("archivo no encontrado, se inicializa array vacio para categoria");
		
				categorias = new List<Categoria>();
			}


			return categorias;
		}

		public static void saveAll(List<Categoria> categoria)
		{
			try
			{
				File.WriteAllText(fileName, JsonConvert.SerializeObject(categoria));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw new Exception("ocurrio un error al guardar los datos");
			}


		}

	}

}
