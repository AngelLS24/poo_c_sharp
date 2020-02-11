using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    class IPN : Escuela
    {
        // Atributos propios de la clas
        private string Cede { get; set; }
        private string Especialidad { get; set; }
        // Constructor
        public IPN(string cede, string nombre, int oferta, string especialidad) : base(nombre, oferta)
        {
            Cede = cede;
            Especialidad = especialidad;
        }
        // Sobreescribe metodo de la clase padre
        public override void Presentacion()
        {
            Console.WriteLine("Universidad: {0}\nOferta: {1}\nCede principal: {2}\nEspecialidad: {3}\n", Nombre, Oferta, Cede, Especialidad);
        }
    }
}