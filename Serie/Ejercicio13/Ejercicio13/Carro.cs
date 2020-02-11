using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    class Carro
    {
        // Atributos de la clase Carro
        protected double Peso { get; set; }
        protected double Altura { get; set; }
        protected bool Encendido { get; set; }

        // Constructor de la clase
        public Carro(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
            Encendido = false;
        }
        // Metodo Encender
        public void Encender()
        {
            Encendido = true;
        }
        // Metodo Apagar
        public void Apagar()
        {
            Encendido = false;
        }
        // Funcion que nos muestra el estado del carro
        public virtual void Estado()
        {
            if (Encendido)
                Console.WriteLine("La maquina esta prendida");
            else
                Console.WriteLine("La maquina esta apagada");
        }
        // Funcion que nos regresa la informacion del objetp
        public override string ToString()
        {
            return string.Format("\nDatos generales\nPeso: {0} kg\nAltura: {1} mts", Peso, Altura);
        }
    }
}
