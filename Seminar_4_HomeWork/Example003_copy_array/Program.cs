// Написать программу копирования массива

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    return number;   
}

int[] CreatArray(int length, int minNum, int maxNum)
{
    int[] array = new int [length];
    var random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minNum, maxNum + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int [array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return array;
}

void PrintArray(string text, int[] array)
{
    Console.WriteLine(text);
    foreach(var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}


int length = InputNumber("Введите длину массива ");
int minNum = InputNumber("Введите минимальное число массива ");
int maxNum = InputNumber("Введите максимальное число массива ");

int[] array = CreatArray(length, minNum, maxNum);
int[] copyArray = CopyArray(array);

Console.WriteLine();
PrintArray("Оригинальный массив:", array);
PrintArray("Копия массива:", copyArray);