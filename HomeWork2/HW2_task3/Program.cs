using static System.Console;
Clear();

WriteLine("Введите порядковый номер дня недели, чтобы узнать является ли этот день выходным:");
int a = int.Parse(ReadLine());

WriteLine(a > 0 && a < 6 ? "нет" : a == 6 || a == 7 ? "да" : "В неделе 7 дней! Попробуйте заново.");

// if (a>0 && a<6)
// {
//     WriteLine("нет");
// }
// else if(a ==6||a==7){
//     WriteLine("да");
// }
// else WriteLine("В неделе 7 дней! Попробуйте заново.");
