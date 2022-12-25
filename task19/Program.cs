//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());
int reverse_number = number%10;

//if (number == reverse_number)

WriteLine(reverse_number);
// {
//     WriteLine($"КЛАСС! Это число {number} полиндром!");
// }
// else
// {
//     WriteLine($"Это самое обычное число {number}.");
// }