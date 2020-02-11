using System;
using System.Collections.Generic;
/*
 * Programa que ejemplifica el polimorfismo con un aclase padre y 3 clases hijas
 */
namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea una lisat de objetos para almacenar objetos de nuestras clases hijo
            var escuelas = new List<Escuela>
            {
                // Se instancian 1 objeto de cada una de nuestras clases
                new UNAM("Ciudad Universitaria", "UNAM", 128),
                new IPN("Zacatenco", "IPN", 55, "Area 1")
            };
            // Se recorre la lista de objetos
            foreach (var escuela in escuelas)
            {
                // Se llama al metodo de cada objeto
                escuela.Presentacion();
            }
            Console.ReadKey();
        }
    }
}
