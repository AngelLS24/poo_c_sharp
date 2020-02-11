using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    class Escuela
    {
        // Atributos de nuestra clase padre
        protected string Nombre { get; set; }
        protected int Oferta { get; set; }
        // Constructor de clase padre
        public Escuela(string nombre, int oferta)
        {
            Nombre = nombre;
            Oferta = oferta;
        }
        // Metodo que hereda a clases hija
        public virtual void Presentacion()
        {
            Console.WriteLine("Clase padre");
        }
    }
}
