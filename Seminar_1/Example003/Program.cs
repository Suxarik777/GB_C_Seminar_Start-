// Показать четные числа от 1 до N

Console.WriteLine("Введите максимальное число до которого мы покажем четные числа: ");
int userNumber = int.Parse(Console.ReadLine());

int count = 1;

Console.WriteLine(" ");
 
while(count < userNumber)
{
    if(count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count++;
}
Console.WriteLine(" ");

