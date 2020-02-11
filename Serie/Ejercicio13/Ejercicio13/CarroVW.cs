using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    class CarroVW : Carro
    {
        // Atributo modelo
        public string Modelo = "VolksWagen";

        // Constructor de la clase, este hereda de la clase Carro
        public CarroVW(double peso, double altura) : base(peso, altura) { }
        // Metodo sobreescrito de la clase padre
        public override void Estado()
        {
            if (Encendido)
                Console.WriteLine("Ahora si ya pisale");
            else
                Console.WriteLine("No tan rapido bro, primero enciende el motor");
        }
        // Metodo que nos regresa la informacion del objeto
        public override string ToString()
        {
            return string.Format("\nDatos generales\nPeso: {0} kg\nAltura: {1} mts\nModelo: {2}", Peso, Altura, Modelo);
        }
    }
}
