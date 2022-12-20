using static System.Console;
Clear();

WriteLine("Первый стрелок сбил:");
int a = int.Parse(ReadLine());
WriteLine("Второй стрелок сбил:");
int b = int.Parse(ReadLine());

WriteLine("Всего сбито " + (a + b - 1) + " банок");
