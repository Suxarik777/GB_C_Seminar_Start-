// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Это ЭКСПЕРЕМЕНТАЛЬНОЕ выполнение задания с избыточным использованием массивов и функций
// нормальное выполнение по пути 
// GB_C_Seminar(Знакомство с языками программирования) > Seminar_2_HomeWork 
// > Example005_cube_chisla_ot_1_do_N

int[] CreatArrayOrder(int size) //заполение массива по порядку
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

int[] ArrayCube(int[] array)
{
    int[] newArray = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i] * array[i] * array[i];
    }
    return newArray;
}

void PrintArrayResult(int[] arraySource, int[] arrayResult)
{
    for(int i = 0; i < arraySource.Length && i < arrayResult.Length; i++)
    {
        Console.WriteLine($"Число {arraySource[i]} в кубе = {arrayResult[i]}");
    }
}

Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine() ?? "0");

int[] arrayNumbers = CreatArrayOrder(numberN);

int[] arrayNumbersCube = ArrayCube(arrayNumbers);

PrintArrayResult(arrayNumbers, arrayNumbersCube);