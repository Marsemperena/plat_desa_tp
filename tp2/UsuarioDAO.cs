using System;
using tp1;
using Plataforma_TP2;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace dao
{
	public class UsuarioDAO
	{


		static string fileName = Path.Combine(Environment.GetFolderPath(
		   Environment.SpecialFolder.ApplicationData), "Usuario.json");

		static UsuarioDAO()
		{
		}

		public static List<Usuario> getAll()
		{
			List<Usuario> productos;
			try
			{
				productos = JsonConvert.DeserializeObject<List<Usuario>>
	(File.ReadAllText(fileName));
			}
			catch (Exception ex)
			{
				Console.WriteLine("archivo no encontrado, se inicializa un objeto vacio para productos");
				productos = new List<Usuario>();
			}


			return productos;
		}

		public static void saveAll(List<Usuario> usuario)
		{
			try
			{
				File.WriteAllText(fileName, JsonConvert.SerializeObject(usuario));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw new Exception("ocurrio un error al guardar los datos");
			}


		}

	}

}
