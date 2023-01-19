﻿// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

using static System.Console;
Clear();
Write("Введите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);

// WriteLine($"[{string.Join(" ", array)}]"); // вывод массива


// WriteLine($"[{string.Join(",", ReverseArray(array))}]");
// int[] ReverseArray(int[] inArray)
// {
//     int[] result=new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i]=inArray[inArray.Length-1-i];
//     }

//     return result;
// }

WriteLine($"[{string.Join(",", array)}]");
ReverseArray(array);
WriteLine($"[{string.Join(",", array)}]");

void ReverseArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length/2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}



int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(1, 10);
    }
    return resultArray;
}