using System;

/*
 * Programa que pide al usuario una cadena de texto e imprima la misma cadena de texto, pero antes de cada vocal,
 * agrega una f.
 */

class F
{
    // Funcion que agrega una f antes de cada vocal
    static void AgregaF(string cad)
    {
        string vocales = "aeiou";
        // Recorre la cadena ingresada por el usuario
        for(int i = 0; i < cad.Length; i++)
        {
            // Recorre la cadena con las vocales
            for(int j = 0; j < vocales.Length; j++)
            {
                // Valida si el caracter es una vocal
                if (cad[i].Equals(vocales[j]))
                    Console.Write("f");
            }
            // Imprime el caracter
            Console.Write(cad[i]);
        }
    }
    // Funcion principal del programa
    static void Main(string[] args)
    {
        string cadena;
        Console.WriteLine("Escribe una cadena");
        cadena = Console.ReadLine();
        AgregaF(cadena);

        Console.ReadKey();
    }
}