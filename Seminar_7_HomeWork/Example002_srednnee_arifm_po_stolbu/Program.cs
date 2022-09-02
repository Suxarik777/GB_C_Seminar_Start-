// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

double[,] FillMatrix(int rows, int columns, int minNum, int maxNum)
{
    double[,] matrix = new double[rows, columns];
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

double[] ArithmeticMeanColums(double[,] matrix)
{
    double[] arrResultColums = new double[matrix.GetLength(1)];
    double sum = 0;

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        arrResultColums[j] = sum / matrix.GetLength(1);
        sum = 0;
    }
    return arrResultColums;
}

double[] NumberMathRound(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = Math.Round(array[i], 3);
    return array;
}


void PrintArray(double[] array)
{
    foreach(var element in array)
        Console.Write(element + "\t");
    Console.WriteLine();
}

int rowsMatrix = 3;
int columnsMatrix = 3;
int minNumberMatrix = 1;
int maxNumberMatrix = 9;

double[,] matrix = FillMatrix(rowsMatrix, columnsMatrix, minNumberMatrix, maxNumberMatrix);
PrintMatrix(matrix);

double[] arrResult = ArithmeticMeanColums(matrix);
arrResult = NumberMathRound(arrResult);

Console.WriteLine("================================");
PrintArray(arrResult);

