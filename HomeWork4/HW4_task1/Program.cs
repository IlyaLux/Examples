// Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B 
// с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear();

WriteLine("Введите число 'А' и натуральную степень этого числа 'n'");
if (!int.TryParse(ReadLine(), out int A) || !int.TryParse(ReadLine(), out int n) || n<0)
{
    WriteLine("'A' и 'n' должны быть числами, 'n' должно быть натуральным числом");
    return;
}
WriteLine($"{A} в степени {n} равно {NumDegree(A, n)}");






int NumDegree(int num, int degree)
{
    int result = 1;
    while (degree > 0)
    {
        result *= num;
        degree--;
    }
    return result;
}