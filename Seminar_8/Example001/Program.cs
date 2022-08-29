// В матрице чисел найти сумму элементов главной диагонали



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
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int SumElements (int [,] matrix)
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i,i];
    }
    return sum;
}


int rows = 3;
int columns = 3;

int[,] array = FillArrayMatrix(rows, columns);
PrintArrayDouble(array);

int sum = SumElements(array);
Console.WriteLine($"Сумма элементов: {sum}");