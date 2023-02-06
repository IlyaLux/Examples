// Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();

WriteLine(AkkermanFunc(3, 2));

int AkkermanFunc(int a, int b)
{
    if (a == 0) return b + 1;
    if (a > 0 && b == 0) return AkkermanFunc(a - 1, 1);
    if (a > 0 && b > 0) return AkkermanFunc(a - 1, AkkermanFunc(a, b - 1));
    return AkkermanFunc(a, b);
}