//Напишите программу, 
//которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите целое положительное число >");
int x = 1; 

while (x <= number)
{
    int result = x*x;
    Console.Write($"{result} ");
    x++;
}
Console.WriteLine();
for(int i = 1; i <= number; i++)
{
    int result = i*i;
    Console.Write($"{result} ");
}
