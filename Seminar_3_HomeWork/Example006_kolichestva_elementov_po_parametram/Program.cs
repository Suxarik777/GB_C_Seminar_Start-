// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] CreatArray()
{
    int size = 123;
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(0, 1000);
    return array;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

int QuantityNumbers(int[] array)
{
    int quantity = 0;
    foreach(var element in array)
        if(element >= 10 && element <= 99) quantity++;
    return quantity;
}

bool AreNumbers(int how)
{
    if(how > 0) return true;
    else return false;
}

int[] numbers = CreatArray();
Console.WriteLine("Массив вашему вниманию");
PrintArray(numbers);

int sumDigits = QuantityNumbers(numbers);

bool chekPrint = AreNumbers(sumDigits);
Console.WriteLine(chekPrint ? $"Кол-во элементов в отрезке [10, 99]: {sumDigits}" 
                : "Нет чисел  в отрезке [10, 99]");