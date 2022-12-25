//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;
Clear();

WriteLine("Введите точку A на оси X: ");
int.TryParse(ReadLine(), out int AX);
WriteLine("Введите точку A на оси Y: ");
int.TryParse(ReadLine(), out int AY);
WriteLine("Введите точку A на оси Z: ");
int.TryParse(ReadLine(), out int AZ);
WriteLine("Введите точку B на оси X: ");
int.TryParse(ReadLine(), out int BX);
WriteLine("Введите точку B на оси Y: ");
int.TryParse(ReadLine(), out int BY);
WriteLine("Введите точку B на оси Z: ");
int.TryParse(ReadLine(), out int BZ);
WriteLine("Введите точку C на оси X: ");
int.TryParse(ReadLine(), out int CX);
WriteLine("Введите точку C на оси Y: ");
int.TryParse(ReadLine(), out int CY);
WriteLine("Введите точку C на оси Z: ");
int.TryParse(ReadLine(), out int CZ);

double length = Math.Sqrt(Math.Pow((AX-BX-CX),2) + Math.Pow((AY-BY-CY),2) + Math.Pow((AZ-BZ-CZ),2));
WriteLine($"{length:f2}");


