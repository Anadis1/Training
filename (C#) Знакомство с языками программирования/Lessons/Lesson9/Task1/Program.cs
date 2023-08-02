// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadInt(string message)				// Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void func(int arg)
{
    if (arg <= 0)
    {
        return;
    }
    func(arg - 1);
    System.Console.WriteLine(arg);
}

int a = 3;
func(a);