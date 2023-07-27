// Принять трехзначное число и выдать его вторую цифру
Console.Clear();
int num = new Random() .Next(100, 1000);
Console.WriteLine(num);
int result1 = (num % 100 / 10);
Console.WriteLine(result1);