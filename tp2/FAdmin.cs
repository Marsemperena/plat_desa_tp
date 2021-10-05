using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp1;
using dao;

namespace Slc_Mercado
{
    public partial class FAdmin : Form
    {
        public string[] argumentos;
        List<List<string>> datos;

        public List<Producto> productos;
        public List<Categoria> categorias;
        public List<Usuario> usuarios;


        public FAdmin(string[] args)
        {
            productos = ProductoDAO.getAll();
            categorias = CategoriaDAO.getAll();
            usuarios = UsuarioDAO.getAll();

            InitializeComponent();
            argumentos = args;
            label2.Text = args[0];
            datos = new List<List<string>>();
            //List<string> producto1 = new List<string>(new string[] { "TV", "50000", "200" });
            //List<string> producto2 = new List<string>(new string[] { "PC", "75000", "150" });
            //datos.Add(producto1);
            // datos.Add(producto2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData(datos);
        }

        private void refreshData(List<List<string>> data)
        {
            //borro los datos
            tabla.Rows.Clear();
            //agrego lo nuevo
            foreach (List<string> item in data)
                tabla.Rows.Add(item.ToArray());

        }

        private void tablaDatosRefresh(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string tabla = (string)tablaDatos.SelectedItem;

            if (tabla == "Tabla_Usuarios")
            {
                foreach (Usuario user in usuarios)
                {
                    datos.Add(new List<string>(new string[] { user.id.ToString(), user.dni.ToString(), user.nombre.ToString(), user.apellido.ToString(), user.mail.ToString(), user.password.ToString(), user.tipo.ToString(), user.cuilCuit.ToString(), }));
                }

            }
            if (tabla == "Tabla_Productos")
            {
                foreach (Producto prod in productos)
                {
                    datos.Add(new List<string>(new string[] { prod.nombre.ToString(), prod.precio.ToString(), prod.cantidad.ToString() }));
                }

            }
            if (tabla == "Tabla_Categorias")
            {
                foreach (Categoria cat in categorias)
                {
                    datos.Add(new List<string>(new string[] { cat.id.ToString(), cat.nombre.ToString() }));
                }

            }

            refreshData(datos);

        }

    }
}
}
