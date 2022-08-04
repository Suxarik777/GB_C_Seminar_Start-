int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);


Console.WriteLine("Мы сгенерировали два числа: ");
Console.WriteLine("Первое число: " + a);
Console.WriteLine("Второе число: " + b);

if (a > b)
{
    Console.WriteLine("Больше первое число: " + a);
    Console.WriteLine("Меньше второе число: " + b);
}
else if (a < b)
{
    Console.WriteLine("Меньше первое число: " + a);
    Console.WriteLine("Больше второе число: " + b);
}
else
{
    Console.WriteLine($"Первое число: {a} и второе число: {b} равны.");
}

