using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_18
{
    internal class Enum
    {
        enum Marks
        {
            отлично = 5,
            хорошо = 4,
            удовлетворительно = 3,
            неудовлетворительно = 2,
            очень_плохо = 1
        }
        enum Seasons
        {
            winter,
            spring,
            summer,
            autumn
        }
        static void MarksWr(int rating)
        {
            switch (rating)
            {
                case 5:
                    Console.WriteLine("Характеристика отметки " + (int)Marks.отлично + ": Отлично");
                    break;
                case 4:
                    Console.WriteLine("Характеристика отметки " + (int)Marks.хорошо + ": Хорошо");
                    break;
                case 3:
                    Console.WriteLine("Характеристика отметки " + (int)Marks.удовлетворительно + ": Удовлетворительно");
                    break;
                case 2:
                    Console.WriteLine("Характеристика отметки " + (int)Marks.неудовлетворительно + ": Неудовлетворительно");
                    break;
                case 1:
                    Console.WriteLine("Характеристика отметки " + (int)Marks.очень_плохо + ": Очень плохо");
                    break;



            }
        }
        static void SeasonsWr(string season)
        {
            switch (season)
            {
                case "summer":
                    Console.WriteLine("Праздник в данный промежуток:\n" + "09.06 Международный день друзей\n" + "12.06 День принятия Декларации о государственном суверенитете Российской Федерации \n" + "13.06 Вознесение Господа Иисуса Христа\n" + "12.08 Международный день молодёжи, а также День Военно-воздушных сил.\n");
                    break;
                case "winter":
                    Console.WriteLine("Праздники в данный промежуток\n" + "01.01 Новый год\n" + "23.02 День защитника Отечества\n" + "13.01 - 14.01 Старый Новый Год\n" + "18.01 День прорыва блокады Ленинграда" + "14.02 День всех влюблённых\n");
                    break;
                case "spring":
                    Console.WriteLine("Праздники в данный промежуток\n" + "08.03 8 марта\n" + "09.04 Вербное воскресенье\n" + "16.04 Пасха\n" + "01.04 День дурака\n");
                    break;
                case "autumn":
                    Console.WriteLine("Праздники в данный промежуток\n" + "01.09 День знаний\n" + "06.10 День учителя\n" + "17.11 Международный день студента\n" + "31.10 Хэллоуин\n");
                    break;
            }
        }




        static void Main()
        {
            Console.WriteLine("Введите отметку:");
            int rating = Convert.ToInt32(Console.ReadLine());
            MarksWr(rating);
            Console.WriteLine("Введите время года:");
            string season = Console.ReadLine();
            SeasonsWr(season);
            Console.ReadLine();
        }
    }
}
