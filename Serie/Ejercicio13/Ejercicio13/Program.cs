using System;
/*
 * Programa de herencia con clase Carro
 */
namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carro 1");
            // Se instancia un objeto de la clase Carro
            Carro carro = new Carro(1000, 1.5);
            // Se llama a los metodos del objeto
            carro.Estado();
            carro.Encender();
            carro.Estado();
            carro.Apagar();
            carro.Estado();
            Console.WriteLine(carro.ToString());

            Console.WriteLine("\nCarro 2");
            // Se instancia un objeto de la clase CarroVMW
            CarroBMW carro2 = new CarroBMW(1500, 1.4);
            // Se llama a los metodos del objeto
            carro2.Estado();
            carro2.Encender();
            carro2.Estado();
            carro2.Apagar();
            carro2.Estado();
            Console.WriteLine(carro2.ToString());

            Console.WriteLine("\nCarro 3");
            // Se instancia un objeto de la clase CarroVW
            CarroVW carro3 = new CarroVW(1800, 1.2);
            // Se llama a los metodos del objeto
            carro3.Estado();
            carro3.Encender();
            carro3.Estado();
            carro3.Apagar();
            carro3.Estado();
            Console.WriteLine(carro3.ToString());

            Console.ReadKey();
        }
    }
}
