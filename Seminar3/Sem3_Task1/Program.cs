using static System.Console;
Clear();
WriteLine("Введите номер четверти:");
int a = int.Parse(ReadLine());

switch (a)
{
    case 1:
    {
        WriteLine("x>0 y>0");
        break;
    }
    case 2:
    {
        WriteLine("x<0 y>0");
        break;
    }
    case 3:
    {
        WriteLine("x<0 y<0");
        break;
    }
    case 4:
    {
        WriteLine("x>0 y<0");
        break;
    }
    default:
    {
        WriteLine("ошибка");
        break;
    }
}


// if(a<1||a>4){
//     WriteLine("ошибка");
//     return;
// }
// if(a==1)
// {
//     WriteLine("x>0 y>0");
// }
// if(a==2)
// {
//     WriteLine("x<0 y>0");
// }
// if(a==3)
// {
//     WriteLine("x<0 y<0");
// }
// if(a==4)
// {
//     WriteLine("x>0 y<0");
// }