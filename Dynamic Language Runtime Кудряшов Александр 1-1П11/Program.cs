// Net 6.0
using System.Dynamic;
dynamic student = new ExpandoObject();
Console.Write("Введите фамилию: ");
student.Surname = Console.ReadLine() ?? "Нет значения";
Console.Write("Имя: ");
student.Name = Console.ReadLine() ?? "Нет значения";
Console.Write("Отчество: ");
student.Shortname = Console.ReadLine() ?? "Нет значения";
//Ссылка на группу->где-то тут
Console.Write("Дату рождения: ");
student.Data = Console.ReadLine() ?? "Нет значения";
Console.WriteLine("\nДанные студента: ");
foreach (var znach in (IDictionary<String, Object>)student)
{
    Console.WriteLine(znach.Value);
}
dynamic specialnost = new ExpandoObject();
Console.Write("Название: ");
specialnost.Nazvanie = Console.ReadLine() ?? "Нет значения";
Console.Write("Сокращение: ");
specialnost.Sokrash = Console.ReadLine() ?? "Нет значения";
Console.WriteLine("\nДанные специальности: ");
foreach (var znach in (IDictionary<String, Object>)specialnost)
{
    Console.WriteLine(znach.Value);
}
dynamic para = new ExpandoObject();
Console.Write("Время начала пары: ");
para.NachPar = Console.ReadLine() ?? "Нет значения";
Console.Write("Время окончания пары: ");
para.OkonchPar = Console.ReadLine() ?? "Нет значения";
Console.Write("Время начала перерыва: ");
para.NachPer = Console.ReadLine() ?? "Нет значения";
Console.Write("Время окончания перерыва: ");
para.OkonchPer = Console.ReadLine() ?? "Нет значения";
//Ссылка на смену -> где-то тут 
Console.WriteLine("\nДанные пары: ");
foreach (var znach in (IDictionary<String, Object>)para)
{
    Console.WriteLine(znach.Value);
}
dynamic smena = new ExpandoObject();
Console.Write("Название: ");
smena.Name = Console.ReadLine() ?? "Нет значения";
Console.WriteLine("\nДанные смены: ");
foreach (var znach in (IDictionary<String, Object>)smena)
{
    Console.WriteLine(znach.Value);
}
