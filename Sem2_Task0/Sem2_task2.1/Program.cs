using static System.Console;
Clear();

WriteLine("Введите число 1:");
int a = int.Parse(ReadLine());
WriteLine("Введите число 2:");
int b = int.Parse(ReadLine());
WriteLine(a==b?"=":a > b ? ">" : "<");

// if (a == b)
// {
//     WriteLine("=");
// }
// else {
//     WriteLine(a > b ? ">" : "<");
// }
