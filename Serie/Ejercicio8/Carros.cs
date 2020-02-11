using System;
/*
 * Programa que crea una clase Auto
 */
class Carros
{
    static void Main(string[] args)
    {
        // Se instancian 2 objetos de la clase
        Auto car1 = new Auto();
        Auto car2 = new Auto("Mazda", "Negro", 250000);
        Console.WriteLine("\nInformacion del auto 1");
        Console.WriteLine("Marca: {0}", car1.Marca);
        Console.WriteLine("Costo: {0}", car1.Costo);
        car1.Avanza();

        Console.WriteLine("\nInformacion del carro 2");
        Console.WriteLine("Marca: {0}", car2.Marca);
        car2.Frena();
        car2.Reversa();

        Console.WriteLine("\nEl carro 1 choco!");

        car1.Costo = 150000;

        Console.WriteLine("Su nuevo costo ahora es: {0}", car1.Costo);
        Console.WriteLine("\nEl dueño del carro 1 se compro un nuevo carro");
        // Se instancia 1 objeto de la clase
        Auto car3 = new Auto("Honda", "Azul", 300000);
        Console.WriteLine("Marca: {0}", car3.Marca);
        Console.WriteLine("Color: {0}", car3.Color);
        Console.WriteLine("Costo: {0}", car3.Costo);

        car3.Avanza();

        Console.ReadKey();
    }
}
class Auto
{
    // Variables de la clase
    string marca;
    string color;
    decimal costo;

    // Se asignan valores a marca
    public string Marca 
    {
        get { return marca; }
        set { marca = value; }
    }
    // Se asignan valores a color
    public string Color 
    {
        get { return color; }
        set { color = value; }
    }
    // Se asignan valores a costo
    public decimal Costo
    {
        get { return costo; }
        set { costo = value; }
    }
   

    // Constructor cuando no se reciben valores / por defecto
    public Auto()
    {
        marca = "Toyota";
        color = "Rojo";
        costo = 200000;
    }

    // Constructor sobrecargado / Cuando recibe argumentos
    public Auto(string mar, string col, decimal cos)
    {
        marca = mar;
        color = col;
        costo = cos;
    }
    /*
     * Metodos de la clase Auto
     */
    public void Frena()
    {
        Console.WriteLine("La velocidad se empieza reducir");
    }

    public void Avanza()
    {
        Console.WriteLine("El auto empieza a avanzar");
    }

    public void Reversa()
    {
        Console.WriteLine("El auto empieza a avanzar en reversa");
    }
}