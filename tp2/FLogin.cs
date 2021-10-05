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
    public partial class FLogin : Form
    {
        private bool logued;
        private string[] argumentos;
        private Usuario usuario;
        public delegate void TransfDelegado(Usuario usuario);
        public TransfDelegado TrasfEvento;
        public FLogin(string[] args)
        {
            logued = false;
            InitializeComponent();
            argumentos = args;
        }
        private void login_Click(object sender, EventArgs e)
        {
            //cargar todos los usurios y revisar si existe el user ingresado
            List<Usuario> usuarios = UsuarioDAO.getAll();

            Boolean loginOK = false;

            foreach (Usuario us in usuarios)
            {
                int dni_;
                bool dniOK = Int32.TryParse(dni.Text, out dni_);
                if (dniOK && us.dni == dni_ && us.password == pass.Text)
                {
                    //encontron al usuario
                    usuario = us;
                    loginOK = true;
                    break;
                }
            }

            if (loginOK)
            {
                this.TrasfEvento(usuario);
                this.Close();
            }
            else
                MessageBox.Show("Ocurrio un error al intentar realizar el login");

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

        private void configurar_Click(object sender, EventArgs e)
        {
            FConfigurar configurar = new FConfigurar();
            configurar.Show();
        }
    }
}