using System;

using System.IO;

namespace Slc_Mercado
{
    public class Functions1
    {
     
        public Functions1()
        {
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("--------------------------------------");
            string text = System.IO.File.ReadAllText(@"C:\Users\r4ndl\OneDrive\Documentos\Adobe\abc.txt");
            Console.WriteLine(text);

            Console.WriteLine("--------------------------------------");
            var fileName = Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.ApplicationData), "test.txt");

            Console.WriteLine(fileName);

            Console.WriteLine("--------------------------------------");
        }

    }
}