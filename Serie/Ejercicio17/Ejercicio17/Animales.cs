using System;
using System.Collections.Generic;
using System.Text;
/*
 * Clase que hereda de la interfaz IAnimal
 */
namespace Ejercicio17
{
    class Animales : IAnimal
    {
        /*
         * Atributos de la clase animal estos atributos prodran ser accedidos por las clases
         * que hereden de Animales, esto lo indicamos con la declaracion protected
         */
        protected string Nombre { get; set; }
        protected string Hogar { get; set; }
        protected int Patas { get; set; }
        /*
         * Constructor de la clase Animales(clase base)
         */
        public Animales(string nombre, string hogar, int patas)
        {
            // Se asignan los valores
            Nombre = nombre;
            Hogar = hogar;
            Patas = patas;
        }
        // Metodo que sera accedido por todas las instancias del objeto
        public void Camina()
        {
            Console.WriteLine("El {0} esta caminando", Nombre);
        }
        // Metodo que sera accedido por todas las instancias del objeto
        public void Habla(string habla)
        {
            Console.WriteLine("El {0} hace {1}", Nombre, habla);
        }
        /*
         * Metodo que se hereda, con este metodo ejemplificamos el polimorfismo, ya que el comportamiento
         * del metodo va a variar dependiendo de cada clase, la palabra virtual permite que se sobreescriba
         */
        public virtual void DescribeAnimal()
        {
            return;
        }
    }
}
