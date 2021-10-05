using System;

using Slc_Mercado;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using tp1;
using config;


public class CompraDAO
{


	static string fileName = Path.Combine(LocalFileManager.userpath, "Compra.json");

	static CompraDAO()
	{
	}

	public static List<Compra> getAll()
    {
		List<Compra> compra;
        try
        {
			 compra = JsonConvert.DeserializeObject<List<Compra>>
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
