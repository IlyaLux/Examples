// Задача 52. Напишите программу реализующую методы формирования двумерного массива и массива средних арифметических значений 
// каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");

string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));

PritnMatrix(array);
WriteLine();

double[] newArray = AverageArray(array);

foreach (var item in newArray)
{
    Write($"{Math.Round(item,1)} ");
}





double[] AverageArray(int[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i,j];
        }
        resultArray[j] = summ/array.GetLength(0);
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