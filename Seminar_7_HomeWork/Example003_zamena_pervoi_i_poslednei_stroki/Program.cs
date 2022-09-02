// Написать программу, которая обменивает элементы первой строки и последней строки

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

int[,] ReplacingRows(int[,] matrix)
{
    int help = 0;
    int i = 0;

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        help = matrix[i,j];
        matrix[i,j] = matrix[matrix.GetLength(0) - 1,j];
        matrix[matrix.GetLength(0) - 1,j] = help;
    }
    return matrix;
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

int rows = InputNumber("Введите количество строк: ");
int columns = InputNumber("Введите количество столбцов: ");
int mininmum = InputNumber("Минимальное число: ");
int maximum = InputNumber("Максимальное число: ");

int[,] matrix = FillMatrix(rows, columns, mininmum, maximum);
Console.WriteLine("Matrix:");
PrintMatrix(matrix);

int[,] matrixReplasRows = ReplacingRows(matrix);
Console.WriteLine("Результат задачи:");
PrintMatrix(matrixReplasRows);
