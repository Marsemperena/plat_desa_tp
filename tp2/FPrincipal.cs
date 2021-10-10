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
    public partial class FPrincipal : Form
    {
        FLogin hijoLogin;
        FAdmin hijoMain;
        FUser hijoMain2;
        internal string texto;
        Usuario usuario;
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
        private void TransfDelegado(Usuario usuario)
        {
            Mercado mercado = new Mercado();
            this.usuario = usuario;
            if (usuario != null && usuario.nombre != "")
            {
                MessageBox.Show("Log-in correcto, Usuario: " + usuario.nombre);
                hijoLogin.Close();

                if (mercado.esAdmin(usuario.id))// CONDICION TEMPORAL TENDRÍA QUE VER SI EL USUARIO ES ADMIN O NO - AHORA SOLO SIRVE SI EL USUARIO SE LLAMA ADMIN
                {
                    hijoMain = new FAdmin(usuario);
                    hijoMain.MdiParent = this;
                    hijoMain.Show();
                }
                else
                {
                    hijoMain2 = new FUser(usuario);
                    hijoMain2.MdiParent = this;
                    hijoMain2.Show();
                }
            }
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
