// Найти кубы чисел от 1 до N

int CubeNumber (int num)
{
    int cube = 3;
    int rezult = num;
    int index = 1;
    
    while(index < cube)
    {
        rezult = rezult * num;
        index++;
    }
    return rezult;
}

Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

int index = 1;
int result = 0;
while(index <= numberN)
{
    result = CubeNumber(index);
    Console.WriteLine($"Куб числа {index} = {result}");
    index++;
}