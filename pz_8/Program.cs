using System;

namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = 7;
            int b = 7;
            int x = 0;
            int[,] C = new int[a, b];
            Console.WriteLine("Массив:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    C[i, j] = rnd.Next(-50, 50);
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Побочная диагональ:");
            for (int i = 0, j = 6; i < a; i++, j--)
            {
                Console.Write(C[i, j] + " ");
                if (C[i, j] < 0)
                {
                    x++;

                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество отрицательных чисел = " + x);
        }
    }
}