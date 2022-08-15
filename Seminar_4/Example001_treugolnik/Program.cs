// Выяснить являются ли три числа сторонами треугольника

bool CheckTriangle(int a, int b, int c)=> a+b>c && b+c>a && a+c>b; //возвращение true fals
   // return a+b>c && b+c>a && a+c>b; //можно ещё так

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine() ?? "0");

bool check = CheckTriangle(number1, number2, number3);
Console.WriteLine(check ? "Три числа являются сторонами треугольника" :
                    "Три числа не являются сторонами треугольника");