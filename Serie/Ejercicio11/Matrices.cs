using System;

/*
 * Programa que calcula realiza las operaciones Suma, Resta y Multiplicacion
 */
class Matrices
{
    static void Main(string[] args)
    {
        int tam;
        Console.Write("Escribe el tamaño de las matrices cuadradas (nxn)\nn: ");
        // Se lee el tamaño que tendran las matrices
        tam = Convert.ToInt32(Console.ReadLine());

        // Limpia la pantalla
        Console.Clear();
        Console.WriteLine("Valores de la Matriz 1");
        // Crea una matriz
        double[,] ma1 = new double[tam, tam];
        // Se almacenan los valores de la matriz llamando a la funcion AsignaValores
        MatrizN.AsignaValores(ref ma1);

        // Limpia la pantalla
        Console.Clear();
        Console.WriteLine("Valores de la Matriz 2");
        // Crea una matriz
        double[,] ma2 = new double[tam, tam];
        // Se almacenan los valores de la matriz llamando a la funcion AsignaValores
        MatrizN.AsignaValores(ref ma2);
            
        // El valor obtenido en el menu es almacenado en la variable
        int res = MatrizN.Menu();
        // Se limpia la pantalla
        Console.Clear();
        // Muestra los valores de las matrices
        Console.WriteLine("Matriz 1:");
        MatrizN.MuestraValores(ref ma1);
        Console.WriteLine("Matriz 2:");
        MatrizN.MuestraValores(ref ma2);
        Console.WriteLine();
        // Evalua el valor almacenado en la variable res
        switch (res)
        {
            case 1:
                Console.WriteLine("Resultado de la suma de matrices:");
                // Obtiene el valor de la suma llamando a la funcion SumaMatrices
                MatrizN.SumaMatrices(ref ma1, ref ma2);
                break;
            case 2:
                Console.WriteLine("Resultado de la resta de matrices");
                // Obtiene el valor de la resta llamando a la funcion RestaMAtrices
                MatrizN.RestaMatrices(ref ma1, ref ma2);
                break;
            case 3:
                Console.WriteLine("Resultado de la multiplicacion de matrices");
                // Obtiene el valor de la multiplicacion llamando a la funcion MultiplicaMatriz
                MatrizN.MultiplicaMatrices(ref ma1, ref ma2);
                break;
        }
        Console.ReadKey();
    }
}

static class MatrizN
{
    // Funcion que almacena los valores en las matrices
    static public void AsignaValores(ref double[,] matriz)
    {
        for (int i = 0; i < Math.Sqrt(matriz.Length); i++)
        {
            for (int j = 0; j < Math.Sqrt(matriz.Length); j++)
            {
                int ban = 0;
                // Realiza la validacion de los valores ingresados
                do
                {
                    try
                    {
                        // Se valida que el valor ingresado sea un numero
                        Console.WriteLine("Escribe el valor [{0},{1}]", i, j);
                        // Intenta Convertir el valor en double
                        matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                        ban = 1;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Escribe un valor valido " + e.Message);
                    }
                } while (ban == 0);
                    
            }
        }
    }
    // Funcion que nos muestra los valores almacenados en las matrices
    static public void MuestraValores(ref double[,] matriz)
    {
        double tam = Math.Sqrt(matriz.Length);
        for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                Console.Write(" " + matriz[i, j]);
            }
            Console.WriteLine();
        }
    }
    // Funcion que realiza la Suma de las matrices
    static public void SumaMatrices(ref double[,] m1, ref double[,] m2)
    {
        double tam = Math.Sqrt(m1.Length);
        for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                Console.Write(" " + (m1[i, j] + m2[i,j]));
            }
            Console.WriteLine();
        }
    }
    // Funcion que realiza la resta de las matrices
    static public void RestaMatrices(ref double[,] m1, ref double[,] m2)
    {
        double tam = Math.Sqrt(m1.Length);
        for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                Console.Write(" " + (m1[i, j] - m2[i, j]));
            }
            Console.WriteLine();
        }
    }
    // Funcion que realiza la multiplicacion de las matrices
    static public void MultiplicaMatrices(ref double[,] m1, ref double[,] m2)
    {
        double resultado;
        double tam = Math.Sqrt(m1.Length);
        for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                resultado = 0;
                for(int k = 0; k< tam; k++)
                {
                    resultado += m1[i, k] * m2[k, j];
                }
                Console.Write(" " + resultado);
            }
            Console.WriteLine();
        }
    }
    // Funcion que despliega el menu de opciones de las operaciones que se pueden realizar
    static public int Menu()
    {
        int res = 0, ban = 0;
        Console.Clear();
        Console.WriteLine("Escoge una opcion:");
        Console.WriteLine("\t1:Suma");
        Console.WriteLine("\t2:Resta");
        Console.WriteLine("\t3:Multiplicacion");
        Console.WriteLine("\t3:Multiplicacion");
        Console.Write("Opcion: ");
        do
        {
            try
            {
                res = Convert.ToInt32(Console.ReadLine());
                if (res > 0 && res < 4)
                    ban = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Se ingreso un valor invalido: " + e.Message);
            }
        } while (ban == 0);
        return ;
    }
}

