﻿// Кажется, еще совсем недавно наступил новый 2013 год. А знали ли Вы забавный факт о том, 
// что 2013 год является первым годом после далекого 1987 года, в котором все цифры различны?

// Теперь же Вам предлагается решить следующую задачу: задан номер года, 
// найдите наименьший номер года, который строго больше заданного и в котором все цифры различны.

// Входные данные
// В единственной строке задано целое число y (1000 ≤ y ≤ 9000) — номер года.

// Выходные данные
// Выведите единственное целое число — минимальный номер года, который строго больше y, 
// в котором все цифры различны. Гарантируется, что ответ существует.

// Примеры
// входные данныеСкопировать
// 1987
// выходные данныеСкопировать
// 2013

// входные данныеСкопировать
// 2013
// выходные данныеСкопировать
// 2014



// int year = int.Parse(Console.ReadLine());

// void NextDiffYear(int year)
// {
//     for (int y = year + 1; ; y++)
//     {
//         int a = y / 1000;
//         int b = y / 100 % 10;
//         int c = y / 10 % 10;
//         int d = y % 10;
//         if (a != b && b != c && c != d && a != c && a != d && b != d)
//         {
//           Console.WriteLine(y); 
//             return;
//         }
//     }
// }
// NextDiffYear(year);


// Console.WriteLine("Введите число для проверки: ");
// int n = int.Parse(Console.ReadLine() ?? "0");
// bool k = false; 
// for(int i=0; i < Digitsnumber(n); i++)
// {    
//     if((Digitindex(n,i+1) == 4 || Digitindex(n,i+1) == 7)
//         &&(Digitsnumber(n) == 4 || Digitsnumber(n) == 7))
//         k = true;
// }
// if(k == true)
// {
//     Console.WriteLine("Да, введенное Вами число является счастливым.");
// }
// else
// {
//     Console.WriteLine("Нет, введенное Вами число не является счастливым.");
// }