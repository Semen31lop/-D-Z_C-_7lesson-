int [,] GetArray (int m , int n , int minValue, int maxValue)
{
    int [,] res = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i,j]= new Random().Next(minValue,maxValue);
        }
    }
    return res;
}
void PrintArray(int[,]arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write($"{arr1[i,j]} ");
        }
          Console.WriteLine();
    }
}
int[,] array=GetArray(3,4,-10,10);
PrintArray(array);
Console.Write("Введите строку: ");
int pos1 = int.Parse(Console.ReadLine()!); 
Console.Write("Введите столбец: ");
int pos2 = int.Parse(Console.ReadLine()!); 

if (pos1 < array.GetLength(0) && pos2 < array.GetLength(1)) Console.WriteLine(array[pos1, pos2]);
else Console.WriteLine($"{pos1}{pos2} ->  числа в массиве нет");