// Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using static System.Console;
Clear();

Write("Введите размер матрицы и диапозон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
PritnMatrix(array);
WriteLine();
WriteLine(SummDiag(array));




int[,] GetMatrixArray(int rows, int colums, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
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
            Write($"{inArray[i, j],3} ");
        }
        WriteLine();
    }
}

int SummDiag(int[,] inArray)
{
    int result = 0;
    int size = inArray.GetLength(1) < inArray.GetLength(0)? inArray.GetLength(1) : inArray.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        result += inArray[i, i];
    }
    return result;
}