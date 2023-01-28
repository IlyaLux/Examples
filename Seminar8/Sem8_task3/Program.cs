// **Задача 57:** Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

using static System.Console;
Clear();

Write("Введите размер матрицы и диапозон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
PritnMatrix(array);
WriteLine();

int[] paramInt = new int[parameters.Length];
if (parameters.Length == 4)
{
    for (int i = 0; i < parameters.Length; i++)
    {
        paramInt[i] = CheckInput(parameters[i]);
    }
}
else
{
    WriteLine("только 4 параметра нужно! выход");
    Environment.Exit(0);
}

int[] dict = new int[paramInt[3] - paramInt[2]];

for (int k = 0; k < dict.Length; k++)
{   dict[k] = 0;
    for (int i = 0; i < array.GetLength(0); i ++ )
    {
        for(int j =0; j < array.GetLength(1); j ++)
        {
            if (array[i,j] == k + paramInt[2])
            {
                dict[k] ++;
            }

        }
    }
}

for (int k = 0; k < dict.Length; k++)
{
    WriteLine($"{k + paramInt[2]} we meet {dict[k]} times");
}


int CheckInput(string inString)
{
    if (!int.TryParse(inString, out int result))
    {
        WriteLine("введите цифры");
        Environment.Exit(0);
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