//
//**Задача 1:**Напишите функцию, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4-> 16

int InPowerOf(string info)
{
    Console.Write(info);
    int Outcome = Convert.ToInt32(Console.ReadLine());
    return Outcome;
}

Console.Clear();
Console.WriteLine("Введите два числа:  ");
int rezult=1;
int a = InPowerOf("Число ");
int b = InPowerOf("Степень ");
for (int i = 0; i < b; i++)
{
    rezult *= a;
}
Console.WriteLine($"Натуральная степень ->  {rezult}");