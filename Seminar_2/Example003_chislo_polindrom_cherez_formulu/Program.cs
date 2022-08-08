// Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите пятизначное число: ");
int userNumber = int.Parse(Console.ReadLine());

if (userNumber / 10000 == userNumber  % 10 && userNumber  / 1000 % 10 == userNumber  / 10 % 10)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Не является полиндромом");
}


///while(index < userNumber.Length)

