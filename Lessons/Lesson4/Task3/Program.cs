//Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

int redin(string tex)
{
    Console.WriteLine(tex);
    string number = Console.ReadLine();
    int number2 = Convert.ToInt32(number);
    return number2;
}

int number2 = redin($"Введите число");


int Factorial(int number)
{

int index = 1;
int fact = 1;

while(index <= number2)
{
    fact = fact * index;
    index++;
}
return fact;
}

int Factorial2(int number)
{

int fact = 1;

for(int index = 1; index <= number; index++)
{
    fact = fact * index;
}
return fact;
}


int sum = Factorial(number2);
int sum2 = Factorial2(number2);

Console.Write(sum);
Console.WriteLine();
Console.Write(sum2);