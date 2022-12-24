using static System.Console;
Clear();

WriteLine("Введите число");

// int a = int.Parse(ReadLine());
if (!int.TryParse(ReadLine(), out int N))
{
    WriteLine("ошибка, введите число, а не текст");
    return;
}
int b = 1;
if (N > 0)
{
    while (b <= N)
    {
        Write(Math.Pow(b, 2) + " ");
        b = b + 1;
    }
}
else
{
   while (N <= b)
    {
        Write(Math.Pow(N, 2) + " ");
        N = N + 1;
    } 
}
WriteLine();

