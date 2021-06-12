using System;
using System.Collections.Generic;

namespace _4.EstructurasDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vector (arreglo de una dimensión)");
            string[] dias = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

            Console.WriteLine("Vector de Largo: " + dias.Length);

            Console.WriteLine("\n==== UN VALOR ======");
            Console.WriteLine(dias[0]);


            Console.WriteLine("\n==== RECORRIDO CON FOR ====");
            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine(dias[i]);
            }

            Console.WriteLine("\n==== RECORRIDO CON FOREACH ====");

            foreach (string dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.WriteLine("\n\nMatriz (arreglo multidimensional)");
            int[,] sala = new int[8, 10];
            Random a = new Random();

            Console.WriteLine("Matriz de {0}x{1}", sala.GetLength(0), sala.GetLength(1) );

            Console.WriteLine("\n ==== UN VALOR ====");
            Console.WriteLine(sala[0, 0]);

            Console.WriteLine("\n==== RECORRIDO CON FOR ====");
            for (int f = 0; f < sala.GetLength(0); f++)
            {
                for (int c = 0; c < sala.GetLength(1); c++)
                {
                    sala[f, c] = a.Next(0, 2);
                    Console.Write(sala[f,c]+" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n\nListas");
            List<string> colores = new List<string>();

            colores.Add("rojo");
            colores.Add("azul");
            colores.Add("verde");

            Console.WriteLine("\n==== UN ELEMENTO ====");
            Console.WriteLine(colores[0]);

            Console.WriteLine("\n ==== RECORRIDO CON FOREACH ====");
            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            colores.Add("Amarillo");
            imprimirLista(colores);

            colores.Insert(0, "Blanco");
            imprimirLista(colores);

        }

        public static void imprimirLista(List<string> lista)
        {
            Console.WriteLine("\nImprimiendo lista...");
            Console.WriteLine("Total elementos: " + lista.Count);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
