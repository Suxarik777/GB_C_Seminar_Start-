float InputNumber(string text)
{
    Console.Write(text);
    float number = float.Parse(Console.ReadLine());
    return number;
}

float x1 = InputNumber("Первый друг X1: ");
float x2 = InputNumber("Второй друг X2: ");
float x3 = InputNumber("Третий друг X3: ");

float distance = 0;

if(x2 - x1 == x3 - x2) //проверяем есть ли друг по середине (в данном случае x2)
{
    if(x2 - x1 > 0) distance = (x2 - x1) * 2; //условие чтобы не получить отрицательное число
    else distance = (x1 - x2) * 2; // в противном случае переворачеваем, чтобы получить полож.
}
else if (x1 - x3 == x2 - x1)
{
    if(x1 - x3 > 0) distance = (x1 - x3) * 2;
    else distance = (x3 - x1) * 2;
}
else if (x3 - x2 == x1 - x3)
{
    if(x3 - x2 > 0) distance = (x3 - x2) * 2;
    else distance = (x2 - x3) * 2;
    //distance = (x3 - x2) * 2;
    //(x1 + x2 + x3)/2;
}
else
{
    distance = (x1 + x2 + x3)/3; //условие если все на разном удалении
}
Console.WriteLine(distance);