/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

using System;
using static System.Console;

Clear();

int count = GetInt("Введите число ");
int numbers = 1;
PrintNumber(count, numbers);

void PrintNumber(int n, int count)
{
    if (count > n) return;
    PrintNumber(n, count + 1);
    Console.Write(count + ", ");
}

int GetInt(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}