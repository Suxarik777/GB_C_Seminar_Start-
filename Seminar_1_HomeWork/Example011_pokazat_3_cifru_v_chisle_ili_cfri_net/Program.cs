// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99)
{
    Console.WriteLine("Третья цифра в числе: " + number.ToString()[2]);
}
else
{
    Console.WriteLine("В числе нет третьей цифры");
}