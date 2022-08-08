// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Введите число: ");
int numberUser = int.Parse(Console.ReadLine());

if(numberUser % 7 == 0 && numberUser % 23 == 0)
{
    Console.WriteLine($"Число {numberUser} кратно 7 и 23");
}
else
{
    Console.WriteLine($"ОЙ! Число {numberUser} не кратно 7 и 23 ((");
}