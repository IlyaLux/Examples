//  Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

using static System.Console;
Clear();

Write("Введите размер массива, мин и макс через пробел: ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
printArray(array);
WriteLine(count(array, -100, 100));



int count(int[] array, int i, int j)
{
    int result = 0;
    foreach (var a in array)
    {
        if (a >= i && a <= j) 
        {
            result++;
        }
}
    return result;
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }

    return resultArray;
}

void printArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }

    WriteLine($"{array[array.Length - 1]}]");
}