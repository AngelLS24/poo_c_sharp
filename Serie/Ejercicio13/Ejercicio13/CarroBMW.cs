using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    class CarroBMW : Carro
    {
        // Atributo modelo
        private string Modelo = "BMW";
        
        // Constructor de la clase, este hereda de la clase Carro
        public CarroBMW(double peso, double altura) : base(peso, altura) { }
        // Metodo sobreescrito de la clase padre
        public override void Estado()
        {
            if (Encendido)
                Console.WriteLine("A toda gas");
            else
                Console.WriteLine("No hay gas");
        }
        // Metodo que nos regresa la informacion del objeto
        public override string ToString()
        {
            return string.Format("\nDatos generales\nPeso: {0} kg\nAltura: {1} mts\nModelo: {2}", Peso, Altura, Modelo);
        }
    }
}
