// See https://aka.ms/new-console-template for more information

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,]CreatMatrix (int length, int width, int mininmum, int maximum)
{
    int[,] matrix =new int [length, width];
    Random random = new Random();
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(mininmum, maximum + 1);
        }
    }
    return matrix; 
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


(int, int)? FindPosition(int[,] matrix, int value) //КОРТЕЖ Corteg возвращение двух значений
                                                    // либо null (ставим ?)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] == value) 
            {
                return (i, j);
            }
        }
    }
    return null;
}

// int[]? FindPosition(int[,] matrix, int value)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i, j] == value) 
//             {
//                 return new int []{i, j};
//             }
//         }
//     }
//     return null;
// }

int[,] matrix = CreatMatrix(3,3,0,20);

PrintArrayDouble(matrix);
Console.WriteLine();

int userNumber = InputNumber("Введите число, для поиска: ");

(int, int)? position = FindPosition (matrix, userNumber);

//int row = position[0] ?? -1;
//присваиваем позицию 0, но если там null то присваеваем -1 

Console.WriteLine(position == null ? 
  "Позиции нет" :      $"Позиция в матрице [{position.Value.Item1},{position.Value.Item2}]"); 

// if(position != null)
// {
//     Console.WriteLine($"Позиция в матрице [{position[0]},{position[1]}]"); 
// }
// else
// {
//     Console.WriteLine($"Позиции нет");   
// }


// Console.WriteLine(position[0] < 0 || position[0] < 1 ? 
//     "Позиции нет" : 
//     $"Позиция в матрице [{position[0]},{position[1]}]"); 