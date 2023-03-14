//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
static string Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    return result;
}

void arrayCountPositiveDigits(int[] arrayVoidCount)
{
    int count = 0;
    for(int i = 0; i<arrayVoidCount.Length; i++)
    {
        if(arrayVoidCount[i] > 0)
        {
            count = count + 1;
        }
    }
    System.Console.WriteLine($"Amout of positive numbers = {count}");
}


string inputData = Prompt("Please input a few numbers through ',' : ");

int[] array = inputData.Split(',').Select(Int32.Parse).ToArray();

Console.WriteLine(string.Join(" / ", array));

arrayCountPositiveDigits(array);
