// Задача 38: Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами 
// и вычисления разницы между максимальным и минимальным элементом массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;
Clear();

WriteLine("Введите размер массива: ");
if (!int.TryParse(ReadLine(), out int n) || n < 0)
{
    WriteLine("Введите целое, положительное число");
    return;
}

double[] array = GetArray(n);
PrintArray(array);
WriteLine();
WriteLine($"Разница между максимальным и минимальным элементом равна: {MaxMinDifference(array)}");
WriteLine();


double[] GetArray(int size)
{
    double[] resultArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = Convert.ToDouble(new Random().Next(-1000, 1000)) / 10;
    }
    return resultArray;
}

void PrintArray(double[] arrayName)
{
    for (int i = 0; i < arrayName.Length; i++)
    {
        Write($"{arrayName[i]} ");
    }
}

double MaxMinDifference(double[] arrayName)
{
    double min = arrayName[0];
    double max = arrayName[0];
    foreach (var a in arrayName)
    {
        max = a > max ? a : max;
        min = a < min ? a : min;
    }
    return max - min;
}