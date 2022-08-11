// Определить, присутствует ли в заданном массиве, некоторое число

int[] UserSizeArray()
{
    Console.Write("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    return array;
}

void FillRandomArray(int[] array)
{
    Console.Write("Введите минимальное Random число: ");
    int min = int.Parse(Console.ReadLine());
    Console.Write("Введите максимальное Random число: ");
    int max = int.Parse(Console.ReadLine());

    var random = new Random(); //второй вариант написания кода Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1); //+1 добавляем, потому что в рандоме полуинтеграл
    }
}


void PrintArray(int[] arrayColection)
{
    foreach(var element in arrayColection) //один из видов цикла пробежки по массиву
        Console.Write($"{element} ");   
    Console.WriteLine();                    // пустая строка для красоты
    //     Console.Write(arrayColection[index] + ", ");
}

int IndexOf(int[]array, int find)
{
    int position = -1;                      //указывается -1 чтобы можно было понять что нету
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == find)
        {
            position = i;
            break;
        }
    }
    return position;
}

int[] array = UserSizeArray();
FillRandomArray(array);
PrintArray(array);

Console.Write("Введите число которое мы должны найти в массиве: ");
int number = int.Parse(Console.ReadLine());
int posNumberArray = IndexOf(array, number);

if(posNumberArray == -1)
    Console.WriteLine($"Число {number} не найдено в массиве");
else
    Console.WriteLine($"Число {number} находится в ячейке под номером {posNumberArray + 1}, с индексом {positionNumberArray}");