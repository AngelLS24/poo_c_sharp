using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.VisualBasic;

namespace Consola
{
    class Comandos
    {
        // Funcion que realiza la funcion de cd
        public static bool CdComand(string path)
        {
            // Obtiene la direccion del directorio acual
            string dir = Directory.GetCurrentDirectory();
            // valida si se establece un directorio 
            if (path != "..")
            {
                try
                {
                    // Intenta cambiar al directorio ingresado
                    Directory.SetCurrentDirectory(dir + @"\" + path);
                    // Retorna true
                    return true;
                }
                catch (Exception)
                {
                    // Si no puede cambiar al directorio despliega un mensaje
                    Console.WriteLine("El directorio '{0}' no existe", path);
                    // Retorna false
                    return false;
                }
            }
            // Si el comando es cd ..
            else
            {
                // Cambia de directorio un nivel arriba
                FileSystem.ChDir("..");
                // Retorna true
                return true;
            }
        }
        // Funcion que imprime el historial
        public static void HistoryCommand(List<string> history)
        {
            // Contador que nos dice el numero del comando
            int contador = 0;
            // Recorre la lista del historial
            foreach(var item in history)
            {
                // Aumenta el contador
                contador++;
                // Imprime el contador con el comando guardado
                Console.WriteLine("{0}: {1}", contador, item);
            }
        }
        // Funcion que nos ayuda a agregar valores a una lista
        public static void AddList(string tipo, string[] arr, ref List<string> contenido)
        {
            // Variable que nos ayuda a guardar el directorio/archivo
            string[] con;
            // Recorre el arreglo que recibe con los directorios/archivos
            foreach (var a in arr)
            {
                // Obtiene el nombre del directorio/archivo
                con = a.Split(@"\");
                // Agrega el directorio/archivo a la lista
                contenido.Add(tipo + con[^1]);
            }
        }
        // Funcion que lista los directorios/archivos
        public static void DirComand(string dir)
        {
            // Obtiene todos los archivos del directorio actual
            string[] archivos = Directory.GetFiles(dir);
            // Obtiene todos los directorios del directorio actual
            string[] directorios = Directory.GetDirectories(dir);
            // Lista que guardara todos los elementos listados
            List<string> contenido = new List<string>();
            // Llama a la funcion para agregar los elementos a la lista
            AddList("<FILE> ", archivos, ref contenido);
            // Llama a la funcion para agregar los elementos a la lista
            AddList("<DIR> ", directorios, ref contenido);
            // Ordena la lista
            contenido.Sort();
            // Recorre la lista e imprime el el elemento de la lista
            foreach (var c in contenido)
                Console.WriteLine(c);
        }
        // Funcion que nos ayuda a validar los comandos con sus argumentos
        public static string[] ValidaComando(string comando, int tam)
        {
            // Variable que nos ayuda a almacenar 
            string[] palabras;
            // Variable que almacena un arreglo con las palabras del comando
            string[] salida = new string[tam];
            // Variable que nos ayuda de contador
            int cont = 0;
            // Verifica si el comando tiene comillas
            if (comando.Contains('"'))
                // Separa el comando por comillas
                palabras = comando.Split('"');
            else
                // Si no tiene comillas lo separa por espacio
                palabras = comando.Split(" ");
            // Realiza un cliclo, este ciclo quita los espacios en blanco de las palabras separadas del comando
            for(int i = 0; i < palabras.Length; i++)
                palabras[i] = palabras[i].TrimEnd(' ');
            
            try
            {
                // Recorre las palabras almacenadas
                foreach (var p in palabras)
                {
                    // Verifica si no es un espacio en blanco
                    if (!p.Equals(""))
                    {
                        // Si no es un espacio en blanco lo agrega al arreglo de salida
                        salida[cont] = p;
                        // Incrementa el contador
                        cont++;
                    }
                }
            }
            // Si el comando tiene mas argumentos de los requeridos lanza una excepcion
            catch (IndexOutOfRangeException)
            {
                // Asigna un mensaje en el primer elemento del arreglo de salida
                salida[0] = "No se puede ingresar mas argumentos de los admitidos: " + (tam - 1);
            }
            // Retorna el arreglo de salida
            return salida;
        }
        // Funcion que crea archivos
        public static bool TouchComand(string path)
        {
            // Verifica que el archivo no exista
            if(!File.Exists(path))
            { 
                // Crea el archivo
                using(FileStream fs = File.Create(path))
                    // Cierra el archivo
                    fs.Close();
                // Retorna verdader
                return true;
            }
            // Si el archivo existe
            else
            {
                // Despliega un mensaje
                Console.WriteLine("El archivo '{0}' ya existe", path);
                // Retorna falso
                return false;
            }
        }
        // Funcion que mueve un archivo de carpeta
        public static bool MoveComand(string origen, string destino)
        {
            try
            {
                // Intenta mover un archivo de un origen a destino
                Directory.Move(origen, destino);
                // Retorna true
                return true;
            }
            // Si no puede moverlo lanza una excepcion
            catch (Exception)
            {
                // Despliega el mensaje 
                Console.WriteLine("Direccion invalida");
                // Retorna false
                return false;
            }
        }
    }
}
