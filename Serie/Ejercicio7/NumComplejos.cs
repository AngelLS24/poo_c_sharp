using System;
/*
 * Programa que realiza la suma de 2 numeros complejos
 */
class NumComplejos
{
    class NumeroComplejo
    {
        // Atributos de la clase
        private int real;
        private int imag;
        // Constructor de la clase
        public NumeroComplejo(int partReal, int partImag)
        {
            real = partReal;
            imag = partImag;
        }
        // Funcion que nos muestra el numero complejo en su formato
        public void Imprime()
        {
            // Si la parte imaginaria es 0, solo mostrara la parte real
            if (imag == 0)
                Console.WriteLine("{0}", real);
            // Si la parte imaginaria es menor a 0, se pone en su formato correspondiente
            else if (imag < 0)
                Console.WriteLine("{0} {1}i", real, imag);
            // Si no es ninguna de las anteriores, la parte imaginaria es positiva
            else
                Console.WriteLine("{0} +{1}i", real, imag);
        }
        // Realiza la operacion de sumar 2 numeros complejos y retorna el resultado
        static public NumeroComplejo operator +(NumeroComplejo n1, NumeroComplejo n2)
        {
            // Instancia un objeto de la clase con los valores de las sumas de los numeros compejos que recibe como argumentos
            NumeroComplejo num = new NumeroComplejo(n1.real + n2.real, n1.imag + n2.imag);
            return num;
        }
    }
    static void Main(string[] args)
    {
        // Se instancian 2 numeros complejos
        NumeroComplejo numC1 = new NumeroComplejo(2, 9);
        NumeroComplejo numC2 = new NumeroComplejo(6, -4);
        // Se instancia el tercer numero complejo y se establece como valor el objeto retornado por la funcion de suma '+'
        NumeroComplejo numC3 = numC1 + numC2;
        // Nos muestra los 3 numeros complejos
        Console.WriteLine("Numero 1");
        numC1.Imprime();
        Console.WriteLine("Numero 2");
        numC2.Imprime();
        Console.WriteLine("Suma de numero 1 y numero 2");
        numC3.Imprime();
        Console.ReadKey();
    }
}