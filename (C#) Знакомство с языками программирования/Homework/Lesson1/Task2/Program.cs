Console.Write("Введите первое число ");
string stnum1 = Console.ReadLine();
int num1 = Convert.ToInt32(stnum1);

Console.Write("Введите второе число ");
string stnum2 = Console.ReadLine();
int num2 = Convert.ToInt32(stnum2);

Console.Write("Введите третье число ");
string stnum3 = Console.ReadLine();
int num3 = Convert.ToInt32(stnum3);

int numbermax = num1;

if (numbermax <= num2)
{
    numbermax = num2;
}

if (numbermax <= num3)
{
    numbermax = num3;
}

Console.WriteLine($"Большее из введенных чисел - {numbermax}");
