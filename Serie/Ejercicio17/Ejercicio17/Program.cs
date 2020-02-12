using System;
/*
 * Programa que usa la abstraccion, encapsulamiento, herencia y polimorfismo
 */
namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se instancia un objeto de tipo Mamifero
            Mamiferos perro = new Mamiferos(4, "croquetas", "perro", "casas");
            // Metodo declarado en IAnimal y modificado por Animales
            perro.Habla("Wof");
            // Metodo declarado en Animales
            perro.Camina();
            // Metodo declarado en Mamiferos
            perro.Alimentacion();
            // Declaracion IAnimal -> Animales -> Mamiferos
            perro.DescribeAnimal();

            // Se instancia un objeto de tipo Oviparo
            Oviparos pato = new Oviparos(2, "huevo", "ave", "pato", "granjas");
            // Metodo declarado en IAnimal y modificado por Animales
            pato.Habla("Cuack");
            // Metodo declarado en Animales
            pato.Camina();
            // Declaracion IAnimal -> Animales -> Oviparos
            pato.DescribeAnimal();

            Console.ReadKey();
        }
    }
}
