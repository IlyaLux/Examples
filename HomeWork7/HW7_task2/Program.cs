// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, 
// и возвращающий значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;
Clear();

int[,] array = GetMatrixArray(5,6,-10,10);
PritnMatrix(array);










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