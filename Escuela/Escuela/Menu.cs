using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Menu : Form
    {
        public Menu(string usuario)
        {
            InitializeComponent();
            LBienbenida.ForeColor = Color.Black;
            LBienbenida.Text = "Bienvenido " + usuario;
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tElaborado por:\n\n\tCastillo Alan\n\tLiberos Angel\n\tMartinez Antonio\t", "Creditos");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
