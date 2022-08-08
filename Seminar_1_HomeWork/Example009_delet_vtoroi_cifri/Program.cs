// Удалить вторую цифру трёхзначного числа

int numRandom = new Random().Next(100, 1000);
Console.WriteLine($"Генерируем случайное трёхзначное число: {numRandom}");

int digit1 = numRandom / 100; //получение первой цифры
int digit2 = (numRandom / 10) % 10; //получение второй цифры 
int digit3 = numRandom % 10; //получение третьей цифры

string digitString1 = Convert.ToString(digit1); //ковертируем цифры в строки
string digitString3 = Convert.ToString(digit3);
                                                //есть вариант пойти путём формулы
                                                //int newNumber = digit1 * 10  + digit3; 
                                                // преобразование трёхзначного числа в двухзначное 
                                                //(первая цифра умножить на 10 + вторая цифра)

string twoDigitNumber = digitString1 + digitString3;

// второй вариант поиска
                                
//int digit1 = numRandom / 100; делим на сотые получаем первую цифру
//int digit3 = numRandom % 10; делим с остатком на 10 последняя цифра
//int result = digit1 * 10 + digit3;

Console.WriteLine($"Удаляем вторую цифру и получаем: {twoDigitNumber}");