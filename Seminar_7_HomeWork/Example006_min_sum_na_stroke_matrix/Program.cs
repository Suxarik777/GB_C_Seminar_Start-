// В прямоугольной матрице найти строку с наименьшей суммой элементов.


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

(int, int) SmallRowSum(int[,] matrix)
{
    int[] rowSum = new int [matrix.GetLength(0)];
   
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum[i] += matrix[i,j];
        }
    }

    int minNumberPositionRow = 0;
    for(int i = 0; i < rowSum.Length; i++)
    {
        if(rowSum[i] < rowSum[minNumberPositionRow]) minNumberPositionRow = i; 
    }
    return (rowSum[minNumberPositionRow], minNumberPositionRow);
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

int rows = 3;
int columns = 3;
int mininmum = InputNumber("Минимальное число: ");
int maximum = InputNumber("Максимальное число: ");

int[,] matrix = FillMatrix(rows, columns, mininmum, maximum);
Console.WriteLine("Matrix:");
PrintMatrix(matrix);

(int, int) sumRowsPosition = SmallRowSum(matrix);

Console.WriteLine($"Минимальная сумма {sumRowsPosition.Item1} " 
                + $"на {sumRowsPosition.Item2 + 1} строке матрицы");

