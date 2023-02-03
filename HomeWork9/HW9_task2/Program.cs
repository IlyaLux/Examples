// Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

WriteLine(GetSummNumbers(1,3));



int GetSummNumbers(int num1, int num2)
{
    int summ = 0;
    if (num1 == num2) return summ;
    if (num1 > num2)
    {
        return summ += GetSummNumbers(num1 - 1, num2) + num1;
    }
    else
    {
        return summ += GetSummNumbers(num2 - 1, num1) + num2;
    }
}