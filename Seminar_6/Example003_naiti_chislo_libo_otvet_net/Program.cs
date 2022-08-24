// В двумерном массиве показать позиции числа, заданного пользователем или указать, 
// что такого элемента нет



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

string FindNumber(int[,] matrix, int find)
{
    string position = "-1";
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] == find) 
            {
                position = "[" + Convert.ToString(i) + "," + Convert.ToString(j) + "]";
                break;
            }
        }
    }
    if (position == "-1") position = "Искомое число не найлено";
    return position;
}



int rows = InputNumber("Количество строк в массиве: ");
int columns = InputNumber("Количество столбцов в массиве: ");

int minNumber = InputNumber("Минимальное число в массиве: ");
int maxNumber = InputNumber("Максимальное число в массиве: ");

int userNumber = InputNumber("Введите число, для поиска: ");

int[,] matrixOrigin = FillArrayMatrix(rows, columns, minNumber, maxNumber);
PrintArrayDouble(matrixOrigin);
Console.WriteLine();

string position = FindNumber(matrixOrigin, userNumber);

Console.WriteLine($"Позиция: {position}");
