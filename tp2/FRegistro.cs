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

        }

        private void tipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
