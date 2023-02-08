// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArray(int[] X)
{
    for (int i = 0; i < X.Length; i++)
    {
        X[i]=new Random().Next(10);
    }
    return X;
}
int[] Array= new int[10];
Array=FillArray(Array);
Console.WriteLine(string.Join(",", Array));

int NegativeIndexSum=0;
for (int i = 1; i < Array.Length; i+=2)
{
    NegativeIndexSum+=Array[i];
}
Console.WriteLine(NegativeIndexSum);
