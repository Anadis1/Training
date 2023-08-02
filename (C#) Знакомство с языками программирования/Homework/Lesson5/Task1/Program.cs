//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int numberint()                                 // Запрашивает число у пользователя и переводит его в int
{
    Console.Write("Задайте длину массива --> ");
    string numint = Console.ReadLine();
    int numberint = Convert.ToInt32(numint);
    return numberint;
}

int[] GenerateArray(int len, int min, int max)		// Создает и наполняет массив
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

void PrintArrey(int[] Arrey)				// Показывает в терминале массив
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
}

int checkingForEven(int[] Arrey)            // Подсчет четных чисел в массиве
{
    int number = 0;
    for (int i = 0; i < Arrey.Length; i++)
    {
        if(Arrey[i] % 2 == 0)
        {
            number = number + 1;
        }
    }
    return number;
}

int num = numberint();
int[] numberlist = GenerateArray(num, 100, 999);
int quantity = checkingForEven(numberlist);

PrintArrey(numberlist);
Console.Write($"\nКоличество четных чисел в массиве --> {quantity}");