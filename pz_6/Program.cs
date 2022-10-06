using System;

namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру с которой начнём:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечную температуру:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг:");
            double z = double.Parse(Console.ReadLine());
            while (x <= y)
            {
                Console.WriteLine(x + " C^0 = " + 9.0 / 5.0 * x + 32 + " F^0");
                x += z;
            }
        }
    }
}