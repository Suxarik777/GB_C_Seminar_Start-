// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

int[,] TaskMatrix(int[,] matrix)
{
    int[,] task = new int [matrix.GetLength(0), matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0) task[i,j] = Convert.ToInt32(Math.Pow(matrix[i,j], 2));
            else task[i,j] = matrix[i,j];
        }
    }
    return task;
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
int[,] matrixTask = TaskMatrix(matrix);

Console.WriteLine("Matrix:");
PrintMatrix(matrix);
Console.WriteLine("Результат задачи:");
PrintMatrix(matrixTask);