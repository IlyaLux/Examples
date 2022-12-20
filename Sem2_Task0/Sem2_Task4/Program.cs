using static System.Console;
Clear();

WriteLine("Введите число a:");
int a = int.Parse(ReadLine());
WriteLine("Введите число b:");
int b = int.Parse(ReadLine());

// WriteLine(b == a * a || a == b * b ? "является" : "не является");

WriteLine(b == a * a ? "b является квадратом а" 
                     : a == b * b ? "a является квадратом b" 
                                : "не является");
