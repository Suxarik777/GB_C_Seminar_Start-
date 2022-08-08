// Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


Console.Write("Укажите X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Укажите Y: ");
int y = int.Parse(Console.ReadLine());

if (x != 0 && y != 0)
{
    if (x < 0 && y > 0)
    {
        Console.WriteLine("То это 1 четверть");
    }
    else if (x > 0 && y > 0)
    {
        Console.WriteLine("То это 2 четверть");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("То это 3 четверть");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("То это 4 четверть");
    }
}
else
{
    Console.WriteLine("Вы ввели число 0, введите значение, которое не равно 0");
}