using System;
using System.IO;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        // Variable que guarda una cadena de la forma C:\Users\user\
        public static string path = @"C:\Users\" + Environment.UserName + @"\";
        static void Main()
        {
            // Lista que guardara los comandos ejecutados
            List<string> history = new List<string>();
            // Variable que almacena un valor booleano, esta variable mantendra el programa ejecutandose
            bool continua = true;
            // Variable que va a almacenar lo introducido por el usuario
            string comando;
            // Este bloque permite establecer la direccion
            try
            {
                // Se optiene el directorio Documents o Documentos
                string[] dir = Directory.GetDirectories(path, "Document*s?", SearchOption.TopDirectoryOnly); 
                // Si solo existe un elemento en la variable dir, usara ese elemento para establecer el directorio
                if(dir.Length == 1)
                    Directory.SetCurrentDirectory(dir[0]);
                // Si existen dos carpetas, Documentos y Documents se establece la direccion guardada en path
                else
                    Directory.SetCurrentDirectory(path);
            }
            // Si no encuentra ninguna de las direcciones establecidas arriba, manda un error
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("No se encontro del directorio {0}", path);
            }

            // Este bloque ejecuta todo el programa
            do
            {
                // Imprime la direccion actual del directorio
                Console.Write("{0}> ", Directory.GetCurrentDirectory());
                // Lee el comando
                comando = Console.ReadLine();
                // Separa el comando por espacios
                string[] palabras = comando.Split(" ");
                // Variable que nos ayuda a validar los comandos
                string[] valida;
                // Obtiene el comando y lo evalua
                switch (palabras[0])
                {
                    case "dir":
                        // Valida que el comando escrito solo reciba 2 argumentos
                        valida = Comandos.ValidaComando(comando, 2);
                        // Si la primera palabra es el comando se ejecuta lo siguiente
                        if (valida[0].Equals("dir"))
                        {
                            try
                            {
                                // Obtiene el directorio actual
                                string dir = Directory.GetCurrentDirectory();
                                // Verifica si recibe algun argumento
                                if (String.IsNullOrEmpty(valida[1]))
                                    // Llama a la funcion que cambia de directorio
                                    Comandos.DirComand(dir);
                                // Si recibe una carpeta como argumento
                                else
                                    // Se ejecuta el comando dir sobre el directorio ingresado
                                    Comandos.DirComand(dir + @"\" + valida[1]);
                                // Agrega el comando a la lista del historial
                                history.Add(comando);
                            }
                            // Si no existe el directorio que se pasa como argumento manda una excepcion
                            catch (DirectoryNotFoundException)
                            {
                                Console.WriteLine("El directorio '{0}' no existe", valida[1]);
                            }
                        }
                        // Si no es el comando, es un mensjare y se imprime
                        else
                            Console.WriteLine(valida[0]);
                        // Termina la ejecucion del bloque
                        break;
                    case "cd":
                        // Valida que el comando escrito solo reciba 2 argumentos
                        valida = Comandos.ValidaComando(comando, 2);
                        // Si la primera palabra es el comando se ejecuta lo siguiente
                        if (valida[0].Equals("cd"))
                        {
                            // Verifica si recibe algun argumento que no sea nulo
                            if (!String.IsNullOrEmpty(valida[1]))
                            { 
                                // Llama a la funcion que retornara un valor booleano
                                if (Comandos.CdComand(valida[1]))
                                {
                                    // Verifica si lo ingresado tiene comillas
                                    if (valida[1].Contains(" "))
                                        // Agrega el comando a la lista del historial
                                        history.Add(valida[0] + " \"" + valida[1] + "\"");
                                    else
                                        // Agrega el comando a la lista del historial
                                        history.Add(valida[0] + " " + valida[1]);
                                }
                            }else
                                Console.WriteLine("Se debe especificar el directorio al que se quiere cambiar");
                        }
                        else
                            Console.WriteLine(valida[0]);
                        // Termina la ejecucion del bloque
                        break;
                    case "touch":
                        // Valida que el comando escrito solo reciba 2 argumentos
                        valida = Comandos.ValidaComando(comando, 2);
                        // Si la primera palabra es el comando se ejecuta lo siguiente
                        if (valida[0].Equals("touch"))
                        {
                            // Llama a la funcion que retornara un valor booleano
                            if (Comandos.TouchComand(valida[1]))
                                // Agrega el comando a la lista del historial
                                history.Add(valida[0] + " " + valida[1]);
                        }
                        else
                            Console.WriteLine(valida[0]);
                        // Termina la ejecucion del bloque
                        break;
                    case "move":
                        // Valida si el comando tiene comillas, las comillas son ingresadas para las 
                        // carpetas con espacios
                        if (comando.Contains('"'))
                        {
                            // Valida que el comando escrito solo reciba 2 argumentos
                            valida = Comandos.ValidaComando(comando, 2);
                            // Separara el valor de valida[0] por los espacios
                            string[] pal = Comandos.ValidaComando(valida[0], 2);
                            // Si la primera palabra es el comando se ejecuta lo siguiente
                            if (pal[0].Equals("move"))
                            {
                                // Llama a la funcion que retornara un valor booleano
                                if (Comandos.MoveComand(pal[1], valida[1]))
                                    // Agrega el comando a la lista del historial
                                    history.Add(pal[0] + " " + pal[1] + " \"" + valida[1] + "\"");
                            }
                            else
                                Console.WriteLine(valida[0]);
                        }
                        else
                        {
                            // Valida que el comando escrito solo reciba 3 argumentos
                            valida = Comandos.ValidaComando(comando, 3);
                            // Si la primera palabra es el comando se ejecuta lo siguiente
                            if (valida[0].Equals("move"))
                            {
                                // Llama a la funcion que retornara un valor booleano
                                if (Comandos.MoveComand(valida[1], valida[2]))
                                    // Agrega el comando a la lista del historial
                                    history.Add(valida[0] + " " + valida[1] + " " + valida[2]);
                            }
                            else
                                Console.WriteLine(valida[0]);
                        }
                        // Termina la ejecucion del bloque
                        break;
                    case "history":
                        // Agrega el comando a la lista del historial
                        history.Add(palabras[0]);
                        // Llama a la funcion que imprime el historial de comandos 
                        Comandos.HistoryCommand(history);
                        break;
                    case "cls":
                        // Agrega el comando a la lista del historial
                        history.Add(palabras[0]);
                        // Limpia la pantalla 
                        Console.Clear();
                        // Termina la ejecucion del bloque
                        break;
                    case "exit":
                        // La bandera se vuelve false y con eso termina el programa
                        continua = false;
                        // Termina la ejecucion del bloque
                        break;
                    default:
                        Console.WriteLine("Comando '{0}' no existe", palabras[0]);
                        // Termina la ejecucion del bloque
                        break;
                }
            } while (continua);
        }
    }
}