Console.Write("Введите первое число");
string stnum1 = Console.ReadLine();
int num1 = Convert.ToInt32(stnum1);

Console.Write("Введите второе число");
string stnum2 = Console.ReadLine();
int num2 = Convert.ToInt32(stnum2);

if (num1 > num2) 
{
    Console.WriteLine($"Большее число {num1}, Меньшее число {num2}");
}
if (num1 < num2) 
{
    Console.WriteLine($"Большее число {num2}, Меньшее число {num1}");
}
else
{
    Console.WriteLine("Числа равны");
}