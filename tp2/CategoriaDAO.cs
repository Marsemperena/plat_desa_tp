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

		public static Categoria[] getAll()
		{
			Categoria[] categorias;
			try
			{
				categorias = JsonConvert.DeserializeObject<Categoria[]>
   (File.ReadAllText(fileName));
			}
			catch (Exception ex)
			{
				Console.WriteLine("archivo no encontrado, se inicializa array vacio para categoria");
				int MAX_CATEGORIAS = 5;
				categorias = new Categoria[MAX_CATEGORIAS];
			}


			return categorias;
		}

		public static void saveAll(Categoria[] categoria)
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
