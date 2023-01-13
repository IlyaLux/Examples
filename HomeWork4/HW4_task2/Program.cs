// Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();

WriteLine("Введите число, чтобы узнать сумму его цифр");
if (!int.TryParse(ReadLine(), out int A))
{
    WriteLine("Введите число!");
    return;
}
WriteLine(NumeralSum(A));






int NumeralSum(int num)
{
    int result = 0;
    num = Math.Abs(num);
    while (num>0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}