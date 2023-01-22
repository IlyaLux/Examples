// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

Write("Введите через пробел произвольное количество чисел: ");
string[] inputNumbers = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] newArray = GetArrayFromString(inputNumbers);

WriteLine($"Вы ввели {PositiveNumCount(newArray)} чисел больше 0.");




// int count = 0;
// foreach (var a in newArray)
// {
//     count += a > 0 ? 1 : 0;
// }
// WriteLine($"Введено {count} чисел больше 0.");

int[] GetArrayFromString(string[] line)
{
    int[] array = new int[line.Length];
    for (int i = 0; i < line.Length; i++)
    {
        array[i] = Convert.ToInt32(line[i]);
    }
    return array;
}

int PositiveNumCount (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}
