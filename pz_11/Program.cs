namespace pz_11
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Текст тут есть и он должен быть разделён. Надеюсь это получится";
            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(sentences, delegate (string x, string y) {
                return x.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length.CompareTo(y.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length);
            });

            Console.WriteLine(string.Join(". ", sentences));
        }
    }
}