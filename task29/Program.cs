// Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;
Clear();
int [] arr = GetArray();
GetArray();
PrintArray(arr);

void FullArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(101);
    }
}

int[] GetArray ()
{
    int [] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(101);
    }
    return array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}, ");
    }
}