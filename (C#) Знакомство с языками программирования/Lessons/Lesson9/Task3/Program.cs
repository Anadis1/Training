// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int ReadInt(string message)				// Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int sumNum(int arg)
{
    if (arg <= 0)
    {
        return 0;
    }
    return arg % 10 + sumNum(arg / 10);
}

int number1 = ReadInt("Введите число  --- ");

if (number1 < 0)
{
    number1 = number1 * -1;
    System.Console.WriteLine(sumNum(number1));
}
else
{
    System.Console.WriteLine(sumNum(number1));
}