namespace pz_27

{
    public struct Note
    {
        public string Name;
        public string Tele;
        public DateTime Bday;

        public Note(string name, string tele, DateTime bday)
        {
            Name = name;
            Tele = tele;
            Bday = bday;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Note> blocknote = new List<Note>();
            Console.WriteLine("Введите данные 8 человек:");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Имя, фамилия: ");
                string name = Console.ReadLine();
                Console.Write("Номер телефона: ");
                string tele = Console.ReadLine();
                Console.Write("День рождения (дд.мм.гггг): ");
                DateTime bday = DateTime.Parse(Console.ReadLine());
                blocknote.Add(new Note(name, tele, bday));
            }
            blocknote.Sort((x, y) => x.Name.CompareTo(y.Name));
            Console.Write("Введите месяц (число): ");
            int month = int.Parse(Console.ReadLine());
            bool found = false;
            foreach (Note note in blocknote)
            {
                if (note.Bday.Month == month)
                {
                    Console.WriteLine("{0} {1} {2}", note.Name, note.Tele, note.Bday.ToString("dd.MM.yyyy"));
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("Нет людей с месяцем рождения в этом месяце.");
        }
    }
}