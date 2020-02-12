using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class Automovil : IVehiculo
    {
        // Metodo acelera de IVehculo
        public void Acelera(int velocidad)
        {
            Console.WriteLine("Los automoviles mas veloces pueden llegar a 300km/h en {0} segundos", velocidad);
        }
        // Metodo Frena de IVehiculo
        public void Frena(int frena)
        {
            Console.WriteLine("Frenan de 200km/h en {0} metros ", frena);
        }
        // Metodo Caracteristicas de IVehiculo
        public void Caracteristicas(int ruedas, string color, string tipo)
        {
            Console.WriteLine("Ruedas: {0}\nColor: {1}\nTipo: {2}\n", ruedas, color, tipo);
        }
    }
}
