//Получить последнее число от трехзначного
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int y = number % 10;

Console.WriteLine($"{y}");