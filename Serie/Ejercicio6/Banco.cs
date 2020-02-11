using System;
/*
 * Programa cuenta de banco
 */
class CuentaBancaria
{
    // Se crean los atributos del objeto
    private string nombre;
    private decimal saldo;

    // Se crea la cuenta bancaria
    public CuentaBancaria(string nom, decimal sal)
    {
        nombre = nom;
        saldo = sal;
    }
    // Funcion que nos muestra la informacion de la cuenta creada
    public void MostarInformacion()
    {
        Console.WriteLine("\tCuenta: {0}\tSaldo: {1}", nombre, saldo);
    }
    // Funcion con la que se realizan depositos
    public void Deposito(decimal cantidad)
    {
        Console.WriteLine("\nSaldo: ${0}\nDeposito: ${1} \nFinal: ${2}", saldo, cantidad, (saldo + cantidad));
        // Se suma el deposito a la cuenta
        saldo += cantidad;
    }
    // Funcion que realiza retiros
    public void Retiro(decimal retiro)
    {
        // Valida que el retiro sea menor al saldo
        if (retiro < saldo)
            Console.WriteLine("\nSaldo: ${0}\nRetiro: ${1} \nFinal: ${2}", saldo, retiro, (saldo - retiro));
        else
            Console.WriteLine("No cuentas con el saldo suficiente para realizar un retiro");
        
    }

    static void Main(string[] args)
    {
        // Se crea un arreglo de cuentabancaria
        CuentaBancaria[] cuentas = new CuentaBancaria[2];

        // Ciclo con el que se van creando las cuentas
        for(int i = 0; i < 2; i++)
        {
            // Limpia la pantalla
            Console.Clear();
            Console.WriteLine("Abriendo cuenta");
            Console.Write("Escribe tu nombre: ");
            // Lee el nombre del cliente
            string nom = Console.ReadLine();
            Console.Write("Escribe el saldo incial de la cuenta: ");
            // Lee el saldo inicial
            decimal saldo = Convert.ToDecimal(Console.ReadLine());
            // Crea la cuenta con los valores proporcionados
            cuentas[i] = new CuentaBancaria(nom, saldo);

            Console.WriteLine("\nInformacion de la cuenta");
            // Se muestra la informacion de la cuneta
            cuentas[i].MostarInformacion();

            Console.Write("\nRealiza deposito: ");
            // Se realiza un deposito a la cuenta
            decimal dep = Convert.ToDecimal(Console.ReadLine());
            cuentas[i].Deposito(dep);

            Console.Write("\nRealiza retiro: ");
            // Se realiza un retiro de la cuneta
            decimal ret = Convert.ToDecimal(Console.ReadLine());
            cuentas[i].Retiro(ret);

            Console.WriteLine("\nFin de Transaccion");
            Console.ReadKey();
        }
        Console.ReadKey();
    }
}