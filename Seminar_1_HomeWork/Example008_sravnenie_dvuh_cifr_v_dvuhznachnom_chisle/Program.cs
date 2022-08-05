// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 100);

Console.WriteLine($"Дано число: {number}");

int digit1 = number / 10; //поиск первого числа в двухзначном числе
int digit2 = number % 10; //поиск последнего числа
if (digit1 > digit2)
{
    Console.WriteLine($"Первая цифра: {digit1} наибольшая в числе {number}");
}
else if (digit1 < digit2)
{
    Console.WriteLine($"Вторая цифра: {digit2} наибольшая в числе {number}");
}
else
{
    Console.WriteLine($"Обе цифры числа {number}, равны");
}

