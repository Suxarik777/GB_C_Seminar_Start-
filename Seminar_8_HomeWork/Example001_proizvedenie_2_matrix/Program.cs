// Найти произведение двух матриц


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

int[,] matrixMultiplication(int[,] matrix1, int[,]matrix2)
{
    int[,] result = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    result[i,j] += matrix1[i,k] * matrix2[k,j];
                }
        }
    }
    return result;
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

int[,] matrixFirst = FillMatrix(rows, columns, mininmum, maximum);
int[,] matrixSecond = FillMatrix(rows, columns, mininmum, maximum);
Console.WriteLine("MatrixFirst:");
PrintMatrix(matrixFirst);
Console.WriteLine("MatrixSecond:");
PrintMatrix(matrixSecond);

int[,] resultMatrix = matrixMultiplication(matrixFirst, matrixSecond);
Console.WriteLine("=================");
Console.WriteLine("Результат задачи:");
PrintMatrix(resultMatrix);
