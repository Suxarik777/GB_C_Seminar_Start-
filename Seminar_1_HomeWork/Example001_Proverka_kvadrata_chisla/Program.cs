// По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());

if (numberTwo * numberTwo == numberOne)
{
    Console.Write($"Олично! {numberOne} является квадратом второго числа {numberTwo}");
}
else
{
    Console.Write($"Нет! {numberOne} не является квадратом второго числа {numberTwo}");
}