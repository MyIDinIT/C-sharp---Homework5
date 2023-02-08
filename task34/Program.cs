// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray(int[] X)
{
    for (int i = 0; i < X.Length; i++)
    {
        X[i]=new Random().Next(100,1000);
    }
    return X;
}
int[] Array= new int[10];
Array=FillArray(Array);
Console.WriteLine(string.Join(",", Array));

int PositiveSum=0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i]%2==0) PositiveSum+=Array[i];
}
Console.WriteLine(PositiveSum);
