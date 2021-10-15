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
        public List<List<string>> compras;

        public Mercado mercado;


        public FAdmin(Usuario usuario)
        {
            mercado = new Mercado();

            // TODO llamarlos desde mercado no desde formulario 
            productos = ProductoDAO.getAll();
            categorias = CategoriaDAO.getAll();
            usuarios = UsuarioDAO.getAll();
            compras = CompraDAO.getAllText();

            InitializeComponent();
            //argumentos = args;   VERIFICAR
            label2.Text = usuario.nombre;
            datos = new List<List<string>>();
            columnas = new List<string>();

        }

        private void refreshData(List<List<string>> objData, List<string> columnas)
        {

            productos = ProductoDAO.getAll();
            categorias = CategoriaDAO.getAll();
            usuarios = UsuarioDAO.getAll();
            compras = CompraDAO.getAllText();

            //borro los 
            tabla.Rows.Clear();
            tabla.Columns.Clear();
            tabla.Refresh();

            //tabla.Columns.Add("editar", "editar");
           // tabla.Columns.Add("borrar", "borrar");
            // agrego las columnas dependiendo de la tabla
            for (var i = 0; i < columnas.Count(); i++)
                tabla.Columns.Add(columnas[i], columnas[i]);




            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "editar";
            col.Name = "editar";
            tabla.Columns.Add(col);

            DataGridViewButtonColumn col2 = new DataGridViewButtonColumn();
            col2.UseColumnTextForButtonValue = true;
            col2.Text = "borrar";
            col2.Name = "borrar";
            tabla.Columns.Add(col2);

            //agrego las filas con los objetos
            foreach (List<string> item in objData)
            {
                tabla.Rows.Add(item.ToArray());

            }

           
        }

        private void tablaDatosRefresh(object sender, EventArgs e)
        {
 

            ComboBox comboBox = (ComboBox)sender;
            datos = new List<List<string>>();
            string tabla1 = (string)tablaDatos.SelectedItem;

            recargarDatosPorTabla(tabla1);

            refreshData(datos, columnas);

        }

        private void recargarDatosPorTabla(string tabla1)
        {
            if (tabla1 == "Tabla_Usuarios")
            {
                columnas.Clear();
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
            if (tabla1 == "Tabla_Productos")
            {
                columnas.Clear();
                columnas.Add("ID");
                columnas.Add("Nombre");
                columnas.Add("Precio");
                columnas.Add("Cantidad");
                columnas.Add("Categoria");
                foreach (Producto prod in productos)
                {
                    datos.Add(new List<string>(new string[] { prod.id.ToString(), prod.nombre.ToString(), prod.precio.ToString(), prod.cantidad.ToString(), prod.cat.id.ToString() }));
                }

            }
            if (tabla1 == "Tabla_Categorias")
            {
                columnas.Clear();
                columnas.Add("ID");
                columnas.Add("Nombre");
                foreach (Categoria cat in categorias)
                {
                    datos.Add(new List<string>(new string[] { cat.id.ToString(), cat.nombre.ToString() }));
                }

            }

            if (tabla1 == "Tabla_Compras")
            {
                columnas.Clear();
                columnas.Add("ID");
                columnas.Add("info");

                foreach(List<string> lista in compras)
                {
                    datos.Add(lista);
                }
            }
        }

        private void agregarObj(object sender, EventArgs e)
        {
            string tabla1 = (string)tablaDatos.SelectedItem;
            Int32 index = tabla.Rows.Count - 2;

            try
            {

                if (tabla1 == "Tabla_Productos")
                {
                    double precioProd = 0;
                    int cantProd = 0;
                    int idCateg = 0;
                    int id;
                   // bool idOK = int.TryParse(tabla.Rows[index].Cells[0].Value.ToString(), out id);
                    bool precioOK = double.TryParse(tabla.Rows[index].Cells[2].Value.ToString(), out precioProd);
                    bool cantOK = int.TryParse(tabla.Rows[index].Cells[3].Value.ToString(), out cantProd);
                    bool idcatgOK = int.TryParse(tabla.Rows[index].Cells[4].Value.ToString(), out idCateg);
                    string nombreProd = tabla.Rows[index].Cells[1].Value.ToString();

                    bool nombreOK = nombreProd != "";

                    if ( precioOK && cantOK && idcatgOK && nombreOK) mercado.agregarProducto(nombreProd, precioProd, cantProd, idCateg);

                }

                if (tabla1 == "Tabla_Usuarios")
                {


                    int dniUser;


                    bool dniOk = int.TryParse(tabla.Rows[index].Cells[1].Value.ToString(), out dniUser);
                    string nombreUser = tabla.Rows[index].Cells[2].Value.ToString();
                    string apellidoUser = tabla.Rows[index].Cells[3].Value.ToString();
                    string mailUser = tabla.Rows[index].Cells[4].Value.ToString();
                    string password = tabla.Rows[index].Cells[5].Value.ToString();
                    string cuit_cuil = tabla.Rows[index].Cells[7].Value.ToString();
                    string tipo = tabla.Rows[index].Cells[6].Value.ToString();

                    mercado.agregarUsuario(dniUser, nombreUser, apellidoUser, mailUser, password, cuit_cuil, tipo);

                }

                if (tabla1 == "Tabla_Categorias")
                {
                    Console.WriteLine(tabla.Rows[index]);
                    Console.WriteLine(tabla.Rows[index].Cells[1].Value.ToString());
                    string nombre = tabla.Rows[index].Cells[1].Value.ToString();

                    mercado.agregarCategoria(nombre);
                }

                recargarDatosPorTabla(tabla1);
                refreshData(datos, columnas);

            }
            catch(Exception ex)
            {

            }

            refreshData(datos,columnas);

        }

        private void suprimirObj(object sender, EventArgs e)
        {

        }

        private void modificarObj(object sender, EventArgs e)
        {

        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            string nombreCat;
            string tabla1 = (string)tablaDatos.SelectedItem;
            try
            {
                if (tabla.Columns[e.ColumnIndex].Name == "editar")
                {
                    if (tabla1 == "Tabla_Productos")
                    {
                        double precioProd = 0;
                        int cantProd = 0;
                        int idCateg = 0;

                        bool idOK = int.TryParse(tabla.Rows[e.RowIndex].Cells[0].Value.ToString(), out id);
                        bool precioOK = double.TryParse(tabla.Rows[e.RowIndex].Cells[2].Value.ToString(), out precioProd);
                        bool cantOK = int.TryParse(tabla.Rows[e.RowIndex].Cells[3].Value.ToString(), out cantProd);
                        bool idcatgOK = int.TryParse(tabla.Rows[e.RowIndex].Cells[4].Value.ToString(), out idCateg);
                        string nombreProd = tabla.Rows[e.RowIndex].Cells[1].Value.ToString();

                        bool nombreOK = nombreProd != "";

                        if (idOK && precioOK && cantOK && idcatgOK && nombreOK) mercado.modificarProducto(id, nombreProd, precioProd, cantProd, idCateg);

                    }


                    if (tabla1 == "Tabla_Categorias")
                    {
                        bool idOK = int.TryParse(tabla.Rows[e.RowIndex].Cells[0].Value.ToString(), out id);
                        nombreCat = tabla.Rows[e.RowIndex].Cells[1].Value.ToString();

                        if (idOK && nombreCat != "") mercado.modificarCategoria(id, nombreCat);
                    }


                    if (tabla1 == "Tabla_Usuarios")
                    {
                        int dniUser;

                        bool idOK = int.TryParse(tabla.Rows[e.RowIndex].Cells[0].Value.ToString(), out id);
                        bool dniOk = int.TryParse(tabla.Rows[e.RowIndex].Cells[1].Value.ToString(), out dniUser);
                        string nombreUser = tabla.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string apellidoUser = tabla.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string mailUser = tabla.Rows[e.RowIndex].Cells[4].Value.ToString();
                        string password = tabla.Rows[e.RowIndex].Cells[5].Value.ToString();
                        string cuit_cuil = tabla.Rows[e.RowIndex].Cells[7].Value.ToString();
                        string tipo = tabla.Rows[e.RowIndex].Cells[6].Value.ToString();

                        

                        int.TryParse(tabla.Rows[e.RowIndex].Cells[0].Value.ToString(), out id);

                        mercado.modificarUsuario(id,dniUser,nombreUser,apellidoUser,mailUser,password,cuit_cuil,tipo);
                    }




                }

                if (tabla.Columns[e.ColumnIndex].Name == "borrar")
                {
                   

                    if (tabla1 == "Tabla_Categorias")
                    {
                        int.TryParse(tabla.Rows[e.RowIndex].Cells[0].Value.ToString(), out id);
                        Console.WriteLine("borrando categoria");
                        mercado.eliminarCategoria(id);
                    }


                    if (tabla1 == "Tabla_Usuarios")
                    {
                        int.TryParse(tabla.Rows[e.RowIndex].Cells[0].Value.ToString(), out id);
                        Console.WriteLine("borrando usuario");
                        mercado.eliminarUsuario(id);
                    }

                    if (tabla1 == "Tabla_Productos")
                    {
                        int.TryParse(tabla.Rows[e.RowIndex].Cells[0].Value.ToString(), out id);
                        Console.WriteLine("borrando producto");
                        mercado.eliminarProducto(id);
                    }

                    if (tabla1 == "Tabla_Compras")
                    {
                        int.TryParse(tabla.Rows[e.RowIndex].Cells[0].Value.ToString(), out id);
                        Console.WriteLine("borrando producto");
                        mercado.eliminarCompra(id);
                    }


                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            refreshData(datos,columnas); 
        }


    }
}

