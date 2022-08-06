// Выяснить, кратно ли число заданному, если нет, вывести остаток.
// То есть делится ли ваше число нацело на заданое.

double numberRandom = new Random().Next(1, 10);
Console.WriteLine($"Дано число: {numberRandom}");

Console.Write("Введите своё число: ");
double numberUser = double.Parse(Console.ReadLine());

if (numberUser % numberRandom == 0)
{
    Console.WriteLine("Ваше число кратно заданому");
}
else
{
    Console.WriteLine("Ваше число не кратно второму");
    Console.WriteLine("Остаток от деления " + numberUser % numberRandom);
}