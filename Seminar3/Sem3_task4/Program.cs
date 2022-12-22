using static System.Console;
Clear();

WriteLine("Введите количество деталей");

// int a = int.Parse(ReadLine());
if (!int.TryParse(ReadLine(), out int a))
{
    WriteLine("ошибка, введите число, а не текст");
}


if (a % 6 == 0)
{
    WriteLine("Первый и второй токарь сделали по " + (a / 6) + " деталей");
    WriteLine("Старший токарь сделал " + (a - a / 3) + " деталей");
}
else
{
    WriteLine("Токарь ошибся");
}