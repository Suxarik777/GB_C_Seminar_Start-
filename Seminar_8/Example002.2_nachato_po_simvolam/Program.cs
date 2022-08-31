// // 

// string [,] FillArrayMatrix (int rows, int colums)
// {
//     int[,] matrixText = new int[rows, colums];
//     for(int i = 0; i < matrixText.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrixText.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t");
//         }
//     }
//     return doubleArray;
// }

// void PrintArrayDouble(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[] WhiElements(int[,] matrix)
// {
//     int[] element = new int [matrix.GetLength(0) * matrix.GetLength(1)];
//     int k = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             element[k] = matrix[i,j];
//             k++;
//         }
//     }
//     return element;
// }

// int[] Delete(int[] array, int indexToDelete)
// {
//     if (array.Length == 0) return array;
//     if (array.Length <= indexToDelete) return array;
 
//     int[] output = new int[array.Length - 1];
//     int counter = 0;
 
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == indexToDelete) continue;
//         output[counter] = array[i];
//         counter++;
//     }
//     return output;
// }

// int rows = 8;
// int columns = 1;


// string[,] text = FillArrayMatrix(rows, columns);
// PrintArrayDouble(matrix);

// int[] element = WhiElements(matrix);

// int count = 1;
// for(int i = 0; i < element.Length; i++)
// {
//     for(int j = 0; j < element.Length; j++)
//     {
//         if(i == j) continue;
//         if(element[i] == element[j]) 
//         {   
//             count++;
//             element = Delete(element, j);
//         }
//     } 
//     Console.WriteLine($"Число {element[i]} встречается {count} раз");
//     count = 1;
// }
