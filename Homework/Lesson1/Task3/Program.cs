Console.Write("Введите число - ");
string stnum1 = Console.ReadLine();
int num1 = Convert.ToInt32(stnum1);

int num2 = num1 % 2;

if (num2 == 0)
{
    Console.Write($"{num1} является четным числом");
}

else
{
    Console.Write($"{num1} не является четным числом");
}
