// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы

double InputNumber(string text)
{
    Console.Write(text);
    return double.Parse(Console.ReadLine() ?? "0");
}

void PrintXY(string text, double xY)
{
    Console.Write(text +  xY);
    Console.WriteLine();
}


Console.WriteLine("Укажите координаты ПЕРВОЙ линии.");
double k1 = InputNumber("Введите координату первой точки -k1-: ");
double k2 = InputNumber("Введите координату первой точки -k2-: ");

Console.WriteLine();

Console.WriteLine("Укажите координаты ВТОРОЙ линии.");
double b1 = InputNumber("Введите координату первой точки -b1-: ");
double b2 = InputNumber("Введите координату первой точки -b2-: ");

double x = (b2 - b1)/(k2-k1);
double y = k1 * x + b1;

Console.WriteLine("Точка пересечения двух прямых находится");
PrintXY("По оси X ", x);
PrintXY("По оси Y ", y);