namespace pz_24;
using System;

enum Speciality
{
    Programming,
    Design,
    Marketing
}

class Student : ICloneable
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

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}

class Graduate : Student, ICloneable
{
    public DateTime releaseDate;

    public new void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("Дата выпуска: " + releaseDate.ToShortDateString());
    }

    public new object Clone()
    {
        return this.MemberwiseClone();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graduate graduate1 = new Graduate();
        graduate1.name = "Богдан";
        graduate1.surname = "Шерганов";
        graduate1.patronymic = "Борисович";
        graduate1.dateOfBirth = new DateTime(2004, 11, 2);
        graduate1.yearOfStudy = 2021;
        graduate1.speciality = Speciality.Programming;
        graduate1.releaseDate = new DateTime(2024, 6, 30);

        Student.AddStudent(graduate1);

        Graduate graduate2 = (Graduate)graduate1.Clone();
        graduate2.name = "Петр";
        graduate2.surname = "Петров";
        graduate2.patronymic = "Петрович";
        graduate2.dateOfBirth = new DateTime(2001, 2, 2);
        graduate2.yearOfStudy = 2021;
        graduate2.speciality = Speciality.Design;
        graduate2.releaseDate = new DateTime(2025, 7, 31);

        Student.AddStudent(graduate2);

        Graduate graduate3 = (Graduate)graduate1.Clone();
        graduate3.name = "Сидор";
        graduate3.surname = "Сидоров";
        graduate3.patronymic = "Сидорович";
        graduate3.dateOfBirth = new DateTime(2002, 3, 3);
        graduate3.yearOfStudy = 2022;
        graduate3.speciality = Speciality.Marketing;
        graduate3.releaseDate = new DateTime(2026, 8, 31);

        Student.AddStudent(graduate3);

        Console.WriteLine("Информация о выпускниках после клонирования:");

        graduate1.PrintInfo();

        Console.WriteLine();

        graduate2.PrintInfo();

        Console.WriteLine();

        graduate3.PrintInfo();


    }
}