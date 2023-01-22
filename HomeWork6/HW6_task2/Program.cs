// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, 
//                      y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using static System.Console;
Clear();

WriteLine("Найти точку пересечения прямой y=k1*x+b1 и прямой y=k2*x+b2");
WriteLine("Задайте поочереди значения переменных k1, b1, k2, b2:");
double k1 = int.Parse(ReadLine());
double b1 = int.Parse(ReadLine());
double k2 = int.Parse(ReadLine());
double b2 = int.Parse(ReadLine());

WriteLine($"Координаты точки пересечения двух прямых - ({(b1-b2)/(k2-k1)},{k2*(b1-b2)/(k2-k1)+b2})");