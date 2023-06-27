// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int numberint()                                 
{
    string numint = Console.ReadLine();
    int numberint = Convert.ToInt32(numint);
    return numberint;
}

int[] array1(int arg)   // Создаем массив на основе ввода пользователя
{
    int[] list = new int[arg];
    for (int i = 0; i < arg; i++)
    {
        Console.Write($"Введите число № {i + 1} ---> ");
        list[i] = numberint();
    }
    
    for (int i = 0; i < arg; i++)    // Показываю массив в терминале
    {
        Console.Write($"{list[i]}\t");
    }
    
    return list;
}

int posNum(int[] array)    // Считает кол-во положительных чисел
{
    int posnum1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            posnum1 += 1;
        }
    }
    return posnum1;
}

Console.Write("Сколько чисел всего? ---> ");
int num = numberint();
int[] list1 = array1(num);
int positiveNumbers = posNum(list1);

Console.Write($"\nЧисел больше нуля ---> {positiveNumbers}");

