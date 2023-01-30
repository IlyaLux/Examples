// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
// Tom Marvolo Riddle => I am Lord Voldemort - доп.задача

using static System.Console;
Clear();
WriteLine(Pow(2, 3));

int Pow(int a, int b)
{
    return (b == 1) ? a : Pow(a, b - 1) * a;

    // if (b == 1) return a;
    // else
    // {
    //     return Pow(a, b - 1) * a;
    // }
}