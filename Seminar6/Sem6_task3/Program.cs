// преобразование десятичного числа в двоичное


using static System.Console;
Clear();

WriteLine("Введите число для перевода в двоичную систему:");
int a = int.Parse(ReadLine());

WriteLine(convertTo2(a));


string convertTo2(int number)
{
    if (number == 0) return "0";
    string temp = "";
    while (number > 0)
    {
        temp = number % 2 + temp;
        number /= 2;
}
    return temp;
}