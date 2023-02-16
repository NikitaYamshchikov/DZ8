// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Эта программа покажет наибольшее из трех чисел.");
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b && a > c) {
   max = a;
}
else if (b > c && b > a) {
   max = b;
}
else {
    max = c;
    }
    
Console.Write("Наибольшее число:");    
Console.Write(max);

