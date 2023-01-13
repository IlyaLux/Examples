using static System.Console;
Clear();

WriteLine("Введите число");
int num = int.Parse(ReadLine());
int sum = summa(num);
WriteLine(sum);




int summa(int number)
{
    int result = 1;
    int summ = 0;

    while (result < number+1)
    {
        if (number % result == 0)
        {
            summ += result;
        }

        result++;
    }
    return summ;
}