// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Укажите номер дня недели: ");
int numberDay = int.Parse(Console.ReadLine());

if(numberDay >= 1 && numberDay <= 5)
{
    Console.WriteLine("Это не выходной. Продолжайте работать ;)");
}
else if(numberDay >= 6 && numberDay <= 7)
{
    Console.WriteLine("Да! Вы ввели номер выходного дня. Пойдём отдыхать!");
}
else
{
    Console.WriteLine("УПС! Что то пошло не так. Попробуйте ввести числа от 1 до 7");
}
