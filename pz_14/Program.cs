using System;

namespace pz_14
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            byte i = Convert.ToByte(Console.ReadLine());
            if (i == 1)
            {
                Console.WriteLine("Введите число от 1 до бесконечности:");
                int n = Convert.ToInt32(Console.ReadLine());
                int a = -8;
                int d = -3;
                GetRecursion(a, d, n);
            }
            else if (i == 2)
            {
                double b = 4;
                double q = -0.01;
                Console.WriteLine("Введите число:");
                int n = Convert.ToInt32(Console.ReadLine());
                GetGemrec(b, q, n);
            }
            else if (i == 3)
            {
                Console.WriteLine("Введите два положительных числа:");
                int A = Convert.ToInt32(Console.ReadLine());
                int B = Convert.ToInt32(Console.ReadLine());
                GetChisla(A, B);
            }
        }
        public static int GetRecursion(int a, int d, int n)
        {
            int result;
            if (n == 1)
            {
                result = a;
                Console.WriteLine(result);
                return result;
            }
            else
            {
                result = a + d;
                return GetRecursion(result, d, n - 1);
            }

        }
        public static double GetGemrec(double b, double q, int n)
        {

            double result;
            if (n == 1)
            {
                result = b;
                Console.WriteLine(result);
                return result;
            }
            else
            {
                result = b * q;
                return GetGemrec(result, q, n - 1);
            }
        }
        public static void GetChisla(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
                GetChisla(a - 1, b);
            }
            else if (a < b)
            {
                Console.WriteLine(a);
                GetChisla(a + 1, b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }

    }

}