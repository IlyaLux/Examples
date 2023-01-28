// *Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

using static System.Console;
Clear();

Write("Введите размер матрицы: ");
string[] parameters= ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array=GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));

PritnMatrix(array);

int[,] GetMatrixArray(int rows, int colums)
{  
    int[,] resultArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i, j] = i+j;
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