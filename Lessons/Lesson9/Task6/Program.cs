// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int ReadInt(string message)				// Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool proverkaNaProst(int arg1, int divider = 0)
{
    if (divider == 0)
    {
        divider = arg1 - 1;
    }
    if (divider == 1)
    {
        return true;
    }
    return arg1 % divider > 0 && proverkaNaProst(arg1, divider - 1);
}

int number1 = ReadInt("Введите число ---> ");
System.Console.WriteLine(proverkaNaProst(number1));
