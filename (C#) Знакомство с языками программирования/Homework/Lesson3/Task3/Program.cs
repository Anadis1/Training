// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число --> ");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);

int index = 1;

Console.WriteLine($"Таблица кубов числа {number}");

while(index <= number)
{
    int variable = index * index * index;
    Console.WriteLine(variable);
    index += 1;

}
