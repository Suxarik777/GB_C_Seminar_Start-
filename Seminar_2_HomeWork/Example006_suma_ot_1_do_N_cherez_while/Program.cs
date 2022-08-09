// Найти сумму чисел от 1 до А

Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());

int index = 1;
int result = 1;
while (index < numberA)
{
    result = result + (index + 1);
    index++;
}
Console.WriteLine($"Сумма чисел от 1 до {numberA} = {result}");