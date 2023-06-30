// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string message)					// Запрашивает число у пользователя и переводит его в int
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
            list1[i, j] = rnd.Next(0, 20);
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

void printArray2DSum(int[,] numbers, int temporaryColumns, double temporaryRows)                       	// считает среднее арифметическое в столбцах
{
    double[] temporaryArray = new double[temporaryColumns];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int temporary = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            temporaryArray[temporary] = temporaryArray[temporary] + numbers[i, j];
            temporary++;
        }
    }

    for (int i = 0; i < temporaryArray.Length; i++)
    {
        System.Console.Write($"{temporaryArray[i] / temporaryRows}\t");
    }
}

int rows = ReadInt("введите число рядов ---> ");
int columns = ReadInt("введите число столбцов ---> ");
int[,] newArray = generateArrayDouble2d(rows, columns);
printArray2D(newArray);
System.Console.WriteLine();

printArray2DSum(newArray, columns, rows);