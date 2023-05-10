namespace pz_21
{
    using System;

    class Student
    {
        public string name;
        public string surname;
        public string patronymic;
        public DateTime dateOfBirth;
        public int yearOfStudy;
        public string speciality;

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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Богдан";
            student.surname = "Шерганов";
            student.patronymic = "Борисович";
            student.dateOfBirth = new DateTime(2004, 11, 2);
            student.yearOfStudy = 2021;
            student.speciality = "Программирование";

            student.PrintInfo();
        }
    }
}