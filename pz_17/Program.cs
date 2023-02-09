namespace pz_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Random((unsigned)TimeSpan(null));
            Console.WriteLine("Введите размерность массива:");
            Console.WriteLine("N = ");
            Console.ReadLine(N);
            int A = new int;
            int ptr = A; //Объявляем указатель на массив
            Console.WriteLine("Случайный массив [-100, 100]:");
            for (int i = 0; i < N; i++);
            {
                A[i] = -100 + (() % 201); //Заполняем массив случайными числами
                Console.WriteLine(ptr + i)" "; //Выводим массив с помощью указателя
            }
            
        }
    }
}