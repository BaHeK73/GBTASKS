// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

using static System.Console;

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);

while (a % 2 != 1)
{
    Write($"{a} ");
    a = a + 1;
}
