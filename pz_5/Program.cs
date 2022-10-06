using System;

namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Задание");
            for (int i = 10; i <= 50; i += 6)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("2 Задание");
            for (char i = 'А'; i <= 'м'; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            Console.WriteLine("3 Задание");
            int n = 8;
            int m = 10;
            for (int i = 0; i < m; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine("4 Задание");
            int y = 0;
            for (int i = 0; i < 100; i++)
            {
                if (y == i % 20)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("5 Задание");

            for (int i = 0, j = 40; j - i != 10; i++, j--)
            {
                Console.WriteLine(i + "    " + j);
            }
        }
    }
}