// Показать последнюю цифру трёхзначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Дано трёхзначное число: {number}");

int digitLast = number % 10; //поиск последней цифры в трёхзначном числе

Console.WriteLine($"Последняя цифра: {digitLast}");