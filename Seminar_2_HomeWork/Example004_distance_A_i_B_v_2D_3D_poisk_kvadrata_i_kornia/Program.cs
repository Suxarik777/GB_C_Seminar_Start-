// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите координаты точки пространстве 2D по осям X и Y");

Console.Write("Укажите координату 1 точки по оси X: ");
double num1x2d = double.Parse(Console.ReadLine());
Console.Write("Укажите координату 1 точки по оси Y: ");
double num1y2d = double.Parse(Console.ReadLine());

Console.Write("Укажите координату 2 точки по оси X: ");
double num2x2d = double.Parse(Console.ReadLine());
Console.Write("Укажите координату 2 точки по оси Y: ");
double num2y2d = double.Parse(Console.ReadLine());

double rezult2D = Math.Sqrt(Math.Pow(num2x2d - num1x2d, 2) + Math.Pow(num2y2d - num1y2d, 2));

Console.WriteLine("Расстояние между точками в пространстве 2D: " + rezult2D);


Console.WriteLine("=========");

Console.WriteLine("Введите координаты точки пространстве 3D по осям X, Y и Z");

Console.Write("Укажите координату 1 точки по оси X: ");
double num1X3d = double.Parse(Console.ReadLine());
Console.Write("Укажите координату 1 точки по оси Y: ");
double num1Y3d = double.Parse(Console.ReadLine());
Console.Write("Укажите координату 1 точки по оси Z: ");
double num1Z3d = double.Parse(Console.ReadLine());

Console.Write("Укажите координату 2 точки по оси X: ");
double num2X3d = double.Parse(Console.ReadLine());
Console.Write("Укажите координату 2 точки по оси Y: ");
double num2Y3d = double.Parse(Console.ReadLine());
Console.Write("Укажите координату 2 точки по оси Z: ");
double num2Z3d = double.Parse(Console.ReadLine());

double rezult3D = Math.Sqrt(Math.Pow(num2X3d - num1X3d, 2) + Math.Pow(num2Y3d - num1Y3d, 2)
                + Math.Pow(num2Z3d - num1Z3d, 2));
Console.WriteLine("Расстояние между точками в пространстве 3D: " + rezult3D);