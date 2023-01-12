// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

using static System.Console;
Clear();

WriteLine("Введите число");
int N = int.Parse(ReadLine());
int mnoj = GetMnoj(N);
WriteLine(mnoj);




int GetMnoj(int A)
{
    int result = 1;
    while (A > 0)
    {
        result *= A;
        A--;
    }
    return result;
}