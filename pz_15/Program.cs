using System;
using System.IO;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("input.txt"))
            {
                Console.WriteLine("Файл input.txt не существует");
                Environment.Exit(1);
            }

            string[] lines = new string[0];

            try
            {
                lines = File.ReadAllLines("input.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка при чтении: ", e);
                Environment.Exit(1);
            }

            foreach (string line in lines)
            {
                if (line[0] == line[line.Length - 1])
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}