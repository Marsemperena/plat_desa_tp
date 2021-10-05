using System;

using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using tp1;
using config;
using System;

namespace dao
{
	public class UsuarioDAO
	{
	
		
		static string fileName = Path.Combine(LocalFileManager.userpath, "Usuario.json");

		static UsuarioDAO()
		{
		}

		public static List<Usuario> getAll()
		{
			
			List<Usuario> usuarios;
			try
			{
				usuarios = JsonConvert.DeserializeObject<List<Usuario>>
	(File.ReadAllText(fileName));
			}
			catch (Exception ex)
			{
				Console.WriteLine("archivo no encontrado, se inicializa un objeto vacio para productos");
				usuarios = new List<Usuario>();
			}


			return usuarios;
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
