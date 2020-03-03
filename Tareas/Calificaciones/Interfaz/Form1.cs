using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        //Variables de evaluacion
        int examenPercent;
        int examenCant;
        int proyectoPercent;
        int proyectoCant;
        int tareasPercent;
        int tareasCant;

        //Para validación de datos
        Boolean flag = true;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void butEmpezar_Click(object sender, EventArgs e)
        {
            //Guardamos datos del porcentaje del examen
            try {
                Convert.ToInt32(tbExamPercent.Text);    //Si falla la conversion
                //Validacion de datos
                if (Convert.ToInt32(tbExamPercent.Text) > 0 && Convert.ToInt32(tbExamPercent.Text) < 100)
                    examenPercent = Convert.ToInt32(tbExamPercent.Text);
                else
                    flag = false;
            }
            catch (FormatException) {    flag = false;   }

            //Guardamos datos de la cantidad del examen
            try
            {
                Convert.ToInt32(tbExamCant.Text);       //Si falla la conversion
                //Validacion de datos
                if (Convert.ToInt32(tbExamCant.Text) > 0)
                    examenCant = Convert.ToInt32(tbExamCant.Text);
                else
                    flag = false;
            }
            catch (FormatException) {   flag = false;   }

            //Guardamos datos del porcentaje del proyecto
            try
            {
                Convert.ToInt32(tbProjectPercent.Text);    //Si falla la conversion
                //Validacion de datos
                if (Convert.ToInt32(tbProjectPercent.Text) > 0 && Convert.ToInt32(tbProjectPercent.Text) < 100)
                    proyectoPercent = Convert.ToInt32(tbProjectPercent.Text);
                else
                    flag = false;
            }
            catch (FormatException) { flag = false; }

            //Guardamos datos de la cantidad del proyecto
            try
            {
                Convert.ToInt32(tbProjectCant.Text);       //Si falla la conversion
                //Validacion de datos
                if (Convert.ToInt32(tbProjectCant.Text) > 0)
                    proyectoCant = Convert.ToInt32(tbProjectCant.Text);
                else
                    flag = false;
            }
            catch (FormatException) { flag = false; }

            //Guardamos datos del porcentaje de las tareas
            try
            {
                Convert.ToInt32(tbTareasPercent.Text);    //Si falla la conversion
                //Validacion de datos
                if (Convert.ToInt32(tbTareasPercent.Text) > 0 && Convert.ToInt32(tbTareasPercent.Text) < 100)
                    tareasPercent = Convert.ToInt32(tbTareasPercent.Text);
                else
                    flag = false;
            }
            catch (FormatException) { flag = false; }

            //Guardamos datos de la cantidad de tareas
            try
            {
                Convert.ToInt32(tbTareasCant.Text);       //Si falla la conversion
                //Validacion de datos
                if (Convert.ToInt32(tbTareasCant.Text) > 0)
                    tareasCant = Convert.ToInt32(tbTareasCant.Text);
                else
                    flag = false;
            }
            catch (FormatException) { flag = false; }

            //Lanzamos la siguiente ventana si los valores son válidos
            if (flag)
            {
                Form2 form2 = new Form2();
                form2.Visible = true;
                //Cerramos la ventana inicial
                this.Dispose();
            }
            else
            {
                //Clear textboxes and launch message
            }
            
        }
    }
}
