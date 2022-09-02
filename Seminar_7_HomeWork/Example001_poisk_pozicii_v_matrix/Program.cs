// В двумерном массиве показать позиции числа, заданного пользователем 
// или указать, что такого элемента нет

int InputNumber(string text, int minNumber, int maxNumber)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    if(number < minNumber || number > maxNumber) 
        return InputNumber(
            $"Не правильный ввод! Пожалуйста введите число не меньше {minNumber} и не больше {maxNumber}: ",
            minNumber,
            maxNumber
            );
    else return number;
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

(int, int)? SearchNumberPosition(int[,] matrix, int find)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == find) return (i, j);
        }
    }
    return null;
}

int rowsMatrix = 3;
int columnsMatrix = 3;
int minNumberMatrix = 1;
int maxNumberMatrix = 9;

int userNumber = InputNumber(
        text: $"Введите число от {minNumberMatrix} до {maxNumberMatrix}: ",
        minNumber: minNumberMatrix, 
        maxNumber: maxNumberMatrix
        );

int[,] matrix = FillMatrix(rowsMatrix,columnsMatrix, minNumberMatrix, maxNumberMatrix);

Console.WriteLine("Двумерный массив:");
PrintMatrix(matrix);

(int, int)? position = SearchNumberPosition(matrix, userNumber);

Console.WriteLine(position == null? 
    "Такого элемента нет" : 
    $"Позиция числа {userNumber}: [{position.Value.Item1},{position.Value.Item2}]");