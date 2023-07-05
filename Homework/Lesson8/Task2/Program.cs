// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadInt(string message)					            // Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] generateArrayDouble2d(int rows, int columns)  	// Создает и наполняет массив двумерный массив заполненный случайными целыми числами.
{
    int[,] list1 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < list1.GetLength(0); i++)
    {
        for (int j = 0; j < list1.GetLength(1); j++)
        {
            list1[i, j] = rnd.Next(0, 10);
        }
    }
    return list1;
}

void printArray2D(int[,] numbers)                       	// Показывает в терминале двумерный массив
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void sumRows(int[,] array, int arg)                         // Узнает меньшую сумму в строке
{
    int[] sumLine = new int[arg];
    for (int i = 0; i <= array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j <= array.GetLength(1) - 1; j++)
        {
            sumLine[i] += array[i, j];
        }
    }

    int lineMin = sumLine[0];
    int min = 1;

    for (int i = 0; i < sumLine.Length; i++)
    {
        if (lineMin > sumLine[i])
        {
            lineMin = sumLine[i];
            min = i + 1;
        }
    }
    System.Console.WriteLine($"Минимальная сумма ---> {lineMin} находится в строке ---> {min}");
}

int rows = ReadInt("введите число рядов ---> ");
int columns = ReadInt("введите число столбцов ---> ");
int[,] newArray = generateArrayDouble2d(rows, columns);
printArray2D(newArray);
System.Console.WriteLine();
sumRows(newArray, rows);
