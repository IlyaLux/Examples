// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

using static System.Console;
Clear();

WriteLine("Введите число");
if (!int.TryParse(ReadLine(), out int N))
{
    WriteLine("Введите число!");
    return;
}
int count = Numbers(N);
WriteLine(count);


int Numbers(int A)
{
    int result = 0;
    while (A > 0)
    {
        A /= 10;
        result++;
    }
    return result;
}