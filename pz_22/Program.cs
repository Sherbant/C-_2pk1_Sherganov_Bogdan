using pz_22;

namespace pz_22
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
            return DateTime.Now.Year - yearOfStudy + 1;
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
            student.speciality = Speciality.Programming;

            Student.AddStudent(student);

            student.PrintInfo();

            Student.PrintSpecialitiesCount();
        }
    }
}