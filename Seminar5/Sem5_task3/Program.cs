// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

using static System.Console;
Clear();
int[] array = GetArray(10);
printArray(array);
int fl = SearchArray(array, 4);
WriteLine(fl == 1 ? "да" : "нет"); // WriteLine(SearchArray(array,number) ? "да" : "нет");



int[] GetArray(int size)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(-9, 10);
    }

    return resultArray;
}

void printArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }

    WriteLine($"{array[array.Length - 1]}]");
}


int SearchArray(int[] array, int n)
{
    int fl = 0;
    foreach (var a in array)
    {
        if (a == n)      //  if (a==n) return true;
        {
            fl = 1;
        }
    }
    return fl;          // return false;
}