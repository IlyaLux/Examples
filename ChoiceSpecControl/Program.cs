using static System.Console;
Clear();

Write("Введите массив строк ");

string[] InString = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int count = 0;
foreach (var item in InString)
{
    if (item.Length <= 3) count++;
}

if (count > 0)
{
    string[] resultArray = new string[count];
    int num = 0;
    for (int i = 0; i < InString.Length; i++)
    {
        if (InString[i].Length <= 3)
        {
            resultArray[num] = InString[i];
            num++;
        }
    }
    PrintArray(resultArray);
}
else
{
    WriteLine();
}






void PrintArray(string[] arrayName)
{
    for (int i = 0; i < arrayName.Length - 1; i++)
    {
        Write($"{arrayName[i]}, ");
    }
    Write(arrayName[arrayName.Length - 1]);
}