using static System.Console;
Clear();

WriteLine("Нахождение максимального из двух чисел");
WriteLine("Введите число 1");
int a = int.Parse(ReadLine());
WriteLine("Введите число 2");
int b = int.Parse(ReadLine());

if(a==b){
    WriteLine("Числа равны");
} 
if(a>b){
    WriteLine($"Первое число {a} больше второго {b}");
}
else {
    WriteLine($"Второе число {b} больше первого {a}");
}

// WriteLine(a==b ? "Числа равны" : a>b ? $"Первое число {a} больше второго {b}" : $"Второе число {b} больше первого {a}");

// if(a>b){
//     WriteLine($"Первое число {a} больше второго {b}");
// }
// if(a<b){
//     WriteLine($"Второе число {b} больше первого {a}");
// }
// if(a==b) {
//     WriteLine("Числа равны");
// }
