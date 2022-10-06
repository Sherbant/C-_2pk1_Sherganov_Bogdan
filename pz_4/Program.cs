using System;

namespace pz_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость ветра:");
            int x = int.Parse(Console.ReadLine());
            int y = 0;
            if (x > 0 && x < 5)
            {
                y = 1;
            }
            if (x > 4 && x < 11)
            {
                y = 2;
            }
            if (x > 10 && x < 19)
            {
                y = 3;
            }
            if (x > 18)
            {
                y = 4;
            }
            switch (y)
            {
                case 1:
                    {
                        Console.WriteLine("Слабый");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Умеренный");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Сильный");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Ураган");
                        break;
                    }
            }

        }
    }
}