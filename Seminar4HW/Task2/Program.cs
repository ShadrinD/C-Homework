//Задача 2:**Напишите программу, которая принимает на вход число и
 //выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

//Важно: не использовать строки, использовать только арифметические действия


int Add(string info)
{
    Console.Write(info);
    int Outcome = Convert.ToInt32(Console.ReadLine());
    return Outcome;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int rezult = 0;
int a = Add(" ");
while (a > 0)
{
    rezult += a % 10;
    a = a / 10;
}
Console.WriteLine($"Сумма чисел: {rezult}");