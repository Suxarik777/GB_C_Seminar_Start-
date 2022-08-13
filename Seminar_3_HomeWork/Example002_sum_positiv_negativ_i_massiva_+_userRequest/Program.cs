// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] CreatArray(int size)
{
    var array = new int[size];
    Random random = new Random();
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

int SumElementAr(int[] array, string sign)
{
    int sum = 0;
    if (sign == "+")
    {
        foreach (var element in array)
            if (element > 0) sum += element;
    }
    else if (sign == "-")
    {
        foreach (var element in array)
            if (element < 0) sum += element;
    }
    return sum;
}

void PrintResult(int sum, string sign)
{
    if (sign == "+")
        Console.WriteLine($"Сумма положительных элементов массива:  {sum}");
    else if(sign == "-")
        Console.WriteLine($"Сумма отрицательных элементов массива:  {sum}");
    else
      Console.WriteLine($"User Error. Please repeat the request!");  
}


int sizeInArray = 12;
int[] numberAr = CreatArray(sizeInArray);

Console.WriteLine($"Массив из {sizeInArray} элементов:");
PrintArray(numberAr);

Console.WriteLine("Укажите сумму положительных или отрицательных "
                + "элементов массива мы будем искать?");
Console.Write("Введите + или -: ");
string userRequest = Console.ReadLine();

int result = SumElementAr(numberAr, userRequest); //(массив и параметр поиска элементов)
PrintResult(sum: result, sign: userRequest);