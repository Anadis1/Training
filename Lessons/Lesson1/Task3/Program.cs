// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

string [] week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.Write("Введите день недели");

string weekday = Console.ReadLine();
int dayNumber = Convert.ToInt32(weekday);
if (dayNumber < 0 || dayNumber > 6)
{
    Console.WriteLine("Error");
}
else
{
    Console.WriteLine(week[dayNumber-1]);
}