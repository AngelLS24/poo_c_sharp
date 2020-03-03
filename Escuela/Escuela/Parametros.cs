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
    public partial class Parametros : Form
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
        public Parametros()
        {
            InitializeComponent();
        }

        private void btParam_Click(object sender, EventArgs e)
        {
            //Guardamos datos del porcentaje del examen
            try
            {
                Convert.ToInt32(tbExamPercent.Text);    //Si falla la conversion
                //Validacion de datos
                if (Convert.ToInt32(tbExamPercent.Text) > 0 && Convert.ToInt32(tbExamPercent.Text) < 100)
                    examenPercent = Convert.ToInt32(tbExamPercent.Text);
                else
                    flag = false;
            }
            catch (FormatException) { flag = false; }

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
            catch (FormatException) { flag = false; }

            //Guardamos datos del porcentaje del proyecto
            try
            {
                Convert.ToInt32(tbProyectoPercent.Text);    //Si falla la conversion
                //Validacion de datos
                if (Convert.ToInt32(tbProyectoPercent.Text) > 0 && Convert.ToInt32(tbProyectoPercent.Text) < 100)
                    proyectoPercent = Convert.ToInt32(tbProyectoPercent.Text);
                else
                    flag = false;
            }
            catch (FormatException) { flag = false; }

            //Guardamos datos de la cantidad del proyecto
            try
            {
                Convert.ToInt32(tbProyectosCant.Text);       //Si falla la conversion
                //Validacion de datos
                if (Convert.ToInt32(tbProyectosCant.Text) > 0)
                    proyectoCant = Convert.ToInt32(tbProyectosCant.Text);
                else
                    flag = false;
            }
            catch (FormatException) { flag = false; }

            //Guardamos datos del porcentaje de las tareas
            try
            {
                Convert.ToInt32(tbTareaPercent.Text);    //Si falla la conversion
                //Validacion de datos
                if (Convert.ToInt32(tbTareaPercent.Text) > 0 && Convert.ToInt32(tbTareaPercent.Text) < 100)
                    tareasPercent = Convert.ToInt32(tbTareaPercent.Text);
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
                //Lanzamos la form del menu
                //Menu Menu = new Menu();
                //Menu.Visible = true;
                //Cerramos la ventana actual
                this.Dispose();
            }
            else
            {
                //Clear textboxes and launch message

            }
        }
    }
}
