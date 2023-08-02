// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int numberint(string text)                                 // Запрашивает число у пользователя и переводит его в int
{
    int numberint = Convert.ToInt32(text);
    return numberint;
}

Console.Write("Введите значение k1 ---> ");
int k1 = numberint(Console.ReadLine());
Console.Write("Введите значение b1 ---> ");
int b1 = numberint(Console.ReadLine());
Console.Write("Введите значение k2 ---> ");
int k2 = numberint(Console.ReadLine());
Console.Write("Введите значение b2 ---> ");
int b2 = numberint(Console.ReadLine());

int x = - (b1 - b2) / (k1 - k2);
int y = k1 * x + b1;



Console.Write($"\nТочка пересечения двух прямых ---> x-{x}, y-{y}");