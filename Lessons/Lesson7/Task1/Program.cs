// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1     4    8   19
// 5   -2  33   -2
// 77  3    8     1

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int columns, int min, int max)
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(min, max + 1);
        }
    }
    return numbers;
}

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк >");
int columns = ReadInt("Введите количество столбцов >");
int[,] array = GenerateArray2D(rows, columns, -10, 10);
PrintArray2D(array);