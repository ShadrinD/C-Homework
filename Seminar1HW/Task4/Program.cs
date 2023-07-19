//Из числа N показать все четные числа от 1 до N
Console.Clear();
int N = int.Parse(Console.ReadLine());
int B = 1;

while (B <= Math.Abs(N))
{
    int ost = B % 2;
    if (ost == 0)
        Console.Write($"{B} ");
    B++;
}