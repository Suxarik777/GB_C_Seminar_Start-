// Создание массива



int[] GreateArray(int size, int minimum, int maximum)
{
    int[]array = new int[size];
    var random = new Random();
    for(int i =; i < size; i++)
    {
        array[i] = random.Next(minimum, maximum +1);
    }
    return array;
}
