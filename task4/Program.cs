// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine());

WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine());

WriteLine("Введите третье число: ");
int c = int.Parse(ReadLine());

int max = 0;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Write("max = ");
WriteLine(max);