//


int [,] FillArrayMatrix (int rows, int colums)
{
    int[,] doubleArray = new int[rows, colums];
    var random = new Random();
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i,j] = random.Next(0,10);
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

int[] WhiElements(int[,] matrix)
{
    int[] element = new int [matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            element[k] = matrix[i,j];
            k++;
        }
    }
    return element;
}

int[] Delete(int[] array, int indexToDelete)
{
    if (array.Length == 0) return array;
    if (array.Length <= indexToDelete) return array;
 
    int[] output = new int[array.Length - 1];
    int counter = 0;
 
    for (int i = 0; i < array.Length; i++)
    {
        if (i == indexToDelete) continue;
        output[counter] = array[i];
        counter++;
    }
    return output;
}

int rows = 3;
int columns = 3;

int[,] matrix = FillArrayMatrix(rows, columns);
PrintArrayDouble(matrix);

int[] element = WhiElements(matrix);


int count = 1;
for(int i = 0; i < element.Length; i++)
{
    for(int j = 0; j < element.Length; j++)
    {
        if(i == j) continue;
        if(element[i] == element[j]) 
        {   
            count++;
            element = Delete(element, j);
        }
    } 
    Console.WriteLine($"Число {element[i]} встречается {count} раз");
    count = 1;
}