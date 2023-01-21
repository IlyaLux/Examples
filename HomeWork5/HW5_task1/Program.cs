// Напишите программу реализующую методы формирования массива, заполненного случайными положительными трёхзначными числами,
// и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

WriteLine("Введите размер массива: ");
if (!int.TryParse(ReadLine(), out int n) || n < 0)
{
    WriteLine("Введите целое, положительное число");
    return;
}

int[] array = GetArray(n);
PrintArray(array);
WriteLine();
WriteLine($"Количество четных чисел в массиве: {CountEven(array)}.");




int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(100, 1000);
    }
    return resultArray;
}

void PrintArray(int[] arrayName)
{
    for (int i = 0; i < arrayName.Length; i++)
    {
        Write($"{arrayName[i]} ");
    }
}

int CountEven(int[] arrayName)
{
    int count = 0;
    foreach (var a in arrayName)
    {
        if (a % 2 == 0) count++;
    }
    return count;
}