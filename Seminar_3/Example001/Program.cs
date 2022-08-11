// Задать массив из 8 элементов и вывести их на экран

void FillArray(int[] arrayColection)
{
    int index = 0;
    while (index < arrayColection.Length)
    {
        arrayColection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] arrayColection)
{
    int index = 0;
    while (index < arrayColection.Length)
    {
        Console.WriteLine($"Данные массива в {index + 1} ячейки - {arrayColection[index]}");
        index++;
    }
}


int[] array = new int[8];
FillArray(array);
PrintArray(array);
