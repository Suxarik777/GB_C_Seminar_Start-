// По двум заданным числам проверять является ли одно квадратом другого

bool NumberSquare(int numberA, int numberB)
{
    if(numberB == numberA * numberA)
    {
        return true;
    }
    else
    {
        return false;
    }
}


Console.Write("Введите число №1: ");
int number1 = int.Parse(Console.ReadLine()); 

Console.Write("Введите число №2: ");
int number2 = int.Parse(Console.ReadLine());

bool resultA2B = NumberSquare(number1, number2);
bool resultB2A = NumberSquare(number2, number1);

Console.WriteLine($"Число №2 квадрат числа №1: {resultA2B}");
Console.WriteLine($"Число №1 квадрат числа №2: {resultB2A}");