using System;
using tp1;
using Plataforma_TP2;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace dao
{
	public class CarroDAO
	{


		static string fileName = Path.Combine(Environment.GetFolderPath(
		   Environment.SpecialFolder.ApplicationData), "Carro.json");

		static CarroDAO()
		{
		}

		public static List<Carro> getAll()
		{
			var carro = JsonConvert.DeserializeObject<Mercado>
	(File.ReadAllText(fileName));
			Console.Write(carro);

			return null;
		}

		public static void saveAll(List<Carro> carro)
		{
			File.WriteAllText(fileName, JsonConvert.SerializeObject(carro));

		}

	}

}
