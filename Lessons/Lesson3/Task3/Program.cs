// Задача 3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double Length (int x, int y)
{
   double temp = (x*x) + (y*y);
   return Math.Sqrt(temp); 
}

int x1 = ReadInt("Введите координату X первой точки ");
int y1 = ReadInt("Введите координату Y первой точки ");
int x2 = ReadInt("Введите координату X второй точки ");
int y2 = ReadInt("Введите координату Y второй точки ");

double Diagonale = Length(x1-x2, y1-y2);
Console.WriteLine($"Расстояние между двумя точками равно {Diagonale}");