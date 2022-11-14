using System.Security.Cryptography;

namespace pz_10;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число, которое хотите возвести в 2, 3, 4 степень ");
        double A1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число, которое хотите возвести в 2, 3, 4 степень ");
        double A2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число, которое хотите возвести в 2, 3, 4 степень ");
        double A3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите четвертое число, которое хотите возвести в 2, 3, 4 степень ");
        double A4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите пятое число, которое хотите возвести в 2, 3, 4 степень ");
        double A5 = Convert.ToInt32(Console.ReadLine());
        Power234(A1);
        Power234(A2);
        Power234(A3);
        Power234(A4);
        Power234(A5);
    }
    static void Power234(double A)
    {
        double B, C, D;
        Console.WriteLine($"A = {A}");
        Console.WriteLine($"A в 2 = {B = Math.Pow(A, 2)}");
        Console.WriteLine($"A в 3 = {C = Math.Pow(A, 3)}");
        Console.WriteLine($"A в 4 = {D = Math.Pow(A, 4)}");
    }
}