// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Напишите целое положительное");
string input_string1 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = -number1;
while (number2 <= number1)
{
    Console.Write($"{number2} ");
    number2++;
}