// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

int[] CreatArray(int size)
{
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(100, 1000);
    return array;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

int EvenDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int OddDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) count++;
    }
    return count;
}

Console.Write("Укажите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = CreatArray(length);

Console.WriteLine("Ваш массив: ");
PrintArray(numbers);

int evenNumberQsuantity = EvenDigits(numbers);
int oddNumbersQuantity = OddDigits(numbers);

Console.WriteLine($"В массиве {evenNumberQsuantity} четных и "
                + $"{oddNumbersQuantity} нечетных числа");

