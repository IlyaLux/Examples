using static System.Console;
Clear();

WriteLine("Введите число");
int B = int.Parse(ReadLine());
int sum = summa(B);
WriteLine(sum);




int summa(int A)
{
    int result = 1;
    int sum = 0;

    while (result < A)
    {
        if (A % result = 0)
        {
            sum += result;
        }

        result++;
    }
    return result;
}