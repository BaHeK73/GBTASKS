// Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

using static System.Console;
Clear();

WriteLine("Введите число A: ");
int.TryParse(ReadLine()!, out int A);
WriteLine("Введите степень в которую нужно возвести число: ");
int.TryParse(ReadLine()!, out int B);
WriteLine($"Число {A} в степени {B} = {DegreeNum(A, B)}");

int DegreeNum(int a, int b)
{
    int result = 1;
    int i = 1;
    for(i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
