// Показать двумерный массив размером m×n заполненный целыми числами

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int [,] FillArrayMatrix (int rows, int colums)
{
    int[,] doubleArray = new int[rows, colums];
    var random = new Random();
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i,j] = random.Next(0,10);
        }
    }
    return doubleArray;
}

void PrintArrayDouble(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
}


int rows = InputNumber("Количество строк в массиве: ");
int columns = InputNumber("Количество столбцов в массиве");

int[,] newArray = FillArrayMatrix(rows, columns);
PrintArrayDouble(newArray);