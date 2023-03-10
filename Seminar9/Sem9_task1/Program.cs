// **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

using static System.Console;
Clear();

string result = GetNumbers(15);
WriteLine(result);
WriteLine();
WriteLine(GetNumbers1(20));
PrintNumbers(10);


string GetNumbers(int num)
{
    return (num == 1) ? num.ToString() : $"{GetNumbers(num - 1)},{num}";

    // if (num == 1) return num.ToString();
    // else          return $"{GetNumbers(num-1)},{num}";
}

string GetNumbers1(int num)
{
    if (num == 1) return num.ToString();
    else          return $"{GetNumbers1(num-1)},{num}";
}

void PrintNumbers(int num)
{
    if (num == 1) Write(num);
    else
    {
        PrintNumbers(num - 1);
        Write($",{num}");
    }
}