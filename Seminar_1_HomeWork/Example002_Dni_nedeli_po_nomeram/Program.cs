// По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");
int numberDay = int.Parse(Console.ReadLine());

if (numberDay == 1)
{
    Console.WriteLine($"Номер {numberDay} это Понедельник");
}
else if (numberDay == 2)
{
    Console.WriteLine($"Номер {numberDay} это Вторник");
}
else if (numberDay == 3)
{
    Console.WriteLine($"Номер {numberDay} это Среда");
}
else if (numberDay == 4)
{
    Console.WriteLine($"Номер {numberDay} это Четверг");
}
else if (numberDay == 5)
{
    Console.WriteLine($"Номер {numberDay} это Пятница");
}
else if (numberDay == 6)
{
    Console.WriteLine($"Номер {numberDay} это Суббота");
}
else if (numberDay == 7)
{
    Console.WriteLine($"Номер {numberDay} это Воскресенье");
}
else
{
    Console.WriteLine("Вы ввели не существующий день недели, попробуйте ввести числа от 1 до 7");
}