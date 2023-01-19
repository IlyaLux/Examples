// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

using static System.Console;
Clear();

WriteLine("Вывод первых N чисел Фибоначчи. Введите число n:");
int a = int.Parse(ReadLine());
int[] array = Fibonacci(a);
printArray(array);


int[] Fibonacci(int number)
{
    int[] array = new int[number];
    array[0] = 0; array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
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