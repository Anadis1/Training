// Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool ValidateCoords(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Одна из координат равна нулю");
        return false;
    }
    return true;
}

int GetQuorterNumber(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}

int x = ReadInt("Введите координату X");
int y = ReadInt("Введите координату Y");
if (ValidateCoords(x, y))
{
    int quorter = GetQuorterNumber(x, y);
    System.Console.WriteLine($"Номер четверти {quorter}");
}