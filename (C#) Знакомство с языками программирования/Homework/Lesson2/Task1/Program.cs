// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число - ");
string temporary = Console.ReadLine();
int nunber = Convert.ToInt32(temporary);

int index = 0;
int nunber2 = 0;

if(nunber > 99 && nunber < 1000)
{
    while(index <= 1)
    {
        nunber2 = nunber % 10;
        nunber /= 10;
        index += 1;
    }
    Console.Write($"Вторая цифра введенного числа - {nunber2}");
}
else
{
    Console.Write($"Это не трехзначное число");
}
