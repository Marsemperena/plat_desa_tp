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
    public partial class FPrincipal : Form
    {
        FLogin hijoLogin;
        FAdmin hijoMain;
        internal string texto;
        string usuario;
        bool logued;
        public bool touched;
        public FPrincipal()
        {
            InitializeComponent();
            logued = false;
            // LOGIN
            hijoLogin = new FLogin(new string[1]);
            hijoLogin.MdiParent = this;
            hijoLogin.TrasfEvento += TransfDelegado;
            hijoLogin.Show();

            touched = false;

        }
        private void TransfDelegado(string Usuario)
        {
            this.usuario = Usuario;
            if (usuario != null && usuario != "")
            {
                MessageBox.Show("Log-in correcto, Usuario: " + usuario);
                hijoLogin.Close();
                hijoMain = new FAdmin(new string[] { usuario });
                hijoMain.MdiParent = this;
                hijoMain.Show();
            }
        }
    }
}
