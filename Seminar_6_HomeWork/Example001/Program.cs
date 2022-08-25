// Показать двумерный массив размером m×n заполненный вещественными числами


int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] FillMatrix(int rows, int columns, int minNum, int maxNum)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(minNum, maxNum + 1) + random.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

int rowsMatrix = InputNumber("Введите количество строк: ");
int columnsMatrix = InputNumber("Введите количество столбцов: ");

int minNumber = InputNumber("Минимальное число: ");
int maxNumber = InputNumber("Максимальное число: ");

double[,] realMatrix = FillMatrix(rowsMatrix,columnsMatrix, minNumber, maxNumber);

Console.WriteLine("Двумерный массив:");
PrintMatrix(realMatrix);