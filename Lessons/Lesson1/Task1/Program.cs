// Напишите программу, которая на вход принимает число и выдаёт его квадрат 
// (число умноженное на само себя).

Console.Write("Введите число => ");                             // Вывод приглашения на экран
string inputedString = Console.ReadLine();                      // Ввод пользователя (строка)
int number = Convert.ToInt32(inputedString);                    // Преобразование строки в число
Console.WriteLine($"Вы ввели число {number}!");                 // Вывод введенного значения

int square = number * number;                                   // Вычисление квадрата (логика программы)
Console.WriteLine($"Квадрат числа {number} равен {square}");    // Вывод результата