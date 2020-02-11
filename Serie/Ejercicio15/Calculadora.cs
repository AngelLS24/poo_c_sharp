using System;
using System.Collections.Generic;
/*
 * Programa que realiza operaciones (suma, resta, division y multiplicacion)
 */
class Calculadora
{
    // Funcion que crea el menu
    static public char Menu()
    {
        // Se crea un diccionario para almacenar los valores de las opciones
        Dictionary<char, string> arr = new Dictionary<char, string> { { 'a', "Suma" }, { 'b', "Resta" }, { 'c', "Multiplicacion" }, { 'd', "Division" }, { '?', "Salir" } };
        int ban = 0;
        char c = '0';

        Console.WriteLine("Escoge una opcion:");
        // Se despliegan las opciones que hay dentro del programa
        foreach(KeyValuePair<char, string> valor in arr)
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
    // Funcion que realiza las operaciones suma, resta y multiplicacion
    static public void Operacion(char signo)
    {
        // Variable que sirve de bandera
        bool ban = false;
        do
        {
            try
            {
                // Se leen los dos valores
                Console.Write("Ingrese el valor del primero numero: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el valor del segundo numero: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                // Evalua el signo, de este depende la operacion que se realiza
                switch (signo)
                {
                    // Realiza e imprime la operacion de la suma
                    case '+':
                        Console.WriteLine("\nSuma:\n\t{0} + {1} = {2:0.00}", num1, num2, (num1 + num2));
                        // Se cambia el valor de la bandera para terminar el ciclo
                        ban = true;
                        break;
                    // Realiza e imprime la operacion de la resta
                    case '-':
                        Console.WriteLine("\nSuma:\n\t{0} - {1} = {2:0.00}", num1, num2, (num1 - num2));
                        // Se cambia el valor de la bandera para terminar el ciclo
                        ban = true;
                        break;
                    // Realiza e imprime la operacion de la multiplicacion
                    case '*':
                        Console.WriteLine("\nSuma:\n\t{0} * {1} = {2:0.00}", num1, num2, (num1 * num2));
                        // Se cambia el valor de la bandera para terminar el ciclo
                        ban = true;
                        break;
                }                
            }
            // se lanza la excepcion si es que no se ingresa nada
            catch (FormatException)
            {
                Console.WriteLine("Error se debe ingresar un numero\n");
            }
        } while (!ban);
    }
    // Funcion que realiza la ooeracion de la division
    static public void Division()
    {
        // Variable que funciona de bandera
        bool ban = false;
        do
        {
            try
            {
                // Se obtienen los dos valores para realizar la division
                Console.Write("Ingrese el valor del primero numero: ");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Ingrese el valor del segundo numero: ");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());
                // Se realiza e imprime la operacion
                Console.WriteLine("\nDivision:\n\t{0} / {1} = {2:0.00}", num1, num2, (num1 / num2));
                // Se cambia el valor de la bandera para terminar el ciclo
                ban = true;
            }
            // Se lanza una excepcion si se intenta dividir entre 0
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error no se puede dividir entre '0'\n");
            }
            // Se lanza una excepcion si no se ingresa un valor valido
            catch (FormatException)
            {
                Console.WriteLine("Error se debe ingresar un numero\n");
            }
        } while (!ban);
    }

    static void Main(string[] args)
    {
        // Variable que almacena el valor de la opcion elegida
        char res;
        // Variable que nos sirve de bandera
        bool continuar = true;

        do
        {
            // Se limpia la pantalla cada que se realiza una operacion
            Console.Clear();
            // Llama a la funcion Menu y obtiene un caracter
            res = Menu();
            // Evalua el caracter obtenido
            switch (res)
            {
                // Se realiza la suma
                case 'a':
                    // Se llama a la funcion Operacion con el signo de + como argumento
                    Operacion('+');
                    Console.ReadKey();
                    break;
                // Se realiza la resta
                case 'b':
                    // Se llama a la funcion Operacion con el signo de - como argumento
                    Operacion('-');
                    Console.ReadKey();
                    break;
                // Se realiza la multiplicacion
                case 'c':
                    // Se llama a la funcion Operacion con el signo de * como argumento
                    Operacion('*');
                    Console.ReadKey();
                    break;
                // Se realiza la division
                case 'd':
                    Division();
                    Console.ReadKey();
                    break;
                // Si el caracter es cualquier otro terminara la ejecucion del programa
                default:
                    // Cambia el valor de la bandera para terminar la ejecucion
                    continuar = false;
                    break;
            }
        } while (continuar);
        Console.WriteLine("\nPrograma terminado");
        Console.ReadKey();
    }
}