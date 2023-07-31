/**Задача 3:** Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] arr = new double[8];
FillArray(arr);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(GetCount(arr));

void FillArray(double[] coll)
{
    for (int i = 0; i < coll.Length; i++)
    {
        coll[i] = new Random().NextDouble()*10;
    }
}

double GetCount(double[] arr)
{
    double max_i=Math.Round(arr[0],2), min_i = Math.Round(arr[0],2); 
   for (int i=1; i<arr.Length; i++ )
   {
    arr[i]=Math.Round(arr[i],2); 
    if (arr[i]>max_i) max_i=arr[i];
    if (arr[i]<min_i)  min_i=arr[i];
    Console.WriteLine($"{arr[i]} - {max_i} vs {min_i}"); 
   }
     return  Math.Round(max_i-min_i,2);
}