// Написать программу, которая в двумерном массиве 
// заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).



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

int[,]? ReplacementMatrix(int[,] matrix)
{
    if(matrix.GetLength(0) == matrix.GetLength(1))
    {     
        for(int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for(int j = i + 1; j < matrix.GetLength(1); j++)
            {
                int help = matrix[i,j];
                matrix[i,j] = matrix[j,i];
                matrix[j,i] = help; 
            }
        }
        return matrix;
    }
    else return null;
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

int[,]? matrixNew = ReplacementMatrix(matrix);

if(matrixNew == null) 
    Console.WriteLine("Матрица не квадратная, замена строк на столбцы не возможна");
else 
{
    Console.WriteLine("Результат задачи:");
    PrintMatrix(matrixNew);
}