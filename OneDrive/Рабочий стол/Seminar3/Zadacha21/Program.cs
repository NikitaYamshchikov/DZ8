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