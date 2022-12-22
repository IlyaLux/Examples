using static System.Console;
Clear();

WriteLine("Введите координаты точки x");
int x = int.Parse(ReadLine());
WriteLine("Введите координаты точки y");
int y = int.Parse(ReadLine());

if (x > 0 && y > 0)
{
    WriteLine("первая четверть");
}
else if (x < 0 && y > 0)
{
    WriteLine("вторая четверть");
}
else if (x < 0 && y < 0)
{
    WriteLine("третья четверть");
}
else if (x > 0 && y < 0)
{
    WriteLine("четвертая четверть");
}
