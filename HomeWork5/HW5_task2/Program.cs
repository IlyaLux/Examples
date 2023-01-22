// Задача 36: Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

Write("Введите через пробел размер массива, максимальное и минимальное число массива:");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
WriteLine();
WriteLine(SumNumOddInd(array));




int[] GetArray(int size, int minElement, int maxElement)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minElement, maxElement + 1);
    }
    return resultArray;
}

void PrintArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Write($"{newArray[i]} ");
    }
}

int SumNumOddInd(int[] newArray)
{
    int summ = 0;
    for (int i = 1; i < newArray.Length; i += 2)
    {
        summ += newArray[i];
    }
    return summ;
}