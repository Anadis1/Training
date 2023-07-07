// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadInt(string message)				// Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int power(int arg1, int arg2)
{
    if(arg2 <= 0)
    {
        return 1;
    }
    return arg1 * power(arg1, arg2 - 1); 
}



int number1 = ReadInt("Введите число ---> ");
int number2 = ReadInt("Введите степень числа ---> ");
System.Console.WriteLine(power(number1, number2));
