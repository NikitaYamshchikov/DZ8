int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    Random gen = new Random();
    array[i] = gen.Next(1, 100);
}

System.Console.WriteLine("Output of random array");

Console.WriteLine(string.Join(" / ", array));
System.Console.WriteLine();