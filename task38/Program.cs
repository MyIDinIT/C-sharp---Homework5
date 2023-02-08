// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.7; 7.2; 2.1; 7.8] -> 5.7


double[] FillArray(double[] X)
{
    for (int i = 0; i < X.Length; i++)
    {
        X[i]=new Random().NextDouble();
    }
    return X;
}

void SelectionSort(double[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
     int minPosition=i;
     for (int j = i+1; j <Arr.Length; j++)
     {
        if (Arr[j]<Arr[minPosition])
        minPosition=j;
     }   
    double temp=Arr[i];
    Arr[i]=Arr[minPosition];
    Arr[minPosition]=temp;
    }
}

double[] Array= new double[10];
Array=FillArray(Array);
Console.WriteLine(string.Join("|", Array));
SelectionSort(Array);
Console.WriteLine();
Console.WriteLine(string.Join("|", Array));

double Difference=Array[9]-Array[0];
Console.WriteLine(Difference);

