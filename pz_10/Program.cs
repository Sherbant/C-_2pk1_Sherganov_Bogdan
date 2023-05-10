namespace pz_10
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к файлу: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                string[] directories = path.Split('\\');
                for (int i = 0; i < directories.Length - 1; i++)
                {
                    Console.WriteLine(directories[i]);
                }
            }
            else
            {
                Console.WriteLine("Указанный путь не существует.");
            }
        }
    }
}