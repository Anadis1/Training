// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GenerateArray(int len, int min, int max)
{
    int[] answer = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + "\t");
    }
    System.Console.WriteLine();
}

int SumPositive(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if (item > 0)
        {
            sum += item;
        }
    }
    return sum;
}

int SumNegative(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if (item < 0)
        {
            sum += item;
        }
    }
    return sum;
}

int SumPlus(int[] array, bool isPositive = true)
{
    int sign = -1;
    if (isPositive)
    {
        sign = 1;
    }

    int sum = 0;
    foreach (int item in array)
    {
        if (item * sign > 0)
        {
            sum += item;
        }
    }
    return sum;
}

int[] array = GenerateArray(12, -9, 9);
PrintArray(array);
System.Console.WriteLine($"Сумма положительных элементов {SumPositive(array)}");
System.Console.WriteLine($"Сумма отрицательных элементов {SumNegative(array)}");
System.Console.WriteLine($"Сумма положительных и отрицательных элементов {SumPlus(array)}, {SumPlus(array, false)}");