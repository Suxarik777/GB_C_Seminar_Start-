// Определить, присутствует ли в заданном массиве, некоторое число
// КОД НАПИСАН ПРЕПОДАВАТЕЛЕМ

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write($"{element} ");
}

int[] CreateArray(int size, int minimum, int maximum)
{
    int[] array = new int[size];
    var random = new Random();
    for (int i = 0; i < size; i++)
        array[i] = random.Next(minimum, maximum + 1);
    return array;
}

bool Contains(int[] array, int value)
{
    foreach (var element in array)
        if (element == value)
            return true;
    return false;
}

Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = CreateArray(size, -90, 90);

Console.Write("Your array: ");
PrintArray(array);

Console.WriteLine();

Console.Write("Enter element to find: ");
int element = int.Parse(Console.ReadLine() ?? "0");
bool contains = Contains(array, element);

Console.WriteLine(contains ? "Element contains in array" :
"Element doesn't contains in array");