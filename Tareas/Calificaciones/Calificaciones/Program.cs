using System;

namespace Calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos alumnos se van a calificar: ");

            int tam = Convert.ToInt32(Console.ReadLine());
            string nom;
            string ap_pa;
            string ap_ma;

            double[] calif = new double[3]; 

            Alumno[] alumnos = new Alumno[tam];

            // Lee los datos de los alumnos, los valida y los almacena en un arreglo
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("Nombre del alumno {0}:", i);
                nom = Console.ReadLine();
                Console.WriteLine("Apellido paterno del alumno {0}:", i);
                ap_pa = Console.ReadLine();
                Console.WriteLine("Apellido materno del alumno {0}", i);
                ap_ma = Console.ReadLine();
                Console.WriteLine("Calificacion del proyecto");
                calif[0] = Convert.ToDouble(Console.ReadLine());
                if(calif[0] < 0 || calif[0] > 10)
                {
                    do
                    {
                        Console.WriteLine("Calificacion debe ser del 1 - 10");
                        calif[0] = Convert.ToDouble(Console.ReadLine());
                    } while (calif[0] > 10 || calif[0] < 0);

                }
                Console.WriteLine("Cuantas tareas entrego el alumno {0}", i);
                calif[1] = Convert.ToDouble(Console.ReadLine());
                if (calif[1] < 0 || calif[1] > 5)
                {
                    do
                    {
                        Console.WriteLine("Las tareas totales fueron 5, no puede pasar ese numero");
                        calif[1] = Convert.ToDouble(Console.ReadLine());
                    } while (calif[1] > 5 || calif[1] < 0);

                }
                Console.WriteLine("Participaciones del alumno {0}", i);
                calif[2] = Convert.ToDouble(Console.ReadLine());
                if (calif[2] < 0)
                {
                    do
                    {
                        Console.WriteLine("No puede haber participaciones negativas");
                        calif[2] = Convert.ToDouble(Console.ReadLine());
                    } while (calif[2] < 0);
                }
                alumnos[i] = new Alumno(nom, ap_pa, ap_ma, calif);
            }

            foreach(Alumno alum in alumnos)
            {
                Console.WriteLine(alum.ToString());
            }
            Console.ReadKey();
        }
    }
}
