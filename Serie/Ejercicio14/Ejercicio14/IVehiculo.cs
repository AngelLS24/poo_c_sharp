using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    interface IVehiculo
    {
        /*
         * Interfaz que da ciertas caracteristicas de diversos vehiculos, su propocito solo es dar informacion
         * no se realiza ningun calculo con estos metodos
         */
        void Acelera(int velocidad);
        void Frena(int tiempo);
        void Caracteristicas(int ruedas, string color, string tipo);
    }
}
