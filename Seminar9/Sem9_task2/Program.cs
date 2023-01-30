// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using static System.Console;
Clear();
WriteLine(GetNumbers1(17,4));
WriteLine();
WriteLine(GetNumbers(6, 12));
WriteLine();
PrintNumbers(3, 9);

string GetNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        if (num1 == num2) return num1.ToString();
        else return $"{GetNumbers(num1 - 1, num2)},{num1}";
    }
    else
    {
        if (num2 == num1) return num2.ToString();
        else return $"{GetNumbers(num2 - 1, num1)},{num2}";
    }
}

string GetNumbers1(int num1, int num2)
{
    return (num1 > num2 ? (num1 == num2 ? num1.ToString() :
    $"{GetNumbers1(num1 - 1, num2)}, {num1}") : (num2 == num1 ? num2.ToString() :
    $"{GetNumbers1(num2 - 1, num1)}, {num2}"));
}


void PrintNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        if (num1 == num2) Write(num1);
        else
        {
            PrintNumbers(num1 - 1, num2);
            Write($",{num1}");
        }
    }
    else
    {
        if (num2 == num1) Write(num2);
        else
        {
            PrintNumbers(num2 - 1, num1);
            Write($",{num2}");
        }
    }
}