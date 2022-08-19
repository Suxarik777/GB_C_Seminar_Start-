//Считывание чисел строкой в int через пробел


string str = Console.ReadLine();
        int[] numbers = str.Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(numbers[0]+numbers[1]);
