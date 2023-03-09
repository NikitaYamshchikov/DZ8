//Задача 23
Console.WriteLine ("Input number:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Here are numbers from 1 to {0} to the third power:", n);

for (int i=1; i<=n; i++)
{
    double num = Math.Pow(i, 3);

    Console.Write("{0} ", num);
}

//Задача 19
Console.Write("Input your number: ");
string num = string.Empty;

while(true)
{
    num = Console.ReadLine();
    bool isNumeric = int.TryParse(num, out _);
    if(isNumeric == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Incorrect input, you have to enter only number");
    }
}

int num2 = Convert.ToInt32(num);
int fin = 0;
double num_left = 0;
double num_right = 0;
bool check = false;

while(fin != num.Length/2)
{
    if (fin==0)
    {
        num_right = Math.Truncate((num2/Math.Pow(10, fin))%10);
        num_left = Math.Truncate((num2/Math.Pow(10, num.Length-1)));
        fin++;
        System.Console.WriteLine("Num Left {0}", num_left);
        System.Console.WriteLine("Num Right {0}", num_right);
    }
    else
    {
        num_right = Math.Truncate((num2/Math.Pow(10, fin))%10);
        num_left = Math.Truncate((num2/Math.Pow(10, num.Length-1-fin))%10);
        fin++;
        System.Console.WriteLine("Num Left {0}", num_left);
        System.Console.WriteLine("Num Right {0}", num_right);
    }

    if (num_left == num_right)
    {
        check = true;
        Console.WriteLine(check);
    }
    else
    {
        check = false;
        break;
    }
}

Console.WriteLine();
if (check == true)
{
    Console.WriteLine("The entered number {0} is palindrome", num);
}
else
{
    Console.WriteLine("The entered number {0} isn't palindrome", num);
}
Console.WriteLine();


//Задача 21
Console.WriteLine("\nInput coordinates for dot A :");

Console.Write("X : ");
double xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Y : ");
double ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Z : ");
double za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInput coordinates for dot B :");

Console.Write("X : ");
double xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Y : ");
double yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Z : ");
double zb = Convert.ToInt32(Console.ReadLine());


double length = Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2)+Math.Pow((zb-za), 2)); 

Console.WriteLine ("\nThe distance between A and B dots is: " +(Math.Round(length, 2)));