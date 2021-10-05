using System;

using Plataforma_TP2;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

using tp1;
using config;

namespace Slc_Mercado
{
	public class CarroDAO
	{


		static string fileName = Path.Combine(LocalFileManager.userpath, "Carro.json");

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
