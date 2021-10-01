using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plataforma_TP2
{
    public partial class FLogin : Form
    {
        private bool logued;
        private string[] argumentos;
        private string usuario;
        public delegate void TransfDelegado(string usuario);
        public TransfDelegado TrasfEvento;
        public FLogin(string[] args)
        {
            logued = false;
            InitializeComponent();
            argumentos = args;
        }
        private void login_Click(object sender, EventArgs e)
        {
            usuario = username.Text;
            if (usuario != null && usuario != "")
            {
                this.TrasfEvento(usuario);
                this.Close();
            }
            else
                MessageBox.Show("Debe ingresar un usuario!");

        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void registro_Click(object sender, EventArgs e)
        {
            this.Close();
            FRegistro registro = new FRegistro();
            registro.Show();
        }
    }
}