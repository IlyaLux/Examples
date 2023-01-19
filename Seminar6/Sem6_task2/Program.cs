// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

using static System.Console;
Clear();

WriteLine("Введите 1 сторону треугольника:");
int a = int.Parse(ReadLine());
WriteLine("Введите 2 сторону треугольника:");
int b = int.Parse(ReadLine());
WriteLine("Введите 3 сторону треугольника:");
int c = int.Parse(ReadLine());

WriteLine(Triangle(a,b,c));

string  Triangle(int a, int b, int c)
{
    
    if (a+b>c && a+c>b && b+c>a)
    {
        
        return "Да";
    }
    else
    {
        return "Нет";
    }
}