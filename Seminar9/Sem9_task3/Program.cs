// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

using static System.Console;
Clear();

WriteLine(GetSum(4533));

int GetSum(int num)
{
    return num / 10 == 0 ? num % 10 : GetSum(num / 10) + num % 10;

    // if (num / 10 == 0) return num % 10;
    // else
    // {
    //     return GetSum(num / 10) + num % 10;
    // }
}
