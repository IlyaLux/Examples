using static System.Console;
Clear();

WriteLine("Введите координаты точки a");
int ax = int.Parse(ReadLine());
int ay = int.Parse(ReadLine());
WriteLine("Введите координаты точки b");
int bx = int.Parse(ReadLine());
int by = int.Parse(ReadLine());

// int a = int.Parse(ReadLine());
// if (!int.TryParse(ReadLine(), out int a))
// {
//     WriteLine("ошибка, введите число, а не текст");
//     return;
// }
double lenght = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
// WriteLine(Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by)));
WriteLine($"{lenght:f2}"); // f переводит во float, 2 округляет до 2 знаков
