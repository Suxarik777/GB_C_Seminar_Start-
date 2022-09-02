// Показать натуральные числа от 1 до N, N задано

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string FromToN (int digit, int n)
{
    if (digit <= n) return $"{digit} " + FromToN(digit + 1, n); 
    else return String.Empty;
}

int numberN = InputNumber("Введите число N: ");
int number = 1;

Console.WriteLine(FromToN(number, numberN));