// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти, по отношению к осям X & Y: ");
int numberQuarter = int.Parse(Console.ReadLine());

double positive = double.PositiveInfinity; //записываем в переменную бесконечность
double negative = double.NegativeInfinity;

if(numberQuarter == 1)
{
    Console.WriteLine($"В четверти {numberQuarter}");
    Console.WriteLine($"ось X от -1 до {negative}");
    Console.WriteLine($"ось Y от 1 до {positive}");
}
else if
(numberQuarter == 2)
{
    Console.WriteLine($"В четверти {numberQuarter}");
    Console.WriteLine($"ось X от 1 до {positive}");
    Console.WriteLine($"ось Y от 1 до {positive}");
}
else if
(numberQuarter == 3)
{
    Console.WriteLine($"В четверти {numberQuarter}");
    Console.WriteLine($"ось X от 1 до {positive}");
    Console.WriteLine($"ось Y от -1 до {negative}");
}
else if
(numberQuarter == 4)
{
    Console.WriteLine($"В четверти {numberQuarter}");
    Console.WriteLine($"ось X от -1 до {negative}");
    Console.WriteLine($"ось Y от -1 до {negative}");
}
else
{
    Console.WriteLine("Упс! Что-то пошло не так!");
    Console.WriteLine("Попробуйте ввести числа от 1 до 4");
}