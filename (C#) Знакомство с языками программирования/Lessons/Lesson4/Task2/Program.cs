int lengthnumber(int arg)     // Определяет длинну числа
{
    int temporarynunber = arg;
    int lengthnunber = 0;
    while(temporarynunber > 0)
    {
        temporarynunber /= 10;
        lengthnunber += 1;
    }
    return lengthnunber;
}

int redin(string tex)
{
    Console.WriteLine(tex);
    string number = Console.ReadLine();
    int number2 = Convert.ToInt32(number);
    return number2;
}

int number2 = redin($"Введите число");
int c = lengthnumber(number2);



Console.WriteLine(c);