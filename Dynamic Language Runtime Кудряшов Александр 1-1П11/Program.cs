// Net 6.0
using ClassLibrary1;
using System.Dynamic;

class Program
{
    internal static void Main()
    {
        static void Print(dynamic student)
        {
            Console.WriteLine("\n Данные студента: ");
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Familia);
            Console.WriteLine(student.Otchestvo);
            Console.WriteLine(student.Gryppa);
            Console.WriteLine(student.Otchestvo);
        }
        var student = CreateStudent();
        Print(student);

        static void Print1(dynamic specialnost)
        {
            Console.WriteLine("\n Данные группы: ");
            Console.WriteLine(specialnost.Nazvanie);
            Console.WriteLine(specialnost.Reduction);
        }
        var specialnost = CreateSpecialnost();
        Print1(specialnost);

        static void Print2(dynamic para)
        {
            Console.WriteLine("\n Данные специальности ");
        }
        var para = CreatePara();
        Print2(para);

        static void Print3(dynamic smena)
        {
            Console.WriteLine("\n Данные смены: ");
            Console.WriteLine(smena.Nazvanie);
        }
        var smena = CreateSmena();
        Print3(smena);
    }
    static ExpandoObject CreateStudent()
    {
        dynamic student = new ExpandoObject();
        Console.WriteLine("Введите фамилию студента: ");
        student.Familia = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите имя студента: ");
        student.Name = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите отчество студента: ");
        student.Otchectvo = Console.ReadLine() ?? "Нет значения";
        student.Gryppa = CreateGryppa();
        Console.WriteLine("Введите дату: ");
        student.Data = Console.ReadLine() ?? "Нет значения";
        return student;
    }
    static ExpandoObject CreateGryppa() 
    {
        dynamic gryppa = new ExpandoObject();
        Console.WriteLine("Введите название группы: ");
        gryppa.Name = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите сокращение названия группы: ");
        gryppa.Shortname = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите численность группы: ");
        gryppa.Chislennost = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите год поступления студента: ");
        gryppa.YearPostyp = Console.ReadLine() ?? "Нет значения";
        gryppa.Specialnost = CreateSpecialnost();
        gryppa.ClassLeader = CreateSotrydnik();
        return gryppa;
    }
    static Para CreatePara()
    {
        return new Para();
    }
    static ExpandoObject CreateSmena()
    {
        dynamic smena = new ExpandoObject();
        Console.WriteLine("Введите название смены: ");
        smena.Nazvanie = Console.ReadLine() ?? "Нет значения";
        return smena;
    }
    static ExpandoObject CreatePodrazdelenie()
    {
        dynamic podrazdelenie = new ExpandoObject();
        Console.WriteLine("Введите имя студента: ");
        podrazdelenie.Nazvanie = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите имя студента: ");
        podrazdelenie.Rykovoditel = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите имя студента: ");
        podrazdelenie.Organizacia = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите имя студента: ");
        return podrazdelenie;
    }
    static ExpandoObject CreateSotrydnik()
    {
        dynamic sotrydnik = new ExpandoObject();
        Console.WriteLine("Введите фамилию сотрудника: ");
        sotrydnik.Surname = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите имя сотрудника: ");
        sotrydnik.Name = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите отчество сотрудника: ");
        sotrydnik.Otchestvo = Console.ReadLine() ?? "Нет значения";
        sotrydnik.Doljnost = CreateDoljnost();
        return sotrydnik;
    }
    static ExpandoObject CreateSpecialnost()
    {
        dynamic specialnost = new ExpandoObject();
        Console.WriteLine("Введите название специальности: ");
        specialnost.Name = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите сокращение названия специальности: ");
        specialnost.Reduction = Console.ReadLine() ?? "Нет значения";
        return specialnost;
    }
    static Doljnost CreateDoljnost()
    {
        return new Doljnost();
    }
    static Organizacia CreateOrganizacia()
    {
        return new Organizacia();
    }
}
