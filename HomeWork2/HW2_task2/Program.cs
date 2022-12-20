using static System.Console;
Clear();

WriteLine("Вывод третьей цифры заданного числа.");
WriteLine("Введите число:");
int a = int.Parse(ReadLine());
int b = 0;
if (a > 99 || a < -99)
{
    while (a > 99 || a < -99)
    {
        b = a % 10;
        a = a / 10;
    }
    WriteLine(b < 0 ? -b : b);
}
else WriteLine("третьей цифры нет");
