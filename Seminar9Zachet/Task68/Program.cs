/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

using System;
using static System.Console;

Clear();


int M = Get_int("Введите M: ");
int N = Get_int("Введите N: ");
WriteLine($"Результат вычисления функции Аккермана = {AkkermanMethod(M,N)} ");


int AkkermanMethod(int M, int N)
{
    if (M == 0) 
        return N + 1;
    else 
        if (N == 0) 
            return AkkermanMethod(M - 1, 1);
        else 
            return AkkermanMethod(M - 1, AkkermanMethod(M, N - 1));
}

int Get_int(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}