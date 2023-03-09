Console.WriteLine ("Input number:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Here are numbers from 1 to {0} to the third power:", n);

for (int i=1; i<=n; i++)
{
    double num = Math.Pow(i, 3);

    Console.Write("{0} ", num);
}