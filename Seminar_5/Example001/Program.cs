// l - длинна коридора
// p - магический импульс Гарри скорость метр в секунду
// q - магический импульс Волондеморта скорость метр в секунду 

//Выведите единственное число — расстояние от конца коридора, в котором стоит Гарри, до места второй встречи импульсов заклинаний

//l / p + q = время через которое они встретятся

double InputNumber(string text)
{
    Console.Write(text);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double l = InputNumber("Введите длину коридора l: ");
double p = InputNumber("Скорость магического импульса Гарри p: ");
double q = InputNumber("Скорость магического импульса Волондеморта q: ");



double time = l/(p+q); //время через которое встретятся импульсы
                        //time Гари и time Волондер одинаковы
                        // l1 = Ptime
                        // l2 = Qtime
                        // time = l1/p; time = l2/q


double distanse1 = time1 * p; //расстояние от Гарри до точки встречи
//double distanse2 = time1 * q; //расстояние от Волондеморта до точки встречи
// double distanse1 = p * 1/(p+q)

Console.WriteLine($"Расстояние от Гарри до второй встречи импульсов = {distanse1}");