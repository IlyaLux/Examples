using static System.Console;
Clear();

WriteLine("Input number");
int number = int.Parse(ReadLine()!);
int sum=GetSum(number);
WriteLine($"Sum number 1...A = {sum}");


int GetSum(int A)
{
    int result = 0;
    while (A > 0)
    {
        result += A;
        A--;
    }

    return result;
}