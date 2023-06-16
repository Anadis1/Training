System.Console.WriteLine("Укажите четверть ");

static void DeterminadeDiapozon(int GetQuorterNumber)
{
    switch (GetQuorterNumber)
    {
        case 1:
            System.Console.WriteLine("Первая четверть, диапозон x равен 1 - до бесконечности, y равен 1 - до бесконечности ");
            break;
        case 2:
            System.Console.WriteLine(" Вторая четверть, диапозон x равен -1 - (-до бесконечности), y равен 1 - до бесконечности ");
            break;
        case 3:
            System.Console.WriteLine("Третья четверть, диапозон x равен -1 - (-до бесконечности), y равен -1 - (-до бесконечности) ");
            break;
        case 4:
            System.Console.WriteLine("Четвертая четверть, диапозон x равен 1 - до бесконечности, y равен -1 - (-до бесконечности) ");
            break;
    }
   
}
string quorter = Console.ReadLine();
int GetQuorterNumber = Convert.ToInt32(quorter);

bool ValidateCoords(int GetQuorterNumber)
{
    if (GetQuorterNumber > 0 && GetQuorterNumber <= 4)
    {
        return true;
    }
    System.Console.WriteLine("Такой четверти нет ");
    return false;
}

if (ValidateCoords(GetQuorterNumber))
{
    DeterminadeDiapozon(GetQuorterNumber);

}