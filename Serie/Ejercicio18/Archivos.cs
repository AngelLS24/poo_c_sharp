using System;
using System.IO;
/*
 * Programa de manejo de archivos
 */
class Archivos
{
    static string Menu()
    {
        Console.WriteLine("Escoge una opcion:");
        Console.WriteLine("\t1: Ver si el archivo contiene una palabra");
        Console.WriteLine("\t2: Imprimir linea donde aparece una palabra");
        Console.WriteLine("\t3: Escribir archivo con lineas donde aparece una palabra");
        Console.WriteLine("\t?: Salir");
        Console.Write("Opcion: ");
        return Console.ReadLine();
    }
    // Funcion principal del programa
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Ingresa el nombre de tu archivo: ");
        string archivo = Console.ReadLine();
        string[] lines;

        try
        {
            lines = System.IO.File.ReadAllLines(@archivo);
        }catch(Exception e)
        {
            Console.WriteLine("Verifique el nombre del archivo");
            Console.WriteLine("Error al abrir el archivo: {0}", e.Message);
            return;
        }

        Console.WriteLine();
        string c = Menu();
        Console.WriteLine();
        Console.Write("Ingresa la palabra a buscar: ");
        string palabra = Console.ReadLine();
        switch (c)
        {
            case "1":
                Files.Archivo(palabra, lines);
                break;
            case "2":
                Files.Archivo(lines, palabra);
                break;
            case "3":
                Console.Write("Escribe el nombre de un archivo de salida: ");
                archivo = Console.ReadLine();
                Files.Archivo(archivo, palabra, lines);
                break;
            default:
                break;
        }
        Console.ReadKey();
    }
}

static class Files
{
    public static void Archivo(string palabra, string[] lines)
    {
        int contador = 0;
        foreach (string line in lines)
        {
            contador++;
            if (line.Contains(palabra))
            {
                Console.WriteLine("Palabra '{0}' encontrada en la linea {1}", palabra, contador);
            }
        }
        Console.WriteLine("\nLa palabra {0}, aparece {1} veces en el archivo", palabra, contador);
    }

    public static void Archivo(string[] lines, string palabra)
    {
        int contador = 0;
        foreach (string line in lines)
        {
            contador++;
            if (line.Contains(palabra))
            {
                Console.WriteLine("Linea: " + contador + "\n\t" + line);
            }
        }
    }

    public static void Archivo(string archivo, string palabra, string[] lines)
    {
        int contador = 0;
        string linea;
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@archivo))
        {
            file.WriteLine("Resultado de la busqueda de: '{0}'", palabra);
            foreach (string line in lines)
            {
                contador++;
                if (line.Contains(palabra))
                {
                    linea = "Linea: " + contador + "\n\t" + line;
                    file.WriteLine(linea);
                }
            }
            Console.WriteLine("Resultados escritros en el archivo de salida '{0}'", archivo);
        }
    }
}