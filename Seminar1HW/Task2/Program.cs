// Сравнить, какое из трех чиcел больше
Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max = 1;
if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}
Console.WriteLine($"{max} - Наибольшее число");