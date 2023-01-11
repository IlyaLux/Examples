using static System.Console;
Clear();

// Вид 1
void Method1()
{
    WriteLine("Автор .....");
}
// Method1();


// Вид 2
void Method2(string msg)
{
    WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        WriteLine(msg);
        i++; // инкремент - увеличение на 1
    }
}
// Method21(msg: "Текст сообщения",count: 4);
// Method21(count: 4, msg: " Новый Текст сообщения");


// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

// int year = Method3();
// WriteLine(year);


// Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

// string res = Method4(2, "aa!!");
// WriteLine(res);



// ЦИКЛ For

string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

// string res = Method41(2, "aa!!");
// WriteLine(res);


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         WriteLine($"{i} x {j} = {i * j}");
//     }
//     WriteLine();
// }




//======== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             0123
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }


//     return result;
// }

// string newText = Replace(text, ' ', '|');
// WriteLine(newText);
// WriteLine(          );
// string newText2 = Replace(newText, 'к', 'К');
// WriteLine(newText2);
// WriteLine(          );
// string newText3 = Replace(newText2, 'о', 'О');
// WriteLine(newText3);



int[] arr = { 1, 5, 3, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
