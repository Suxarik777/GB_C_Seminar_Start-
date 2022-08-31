// Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"


double[] InputCoordinatesToArray(string coordinatesText)
{
    string numText = String.Empty;
    double[] number = new double [SizeCoordinateToArray(coordinatesText)];
    
    int i = 0;
    int j = 0; //счетчик массива
    while(i < coordinatesText.Length)
    {
        if(coordinatesText[i] == '0' || coordinatesText[i] == '1' || coordinatesText[i] == '2' || 
        coordinatesText[i] == '3' || coordinatesText[i] == '4' || coordinatesText[i] == '5' ||
        coordinatesText[i] == '6' || coordinatesText[i] == '7' || coordinatesText[i] == '8' ||
        coordinatesText[i] == '9')
        {
            numText = numText + coordinatesText[i];
            number[j] = Convert.ToDouble(numText);
            numText = String.Empty;
            j++;
        }
    i++;
    }
    return number;
}

int SizeCoordinateToArray(string coordinatText)
{
    int size = 0;
    for(int i = 0; i < coordinatText.Length; i++)
    {
        if(coordinatText[i] == ',') size++;
    }
    size = size * 2; //потому что цифр в 2 раза больше запятых
    return size;
}

double[] MultiplicationNumbers(double[] array, double coef)
{
    double[] coefArray = new double [array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        coefArray[i] = array[i] * coef;
    }
    return coefArray; 
}

string OutputCoordinatesToString(double[] array)
{
    string numText = String.Empty;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
        {
            numText += '(' + Convert.ToString(array[i]) + ',';
        }
        else
        {
            numText += Convert.ToString(array[i]) + ')' + " ";
        }
    }
    return numText;
}


Console.WriteLine("Введите координаты 4 точек в формате:");
Console.WriteLine("(0,0) (0,0) (0,0) (0,0)");
Console.WriteLine("включая скобки, запятые и пробелы");
string coordinates = Console.ReadLine();

double[] coordinatesNumArray = InputCoordinatesToArray(coordinates);

Console.WriteLine("Введите коэфициент масштабирования: ");
double coefficient = double.Parse(Console.ReadLine());

double[] multiplikationNumbersArray = MultiplicationNumbers(coordinatesNumArray, coefficient);

Console.WriteLine($"Координаты в масштабе {coefficient}: ");
Console.WriteLine(OutputCoordinatesToString(multiplikationNumbersArray));

// внимание СМОТРИ 6 лекцию... там применили решение с знанием функций C#