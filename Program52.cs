//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res= new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             res[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return res ;
}
void PrintArray(int [,]arr1)
{
     for (int i = 0; i <arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write($"{arr1[i,j]} ");
        }
         Console.WriteLine();
    }
}
void ArithmeticMeanArray(int[,]arr1)
{
     for (int j = 0; j <arr1.GetLength(1); j++)
    {
        double sum =0;
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
        sum+=arr1[i,j];
        }
        Console.Write($"{ sum / arr1.GetLength(0)} ; ");
    }
}
int[,] array=GetArray(3,4,-2,10);
PrintArray(array);
ArithmeticMeanArray(array);