int num = 0;
int exponent = 0;
int result = 1;

while(true)
{
    Console.Write("Input number: ");
    string input_num = Console.ReadLine();
    Console.Write("Input exponent: ");
    string input_exponent = Console.ReadLine();
    bool isNumeric = int.TryParse(input_num, out _);
    bool expIsNumeric = int.TryParse(input_exponent, out _);
    if(isNumeric == true & expIsNumeric == true)
    {
        num = Convert.ToInt32(input_num);
        exponent = Convert.ToInt32(input_exponent);
        break;
    }
    else
    {
        Console.WriteLine("Incorrect input, you have to enter only number");
    }
}
System.Console.WriteLine();

for (int i=0; i<exponent; i++)
{
    result = result * num;
}
System.Console.WriteLine($"Result of exponentation {num}^{exponent} is {result}");
System.Console.WriteLine();

