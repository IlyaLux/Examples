using static System.Console;
Clear();

WriteLine("Нахождение максимального из трех чисел");
WriteLine("Введите число 1:");
int a1 = int.Parse(ReadLine());
WriteLine("Введите число 2:");
int a2 = int.Parse(ReadLine());
WriteLine("Введите число 3:");
int a3 = int.Parse(ReadLine());
int max = a1;
if (a2 > max)
{
    max = a2;
}
if (a3 > max)
{
    max = a3;
}
WriteLine("Максимальное число "+ max);
