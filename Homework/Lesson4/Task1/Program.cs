//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int exponentiation(int num1, int num2)  // Возводит num1 в степень num2
{
    int num3 = 1;
    for (int index = 1; index <= num2; index += 1)
    {
        num3 = num3 * num1;
    }
    return num3;
}

int numberint()					// Запрашивает число у пользователя и переводит его в int
{
    string numint = Console.ReadLine();
    int numberint = Convert.ToInt32(numint);
    return numberint;
}

Console.WriteLine("Введите число");
int number = numberint();
Console.WriteLine("Введите степень");
int multiplier = numberint();

int exponen = exponentiation(number, multiplier);

Console.WriteLine(exponen);