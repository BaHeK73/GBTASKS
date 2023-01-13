// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5


using static System.Console;
Clear();

Write("Введите число: ");
int.TryParse(ReadLine()!, out int number);

WriteLine($"Колмчество цифр в числе {number}: {CountNum(number)}");


int CountNum(int num)
{
    int digits = 0;
    while (num > 0)
    {
        digits++;
        num /=10;
    }
    return digits;
}

