// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4


using static System.Console;
Clear();

Write("Введите размер матрицы и диапозон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
PritnMatrix(array);
WriteLine();
int[,] array2 = ResultMatrix(array);
PritnMatrix(array2);


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

int[,] ResultMatrix(int[,] inArray)
{
    int[,] result = inArray.Clone() as int[,];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i % 2 == 0 && i != 0)
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (j % 2 == 0 && j != 0) result[i, j] *= result[i, j];
            }
    }
    return result;
}