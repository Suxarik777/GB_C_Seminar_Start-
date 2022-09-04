// В двумерном массиве целых чисел. 
// Удалить строку и столбец, на пересечении которых 
// расположен наименьший элемент.

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] FillMatrix(int rows, int columns, int minNum, int maxNum)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(minNum, maxNum + 1);
        }
    }
    return matrix;
}

int[] minMatrixPosition(int[,] matrix)
{
    int[] minPosition = new int [2];
    int[,] posHelp = new int [1, 1];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] > posHelp[0,0]) posHelp[0,0] = matrix[i,j];
        }
    }

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] < posHelp[0,0]) 
            {
                posHelp[0,0] = matrix[i,j];
                minPosition[0] = i; minPosition[1] = j; 
            }
        }
    }
    return minPosition;
}

void PrintMatrix(int[,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] DeletRowColumMatrix(int[,] matrix, int[] indexToDelete)
{
    if (matrix.GetLength(0) == 0) return matrix;
    if (matrix.GetLength(0) <= indexToDelete[0] || 
        matrix.GetLength(1) <= indexToDelete[1]) return matrix;

    int[,] output = new int [matrix.GetLength(0) - 1,  matrix.GetLength(1) - 1];
    int countI = 0; int countJ = 0; 

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i == indexToDelete[0]) continue;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == indexToDelete[1]) continue;
                output[countI, countJ] = matrix[i,j];
                countJ++;
            }
        countI++;
        countJ = 0;
    }
    return output;
}


int rows = 3;
int columns = 3;
int mininmum = InputNumber("Минимальное число: ");
int maximum = InputNumber("Максимальное число: ");

int[,] matrix = FillMatrix(rows, columns, mininmum, maximum);
Console.WriteLine("Matrix:");
PrintMatrix(matrix);

int[] minPosition = minMatrixPosition(matrix);
Console.WriteLine();
Console.WriteLine($"Позиция с минимальным значением: [{minPosition[0]}, {minPosition[1]}]");

int[,] resultMatrix = DeletRowColumMatrix(matrix, minPosition);
Console.WriteLine("Результат задачи:");
PrintMatrix(resultMatrix);
