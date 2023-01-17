// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

using static System.Console;
Clear();
Write("Введите размер массива");
int [] array = GetArray (10);
printArray(array);
ChangeArray(array);
printArray(array);




int [] GetArray( int size)
{
    int[] resultArray = new int [size];

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


void ChangeArray (int [] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        array[i] *= (-1);
    }
}