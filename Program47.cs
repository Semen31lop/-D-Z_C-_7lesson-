//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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
//Console.WriteLine("");
//int nom = int.Parse(Console.ReadLine()!);
//Console.WriteLine("");
//int mon = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(3,4,-5,5);
PrintArray(array);