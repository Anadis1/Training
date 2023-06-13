int what = new Random().Next(10, 99);

Console.WriteLine($"Число - {what}");

int n1 = what / 10;
int n2 = what % 10;

if(n1 > n2)
{
    Console.WriteLine($"Большее число - {n1}");
}
else
{
    Console.WriteLine($"Большее число - {n2}");
}