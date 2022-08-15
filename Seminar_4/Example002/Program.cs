// Написать программу преобразования десятичного числа в двоичное

// int[] DecimalBinary(int number)
// {
//     int[] result = new int [10];
//     int dividing = 0;
//     for(int i = 0; number >= 1; i++)
//     {
//         dividing = number % 2; //*10???
//         result[i] = dividing;
//         number = number / 2;
//     }
//     return result;
// }

// void PrintAnswer(int[] array)
// {
//     foreach(var element in array)
//         Console.Write(element + " ");
// }



// Console.WriteLine("Введите двухзначное число: ");
// int number10 = int.Parse(Console.ReadLine() ?? "0");

// int[] answer = DecimalBinary(number10);
// PrintAnswer(answer);



int ToBinar(int value){
    int binar = 0;
    int i = 0;
    while(value >= 1){
        binar = binar + value % 2 * (int)Math.Pow(10, i); //Math.Pow позволяет записать новую цифру слева
                //binar * 10 + value % 2; // но тут может быть проблема 
        Console.WriteLine(binar);
        value = value / 2;
        i++;
    }
    return binar;
}
Console.Clear();
int value = int.Parse(Console.ReadLine());
Console.WriteLine(ToBinar(value));