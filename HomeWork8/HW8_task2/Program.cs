// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");

string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));

PritnMatrix(array);
WriteLine();
WriteLine($"В {minSummRowsNum(array)} строке наименьшая сумма элементов");



int minSummRowsNum(int[,] inArray)
{
    int indMinRow = 1;
    int minSumm = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        minSumm += inArray[0, j];
    }
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            summ += inArray[i, j];
        }
        if (summ < minSumm)
        {
            minSumm = summ;
            indMinRow = i+1;
        }
    }
    return indMinRow;
}


int[,] GetMatrixArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] resultArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return resultArray;
}

void PritnMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}