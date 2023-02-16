// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// 5->2,4
// 8->2,4,6,8

Console.WriteLine("Добрый день! Программа поможет найти положительные четные числа, до указанного вами.");
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if(a < 0)
{
    Console.WriteLine("Введите положительное число");
}
else
{
   for (int b = 2; b <= a; b++)
   {
    if(b % 2 == 0)
    {Console.WriteLine(b);}
   }
}
Console.WriteLine("Вывод закончен!");