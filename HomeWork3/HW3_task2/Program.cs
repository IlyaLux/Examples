using static System.Console;
Clear();

WriteLine("Найти расстояние между двумя точками в 3D пространстве.");
WriteLine("Введите координаты точки a");
int ax = int.Parse(ReadLine());
int ay = int.Parse(ReadLine());
int az = int.Parse(ReadLine());

WriteLine("Введите координаты точки b");
int bx = int.Parse(ReadLine());
int by = int.Parse(ReadLine());
int bz = int.Parse(ReadLine());

WriteLine($"{Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)):f2}");
