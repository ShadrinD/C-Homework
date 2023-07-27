// Вывести 3 цифру заданного числа или сказать что её нет
Console.Clear();
Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
while (num > 999)
{
    num /= 10;
}
int ThirdDigit = num % 10;
Console.WriteLine("3 цифра -> " + ThirdDigit);

