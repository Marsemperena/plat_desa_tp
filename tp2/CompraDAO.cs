using System;
using tp1;
using Plataforma_TP2;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

public  class CompraDAO
{


	static string fileName = Path.Combine(Environment.GetFolderPath(
	   Environment.SpecialFolder.ApplicationData), "Compra.json");

	static CompraDAO()
	{
	}

	public static Compra getAll()
    {
		Compra compra;
        try
        {
			 compra = JsonConvert.DeserializeObject<Compra>
(File.ReadAllText(fileName));
		}
		catch(Exception ex)
        {
			Console.WriteLine("archivo no encontrado, se inicializa un objeto vacio para compra");

			compra = null;
        }
		return compra;
    }

	public static void saveAll(List<Compra> compra)
    {
        try
        {
			File.WriteAllText(fileName, JsonConvert.SerializeObject(compra));
		}
		catch(Exception ex)
        {
			Console.WriteLine(ex.Message);
			throw new Exception("ocurrio un error al guardar los datos");
        }
		

	}

}
