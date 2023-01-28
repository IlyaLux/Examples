// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

using static System.Console;
Clear();

Write("Введите размер матрицы и диапозон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
PritnMatrix(array);
WriteLine();


int minValue = array[0, 0];
int minIndexI = 0;
int minIndexJ = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < minValue)
        {
            minValue = array[i, j];
            minIndexI = i;
            minIndexJ = j;
        }
    }
}
WriteLine($"minI= {minIndexI}; minJ= {minIndexJ}");
int[,] ResultArray = newArray(array);
PritnMatrix(ResultArray);




int[,] newArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < minIndexI; i++)
    {
        for (int j = 0; j < minIndexJ; j++)
        {
            result[i, j] = array[i, j];
        }
    }
    for (int i = 0; i < minIndexI; i++)
    {
        for (int j = minIndexJ + 1; j < array.GetLength(1); j++)
        {
            result[i, j - 1] = array[i, j];
        }
    }
    for (int i = minIndexI + 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < minIndexJ; j++)
        {
            result[i - 1, j] = array[i, j];
        }
    }
    for (int i = minIndexI + 1; i < array.GetLength(0); i++)
    {
        for (int j = minIndexJ + 1; j < array.GetLength(1); j++)
        {
            result[i - 1, j - 1] = array[i, j];
        }
    }
    return result;
}


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