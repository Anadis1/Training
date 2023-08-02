// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 0, 0 -> 1

int ReadInt(string message)					                // Запрашивает число у пользователя и переводит его в int
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] generateArrayDouble2d(int rows, int columns)  	// Создает и наполняет массив двумерный массив заполненный случайными числами.
{
    int[,] list1 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < list1.GetLength(0); i++)
    {
        for (int j = 0; j < list1.GetLength(1); j++)
        {
            list1[i, j] = rnd.Next(0, 100);
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

void searchByIndex(int variableLine, int variableRow, int variableRowArray, int variableColumnsArray, int[,] variableArray)  // Находит элемент по индексу
{
    if(variableLine > variableRowArray || variableRow > variableColumnsArray)
    {
        System.Console.WriteLine("Такого элемента в матрице нет");
    }
    else
    {
        System.Console.WriteLine($"Найденный по индексу элемент ---> {variableArray[variableLine - 1, variableRow - 1]}");
    }
}

int rowArray = ReadInt("введите число рядов в массиве ---> ");
int columnsArray = ReadInt("введите число столбцов в массиве ---> ");

int[,] newArray = generateArrayDouble2d(rowArray, columnsArray);
printArray2D(newArray);

int line = ReadInt("Укажите строку для поиска ---> ");
int row = ReadInt("Укажите столбец для поиска ---> ");

searchByIndex(line, row, rowArray, columnsArray, newArray);
