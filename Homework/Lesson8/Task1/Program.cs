// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] arrangeRows(int[,] array)                            //Упорядочивает числа в строках строки
{
    int temporarymax = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                temporarymax = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temporarymax;
                j = 0;                                      
            }
        }
    }
    return array;
}

int rows = ReadInt("введите число рядов ---> ");
int columns = ReadInt("введите число столбцов ---> ");
int[,] newArray = generateArrayDouble2d(rows, columns);
printArray2D(newArray);
System.Console.WriteLine();

arrangeRows(newArray);
int[,] arrangeArray = arrangeRows(newArray);
printArray2D(arrangeArray);

