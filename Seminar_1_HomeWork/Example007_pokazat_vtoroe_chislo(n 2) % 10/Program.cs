// Показать вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Дано трёхзначное число: {number}");

int digitTwo = (number / 10) % 10; // получение средней цифры без остатка 25 / 2 = 10

Console.WriteLine($"Вторая цифра: {digitTwo}");