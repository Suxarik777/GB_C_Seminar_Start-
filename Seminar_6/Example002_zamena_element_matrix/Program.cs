// В двумерном массиве n×k заменить четные элементы на противоположные




int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int [,] FillArrayMatrix (int rows, int colums, int min, int max)
{
    int[,] doubleArray = new int[rows, colums];
    var random = new Random();
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i,j] = random.Next(min, max + 1);
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

int[,] ReplacingElements(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] % 2 == 0) matrix[i, j] *= -1;
        }
        Console.WriteLine();
    }
    return matrix;
}


int rows = InputNumber("Количество строк в массиве: ");
int columns = InputNumber("Количество столбцов в массиве");

int minNumber = InputNumber("Минимальное число в массиве");
int maxNumber = InputNumber("Максимальное число в массиве");

int[,] matrixOrigin = FillArrayMatrix(rows, columns, minNumber, maxNumber);
PrintArrayDouble(matrixOrigin);
Console.WriteLine();

int[,] newMatrix = ReplacingElements(matrixOrigin);
PrintArrayDouble(newMatrix);