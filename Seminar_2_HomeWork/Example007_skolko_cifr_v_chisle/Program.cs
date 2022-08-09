// Определить количество цифр в числе

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int numberPrint = number; //вспомогательная переменная для печати числа в конце

int count = 0;
while(number > 0)
{
    number = number/10;
    count++;
}

Console.WriteLine($"Кол-во цифр в числе {numberPrint}: {count}");