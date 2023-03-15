//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string RecursionPositiveInteger(int N)
{
    if (N==1) return N + "";
    else 
    return N + " " + RecursionPositiveInteger(N-1);
}

int N = Prompt("Input number: ");
System.Console.WriteLine(RecursionPositiveInteger(N));
