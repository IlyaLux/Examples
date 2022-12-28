﻿using static System.Console;
Clear();

WriteLine("Является ли число палиндромом?");
WriteLine("Введите пятизначное число:");

if (!int.TryParse(ReadLine(), out int N))
{
    WriteLine("Введите число, а не текст.");
    return;
}
WriteLine((N > 99999 || N < 10000) && (N < -99999 || N > -10000) ? "Число должно быть пятизначным!" : N / 1000 == ((N % 100) % 10 * 10 + (N % 100) / 10) ? "Палиндром" : "Не палиндром");


// if (N < 100000 && N > 9999 || N > -100000 && N < -9999)
// {
//     int a = N % 100;
//     WriteLine(N / 1000 == (a % 10 * 10 + a / 10) ? "Палиндром" : "Не палиндром");
// }
// else
// {
//     WriteLine("Число должно быть пятизначным!");
// }

