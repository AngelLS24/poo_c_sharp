using System;
/*
 * Programa de clase Persona con 3 metodos
 */
class Program
{
    static void Main(string[] args)
    {   
        int edad, mes;
        double estatura;
        double peso;
        Console.Clear();
        Console.WriteLine("Ingresa tus valores:");
        // Leemos el nombre de la persona
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        // Leemos y validamos la edad de la persona
        do
        {
            try
            {
                // Se lee la edad
                Console.Write("Edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                // Se lee el mes de nacimiento
                Console.Write("Mes de nacimiento: ");
                mes = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Debes ingresar un numero entero");
            }
        } while (true);
        // Se lee y valida la altura de la persona
        do
        {
            try
            {
                // Se lee la altura de la persona
                Console.Write("Altura [Metros]: ");
                estatura = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Debes ingresar un valor como 1.8");
            }
        } while (true);
        // Se lee y valida el peso de la persona
        do
        {
            try
            {
                // Se lee el peso de la persona
                Console.Write("Peso [Kg]: ");
                peso = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un peso correcto.");
            }
        } while (true);

        // Se instancia un nuevo objeto de la clase persona con lo ingresado por el usuario
        Persona nuevo = new Persona(nombre, edad, estatura, peso);
        // Se ejecutan los metodos de la clase
        nuevo.AnioNacimiento(mes);
        nuevo.Salud();
        nuevo.Presentate();

        Console.ReadKey();
    }
}

class Persona
{
    // Variable que nos sirve para hacer calculos con fechas
    DateTime today = new DateTime(2020, 2, 11, 12, 00, 0);
    // Atributos de la clase Persona
    public string Nombre;
    public int Edad;
    public double Estatura;
    public double Peso;
    private int anio;

    // Constructor de la clase
    public Persona(string nombre, int edad, double estatura, double peso)
    {
        Nombre = nombre;
        Edad = edad;
        Estatura = estatura;
        Peso = peso;
    }
    // Funcion que calcula el año de nacimiento en base al mes de nacimiento y la edad
    public void AnioNacimiento(int mes)
    {        
        // Si el mes es menor al mes en el que estamos, aun no cumple años
        if (mes < today.Month)
        {
            anio = today.Month - Edad;
            Console.WriteLine("\n{0} nacio en {1}\n", Nombre, anio);
        }
        // Si el mes es mayor al mes en el que estamos, ya cumplio años
        else if (mes > today.Month)
        {
            anio = (today.Year - Edad) - 1;
            Console.WriteLine("\n{0} nacio en {1}\n", Nombre, anio);
        }
    }
    // Funcion que nos dice si somo parcialmente saludables en base al peso y estatura
    public void Salud()
    {
        // Verifica que la estatura tenga relacion con el peso de la persona
        if((Estatura * 100 - 100) > Peso)
            Console.WriteLine("{0} mide {1} y pesa {2}\n{0} esta saludable\n", Nombre, Estatura, Peso, Nombre);
        else
            Console.WriteLine("{0} mide {1} y pesa {2}\n{0} deberia hacer mas ejercicio\n", Nombre, Estatura, Peso, Nombre);
        
    }
    // Funcion que nos muestra la informacion de la persona
    public void Presentate()
    {
        Console.WriteLine("Hola mi nombre es {0} y tengo {1} años, naci en {2} y peso {3} kg", Nombre, Edad, anio, Peso);
    }
}