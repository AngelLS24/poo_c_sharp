using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class Avion : IVehiculo
    {
        // Metodo acelera de IVehculo
        public void Acelera(int velocidad)
        {
            Console.WriteLine("Un avion despega a la velocidad de {0} kmph", velocidad);
        }
        // Metodo Frena de IVehiculo
        public void Frena(int tiempo)
        {
            Console.WriteLine("Tarda en frenar {0} minutos", tiempo);
        }
        // Metodo Caracteristicas de IVehiculo
        public void Caracteristicas(int ruedas, string color, string tipo)
        {
            Console.WriteLine("Ruedas: {0}\nColor: {1}\nTipo: {2}\n", ruedas, color, tipo);
        }
    }
}
