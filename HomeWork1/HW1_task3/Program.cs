using static System.Console;
Clear();

WriteLine("Явяляется ли число четным?");
WriteLine("Введите число:");
int a = int.Parse(ReadLine());

if (a % 2 == 0)
{
    WriteLine("число четное");
}
else
{
    WriteLine("число нечетное");
}

// WriteLine(a % 2 == 0 ? "число четное" : "число нечетное");