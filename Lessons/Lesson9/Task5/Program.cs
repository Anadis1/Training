// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int ReadInt(string message)				// Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool stepenDvoiki(int arg1)
{
    if(arg1 <= 2)
    {
        return true;
    }
    if(arg1 % 2 == 1)
    {
        return false;
    }
    return stepenDvoiki(arg1 / 2);
}

int number1 = ReadInt("Введите число ---> ");
System.Console.WriteLine(stepenDvoiki(number1));
