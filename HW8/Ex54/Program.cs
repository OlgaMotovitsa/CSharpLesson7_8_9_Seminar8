// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] GetRandomArray (int rowLength, int colLength)
{
    int [,] array = new int [rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
int [,] Array = GetRandomArray (3, 4);


void Printarray (int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}  ");
        }
        Console.WriteLine();
    }
} 
Printarray(Array);

void ArrangeElementsInRows(int[,] dimensArray)
{
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    for (int j = 0; j < Array.GetLength(1); j++)
    {
      for (int k = 0; k < Array.GetLength(1) - 1; k++)
      {
        if (Array[i, k] < Array[i, k + 1])
        {
          int temp = Array[i, k + 1];
          Array[i, k + 1] = Array[i, k];
          Array[i, k] = temp;
        }
      }
    }
  }
}

Console.WriteLine();
ArrangeElementsInRows(Array);
Printarray(Array); 