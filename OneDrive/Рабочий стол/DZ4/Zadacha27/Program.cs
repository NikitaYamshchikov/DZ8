Console.Write("Input your number: ");
string num = string.Empty;
int sum = 0;

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

char[] number = num.ToCharArray();

for (int i=0; i<number.Length; i++)
{
    int change = Convert.ToInt32(number[i])-48;
    sum = sum + change;
}

System.Console.WriteLine($"The Sum of each number = {sum}");

