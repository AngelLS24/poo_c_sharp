using System;
using System.Collections.Generic;
using System.Text;

namespace Calificaciones
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Ap_Paterno { get; set; }
        public string Ap_Materno { get; set; }
        public double[] Calificaciones { get; set; }
        public double Calificacion { get; set; }
        // Constructor
        public Alumno(string nombre, string ap_paterno, string ap_materno, double [] calificaciones)
        {
            Nombre = nombre;
            Ap_Paterno = ap_paterno;
            Ap_Materno = ap_materno;
            Calificacion = calculadora.califica(calificaciones);
        }

        public override string ToString()
        {
            return String.Format("Alumno {0} {1} {2} tiene {3:#.##} de calificacion final", Nombre, Ap_Paterno, Ap_Materno, Calificacion);
        }
    }

    public static class calculadora
    {
        // Genera la calificacion de los alumnos
        public static double califica(double [] calificaciones)
        {
            double res = 0;

            res += calificaciones[0] * 0.6;
            res += calificaciones[1] * 10 / 5 * 0.4;
            if (calificaciones[2] > 5)
            {
                if (res < 10)
                {
                    if ((res + (calificaciones[2] * 0.08)) > 10)
                        res = 10.0;
                    else
                        res += (calificaciones[2] * 0.08);
                }
                else
                    return res;
            }
            return res;
        }
    }
}
