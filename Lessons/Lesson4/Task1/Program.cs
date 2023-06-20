// Задача 1: Напишите программу, которая принимает на вход
//  число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Извините, но вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int SumNumbers(int number)
{
    int sum = 0;
    int count = 0;
    while (count <= number)
    {
        sum += count;
        count++;
    }

    return sum;
}

int SumNumbers2(int number)
{
    int sum2 = 0;
    for (int i = 0; i <= number; i++)
    {
        sum2 += i;
    }

    return sum2;
}

int number = Prompt("Введите число");

int sum = SumNumbers(number);
System.Console.WriteLine(sum);

int sum2 = SumNumbers2(number);
System.Console.WriteLine(sum2);