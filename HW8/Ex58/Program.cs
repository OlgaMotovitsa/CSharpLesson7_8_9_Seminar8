// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] GetFirstArray (int rowLength, int colLength)
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
int [,] firstArray = GetFirstArray (2, 2);

int [,] GetSecondArray (int rowLength, int colLength)
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
int [,] secondArray = GetSecondArray (2, 2);


int[,] resultArray = new int[2, 2]; 
void MultiplyArrays(int[,] firstArray, int[,] secondArray)
{

  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum = sum + firstArray[i,k] * secondArray[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}
MultiplyArrays(firstArray, secondArray);

void Printarray (int [,] firstArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            Console.Write($"{firstArray[i, j]}  ");
        }
        Console.WriteLine();
    }
} 
Printarray(firstArray);
Console.WriteLine();
Printarray(secondArray);
Console.WriteLine();
Printarray(resultArray);
  
