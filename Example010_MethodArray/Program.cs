using static System.Console;
Clear();

int[] array = { 11, 24, 23, 74, 58, 15, 63, 67, 58 };
int n = array.Length;
int find = 58;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        WriteLine(index);
        break;
    }
    index++; // index = index + 1
}