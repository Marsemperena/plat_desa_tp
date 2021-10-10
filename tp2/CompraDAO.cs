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

			compra = new List<Compra>();
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



	public static List<List<string>> getAllText()
	{
		List<List<string>> compra;
		try
		{
			compra = JsonConvert.DeserializeObject<List<List<string>>>
(File.ReadAllText(fileName));
		}
		catch (Exception ex)
		{
			Console.WriteLine("archivo no encontrado, se inicializa un objeto vacio para compra");

			compra = new List<List<string>>();
		}
		return compra;
	}

	public static void saveAllText(List<Compra> compra)
	{
		List<List<string>> compraText = new List<List<string>>();
		Random rnd = new Random();
		foreach (Compra comp in compra)
        {
			int id = rnd.Next(0, 9999); //generar autoincremental con la base
			List<string> aux = new List<string>();
			aux.Add(id.ToString());
			aux.Add(comp.comprador.toString());
			aux.Add(comp.listaDeProductos());
			compraText.Add(aux);
        }
		try
		{
			File.WriteAllText(fileName, JsonConvert.SerializeObject(compraText));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			throw new Exception("ocurrio un error al guardar los datos");
		}


	}

    internal static void saveAllText1(List<List<string>> compras)
    {
		try
		{
			File.WriteAllText(fileName, JsonConvert.SerializeObject(compras));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			throw new Exception("ocurrio un error al guardar los datos");
		}
	}
}
