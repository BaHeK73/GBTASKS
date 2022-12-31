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

// Решение на любое число
// WriteLine("Введите число: ");


// long num = long.Parse(ReadLine()!);
// long revers = 0;
// long num2 = num;
// while (num2 != 0)
// {
//     revers *= 10;
//     revers += num2 % 10;
//     num2 = num2 / 10;
// }
// Write(revers == num ? "Полиндром" : "Обычное число");