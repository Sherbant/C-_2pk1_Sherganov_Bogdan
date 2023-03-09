namespace pz_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("25 вариант\n");
            }
            double rul_lenght = 7; /* Длина рулона */
            double rul_width = 1; /* Ширина рулона */
            double wall_height = 3; /* Высота стены */
            double room_width = 4; /* Ширина комнаты */
            double room_lenght = 6.0; /* Длина комнаты */
            int rul_count = (int)Math.Ceiling(((room_width + room_lenght) * 2) / ((int)Math.Truncate(rul_lenght / wall_height) * rul_width)); /* Необходимое количество рулонов */
            double ostatok_percent = 100.0 * (1 - ((room_width + room_lenght) * 2 * wall_height) / (rul_count * rul_lenght * rul_width)); /* Общий остаток в процентах к площади рулонов */

            Console.WriteLine($"Кол во рулонов:{rul_count} , % {ostatok_percent}");

        }
    }
}