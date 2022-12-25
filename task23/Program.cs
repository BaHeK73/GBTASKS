//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

using static System.Console;
Clear();

WriteLine("Введите число N: ");
int.TryParse(ReadLine(), out int N);
int i = 1;
while (i < N+1)
{
    Write($"n {i} ");
    i++;
}
