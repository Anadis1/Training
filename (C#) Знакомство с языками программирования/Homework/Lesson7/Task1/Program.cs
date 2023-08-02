// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] generateArrayDouble2d(int rows, int columns)  // Создает и наполняет двумерный массив заполненный случайными вещественными числами.
{
    double[,] list1 = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < list1.GetLength(0); i++)
    {
        for (int j = 0; j < list1.GetLength(1); j++)
        {
            list1[i, j] = rnd.Next(0, 100) + rnd.NextDouble();
        }
    }
    return list1;
}

void printArray2D(double[,] numbers)                       // Показывает в терминале двумерный массив
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("введите число рядов ---> ");
int columns = ReadInt("введите число столбцов ---> ");
double[,] newArray = generateArrayDouble2d(rows, columns);
printArray2D(newArray);


