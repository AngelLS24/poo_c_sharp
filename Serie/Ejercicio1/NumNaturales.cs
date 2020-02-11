using System;

/*
 * Prgrama que suma los primeros n numeros naturales de un numero n
 * dado por el usuario
 */
class NumNaturales
{
    /*
        Funcion que realiza la suma de los primeros n numeros naturales, si recibe un 3, 
        realiza la suma de 1 + 2, ya que son los primeros n numeros naturales  
    */
    public static int sumaNaturales(int num)
    {
        // Crea una variable que almacena los valores de la suma
        int res = 0;
        // Realiza un ciclo for para obtener los numeros que se van a sumar
        for(int i = 1; i < num; i++)
            res += i; // Se van sumando los numeros a nuesra variable
        // Restorna el valor resultante
        return res;
    }

    static void Main()
    {
        Console.WriteLine("Suma de numeros naturales");
        Console.WriteLine("Ingrese un numero:");
        int num = 0;
        // Mientras el valor sea un valor invalido, se ejecuta este bloque
        do
        {
            // Se usa un try-catch para validar el formato de la entrada
            try 
            {
                // Se lee la entrada y se convierte a numero entero
                num = Convert.ToInt32(Console.ReadLine());
                // Valida que el nuimero sea mayor que 0, de otra manera no es valido
                if (num < 0)
                    Console.WriteLine("El numero debe ser mayor a 0");
            }
            catch(FormatException)
            {
                // Mensaje que se despliega en caso se que no se ingrese un numero entero
                Console.WriteLine("La entrada debe de se un numero entero");
                num = 0;
            }
        } while (num <= 0);

        Console.WriteLine("La suma de los primeros numeros naturales de {0} es {1}", num, sumaNaturales(num));

        Console.ReadKey();
    }
}
