// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] newArrayOnLenghth(string[] Array)           // создает новый массив где переменные ровны трем символам или менее
{
    int ArrayLength = 0;
    for (int i = 0; i < Array.Length; i++)          
    {
        int temporary = Array[i].Length;

        if (temporary <= 3)
        {
            ArrayLength++;
        }
    }
    string [] temporarilyArray = new string[ArrayLength];
    int index = 0;
    for (int i = 0; i <= Array.Length - 1; i++)          
    {
        int temporary = Array[i].Length;

        if (temporary <= 3)
        {
            temporarilyArray[index] = Array[i];
            index+= 1;
        }
    }
    return temporarilyArray;

}

void printArrey(string[] Arrey)				// Показывает в терминале массив
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
}


string[] originalArray = { "День", "Ночь", "Три", "Пять", "Лак", "Краска", "Бык", "Як", "Зеленка", "Йод" };
string[] finishedArray = newArrayOnLenghth(originalArray);

printArrey(finishedArray);
