// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// (*) В 3-й задаче Доп сложность. Ввод с консоли “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”


int numberint()                                     // Запрашивает число у пользователя и переводит его в int
{
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

void PrintArrey(int[] Arrey)				        // Показывает в терминале массив
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
}


Console.Write("Введите длину массива --> ");
int quantity = numberint();
Console.Write("Введите минимаотное значение числа в массиве --> ");
int min = numberint();
Console.Write("Введите максимальное значение числа в массиве --> ");
int max = numberint();

int[] number = GenerateArray(quantity, min, max);
PrintArrey(number);
