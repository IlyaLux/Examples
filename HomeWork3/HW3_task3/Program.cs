using static System.Console;
Clear();

WriteLine("Найти кубы чисел от 1 до N.");
WriteLine("Введите число:");
if (!int.TryParse(ReadLine(), out int N))
{
    WriteLine("Введите число!");
    return;
}
int b = 1;
if (N > 0)
{
    while (b <= N)
    {
        Write(Math.Pow(b, 3) + " ");
        b++;
    }
}
else
{
    while (b >= N)
    {
        Write(Math.Pow(b, 3) + " ");
        b--;
    }
}