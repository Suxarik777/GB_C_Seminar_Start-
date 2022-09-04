// Сформировать трехмерный массив не повторяющимися 
// двузначными числами показать его построчно на экран 
// выводя индексы соответствующего элемента


int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    if(number >= 10 && number < 100) return number;
    else return InputNumber("Вы ввели некоректное число!!! "
                        + "Пожалуйста введите число от 10 до 99 ");
}

int[,,] FillCube(int rows, int columns, int diagonal, int minNum, int maxNum)
{
    int[,,] cube = new int[rows, columns, diagonal];
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                cube[i, j, k] = GenerateUniqueNumber(minNum, maxNum);
            }
        }
    }
    return cube;
}

int GenerateUniqueNumber(int minNum, int maxNum)
{
    HashSet<int> numbers = new HashSet<int>();
    Random random = new Random();
    while (true)
    {
        var number = random.Next(minNum, maxNum + 1);
        if (!numbers.Contains(number))
        {
            numbers.Add(number);
            return number;
        }
    }
}

void PrintCube(int[,,] cube)
{
     for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент <{cube[i, j, k]}> по индексу [{i}, {j}, {k}]");
            }
        }
    }
}



int rows = 2;
int columns = 2;
int diagonal = 2;
int mininmum = InputNumber("Минимальное двухзначное число: ");
int maximum = InputNumber("Максимальное двузначное число: ");

int[,,] cube = FillCube(rows, columns, diagonal, mininmum, maximum);
Console.WriteLine("Cube:");
PrintCube(cube);