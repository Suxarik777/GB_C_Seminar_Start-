// Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    if (number > 0) return number;
    else return InputNumber("Не получится! Нужно указать N больше нуля: ");
}

int InputNumberFirst(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int InputNumberSecond(string text, int a)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    if (number > a) return number;
    else return InputNumberSecond("Не получится! Нужно указать число, чтобы было больше первого: ", a);
}



// int ProgramNumbersSumStep(int n, int first, int second)
// {
//     int i = first;
//     int j = second;
//     while(j < n)
//     {
//         return Console.Write($"{FibUpgreat(i,j)} ");
//         i++;
//         j = FibUpgreat(i,j);
//     }
// }


int Fib(int i, int j)
{
    if(i < 1) return 0;
    if(i == j) return i;
    return Fib(i-1, j) + Fib(i - 2, j);
}


int numberN = InputNumber("Введите сколько чисел показать: ");
int numberA = InputNumberFirst("Укажите первое число: ");
int numberB = InputNumberSecond("Укажите второе число: ", numberA);


int i = numberA;
int j = numberB;
while( j < numberN)
{
    Console.Write($"{Fib(i, j)} ");
    i++;
    j = Fib(i, j);
}