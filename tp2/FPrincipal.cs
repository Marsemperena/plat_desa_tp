using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slc_Mercado
{
    public partial class FPrincipal : Form
    {
        FLogin hijoLogin;
        FAdmin hijoMain;
        FUser hijoMain2;
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

                if (usuario == "admin") // CONDICION TEMPORAL TENDRÍA QUE VER SI EL USUARIO ES ADMIN O NO - AHORA SOLO SIRVE SI EL USUARIO SE LLAMA ADMIN
                {
                    hijoMain = new FAdmin(new string[] { usuario });
                    hijoMain.MdiParent = this;
                    hijoMain.Show();
                }
                else
                {
                    hijoMain2 = new FUser(new string[] { usuario });
                    hijoMain2.MdiParent = this;
                    hijoMain2.Show();
                }
            }
        }
    }
}
