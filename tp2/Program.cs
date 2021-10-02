using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

using tp1;
using Newtonsoft.Json;

namespace Plataforma_TP2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var arlist1 = new ArrayList();

            arlist1.Add("Bill");
            arlist1.Add("asdasd");
            arlist1.Add("Bilasdasdasdl");
            arlist1.Add("asdasd");
            arlist1.Add("asd");
            arlist1.Add("Biasdasdll");
            arlist1.Add("dasd");





            LocalFileManager.SerializeObject2(arlist1, @"C:\Users\r4ndl\AppData\Roaming\test.txt");


            var tes1 = LocalFileManager.DeSerializeObject<ArrayList>(@"C:\Users\r4ndl\AppData\Roaming\test.txt");


            // Read the file contents back into a variable.
            // ArrayList object1 = Class1.ReadFromBinaryFile<ArrayList>(@"C:\someClass.txt");

            Mercado m = new Mercado();

            m = m;

            //LocalFileManager.SerializeObject2<Mercado>(m, @"C:\Users\r4ndl\AppData\Roaming\mercado.txt");

            List<Empresa> usuario = new List<Empresa>();
            usuario.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            usuario.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            usuario.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            usuario.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            usuario.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            usuario.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            LocalFileManager.SerializeObject2<IEnumerable<Empresa>>(usuario, @"C:\Users\r4ndl\AppData\Roaming\mercado.txt");


            ArrayList usuariosAL = new ArrayList();

            usuariosAL.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            usuariosAL.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            usuariosAL.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            usuariosAL.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            usuariosAL.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));
            usuariosAL.Add(new Empresa(1, 0, 234123, "test 0", "test 00", "mail@mail.com", "pass"));


            //string asdasdasdasdas = LocalFileManager.SerializeArrayList(usuariosAL);

            //asdasdasdasdas = asdasdasdasdas;

            Dictionary<string, string> openWith =
    new Dictionary<string, string>();

            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");



            File.WriteAllText(@"C:\Users\r4ndl\AppData\Roaming\mercado.txt", JsonConvert.SerializeObject(m));


            var dictionary = JsonConvert.DeserializeObject<Mercado>
    (File.ReadAllText(@"C:\Users\r4ndl\AppData\Roaming\mercado.txt"));

            ///

            Categoria[] categorias;






           categorias = new Categoria[5];
            //  this.usuario = new List<Usuario>();
           

            categorias[0] = new Categoria(2, "categ 0");
            categorias[1] = new Categoria(1, "categ 1");
           categorias[2] = new Categoria(4, "categ 3");


           CategoriaDAO.saveAll(categorias);


            var lala = CategoriaDAO.getAll();

            Categoria[] c = lala;
            ////

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FPrincipal());
        }
    }
}
