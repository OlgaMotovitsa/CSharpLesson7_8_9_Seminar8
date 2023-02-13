
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9

int GetNumberM(string message)
{
    Console.WriteLine(message);
    int M = int.Parse(Console.ReadLine()!);
    return M;
}
int numberM = GetNumberM("Введите число M:"); 

int GetNumberN(string message)
{
    Console.WriteLine(message);
    int N = int.Parse(Console.ReadLine()!);
    return N;
}
int numberN = GetNumberN("Введите число N:"); 

int AkkermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberN == 0 && numberM > 0) 
    {
        return AkkermanFunction (numberM - 1, 1);
    }
    else if (numberM > 0 && numberN > 0) 
    {
    return  AkkermanFunction(numberM - 1, AkkermanFunction(numberM, numberN - 1));    
    }
    return AkkermanFunction (numberM, numberN);
}
int AkkermanResult = AkkermanFunction (numberM, numberN);
Console.WriteLine ($"M = {numberM} N = {numberN} -> A(m, n) = {AkkermanResult}.");