// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Задайте число N: ");
int numberN = int.Parse(Console.ReadLine());

int result = 1;
int index = 1;
while(index < numberN)
{
    result = result * (index + 1);
    index++;
}

Console.WriteLine($"Произведение чисел от 1 до {numberN} = {result}");