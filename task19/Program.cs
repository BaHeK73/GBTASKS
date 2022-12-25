//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

using static System.Console;
Clear();

WriteLine("Введите пятизначное число:");
int number = int.Parse(ReadLine()!);

if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
 
            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = (number / 100) % 10;
                int remainder2 = number % 10;
                if(division2 == remainder2)
                WriteLine("Полиндром");
            }
            else 
            WriteLine("Не является полиндромом");
            
    }
    else
    WriteLine("Некорректное число!");

// WriteLine("Введите число: ");
// string number = ReadLine()!;
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }