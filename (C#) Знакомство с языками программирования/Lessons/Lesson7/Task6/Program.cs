// Задача 5: Задайте двумерный массив. Найдите максимальный элемент массива и среднее арифметическое всех элементов массива.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Максимальный элемент массива 9
// Среднее арифметическое 4.25

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] numbers)
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

int[,] GenerateArray2D(int rows, int columns)
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(-10, 10);
        }
    }
    return numbers;
}

int FindMax(int[,] numbers)
{
    int max = numbers[0,0];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if(numbers[i,j] > max) 
            {
                max = numbers[i,j];
            }
        }
    }
    return max;
}

double FindAvg(int[,] numbers)
{
    double sum = 0;
    double avg = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum += numbers[i,j];
        }
    }
    avg = sum / numbers.Length;
    return avg;
}

int rows = ReadInt("введите число рядов");
int columns = ReadInt("введите число столбцов");
int[,] newArray = GenerateArray2D(rows,columns);
PrintArray2D(newArray);
double output = FindAvg(newArray);
int outputMax = FindMax(newArray);
Console.WriteLine($"Среднее арифметическое чисел равно => {output}");
Console.WriteLine($"максимальное число равно => {outputMax}");