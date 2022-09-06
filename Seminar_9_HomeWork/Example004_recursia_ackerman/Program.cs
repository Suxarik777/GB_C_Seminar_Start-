// Написать программу вычисления функции Аккермана

int InputNumberM(string text)
{
    Console.Write(text);
    int numberM = int.Parse(Console.ReadLine());
    if (numberM > 0) return numberM;
    else return InputNumberM("Не получится! Нужно указать M больше нуля: ");
}

int InputNumberN(string text, int m)
{
    Console.Write(text);
    int numberN = int.Parse(Console.ReadLine());
    if (numberN > m) return numberN;
    else return InputNumberN("Не получится! Нужно указать N, чтобы была больше M: ", m);
}

int AckermanRecursion(int m, int n)
{
    if (m == 0)                 return n + 1;
    else if (n == 0 && m > 0)   return AckermanRecursion(m - 1, 1);
    else                        return AckermanRecursion(m - 1, AckermanRecursion(m, n - 1));
}

int numberM = InputNumberM("Введите число M: ");
int numberN = InputNumberN("Введите число N: ", numberM);

Console.WriteLine(AckermanRecursion(numberM, numberN));
