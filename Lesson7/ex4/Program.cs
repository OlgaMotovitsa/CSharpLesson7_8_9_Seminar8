﻿// Факториал числа
// . В нашем случае факториалом числа называется
// произведение чисел от 1 до n. Соответственно, используя итеративный подход, мы описываем
// функцию, принимающую значение того самого n, факториал которого требуется найти.
// Дальше заводим некоторую результирующую переменную, по умолчанию будет нейтральный
// по умножению элемент — 1. Далее идёт цикл от 1 до момента, пока i меньше или равно n.
// Соответственно, будем домножать результат на текущее значение i, а после этого —
// возвращать результат.
// Если у нас рекурсивный подход, обязательное условие выхода — то, что n, аргумент нашей
// функции, стал равен 1. В этом случае будем возвращать 1. Кстати, по-хорошему надо описать
// ещё и 0, потому что 0! тоже считается 1. И остальные условия, когда мы будем возвращать
// текущее значение n, умноженное на вызов рекурсивной функции с аргументом на 1 меньше. А
// результат будет одинаковым



int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n)
{
    if ( n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
System.Console.WriteLine(FactorialFor(10));
System.Console.WriteLine(FactorialRec(10));
