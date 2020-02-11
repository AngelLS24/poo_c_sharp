using System;

/*
 * Programa que pide 2 numeros del 1 al 9 e imprime los numeros del 1 al 100, si el numero es multiplo
 * de cualquiera de los dos numeros dados, se imprime la palabra clap
 */

public class Clap
{
    // Funcion que agrega valida y regresa un numero leido del usuario
    public static int AgregaNum()
    {
        int ban = 0, num = 0;
        do
        {
            try
            {
                Console.WriteLine("Ingresa el valor de un numero del 1 - 9");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 10 && num > 0)
                    ban = 1;
                else
                    Console.WriteLine("El numero no debe ser mayor a 9, ni menor a 0");
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor ingresado invalido " + e.Message);
            }
        } while (ban == 0);
        return num;
    }
    // Funcion que imprime todos los numeros del 1 - 100
    public static void ImprimeNumeros(int a, int b)
    {
        for(int i = 1; i <= 100; i++)
        {
            // Valida si los numeros son multiplos de algun numero dado por el usuario
            if (i % a == 0 || i % b == 0)
                Console.WriteLine("clap");
            else
                Console.WriteLine(i);
        }
        Console.ReadKey();
    }
    // Funcion Main del programa
    static void Main(string[] args)
    {
        int num1 = AgregaNum();
        int num2 = AgregaNum();

        Console.Clear();
        ImprimeNumeros(num1, num2);
    }
}
