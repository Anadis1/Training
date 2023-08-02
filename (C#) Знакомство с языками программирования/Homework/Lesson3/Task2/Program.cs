// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int numberint()
{
    string numint = Console.ReadLine();
    int numberint = Convert.ToInt32(numint);
    return numberint;
}

double Length (int x, int y, int z)
{
   double temp = (x*x) + (y*y) + (z*z);
   return Math.Sqrt(temp); 
}

Console.Write("Введите кординату X первой точки --> ");
int x1 = numberint();
Console.Write("Введите кординату Y первой точки --> ");
int y1 = numberint();
Console.Write("Введите кординату Z первой точки --> ");
int z1 = numberint();
Console.Write("Введите кординату X второй точки --> ");
int x2 = numberint();
Console.Write("Введите кординату Y второй точки --> ");
int y2 = numberint();
Console.Write("Введите кординату Z второй точки --> ");
int z2 = numberint();

double Diagonale = Length(x1-x2, y1-y2, z1-z2);
Console.WriteLine($"Расстояние между двумя точками равно {Diagonale}");

Console.Write(Length);