// Найти сумму цифр числа



int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SplitNumber(int number)
{
    if(number == 0) return 0;
    else return number % 10 + SplitNumber(number / 10); //% остаток от деления на 10 берёт последнюю цифру
}


int number = InputNumber("Введите число: ");
Console.WriteLine(SplitNumber(number));
