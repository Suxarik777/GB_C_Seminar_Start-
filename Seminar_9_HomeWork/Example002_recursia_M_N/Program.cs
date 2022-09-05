// Показать натуральные числа от M до N, N и M заданы

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string FromUpToMN(int digitM, int digitN)
{
    if (digitM <= digitN) return $"{digitM} " + FromUpToMN(digitM + 1, digitN);
    return String.Empty;
}

string FromDownToMN(int digitM, int digitN)
{
    if (digitM >= digitN) return $"{digitM} " + FromDownToMN(digitM - 1, digitN);
    return String.Empty;
}

int numberM = InputNumber("Введите число M: ");
int numberN = InputNumber("Введите число N: ");

if (numberM <= numberN) 
    Console.WriteLine(FromUpToMN(numberM, numberN));
else if (numberM > numberN)
    Console.WriteLine(FromDownToMN(numberM, numberN));

