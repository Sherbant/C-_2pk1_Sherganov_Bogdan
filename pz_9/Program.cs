using System;
using System.Linq;

namespace PZ_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВАРИАНТ 26\n");
            Random random = new Random();
            int size = random.Next(7, 26);
            string[][] array = new string[5][];
            int k = 0;
            Console.WriteLine("1.2. Зубчатый массив");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = new string[k = random.Next(7, 26)];

                for (int j = 0; j < k; j++)
                {
                    array[i][j] = random.Next(7, 26).ToString();
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("3.Последние элементы строк зуб. массива: ");
            string[] arrayEnd = new string[5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                arrayEnd[i] = array[i][array[i].Length - 1];
                Console.Write(arrayEnd[i] + " ");
            }
            Console.WriteLine();


            Console.WriteLine("4.Максимальные элементы зуб. массива: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write((arrayEnd[i] = array[i].Max() + " "));
            }
            Console.WriteLine();


            Console.WriteLine("5.Зуб. массив, где первый элемент и максимальный поменялись местами: ");
            string firstValue = "";
            string maxValue = "";
            for (int i = 0, j = 0; i < array.GetLength(0); i++)
            {
                maxValue = array[i].Max();
                int index = Array.IndexOf(array[i], maxValue);
                firstValue = array[i][j];
                array[i][j] = array[i].Max();
                array[i][index] = firstValue;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("6.Перевернутый зуб. массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = array[i].Length - 1; j >= 0; j--)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("(b)Колличество элементов в каждой строке: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{i + 1}:{array[i].Length}  ");
            }
            Console.WriteLine();

        }
    }
}
