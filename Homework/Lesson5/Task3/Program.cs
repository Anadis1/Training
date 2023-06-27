//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GenerateArray()		                // Создает и наполняет массив
{
    double[] list1 = new double[6];
    Random rnd = new Random();
    double variable = 0;
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(0, 100) + rnd.NextDouble();
    }
    return list1;
}

void PrintArrey(double[] Arrey)		            // Показывает в терминале массив
{
    Console.Write($"Массив --> ");
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write($"\t{Arrey[i]:f1}");
    }
}


double[] list1 = GenerateArray();
PrintArrey(list1);

double min = list1[0];
double max = 0;
for (int i = 0; i < list1.Length; i++)
{
    if(min > list1[i])
    {
        min = list1[i];
    }
    if(max < list1[i])
    {
        max = list1[i];
    }

}

System.Console.WriteLine($"\nМинимальное число в массиве ---> {min:f1}\nМаксимальное число в массиве ---> {max:f1}\nРазница между максимальным и минимальным числом ---> {max - min:f1}");