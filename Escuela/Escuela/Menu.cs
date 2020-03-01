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
        protected string Conexion;
        public Menu(string usuario, string conexion)
        {
            InitializeComponent();
            LBienbenida.ForeColor = Color.Black;
            LBienbenida.Text = "Bienvenido " + usuario;
            Conexion = conexion;
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tElaborado por:\n\n\tCastillo Alan\n\tLiberos Angel\n\tMartinez Antonio\t", "Creditos");
            MessageBox.Show(Conexion);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
