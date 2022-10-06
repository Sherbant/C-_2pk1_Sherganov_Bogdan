using System;

namespace pz_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число f: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double p;
            double t;

            if (b > 0)
            {
                p = f * Math.Cos(b * Math.PI / 180) / Math.Sqrt(Math.Pow(b, 2) - Math.Pow(f, 2));
            }
            else
            {
                p = 2 * f - Math.Sin(b * Math.PI / 180);
            }
            if (p > 0)
            {
                t = Math.Pow(Math.Sin(b * p), 2) - Math.Pow(Math.Cos(b - p), 2);
            }
            else
            {
                t = Math.Pow(Math.Sin(b * f), 2) - Math.Pow(Math.Cos(b + p), 2);
            }

            double r = 12 * b + 3 * p * Math.Pow(t, 2) + f;

            Console.WriteLine($"Число b: {b}");
            Console.WriteLine($"Число f: {f}");
            Console.WriteLine($"Число p: {p}");
            Console.WriteLine($"Число t: {t}");
            Console.WriteLine($"Число r: {r}");
        }
    }
}