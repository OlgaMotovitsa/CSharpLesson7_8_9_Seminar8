// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumFor(int m, int n)
// {
//     int result = 0;
//     for (int i = m; i <= n; i++ ) result +=i;
//     return result;
// }
// System.Console.WriteLine((SumFor(4,8)));

int SumRec(int start, int end)
{
    while (start < 0)
    {
        start++;
    }
    if (start > end) return 0;
    else 
    return start + SumRec(start + 1, end);
}

System.Console.WriteLine((SumRec(4, 8)));






