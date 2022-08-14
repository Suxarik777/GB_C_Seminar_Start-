// Написать программу замену элементов массива на противоположные

int[] CreatArrayRandom(int size)
{
    var array = new int [size];
    var random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

int[] Replacing(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

Console.Write("Укажите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] randomNumbers = CreatArrayRandom(length);

Console.WriteLine("Начальная версия массива: ");
PrintArray(randomNumbers);

int [] randomNumbers2 = Replacing(randomNumbers);
Console.WriteLine("Массив с заменой элементов на противоположенные: ");
PrintArray(randomNumbers2);