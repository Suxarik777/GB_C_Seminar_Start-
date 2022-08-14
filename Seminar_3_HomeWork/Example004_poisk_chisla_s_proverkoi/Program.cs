// Определить, присутствует ли в заданном массиве, некоторое число

int[] CreatArrayRandom(int size)
{
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

bool SearchNumber(int[] array, int find)
{
    foreach (var element in array)
        if (element == find) 
            return true;
        return false;
}

int PositionNumber(int[] array, int find, bool answer)
{
    int position = -1;
    if (answer == true)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == find) 
            {
                position = i;
                break;
            }
        }
    }
    return position;
}



Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] searchArray = CreatArrayRandom(size);

Console.WriteLine("Вот ваш массив:");
PrintArray(searchArray);

Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

bool findNumber = SearchNumber(searchArray, number);
int positionNumber = PositionNumber(searchArray, number, findNumber);

Console.WriteLine(findNumber ? $"Число {number} найдено и находится " 
                + $"под индексом №: {positionNumber}" : 
                "Не повезло! Такого числа в массиве нет.");