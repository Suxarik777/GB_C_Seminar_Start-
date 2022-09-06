// Написать программу возведения числа А в целую стень B

int InputNumberA(string text)
{
    Console.Write(text);
    int numberA = int.Parse(Console.ReadLine());
    return numberA;
}

int InputNumberB(string text)
{
    Console.Write(text);
    int numberB = int.Parse(Console.ReadLine());
    if (numberB > 0) return numberB;
    else return InputNumberB("Не получится! Нужно указать B больше нуля: ");
}


int RecursionPow(int a, int b)
{
    if (b > 0) return a * RecursionPow(a, b - 1);
    return 1;
}

int numberA = InputNumberA("Введите число A: ");
int numberB = InputNumberB("Введите степень B: ");

Console.WriteLine(RecursionPow(numberA, numberB));