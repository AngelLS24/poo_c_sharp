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
    public partial class FProfesores : Form
    {
        public string usuario = "user";
        public string contra = "hola123.,";
        public int cont = 1;
        public FProfesores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = TBUser.Text;
            string pass = TBPass.Text;
            

            if(cont < 3)
            {
                if (user == usuario && pass == contra)
                {
                    MessageBox.Show("Bienvenido de nuevo " + user);
                    Menu menu = new Menu(user);
                    menu.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("\tContraseña o Usuario incorrectos\n\n\t\tIntento: " + cont, "Error");
                    cont++;
                }
            }
            else
            {
                MessageBox.Show("Se excedio el numero de intentos");
                Application.Exit();
            }
        }
    }
}
