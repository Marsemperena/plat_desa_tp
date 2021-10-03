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
            DialogResult resultado = ofd.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                baseDirectoryName = ofd.SelectedPath;
                baseDirectoryLabel.Content = baseDirectoryName;
            }
        }
    }
    }
}
