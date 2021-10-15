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
            mercado = new Mercado();
            InitializeComponent();
            //argumentos = args;   VERIFICAR
            label2.Text = usuario.nombre;
            datos = new List<List<string>>();

            cargarProductos();
            refreshData(datos);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idUsuario = 0;

            string message = mercado.mostrarCarro(idUsuario);
            string caption = "Desea confirmar la compra?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    //mercado.comprar(usuario.id);

                    if (mercado.comprar(0))
                    {
                        MessageBox.Show("Compra realizada con exito!");
                        mercado.vaciarCarro(idUsuario);
                        textBox1.Text = mercado.calcularCompra(idUsuario).ToString();
                        button1.Text = "Ver carrito";
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al realizar la compra");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al intentar realizar la compra");
                }
            }

           
         
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
                datos.Add(new List<string>(new string[] { prod.id.ToString(), prod.nombre.ToString(), prod.precio.ToString(), prod.cantidad.ToString() }));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string nombreProd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string idProd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //buscar id de producto
                dataGridView2.Rows[0].Cells[1].Value = nombreProd;

                dataGridView2.Rows[0].Cells[0].Value = idProd;

                dataGridView2.Rows[0].Cells[2].Value = 1;
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Carrito vaciado con exito");
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idUsuario = 0;
            //usuario.id = 0; //sacar esto
            //mercado.vaciarCarro(usuario.id);
            mercado.vaciarCarro(0);
            textBox1.Text = mercado.calcularCompra(idUsuario).ToString();
            MessageBox.Show("Carrito vaciado con exito");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id_producto;

                int idUsuario = 0; // aca deberia ir el usuario
                int cantidadProd;

                int.TryParse(dataGridView2.Rows[0].Cells[0].Value.ToString(), out id_producto);
                string test = dataGridView2.Rows[0].Cells[1].Value.ToString();
                int.TryParse(dataGridView2.Rows[0].Cells[2].Value.ToString(), out cantidadProd);

                //mercado.agregarAlCarro(mercado.buscarProductoPorNombre(dataGridViewTextBoxColumn1.DataGridView.Rows.ToString()).id, dataGridViewTextBoxColumn3.DataGridView.FirstDisplayedScrollingRowIndex ,usuario.id);
                mercado.agregarAlCarro(id_producto, cantidadProd, idUsuario);

                textBox1.Text = mercado.calcularCompra(idUsuario).ToString();
                button1.Text = "Ver carrito (" + mercado.cantidadArticulos(idUsuario).ToString() + ")";
            }
            catch(Exception ex)
            {
                MessageBox.Show("ocurrio un error por favor intente nuevamente");
            }
            
        }


        private void dataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // For any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Calculate amount code goes here
        }
    }
}
