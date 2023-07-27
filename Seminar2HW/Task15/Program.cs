// Выбрать день недели по цифре и определить выходной ли это

Console.Clear ();
Console.Write("Введите номер дня недели 1-7: ");
int NumberDayOfWeek = int.Parse(Console.ReadLine());

if (NumberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник");
}

if (NumberDayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
    
if (NumberDayOfWeek == 3)
{
    Console.WriteLine("Среда");
}

if (NumberDayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}

if (NumberDayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}

if (NumberDayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}

if (NumberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}

if (NumberDayOfWeek < 1 || NumberDayOfWeek > 7)
{
    Console.WriteLine("Неправильный номер");
    return;
}

if (NumberDayOfWeek <=7 && NumberDayOfWeek >= 6)
{
    Console.WriteLine("Ура, Выходной");
}