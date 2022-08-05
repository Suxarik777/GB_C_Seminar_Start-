// Показать числа от -N до N

Console.Write("Введите отрицательное число: ");
int numberNegative = int.Parse(Console.ReadLine());
Console.Write("Введите положительное число: ");
int numberPositive = int.Parse(Console.ReadLine());

int numberPrint = numberNegative; //с этой переменной легче читать код
while (numberPrint <= numberPositive)
{
    Console.Write(numberPrint + " ");
    numberPrint++;
}
Console.WriteLine(" ");



