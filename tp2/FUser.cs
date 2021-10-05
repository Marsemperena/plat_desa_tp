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

namespace Slc_Mercado
{
    public partial class FUser : Form
    {
        public string[] argumentos;
        List<List<string>> datos;
        public List<Producto> productos;
        Mercado mercado;
        Usuario usuario;

        public FUser(Usuario usuario)
        {

            productos = ProductoDAO.getAll();
            InitializeComponent();
            //argumentos = args;   VERIFICAR
            label2.Text = usuario.nombre;
            datos = new List<List<string>>();
            //List<string> producto1 = new List<string>(new string[] { "TV", "50000", "200" });
            //List<string> producto2 = new List<string>(new string[] { "PC", "75000", "150" });
            //datos.Add(producto1);
            // datos.Add(producto2);

            cargarProductos();
            refreshData(datos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mercado.comprar(usuario.id);
        }


        private void refreshData(List<List<string>> data)
        {
            //borro los datos
            dataGridView1.Rows.Clear();
            //agrego lo nuevo
            foreach (List<string> producto in data)
                dataGridView1.Rows.Add(producto.ToArray());

        }

        private void cargarProductos()
        {
            foreach (Producto prod in productos)
            {
                datos.Add(new List<string>(new string[] { prod.nombre.ToString(), prod.precio.ToString(), prod.cantidad.ToString() }));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mercado.vaciarCarro(usuario.id);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mercado.agregarAlCarro(mercado.buscarProductoPorNombre(dataGridViewTextBoxColumn1.DataGridView.Rows.ToString()).id, dataGridViewTextBoxColumn3.DataGridView.FirstDisplayedScrollingRowIndex ,usuario.id);
        }
    }
}
