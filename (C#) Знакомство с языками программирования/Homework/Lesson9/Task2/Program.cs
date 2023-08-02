// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ReadInt(string message)                                 // Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int sumTheGap(int arg1, int arg2)
{
    if (arg1 > arg2)
    {
        return 0;
    }
    sumTheGap(arg1 + 1, arg2);
    return arg1 + sumTheGap(arg1 + 1, arg2);
}

int number1 = ReadInt("Задайте минимальное значение ---> ");
int number2 = ReadInt("Задайте максимально значение ---> ");

System.Console.WriteLine(sumTheGap(number1, number2));
