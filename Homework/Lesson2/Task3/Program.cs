//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите цифру обозначающую день недели - ");
string temporary = Console.ReadLine();
int number = Convert.ToInt32(temporary);

string [] list1 = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if(1 <= number && number <= 7)
{
    if(number <= 5)
    {
        Console.Write($"{list1[number - 1]} - будний");
    }
    else
    {
        Console.Write($"{list1[number - 1]} - выходной");
    }
}
else
{
    Console.Write("Такого дня нет");
}
