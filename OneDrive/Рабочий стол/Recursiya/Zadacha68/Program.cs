//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

long RecursionAkkerman(long M, long N)
{
    if (M==0) return N+1;
    else if (N==0) return RecursionAkkerman(M-1, 1);
    else return RecursionAkkerman(M-1, RecursionAkkerman(M, N-1));
}

int m = Prompt("Input m: ");
int n = Prompt("Input n: ");
System.Console.WriteLine( $"Result of Akkerman function = {RecursionAkkerman(m, n)}");
