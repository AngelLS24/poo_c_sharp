using System;
using System.Collections.Generic;
/*
 * Programa de BecarioMart
 */
class Program
{
    static public char MenuOpciones(string op1, string op2)
    {
        // Se crea un diccionario para almacenar los valores de las opciones
        Dictionary<char, string> arr = new Dictionary<char, string> { { 'a', op1 }, { 'b', op2 }, { '?', "Salir" } };
        int ban = 0;
        char c = '0';

        Console.WriteLine("Escoge una opcion:");
        // Se despliegan las opciones que hay dentro del programa
        foreach (KeyValuePair<char, string> valor in arr)
        {
            Console.WriteLine("\t{0}: {1}", valor.Key, valor.Value);
        }
        do
        {
            try
            {
                Console.Write("Opcion: ");
                // Intenta obtener un caracter de la entrada, si es mas de un caracter, lanza una excepcion
                c = Convert.ToChar(Console.ReadLine());
                ban = 1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, se debe ingresar un solo caracter\n");
            }
        } while (ban == 0);
        // Regresa el caracter leido por el usuario
        return c;
    }

    public static void AgregarProducto(List<string> productos, List<decimal> precios)
    {
        Console.Write("Escribe el nombre del producto: ");
        string producto = Console.ReadLine();
        productos.Add(producto);

        decimal costo = 0;
        Console.Write("Escribe el precio del producto: ");
        do
        {
            try
            {
                costo = Convert.ToDecimal(Console.ReadLine());
                precios.Add(costo);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Se debe ingresar un valor numerico");
            }
            Console.ReadKey();
        } while (true);
    }
    // Funcion que nos muestra lo que se puede hacer en el carro
    public static void Carrito(List<string> nombres, List<decimal> precios)
    {
        Console.Clear();
        char op = '0';
        bool continua = true;
        decimal total;

        do
        {
            // Despliega menu con las opciones que se le pasan como argumentos
            op = MenuOpciones("Comprar/Pagar productos", "Dejar producto");
            // Obtiene el costo total de la lista e imprime los valores en pantalla
            total = InformacionProductos(nombres, precios);
            // Evalua la opcion obtenida
            switch (op)
            {
                case 'a':
                    // Verifica si el total es mayor a 500
                    if (total > 500)
                        Console.WriteLine("Te haz excedido comprando, requieres dejar algo");
                    else
                    {
                        Console.WriteLine("Gracias por su compra, vuelva pronto");
                        // Rompe la ejecucion
                        continua = false;
                    }
                    break;
                case 'b':
                    // Se obtiene el indice del producto que se va a eliminar
                    Console.Write("\nIndica el indice del producto: ");
                    
                    // Verifica que se pueda trabajar con el indice leido por el usuario
                    try
                    {
                        int indice = Convert.ToInt32(Console.ReadLine());
                        nombres.RemoveAt(indice);
                        precios.RemoveAt(indice);
                        InformacionProductos(nombres, precios);
                    }
                    // Lanza excepcion de formato
                    catch (FormatException)
                    {
                        Console.WriteLine("Se debe ingresar un valor numerico");
                    }
                    // Lanza excepcion de indice fuera de rango
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Ingrese un indice correcto");
                    }
                    break;
                default:
                    // Cualquier caracter que no sea indice de una opcion termina la ejecucion
                    Console.WriteLine("Fin de la ejecucion");
                    continua = false;
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        } while (continua);
    }

    // Nos imprime nombre, precio e indice del producto
    public static decimal InformacionProductos(List<string> nombres, List<decimal> precios)
    {
        decimal total = 0;
        // Se recorren las listas para mostrar su contenido
        for (int i = 0; i < nombres.Count; i++)
        {
            // Imprime en pantalla el contenido
            Console.WriteLine("Producto: {0}, Precio: {1}, Indice: {2}", nombres[i], precios[i], i);
            // Suma todo para calcular el costo total
            total += precios[i];
        }
        return total;
    }

    static void Main(string[] args)
    {
        // Crea las listas de los productos y los precios
        List<string> productos = new List<string>();
        List<decimal> precios = new List<decimal>();

        bool continuar = true;
        char op = '0';
        // Limpia la pantalla
        Console.Clear();
        do
        {
            // Imprime el menu con las opciones que recibe como argumentos
            op = MenuOpciones("Añadir producto", "Carrito");
            switch (op)
            {
                case 'a':
                    // Llama a la funcion que agrega productos
                    AgregarProducto(productos, precios);
                    break;
                case 'b':
                    // Llama a la funcion carrito
                    Carrito(productos, precios);
                    continuar = false;
                    break;
                default:
                    continuar = false;
                    Console.WriteLine("Vuelva pronto");
                    break;
            }
            Console.Clear();
        } while (continuar);
    }
}