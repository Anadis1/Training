// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadInt(string message)				// Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void func(int arg1, int arg2)
{
    if (arg1 > arg2)
    {
        return;
    }
    System.Console.WriteLine(arg1);
    func(arg1 + 1, arg2);
}

int number1 = ReadInt("Введите число 1 --- ");
int number2 = ReadInt("Введите число 2 --- ");
func(number1, number2);

