// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

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

int[,] matrixMultiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        System.Console.WriteLine($"Нельзя найти произведение таких матриц");
    }
    
    int[,] matrixM = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    matrixM[i,j] += array1[i,k] * array2[k,j];
                }
            }
        }
    return matrixM;
}

int rows1 = ReadInt("введите число рядов ---> ");
int columns1 = ReadInt("введите число столбцов ---> ");
int rows2 = ReadInt("введите число рядов ---> ");
int columns2 = ReadInt("введите число столбцов ---> ");

int[,] matrix1 = generateArrayDouble2d(rows1, columns1);
printArray2D(matrix1);
System.Console.WriteLine();
int[,] matrix2 = generateArrayDouble2d(rows2, columns2);
printArray2D(matrix2);
System.Console.WriteLine();

int[,] matrixMult = matrixMultiplication(matrix1, matrix2);
printArray2D(matrixMult);