using System;

/*
 * Programa que calcula la serie de fibonacci
 */
class Fibonacci
{
    // Funcion que realiza la serie de fibonacci
    public static int Fibo(int num)
    {
        if (num == 0)
            return 0;
        else if (num == 1)
            return 1;
        else if (num > 1)
            return Fibo(num - 1) + Fibo(num - 2);
        return -1;
    }
    // Funcion principal del programa
    static void Main(string[] args)
    {
        int ban = 0, num = 0;
        // Bloque do-while valida que el numero ingresado sea mayor a 0 y que sea un numero
        do
        {
            try
            {
                Console.Write("Ingrese el numero para la serie de fibonacci");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                    ban = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Se ingreso un valor invalido: " + e.Message);
            }
        } while (ban == 0);
        
        // Ciclo que imprime la serie de fibonacci
        for(int i = 0; i < num; i++)
        {
            Console.Write(Fibo(i) + " ");
        }
        Console.ReadKey();
    }
}