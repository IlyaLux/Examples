// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");

string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));

PritnMatrix(array);
WriteLine();

SortingMatrixArray(array);
PritnMatrix(array);






int[,] SortingMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int quantity = 0;
        for (quantity = 0; quantity < inArray.GetLength(1); quantity++)
        {
            for (int j = 0; j < inArray.GetLength(1)-1; j++)
            {
                if (inArray[i, j] < inArray[i, j + 1])
                {
                    int temp = inArray[i, j];
                    inArray[i, j] = inArray[i, j + 1];
                    inArray[i, j + 1] = temp;
                }
            }
        }
    }
    return inArray;
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