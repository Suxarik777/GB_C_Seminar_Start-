// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


int[] CreatArray(int size)
{
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

int sizeArray = 8;
int[] numbers = CreatArray(sizeArray);

Console.WriteLine("Массив из 8 элементов:");
PrintArray(numbers);