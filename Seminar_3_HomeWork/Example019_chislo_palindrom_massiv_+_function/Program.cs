// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int[] CreatArrayFix()
{
    int fixSize = 5;
    int[] array = new int[fixSize];
    Console.WriteLine($"Длина массива {fixSize} ячеек");
    FillArrayManually(array);
    return array;
}

void FillArrayManually(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число в массив: ");
        array[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write($"{element} ");
}

bool CheckArrayPalindrom(int[] array)
{
    int check = 0;
    for (int i = 0; i < (array.Length - 1) / 2; i++)
    {
        if (array[i] == array[array.Length - 1 - i]) // -1 поскольку .Length считает не с нуля
        {
            check++;
        }
    }
    if(check == (array.Length - 1) / 2) return true;
    else return false;
}

Console.WriteLine("Создание массива...");
int[] array = CreatArrayFix();
Console.WriteLine();

Console.WriteLine("Печать массива...");
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Проверка массива на палиндром...");
bool check = CheckArrayPalindrom(array);

Console.WriteLine(check ? "Ура!!! Число является палиндромом!" :
"Упс... Число не является палиндромом :(");