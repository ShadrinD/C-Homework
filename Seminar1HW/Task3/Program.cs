//Является ли число четным
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int ost = a % 2;
if (ost == 0)
{
    Console.WriteLine($"{a} - четное число");
}
if (ost != 0)
{
    Console.WriteLine($"{a} - нечетное число");
}
