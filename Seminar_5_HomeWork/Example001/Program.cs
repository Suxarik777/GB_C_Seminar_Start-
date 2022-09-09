﻿// Театральная площадь в столице Берляндии представляет собой прямоугольник 
// n × m метров. По случаю очередного юбилея города, было принято решение 
// о замощении площади квадратными гранитными плитами. Каждая плита имеет размер a × a.

// Какое наименьшее количество плит понадобится для замощения площади? 
// Разрешено покрыть плитами большую поверхность, чем театральная площадь, 
// но она должна быть покрыта обязательно. Гранитные плиты нельзя ломать или дробить, 
// а разрешено использовать только целиком. 
// Границы плит должны быть параллельны границам площади.

// Входные данные
// В первой строке записано три целых натуральных числа n, m и a (1 ≤ n, m, a ≤ 109).

// Выходные данные
// Выведите искомое количество плит.

// Примеры
// входные данныеСкопировать
// 6 6 4
// выходные данныеСкопировать
// 4

//https://codeforces.com/contest/1/problem/A

// тип данных long //натуральные целочисленные

// m/a
// n/a

// если целые числа 
// если нецелые числа

Console.WriteLine("Укажите: Длину, ширину, сторону квадратной плиты: ");
string str = Console.ReadLine();
int[] num = str.Split(' ').Select(int.Parse).ToArray();
long x,y;
x = num[0] / num[2];
y = num[1] / num[2];
if (num[0] % num[2] != 0)
    x++;
if (num[1] % num[2] != 0)
    y++;
Console.WriteLine(x*y);