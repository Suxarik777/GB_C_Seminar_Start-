// Найти сумму элементов от M до N, N и M заданы

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string SumUpToMN(int digitM, int digitN, int sum)
{
    if (digitM < digitN)
    {
        sum += digitM;
        return $" {digitM} +" + SumUpToMN(digitM + 1, digitN, sum);
    }
    else if (digitM == digitN)
    {
        sum += digitM;
        return $" {digitM}  " + SumUpToMN(digitM + 1, digitN, sum);
    }
    return $"= {sum}";
}

string SumDownToMN(int digitM, int digitN, int sum)
{
    if (digitM > digitN)
    {
        sum += digitM;
        return $" {digitM} +" + SumDownToMN(digitM - 1, digitN, sum);
    }
    else if (digitM == digitN)
    {
        sum += digitM;
        return $" {digitM}  " + SumDownToMN(digitM - 1, digitN, sum);
    }
    return $"= {sum}";
}

int numberM = InputNumber("Введите число M: ");
int numberN = InputNumber("Введите число N: ");
int sum = 0;

if (numberM <= numberN) 
    Console.WriteLine(SumUpToMN(numberM, numberN, sum));
else if (numberM > numberN)
    Console.WriteLine(SumDownToMN(numberM, numberN, sum));
