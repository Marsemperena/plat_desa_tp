using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using config;

namespace Slc_Mercado
{
    public partial class FConfigurar : Form
    {
        public FConfigurar()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            ofd.Description =
                "seleccionar carpeta para guardar datos locales";




            DialogResult resultado = ofd.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string folderName = ofd.SelectedPath;
                LocalFileManager.userpath = folderName;
            }

        }

        private void volver_Click(object sender, EventArgs e)
        {
            Console.WriteLine("");
            this.Close();
            FPrincipal menuPrincipal = new FPrincipal();
            menuPrincipal.Show();

        }

        /*volver atras
         
            this.Close();
            FPrincipal menuPrincipal = new FPrincipal();
            menuPrincipal.Show();
         
         */

    }
}