// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число --> ");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);

if(number > 9999 && number < 100000)
{
    int figure1 = number / 10000;
    int figure2 = number / 1000 % 10;
    int figure4 = number / 10 % 10;
    int figure5 = number % 10;

    if(figure1 == figure5 && figure2 == figure4)
    {
        Console.Write($"Число {number} является полиндромом");
    }
    else
    {
        Console.Write($"Число {number}  НЕ является полиндромом");
    }

}
else
{
    Console.Write("Это не пятизначное число");
}
