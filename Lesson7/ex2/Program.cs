// вывести число от
// большего к меньшему, то итеративно подход принципиально отличаться не будет — придётся
// немного поправить условия. Соответственно, потребуется делать вывод от большего к
// меньшему и производить не инкремент счётчика, а декремент. В то же время, используя
// рекурсию, нам достаточно поменять саму собирающую строку. То есть мы будем прибавлять
// не слева, как это было в предыдущем примере, а справа.

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
       result += $"{i} "; 
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec( a + 1, b) + $"{a} ";
    else return String.Empty;
}

System.Console.WriteLine((NumbersFor(1, 10)));
System.Console.WriteLine((NumbersRec(1, 10)));