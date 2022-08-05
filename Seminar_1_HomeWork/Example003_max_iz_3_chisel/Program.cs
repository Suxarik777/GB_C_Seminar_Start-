// Найти максимальное из трех чисел

Console.WriteLine("Смотрим три числа");

int number1 = new Random().Next(1, 10);
Console.WriteLine($"Первое число: {number1}");
int number2 = new Random().Next(1, 10);
Console.WriteLine($"Второе число: {number2}");
int number3 = new Random().Next(1, 10);
Console.WriteLine($"Третье число: {number3}");  

int max = 0;

if(max < number1)
{
    max = number1;
}
else if(max < number2)
{
    max = number2;
}
else if(max < number3)
{
    max = number3;
}

Console.WriteLine($"Наибольшее число: {max}");

