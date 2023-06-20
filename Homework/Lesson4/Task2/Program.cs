//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int numberint()					        // Запрашивает число у пользователя и переводит его в int
{
    Console.Write("Введите число --> ");
    string numint = Console.ReadLine();
    int numberint = Convert.ToInt32(numint);
    return numberint;
}

int TheSumOfDigitsInANumber(int num1)   // Выполняет сложение цифр в числе
{
    int num2 = 0;
    while (num1 > 0)
    {
        num2 = num2 + num1 % 10;
        num1 /= 10;
    }
    return num2;
}

int number = numberint();
int sumfigure = TheSumOfDigitsInANumber(number);

Console.Write($"Сумма цифр в числе --> {sumfigure}");