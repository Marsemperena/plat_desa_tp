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
        List<string> columnas;

        public List<Producto> productos;
        public List<Categoria> categorias;
        public List<Usuario> usuarios;


        public FAdmin(Usuario usuario)
        {
            productos = ProductoDAO.getAll();
            categorias = CategoriaDAO.getAll();
            usuarios = UsuarioDAO.getAll();

            InitializeComponent();
            //argumentos = args;   VERIFICAR
            label2.Text = usuario.nombre;
            datos = new List<List<string>>();
            columnas = new List<string>();

        }

        private void refreshData(List<List<string>> objData, List<string> columnas)
        {

            //borro los datos
            tabla.Rows.Clear();

            // agrego las columnas dependiendo de la tabla
            for (var i = 0; i < columnas.Count(); i++)
                tabla.Columns.Add(columnas[i], columnas[i]);

            //agrego las filas con los objetos
            foreach (List<string> item in objData)
                tabla.Rows.Add(item.ToArray());

        }

        private void tablaDatosRefresh(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string tabla = (string)tablaDatos.SelectedItem;

            if (tabla == "Tabla_Usuarios")
            {
                columnas.Add("ID");
                columnas.Add("DNI");
                columnas.Add("Nombre");
                columnas.Add("Apellido");
                columnas.Add("Mail");
                columnas.Add("Password");
                columnas.Add("Tipo");
                columnas.Add("Cuil-Cuit");
                foreach (Usuario user in usuarios)
                {
                    datos.Add(new List<string>(new string[] { user.id.ToString(), user.dni.ToString(), user.nombre.ToString(), user.apellido.ToString(), user.mail.ToString(), user.password.ToString(), user.tipo.ToString(), user.cuilCuit.ToString(), }));
                }

            }
            if (tabla == "Tabla_Productos")
            {
                columnas.Add("ID");
                columnas.Add("Nombre");
                columnas.Add("Precio");
                columnas.Add("Cantidad");
                foreach (Producto prod in productos)
                {
                    datos.Add(new List<string>(new string[] { prod.nombre.ToString(), prod.precio.ToString(), prod.cantidad.ToString() }));
                }

            }
            if (tabla == "Tabla_Categorias")
            {
                columnas.Add("ID");
                columnas.Add("Nombre");
                foreach (Categoria cat in categorias)
                {
                    datos.Add(new List<string>(new string[] { cat.id.ToString(), cat.nombre.ToString() }));
                }

            }

            refreshData(datos, columnas);

        }

        private void agregarObj(object sender, EventArgs e)
        {

        }

        private void suprimirObj(object sender, EventArgs e)
        {

        }

        private void modificarObj(object sender, EventArgs e)
        {

        }
    }
}

