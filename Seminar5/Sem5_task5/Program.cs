// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

using static System.Console;
Clear();

Write("Введите размер массива, мин и макс через пробел: ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
printArray(array);
int[] array2 = MultArray(array);
printArray(array2);




int[] MultArray(int[] array)
{
    int size = 0;
    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
    }
    else
    {
        size = array.Length / 2 + 1;
    }
    int[] resultarray = new int[size];
    for (int i = 0; i < array.Length / 2 + 1; i++)
    {
        resultarray[i] = array[i] * array[array.Length - i - 1];
    }
    return resultarray;
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