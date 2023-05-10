namespace pz_16
{
    using System;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            int[] numbers = File.ReadAllLines(inputPath).Select(int.Parse).ToArray();
            Array.Sort(numbers);

            File.WriteAllLines(outputPath, numbers.Select(n => n.ToString()));
        }
    }
}