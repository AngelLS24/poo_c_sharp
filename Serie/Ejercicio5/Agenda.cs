    using System;
using System.Collections.Generic;

/*
 * Programa que simula una agenda
 */
class Agenda
{
    // Funcion que nos despliega un menu, regresa un numero entero que es el elegido por el usuario
    static int Menu()
    {
        Console.Clear();
        Console.WriteLine("Escoge una opcion:");
        Console.WriteLine("\t1: Agregar Contacto");
        Console.WriteLine("\t2: Eliminar Contacto");
        Console.WriteLine("\t3: Mostrar Contacto");
        Console.WriteLine("\t?: Salir");
        Console.Write("Opcion: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // Funcion principal del programa
    static void Main(string[] args)
    {
        // Se crea el diccionario que se usa para la agenda
        Dictionary<string, string> agenda = new Dictionary<string, string>();
        /*
         *Variables que nos ayudan a la ejecucion, ban nos sirve como bandera de que todo se ejecuta correctamente
         * op es la variable que obtiene el valor de la funcion Menu, la cual despues es evaluada en dentro del
         * switch
         */
        int ban = 0, op = 0;
        do
        {
            try
            {
                // Obtiene el valor que regresa la funcion Menu
                op = Menu();
                switch (op)
                {
                    case 1:
                        // Agrega contactos al diccionario de contactos
                        try
                        {
                            int isNumber = 0; 
                            Console.Write("Escribe el nombre del contacto: ");
                            string nom = Console.ReadLine();
                            Console.Write("Escribe el numero de '{0}': ", nom);
                            string num = Console.ReadLine();
                            // Valida que sea un numero telefonico de 10 digitos
                            if (num.Length == 10) { 
                                for(int i = 0; i < num.Length; i++)
                                {
                                    // Valida que cada uno de los valores ingresados sea un numero
                                    if (Char.IsLetter(num[i]))
                                        isNumber = 1;
                                }
                                // Si son puros numeros agrega el contacto a la agenda
                                if (isNumber == 0)
                                {
                                    agenda.Add(nom, num);
                                    Console.WriteLine("\nContacto '{0}' agregado", nom);
                                }
                                else
                                    Console.WriteLine("El numero no puede contener letras");
                            }
                            else
                                Console.WriteLine("El numero debe contener 10 digitos");
                            Console.ReadKey();
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("El contacto ya existe");
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        // Elimina contactos del diccionario de contactos
                        Console.Write("Escribe el nombre del contacto: ");
                        string elimina = Console.ReadLine();
                        // Verifica si el diccionario contiene la llave proporcionada
                        if (agenda.ContainsKey(elimina))
                        {
                            // Si la llave existe en el diccionario, elimina el contacto
                            Console.WriteLine("\nContacto eliminado:");
                            Console.WriteLine("\tNumbre: {0}\n\tNumero: {1}", elimina, agenda[elimina]);
                            agenda.Remove(elimina);
                        }
                        else
                        {
                            Console.WriteLine("El contacto '{0}' no existe ", elimina);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        // Busca contactos dentro del diccionario de contactos
                        Console.Write("Escribe el nombre del contacto: ");
                        string busca = Console.ReadLine();
                        // Verifica si el diccionario contiene la llave proporcionada
                        if (agenda.ContainsKey(busca))
                        {
                            // Si existe la llave, muestra la informacion del contacto
                            Console.WriteLine("\nResultado de la busqueda:");
                            Console.WriteLine("\tNumbre: {0}\n\tNumero: {1}", busca, agenda[busca]);
                        }
                        else
                        {
                            Console.WriteLine("Contacto no encontrado");
                        }
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Fin de la ejecucion");
                        // ban se vuelve 1, con esto se terminara la ejecucion del programa
                        ban = 1;
                        break;
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Valor invalido: " + e.Message);
                Console.ReadKey();
            }
        // Todo este bloque sera ejecutado mientras que la bariable ban sea 0 
        } while (ban == 0);

        Console.ReadKey();
    }
}