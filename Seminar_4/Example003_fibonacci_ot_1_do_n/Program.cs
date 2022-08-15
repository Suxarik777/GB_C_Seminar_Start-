// Показать числа Фибоначчи меньшие заданного числа N
// ВНИМАНИЕ! 3 решение (закоментируй одно)

//Рекурсия
int Fib(int i)
{
    if(i < 1) return 0;
    if(i == 1) return 1;
    return Fib(i-1) + Fib(i - 2);
}
Console.Clear();
int N = int.Parse(Console.ReadLine());
int i = 0;
int j = 0;
while( j < N)
{
    Console.Write($"{Fib(i)} ");
    i++;
    j = Fib(i);
}

/////////////////////////////////

//просто цикл
int n = 10946;
int fibon1 = 0;
int fibon2 = 1;
Console.Write("0 1" + " ");
while (fibon2 <= n - fibon1)
{
int temp = fibon2;
fibon2 = fibon2 + fibon1;
fibon1 = temp;
Console.Write(fibon2 + " ");
}

///////////////////////////////

//через массив
int[] fibonacci = new int[1000];
fibonacci[0] = 1;
fibonacci[1] = 1;
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"{fibonacci[0]} {fibonacci[1]} ");
int index = 1;
while(fibonacci[index]<n)
{
    index++;
    fibonacci[index]=fibonacci[index-1]+fibonacci[index-2];
    if(fibonacci[index]<n)
        Console.Write($"{fibonacci[index]} ");
}