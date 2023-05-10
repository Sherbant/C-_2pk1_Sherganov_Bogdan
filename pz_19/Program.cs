using System;
using System.IO;
using System.Text.RegularExpressions;

namespace pz_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("text.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            //Console.WriteLine(reader.ReadToEnd());


            string text = reader.ReadToEnd();
            file.Close();

            //Console.WriteLine(text);
            string Pattern = @"([А-Я][а-я]+\s?[А-Я][а-я]+)\s[+7]";

            Regex regex = new Regex(Pattern);
            foreach (Match match in regex.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
            //Console.WriteLine(names);

        }
    }
}
