// Вывести 3 цифру заданного числа или сказать что её нет
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num / 100 > 1)
{
    int result = (num % 10);
    Console.WriteLine(result);
}
else {
    Console.WriteLine("Неправильное число");
    return;
}

