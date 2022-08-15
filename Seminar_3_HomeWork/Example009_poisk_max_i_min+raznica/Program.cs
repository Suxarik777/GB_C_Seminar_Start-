// В Указанном массиве вещественных чисел найдите разницу между 
// максимальным и минимальным элементом

int[] CreatArray(int length, int minNum, int maxNum)
{
    var array = new int[length];
    var random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minNum, maxNum + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

int[] SearchNumber(int[] array)
{
    int[] numbersMaxMin = new int[2]; // тупо ищем два числа макс и мин и записываем
    int maxNumberPos = 0;
    int minNumberPos = 0;
    for(int i = 0; i < array.Length; i++) //поиск максимального числа
        if(array[i] > array[maxNumberPos]) maxNumberPos = i;

    for(int i = 0; i < array.Length; i++) //поиск минимального числа
        if(array[i] < array[minNumberPos]) minNumberPos = i;

    numbersMaxMin[0] = array[maxNumberPos]; //записываем максимальное число
    numbersMaxMin[1] = array[minNumberPos]; //записываем минимальное число
    return numbersMaxMin;
}

Console.Write("Какая длина массива? ");
int sizeArr = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Запишите минимальную цифру в массиве: ");
int minDigit = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Запишите максимальную цифру в массиве: ");
int maxDigit = int.Parse(Console.ReadLine() ?? "0");

int[] numArr = CreatArray(sizeArr, minDigit, maxDigit);
Console.WriteLine("Волшебство с массивом...");
PrintArray(numArr);

int[] numbersMaxMinArr = SearchNumber(numArr); //запись макс и мин числа в массиве

Console.WriteLine($"Максимально число в массиве: {numbersMaxMinArr[0]}");
Console.WriteLine($"Минимальное число в массиве: {numbersMaxMinArr[1]}");

int result = numbersMaxMinArr[0] - numbersMaxMinArr[1];
Console.WriteLine($"{numbersMaxMinArr[0]} - {numbersMaxMinArr[1]} = {result}");
Console.WriteLine($"Ответ: разница между максимальным и минимальным " 
                + $"элементом массива: {result}");