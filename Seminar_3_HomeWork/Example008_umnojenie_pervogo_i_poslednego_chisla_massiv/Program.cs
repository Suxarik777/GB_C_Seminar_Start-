// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

int[] ResultNumArr(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    return result;
}

void PrintResult(int[] arr, int[] result)
{
    Console.WriteLine("Ответ по условиям задачи");
    for (int i = 0; i <= arr.Length / 2; i++) //гоним по всей длинне <=, 
    {                                       //чтобы иметь возможность вывести центр число
        if (i < arr.Length / 2)
        {
            Console.WriteLine($"{arr[i]} * {arr[arr.Length - 1 - i]} = {result[i]}");
        }
        else if (arr.Length % 2 != 0 && i == arr.Length / 2) //проверка условия вывода
        {                                                   // центр числа при нечетном массиве
            Console.WriteLine($"Центральное число в массиве: {arr[i]}");
        }
    }
}

Console.Write("Укажите длину массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимальную цифру в массиве: ");
int minDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажиет максимальную цифру в массиве: ");
int maxDigit = Convert.ToInt32(Console.ReadLine());

int[] numArr = CreatArray(sizeArr, minDigit, maxDigit);
Console.WriteLine("Генерируем массив...");
PrintArray(numArr);

int[] resultArr = ResultNumArr(numArr);
PrintResult(numArr, resultArr);