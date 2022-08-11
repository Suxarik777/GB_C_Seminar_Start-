// Дан массив из 10 целых чисел 
// в диапозоне от [-99,60] заменить в этом массиве отрицательные числа на 0

void FillArray(int[] arrayNew)
{
    int index = 0;
    int length = arrayNew.Length;
    //Random random = new Random(); //вынос создания нового рандома за пределы цикла
    //var random = new Random(); //var это тип данных который может быть определён
                                // из выражения справа (после равно)
                                // например var array = new int [10] вместо int[] array = new int [10]
    while(index < length)
    {
        arrayNew[index] = new Random().Next(-99,61);
        index++;
    }
}

void PrintArray(int[] arrayColection)
{
    int index = 0;
    while (index < arrayColection.Length)
    {
        Console.Write(arrayColection[index] + ", ");
        index++;
    }
    // foreach(var element in array) //один из видов цикла пробежки по массиву
    // Console.Write($"{element} ")
}

void EventArray (int[]arrayEvent)
{
    int index = 0;
    while(index < arrayEvent.Length)
    {
        if(arrayEvent[index] < 0)
        {
            arrayEvent[index] = arrayEvent[index] * 0;
        }
        index++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
EventArray(array);
Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");


