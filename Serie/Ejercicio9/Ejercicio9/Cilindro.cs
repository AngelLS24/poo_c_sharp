using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Cilindro
    {
        // Atributos del objeto
        public double Radio { get; set; }
        public double Altura { get; set; }

        public double caras;
        public double lateral;
        // Constructor del objeto
        public Cilindro(double radio, double altura)
        {
            // Se asignan los valores a los atributos del objeto
            Radio = Math.Abs(radio);
            Altura = Math.Abs(altura);
        }
        // Funcion que calcula el area de las caras de un cilindro
        public void AreaCaras()
        {
            caras = 2 * Math.PI * Math.Pow(Radio, 2);
            Console.WriteLine("Area de las caras del cilindro: {0:0.00}", caras);
        }
        // Funcion que calcula el area lateral del cilindro
        public void AreaLateral()
        {
            lateral = 2 * Math.PI * Radio * Altura;
            Console.WriteLine("Area lateral del cilindro: {0:0.00}", lateral);
        }
        // Funcion que calcula el area superficial del cilindro
        public void AreaSuperficial()
        {
            Console.WriteLine("Area superficial del cilindro: {0:0.00}", (lateral + caras));
        }
        // Funcion muestra los datos del cilindro
        public void DatosCilindro()
        {
            Console.WriteLine("Cilindro con radio de {0} y altura {1}", Radio, Altura);
        }
    }
}
