// Задача 21
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// ЭТО ЭКСПЕРМЕНТАЛЬНАЯ попытка, максимального зайдествования функций, для автоматизации.
// на практике проще вписать данные в каждое число отдельно 

double[] CreatArrayDotXYZ(string namePoint)
{
    int dotPoints = 3;
    double[] array = new double [dotPoints];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите позицию точки {namePoint} на оси {XYZ(i)}: ");
        array[i] = double.Parse(Console.ReadLine());
    }
    return array;
}

string XYZ(int pos)
{
    string x = Convert.ToString("X");
    string y = Convert.ToString("Y");
    string z = Convert.ToString("Z");
    if(pos == 0) return x;
    else if(pos == 1) return y;
    else return z;
}

void PrintArray(double[] array) 
{
    foreach(var element in array)
        Console.Write($"{element}, ");
}

double DistancePoints3D(double[] A, double[] B) // AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
{
    double[] interResult = new double[A.Length]; // промежуточная переменная
    double result = 0;
    for(int i = 0; i < A.Length; i++)
    {
        interResult[i] = Math.Pow(B[i] - A[i], 2);
    }
    for(int i = 0; i < interResult.Length; i++)
    {
        result = result + interResult[i];
    }
    result = Math.Sqrt(result); //√ корень
    return result;
}

double NumberOptimization(double number) // снижение кол-ва цифр после запятой
{                                        // алтернатива Math.Round(1.12345, 2)
    number = number - number % 0.01;
    return number;
}

string a = Convert.ToString("A");
double[] pointA = CreatArrayDotXYZ(a);

string b = Convert.ToString("B");
double[] pointB = CreatArrayDotXYZ(b);

Console.Write($"Позиция точки A: ");
PrintArray(pointA);
Console.Write($"Позиция точки B: ");
PrintArray(pointA);

double distance = DistancePoints3D(pointA, pointB);
distance = NumberOptimization(distance);

Console.WriteLine($"Расстояние между точками A и B в 3D пространстве = {distance}");