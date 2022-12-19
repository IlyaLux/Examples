using static System.Console;
Clear();

WriteLine("Нахождение максимального из двух чисел");
WriteLine("Введите число 1");
int a = int.Parse(ReadLine());
WriteLine("Введите число 2");
int b = int.Parse(ReadLine());
if(a>b){
    WriteLine($"Первое число {a} больше второго {b}");
}
if(a<b){
    WriteLine($"Второе число {b} больше первого {a}");
}
if(a==b) {
    WriteLine("Числа равны");
}
