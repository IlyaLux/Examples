using static System.Console;
Clear();

WriteLine("Введите число 1:");
int a = int.Parse(ReadLine());
WriteLine("Введите число 2:");
int b = int.Parse(ReadLine());
// int c = a % b;

WriteLine((a % b) == 0 ? "кратно" : "не кратно, остаток " + a % b);
