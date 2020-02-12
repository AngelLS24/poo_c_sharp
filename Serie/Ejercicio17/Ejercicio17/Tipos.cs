using System;
using System.Collections.Generic;
using System.Text;
/*
 * Clases que hereda de Animales
 */
namespace Ejercicio17
{
    // Mamiferos hereda de Animales
    class Mamiferos : Animales
    {
        // Atributo privado, es accesible solo por la clase
        private string Alimento { get; set; }
        // Constructor, en este caso, se usa el cosntructor de la clase base
        public Mamiferos(int patas, string alimento, string nombre, string hogar) : base(nombre, hogar, patas)
        {
            Alimento = alimento;
        }
        /* 
         * Se sobre escribe el metodo DescribeAnimal de la clase padre, el comportamiento de este metodo
         * sera el que se indique y sera unicamente para los objetos instanciados de la clase
         */
        public override void DescribeAnimal()
        {
            Console.WriteLine("El {0} tiene {1} patas, ellos viven en {2}\n", Nombre, Patas, Hogar);
        }
        // Metodo unico de la clase
        public void Alimentacion()
        {
            Console.WriteLine("Los {0} se alimentan de {1}", Nombre, Alimento);
        }
    }
    // Oviparos hereda de Animales
    class Oviparos : Animales
    {
        // Atributos unicos de la clase Oviparos, solo son accedidos por la clase
        private string Nacimiento { get; set; }
        private string Especie { get; set; }
        // Constructor, en este caso, se usa el cosntructor de la clase base
        public Oviparos(int patas, string nacimiento, string especie, string nombre, string hogar) : base(nombre, hogar, patas)
        {
            Nacimiento = nacimiento;
            Especie = especie;
        }
        /* 
         * Se sobre escribe el metodo DescribeAnimal de la clase padre, el comportamiento de este metodo
         * sera el que se indique y sera unicamente para los objetos instanciados de la clase
         */
        public override void DescribeAnimal()
        {
            Console.WriteLine("El {0} es un {1} que nacen en {2} y tienen {3} patas, ellos viven en {4}", Nombre, Especie, Nacimiento, Patas, Hogar);
        }
    }
}
