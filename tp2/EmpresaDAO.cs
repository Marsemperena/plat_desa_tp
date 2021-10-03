using System;
using tp1;
using Plataforma_TP2;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

public  class EmpresaDAO
{


	static string fileName = Path.Combine(Environment.GetFolderPath(
	   Environment.SpecialFolder.ApplicationData), "Empresa.json");

	static EmpresaDAO()
	{
	}

	public static List<Empresa> getAll()
    {
		var carro = JsonConvert.DeserializeObject<Mercado>
(File.ReadAllText(fileName));
		Console.Write(carro);

		return null;
    }

	public static void saveAll(List<Empresa> empresa)
    {
		File.WriteAllText(fileName, JsonConvert.SerializeObject(empresa));

	}

}
