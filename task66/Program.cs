﻿// Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Write(output);
    return int.Parse(ReadLine()!);
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}