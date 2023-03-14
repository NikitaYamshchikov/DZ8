static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

System.Console.WriteLine("Есть 2 прямые, заданные уравнения у1 = к1*х1 + b1 и у2 = к2*х2 + b2. Задай значения для k и b, чтобы найти точку пересечения прямых.");

double k1 = Prompt("Please input a value of k1: ");
double b1 = Prompt("Please input a value of b1: ");
double k2 = Prompt("Please input a value of k2: ");
double b2 = Prompt("Please input a value of b2: ");

if(b1 < 0)
{
    System.Console.WriteLine($"Формулы с указанными значениями выглядят так: y1 = {k1}*x1 - {Math.Abs(b1)} и y1 = {k2}*x1 + {b2}");
}
else if (b2<0)
{
    System.Console.WriteLine($"Формулы с указанными значениями выглядят так: y1 = {k1}*x1 + {b1} и y1 = {k2}*x1 - {Math.Abs(b2)}");
}
else if(b1<0 && b2<0)
{
     System.Console.WriteLine($"Формулы с указанными значениями выглядят так: y1 = {k1}*x1 - {Math.Abs(b1)} и y1 = {k2}*x1 - {Math.Abs(b2)}");
}
else
{
    System.Console.WriteLine($"Формулы с указанными значениями выглядят так: y1 = {k1}*x1 + {b1} и y1 = {k2}*x1 + {b2}");
}

if (k1==0 && k2==0)
{
    System.Console.WriteLine("Прямые не пересекаются - они проложенны параллельно");
}
else
{
    double x12 = (b2-b1)/(k1-k2);
    double y12 = k1*x12+b1;
    System.Console.WriteLine($"Координаты точки пересечения (х, y) = ({x12}, {y12})");
}
