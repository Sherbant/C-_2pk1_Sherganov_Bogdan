namespace pz_23
{
    using System;

    enum Speciality
    {
        Programming,
        Design,
        Marketing
    }

    class Student
    {
        public string name;
        public string surname;
        public string patronymic;
        public DateTime dateOfBirth;
        public int yearOfStudy;
        public Speciality speciality;

        private static int programmingStudentsCount = 0;
        private static int designStudentsCount = 0;
        private static int marketingStudentsCount = 0;

        public int GetCourse()
        {
            return DateTime.Now.Year - yearOfStudy;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Фамилия: " + surname);
            Console.WriteLine("Отчество: " + patronymic);
            Console.WriteLine("Дата рождения: " + dateOfBirth.ToShortDateString());
            Console.WriteLine("Год начала обучения: " + yearOfStudy);
            Console.WriteLine("Специальность: " + speciality);
            Console.WriteLine("Текущий курс обучения: " + GetCourse());
        }

        public static void AddStudent(Student student)
        {
            if (student.speciality == Speciality.Programming)
            {
                programmingStudentsCount++;
            }
            else if (student.speciality == Speciality.Design)
            {
                designStudentsCount++;
            }
            else if (student.speciality == Speciality.Marketing)
            {
                marketingStudentsCount++;
            }
        }

        public static void PrintSpecialitiesCount()
        {
            Console.WriteLine("Количество студентов по специальностям:");
            Console.WriteLine("Программирование: " + programmingStudentsCount);
            Console.WriteLine("Дизайн: " + designStudentsCount);
            Console.WriteLine("Маркетинг: " + marketingStudentsCount);
        }
    }

    class Graduate : Student
    {
        public DateTime releaseDate;

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Дата выпуска: " + releaseDate.ToShortDateString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Graduate graduate = new Graduate();
            graduate.name = "Богдан";
            graduate.surname = "Шерганов";
            graduate.patronymic = "Борисович";
            graduate.dateOfBirth = new DateTime(2004, 11, 2);
            graduate.yearOfStudy = 2021;
            graduate.speciality = Speciality.Programming;
            graduate.releaseDate = new DateTime(2024, 6, 30);

            Student.AddStudent(graduate);

            graduate.PrintInfo();

            Student.PrintSpecialitiesCount();
        }
    }
}