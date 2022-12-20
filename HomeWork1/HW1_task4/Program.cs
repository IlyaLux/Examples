using static System.Console;
Clear();

WriteLine("Вывод четных чисел от 1 до заданного числа");
WriteLine("Введите число:");
int a = int.Parse(ReadLine());
int b = 1;

if (a > 1)
{
    while (b <= a)
    {
        if (b % 2 == 0)
        {
            Write(b + " ");
        }
        b++;
    }
}
else
{
    while (b >= a)
    {
        if (b % 2 == 0)
        {
            Write(b + " ");
        }
        b--;
    }
}
WriteLine();