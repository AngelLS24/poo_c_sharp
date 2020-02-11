using System;
/*
 * Programa con metodos de la clase Math
 */
namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Figura: Circulo\n");
            do
            {
                try
                {
                    // Lee los valores que se ocupan para instanciar al objeto
                    Console.Write("Escribe el Radio para un circulo: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    // Se instancia un nuevo objeto
                    Circulo cir = new Circulo(radio);
                    // Se llama a los metodos del objeto
                    cir.Area();
                    cir.Perimetro();
                    cir.DatosCirculo();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debes escribir un numero");
                }
            } while (true);
            Console.ReadKey();
            Console.WriteLine("\nFigura: Cilindro\n");
            do
            {
                try
                {
                    // Lee los valores que se ocupan para instanciar al objeto
                    Console.WriteLine("Escribe el Radio y la Altura para un cilindro");
                    Console.Write("Radio: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    // Se instancia un nuevo objeto
                    Cilindro cil = new Cilindro(radio, altura);
                    // Se llama a los metodos del objeto
                    cil.AreaCaras();
                    cil.AreaLateral();
                    cil.AreaSuperficial();
                    cil.DatosCilindro();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debes escribir un numero");
                }
            } while (true);
            Console.ReadKey();
        }
    }
}
