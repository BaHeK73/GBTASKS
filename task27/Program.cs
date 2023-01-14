// Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

using static System.Console;
Clear();

Write("Введите число: ");
int.TryParse(ReadLine()!, out int number);
WriteLine($"Сумма цифр в числе {number} = {SumNum(number)}");


int SumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num%10;
        num /=10;
    }
    return sum;
}