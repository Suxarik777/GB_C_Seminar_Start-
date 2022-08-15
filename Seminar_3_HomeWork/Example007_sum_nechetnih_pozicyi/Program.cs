// Найти сумму чисел одномерного массива стоящих на нечетной позиции


int[] CreatArray(int length, int minNumber, int maxNumber)
{
    var array = new int[length];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minNumber, maxNumber + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

void PrintArrayIndexOdd(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (array.Length % 2 != 0)       // определяем четная не четная длинна
        {
            if ((i + 1) % 2 != 0 && array.Length - 1 != i)
                Console.Write(array[i] + " + ");
            else if ((i + 1) % 2 != 0 && array.Length - 1 == i)
                Console.Write(array[i] + " ");      //на последнем плюс не ставим

        }
        else if (array.Length % 2 == 0)
        {
            if ((i + 1) % 2 != 0 && array.Length - 2 != i)
                Console.Write(array[i] + " + ");
            else if ((i + 1) % 2 != 0 && array.Length - 2 == i)
                Console.Write(array[i] + " ");  //на препоследним плюс не ставим
        }                                    // (потому что последний четный и мы его пропустим)
}

void CheckUser(int minNumber, int maxNumber)
{
    if (minNumber > maxNumber)
        System.Diagnostics.Process.GetCurrentProcess().Kill(); //сброс программы
}

int SumArrOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if ((i + 1) % 2 != 0) sum += array[i];
    return sum;
}

Console.Write("Введите длинну массива: ");
int sizeArr = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное число генерации: ");
int minRandom = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное число генерации: ");
int maxRandom = int.Parse(Console.ReadLine() ?? "0");

CheckUser(minRandom, maxRandom);
int[] numberArr = CreatArray(sizeArr, minRandom, maxRandom);
PrintArray(numberArr);

int answer = SumArrOddIndex(numberArr);
Console.WriteLine("Сумма чисел на нечетных позициях: ");
PrintArrayIndexOdd(numberArr);
Console.WriteLine($"= {answer}");