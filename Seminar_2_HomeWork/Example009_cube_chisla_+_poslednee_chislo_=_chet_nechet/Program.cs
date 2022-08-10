// Показать кубы чисел, заканчивающихся на четную цифру

int CubeNumber(int num)
{
    int cube = 3;
    int rezult = num;
    int index = 1;

    while (index < cube)
    {
        rezult = rezult * num;
        index++;
    }
    return rezult;
}

Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

int index = 1;
int num = 0;
int numCheck = 0;
while (index <= numberN)
{
    num = CubeNumber(index);
    numCheck = num % 10 % 2;
    if (numCheck == 0)
    {
        Console.WriteLine($"Куб числа {index} заканчивается на четную цифру = {num}");
    }
    // else if(numCheck != 0)
    // {
    //     Console.WriteLine($"Куб числа {index} заканчивается на нечетную цифру = {num}");
    // }
    index++;
}