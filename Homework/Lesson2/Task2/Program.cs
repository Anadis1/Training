//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число - ");
string temporary = Console.ReadLine();
int number = Convert.ToInt32(temporary);

int index = 0;
int length = 0;                     // Количество цифр в числе
int temporarynunber = number;
int figure = 0;

while(temporarynunber > 0)          // Определяем длинну числа
{
    temporarynunber /= 10;
    length += 1;
}

if(length > 2)
{
    while(index < length - 2)
    {
        figure = number % 10;
        number /= 10;
        index += 1;
    }
    Console.Write(figure);
}
else
{
    Console.Write($"В числе отсутствует третья цифра");
}
