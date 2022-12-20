using static System.Console;
Clear();

WriteLine("Вывод второй цифры трехзначного числа");
WriteLine("Введите трехзначное число:");
int a = int.Parse(ReadLine());

WriteLine(a < -99 && a > -1000 ? -(a / 10 % 10) : a < 1000 && a > 99 ? a / 10 % 10 : "Неверное число. Начните сначала.");

// if (a < -99 && a > -1000 )
// {
//     WriteLine(-(a / 10 % 10) );
// }
// else if (a < 1000 && a > 99)
// {
//     WriteLine(a / 10 % 10);
// }
// else
// {
//     WriteLine("Неверное число. Начните сначала.");
// }