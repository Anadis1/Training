//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int numberint()                                 // Запрашивает число у пользователя и переводит его в int
{
    Console.Write("Введите длину массива --> ");
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
    Console.Write($"Массив --> ");
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
}

int SumArrey(int[] Arrey)                   // Сумма нечетных чисел в массиве
{
    int sum = 0;
    int even = 0;
    for (int i = 0; i < Arrey.Length; i++)
    {
        if(i == even)
        {
            sum = sum + Arrey[i];
            even += 2; 
        }
    }
    return sum;
}

int quantity = numberint();

int[] list1 = GenerateArray(quantity, 0, 30);
PrintArrey(list1);
int sumnumber = SumArrey(list1);
Console.Write($"\nСумма нечетных чисел --> {sumnumber}");
