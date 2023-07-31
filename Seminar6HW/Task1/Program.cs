/***Задача 1:** Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3*/

Console.Clear();
Console.Write("Введите несколько чисел: ");
int length = Convert.ToInt32(Console.ReadLine());
int col=0;
for (int i = 0; i < length; i++)
{
Console.Write($"Введите {i+1} число:  ");
if (Convert.ToInt32(Console.ReadLine()) > 0) col++;
}
Console.WriteLine($"Количество чисел больше нуля:  {col}");