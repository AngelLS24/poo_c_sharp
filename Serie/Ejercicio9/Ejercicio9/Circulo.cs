using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Circulo
    {
        // Atributo del objeto
        public double Radio { get; set; }
        // Constructor del objeto
        public Circulo(double radio)
        {
            // Se asigna el valor al atributo del objeto
            Radio = Math.Abs(radio);
        }
        // Funcion que calcula el perimetro
        public void Perimetro()
        {
            Console.WriteLine("Perimetro: {0:0.00}", (2 * Math.PI * Radio));
        }
        // Funcion que calcula el area
        public void Area()
        {
            Console.WriteLine("Area: {0:0.00}", (Math.PI * Math.Pow(Radio, 2)));
        }
        // Funcion que imprime los datos del objeto
        public void DatosCirculo()
        {
            Console.WriteLine("Circulo con radio: {0}", Radio);
        }
    }
}
