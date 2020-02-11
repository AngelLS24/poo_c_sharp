using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    class UNAM : Escuela
    {
        // Atributo propio de la clase 
        private string Cede { get; set; }
        // Constructor
        public UNAM(string cede, string nombre, int oferta) : base(nombre, oferta)
        {
            Cede = cede;
        }
        // Sobre escribe metodo de la clase padre
        public override void Presentacion()
        {
            Console.WriteLine("Universidad: {0}\nOferta: {1} carreras\nCede principal: {2}\n", Nombre, Oferta, Cede);
        }
    }
}
