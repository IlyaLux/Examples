// Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;
Clear();

int[] array = GetArray();


int[] GetArray()
{
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-999, 1000);
        Write($"{array[i]} "); 
    }
    return array;
}






// int[] array = GetArray(8);


// int[] GetArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-2147483648, 2147483647);
//         Write($"{array[i]} "); 
//     }
//     return array;
// }