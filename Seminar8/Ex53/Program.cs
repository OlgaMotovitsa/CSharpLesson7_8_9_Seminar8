// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.


Random rnd = new Random();
int[,] matrix = Generate2DArray(rnd.Next(3, 6), rnd.Next(3, 6));
Print2DArray(matrix);
ChangeArray(matrix);
System.Console.WriteLine();
System.Console.WriteLine();
Print2DArray(matrix);

void ChangeArray(int[,] arr)
{
      for(int i = 0; i < arr.GetLength(1); i++)
    {
        for(int j = 0; j < arr.GetLength(0); j++)
        {
            int firstArr = arr[0,i];
            arr[0,i] = arr[arr.GetLength(0) - 1, i];
            arr[arr.GetLength(0)- 1, i ] = firstArr;
        }
    }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i =0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1,10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}