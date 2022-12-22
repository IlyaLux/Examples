using static System.Console;
Clear();

WriteLine("Введите порядковый номер дня недели:");
int a = int.Parse(ReadLine());

switch (a)
{
    case 1:
        {
            WriteLine("понедельник");
            break;
        }
    case 2:
        {
            WriteLine("вторник");
            break;
        }
    case 3:
        {
            WriteLine("среда");
            break;
        }
    case 4:
        {
            WriteLine("четверг");
            break;
        }
    case 5:
        {
            WriteLine("пятница");
            break;
        }
    case 6:
        {
            WriteLine("суббота");
            break;
        }
    case 7:
        {
            WriteLine("воскресенье");
            break;
        }
    default:
        {
            WriteLine("Ошибка. Введите число от 1 до 7");
            break;
        }
}
