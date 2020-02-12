using System;
/*
 * Programa que ejemplifica el uso de interfaces
 */
namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia un objeto IVehiculo de tipo avion
            IVehiculo avion = new Avion();
            // Metodos de la interfaz
            avion.Acelera(290);
            avion.Frena(5);
            avion.Caracteristicas(22, "blanco", "Aerero");
            // Instancia un objeto IVehiculo de tipo automovil
            IVehiculo carro = new Automovil();
            // Metodos de la interfaz
            carro.Acelera(6);
            carro.Frena(160);
            carro.Caracteristicas(4, "depende de la carroceria", "carreras");

            // Instancia un objeto IVehiculo de tipo motocicleta
            IVehiculo moto = new Motocicleta();
            // Metodos de la interfaz
            moto.Acelera(20);
            moto.Frena(8);
            moto.Caracteristicas(2, "negra", "trabajo");

            Console.ReadKey();
        }
    }
}
