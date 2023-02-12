// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.


/* Задайте двумерный массив. Напишите программу,
 которая поменяет местами первую и последнюю строку массива.*/


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
      int firstArr = arr[0,i];
      arr[0,i] = arr[arr.GetLength(0) - 1, i];
      arr[arr.GetLength(0) - 1, i] = firstArr;
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

int[,] ChangeOrder(int[,] matr)
{
    int[,] arr = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[i,j] = matr[j, i];
        }
    }
    return arr;
}
static int[,] WriteMatr(int k, int l)
{
    int[,] matr = new int[k, l];
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}