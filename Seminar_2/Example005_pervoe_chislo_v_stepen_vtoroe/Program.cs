// Возведите число А в натуральную степень B используя цикл
int NumberStep(int numberDigit, int numberStep)
{
    int index = 1;
    int result = numberDigit;

    while(index < numberStep)
    {
        result = result * numberDigit;
        index++;
    }
    return result;
}

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int result = NumberStep(numberA, numberB);

Console.WriteLine($"Число {numberA} в натуральной степени {numberB} равняется {result}");

// int index = 1;
// int result = numberA;

// while(index < numberB)
// {
//     result = result * numberA;
//     index++;
// }

