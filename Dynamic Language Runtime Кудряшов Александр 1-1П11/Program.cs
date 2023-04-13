// Net 6.0
using ClassLibrary1;
using Dynamic_Language_Runtime_Кудряшов_Александр_1_1П11;
using System.Dynamic;

class Program
{
    internal static void Main()
    {
        static void Print(dynamic student)
        {
            Console.WriteLine("\nДанные студента: ");
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Familia);
            Console.WriteLine(student.Surname);
            Console.WriteLine(student.Gryppa);
            Console.WriteLine(student.Data);
        }
        var student = CreateStudent();
        Print(student);

        static void Print1(dynamic specialnost)
        {
            Console.WriteLine("\nДанные специальности: ");
            Console.WriteLine(specialnost.Name);
            Console.WriteLine(specialnost.Reduction);
        }
        var specialnost = CreateSpecialnost();
        Print1(specialnost);
        static void Print2(dynamic para)
        {
            Console.WriteLine("\nДанные пары: ");
            Console.WriteLine(para.Nachpar);
            Console.WriteLine(para.Okonchpar);
            Console.WriteLine(para.Nachper);
            Console.WriteLine(para.Okonchper);
            Console.WriteLine(para.Smena);
        }
        var para = CreatePara();
        Print2(para);

        static void Print3(dynamic smena)
        {
            Console.WriteLine("\nДанные смены: ");
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
        student.Surname = Console.ReadLine() ?? "Нет значения";
        student.Gryppa = CreateGryppa();
        Console.WriteLine("Введите дату: ");
        student.Data = Console.ReadLine() ?? "Нет значения";
        return student;
    }
    static Gryppa CreateGryppa() 
    {
        return new Gryppa();
    }
    static ExpandoObject CreatePara()
    {
        dynamic para = new ExpandoObject();
        Console.WriteLine("\nВведите время начала пары: ");
        para.Nachpar = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите время конца пары: ");
        para.Okonchpar = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите время начала перерыва: ");
        para.Nachper = Console.ReadLine() ?? "Нет значения";
        Console.WriteLine("Введите время конца перерыва: ");
        para.Okonchper = Console.ReadLine() ?? "Нет значения";
        para.Smena = "Первая";
        return para;
    }
    static ExpandoObject CreateSmena()
    {
        dynamic smena = new ExpandoObject();
        Console.WriteLine("\nВведите название смены: ");
        smena.Nazvanie = Console.ReadLine() ?? "Нет значения";
        return smena;
    }
    static Podrazdelenie CreatePodrazdelenie()
    {
        return new Podrazdelenie();
    }
    static ExpandoObject CreateSotrydnik()
    {
        dynamic sotrydnik = new ExpandoObject();
        Console.WriteLine("\nВведите фамилию сотрудника: ");
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
        Console.WriteLine("\nВведите название специальности: ");
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
