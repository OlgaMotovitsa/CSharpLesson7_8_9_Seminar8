// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] randomArray1 = GetRandomArray (2, 2);
int [,] randomArray2 = GetRandomArray (2, 2);


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


int[,] resultArray = new int[2, 2]; 

MultiplyArrays(randomArray1, randomArray2);

void MultiplyArrays(int[,] randomArray1, int[,] randomArray2)
{

  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < randomArray1.GetLength(1); k++)
      {
        sum = sum + randomArray1[i,k] * randomArray2[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}


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
Printarray(randomArray1);
Console.WriteLine();
Printarray(randomArray2);
Console.WriteLine();
Printarray(resultArray);
  
