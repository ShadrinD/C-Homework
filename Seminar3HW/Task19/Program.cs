// Задача 19: Напишите программу,которая принимает
//  на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

int num, ost, sum = 0, temp;
Console.Write("Введите пятизначное число:");
num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    for (temp = num; num != 0; num = num / 10)
    {
        ost = num % 10;
        sum = sum * 10 + ost;
    }
    if (temp == sum)
        Console.Write($"{temp} является палиндромом");
    else
        Console.Write($"{temp} не является палиндромом");
}
else
    Console.Write("Введите пятизначное число");