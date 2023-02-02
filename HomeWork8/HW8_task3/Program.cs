// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();

InputData:
Write("Введите размер ПЕРВОЙ матрицы и диапазон значений через пробел: ");
string[] parameters1 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array1 = GetMatrixArray(int.Parse(parameters1[0]), int.Parse(parameters1[1]), int.Parse(parameters1[2]), int.Parse(parameters1[3]));

Write("Введите размер ВТОРОЙ матрицы и диапазон значений через пробел: ");
string[] parameters2 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array2 = GetMatrixArray(int.Parse(parameters2[0]), int.Parse(parameters2[1]), int.Parse(parameters2[2]), int.Parse(parameters2[3]));

if (int.Parse(parameters1[1]) != int.Parse(parameters2[0]))
{
    WriteLine();
    WriteLine("Количество столбцов 1ой матрицы должно быть равно количеству строк 2ой матрицы");
    WriteLine("Повторите ввод данных");
    WriteLine();
    goto InputData;
}

PrintMatrix(array1); WriteLine();
PrintMatrix(array2); WriteLine();
PrintMatrix(MultArray(array1,array2));



int[,] MultArray(int[,] inArray1, int[,] inArray2)
{
    int[,] resultArray = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            for (int k = 0; k < inArray1.GetLength(1); k++)
            {
                resultArray[i, j] += inArray1[i, k] * inArray2[k, j];
            }
        }
    }
    return resultArray;
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

void PrintMatrix(int[,] inArray)
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