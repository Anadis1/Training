Console.Write("Введите число - ");
string variable = Console.ReadLine();
int maxnumber = Convert.ToInt32(variable);
int number = 1;

while (number <= maxnumber)
{
    if (number % 2 == 0)
    {
        Console.Write($"{number}, ");
    }
    number++;   
}
