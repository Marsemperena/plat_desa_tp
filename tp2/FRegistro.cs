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
    public partial class FRegistro : Form
    {
        public FRegistro()
        {
            
            InitializeComponent();
   
        }

        private void FRegistro_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Completar los campos con la informacion solicitada.");
        }
        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
            FPrincipal menuPrincipal = new FPrincipal();
            menuPrincipal.Show();
        }
        private void registrarUsuario_Click(object sender, EventArgs e)
        {
            //leer archivo de usuarios //TODO encriptar en algun momento

            List<Usuario> usuarios = UsuarioDAO.getAll();

            //agregar usuario al array temporal
            int id = 0;
            int dni;
            int.TryParse(cuit.Text, out dni);
            string nombre = nombre_.Text;
            string apellido = apellido_.Text;
            string mail = mail_.Text;
            string password = pass.Text;
            Carro MiCarro = null;

            if (validar())
                usuarios.Add(new Usuario(id, dni, nombre, apellido, mail, password, tipoUsuario.SelectedItem.ToString(), cuit.Text));
            else return;

            //guardar

            UsuarioDAO.saveAll(usuarios);

            MessageBox.Show("Usuario registrado con exito");
            this.Close();
            FPrincipal menuPrincipal = new FPrincipal();
            menuPrincipal.Show();
        }

        private bool validar()
        {
            if(dni.Text!="" && cuit.Text!="" && nombre_.Text!="" && apellido_.Text != "" && mail_.Text != "" && pass.Text != "" && tipoUsuario.SelectedItem!=null && !"".Equals(tipoUsuario.SelectedItem.ToString()) )

            return true;

            else
            {
                MessageBox.Show("Por favor completar todos los campos con la informacion solicitada.");
                return false;
            }
        }

        private void tipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
