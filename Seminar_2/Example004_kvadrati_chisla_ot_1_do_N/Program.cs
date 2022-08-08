// Показать таблицу квадратов чисел от 1 до N

Console.Write("Введите число N: ");
int userNumber = int.Parse(Console.ReadLine());

//int length = userNumber;
int index = 1;

while(index <= userNumber)
{
    int result = index * index;
    Console.WriteLine($"Квадрат числа {index} равен {result}");
    index++;
}