//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

using static System.Console;
Clear();

WriteLine("Введите число N: ");
int N = int.Parse(ReadLine()!);
int i = 1;
int table = N > 0? N : i - N + 1;

string line_1 = "- - -";
string line_2 = "| N ";
string line_3 = "| N^3 ";

int x = 1;
while(x <= table)
{
    double cub = Math.Pow(i, 3);
    int count_cub = cub.ToString().Length;
    int count_table = i.ToString().Length;

    line_1 += new string('-', count_cub);
    line_2 += $" {N} ";
    line_2 += new string(' ', count_cub - count_table);
    line_2 += "|";
    line_3 += $" {cub} |";

    i++;
    if (N > 0) i++;
    else i--;
}

WriteLine(line_1);
WriteLine(line_2);
WriteLine(line_1);
WriteLine(line_3);
WriteLine(line_1);