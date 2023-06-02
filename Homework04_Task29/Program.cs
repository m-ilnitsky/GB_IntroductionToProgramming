// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string message)
{
    while (true)
    {
        Console.Write(message);
        string? numberString = Console.ReadLine();

        if (int.TryParse(numberString, out int number))
        {
            return number;
        }

        Console.WriteLine("Введите корректное целое число!");
    }
}

int[] ReadIntNumbers(string messageTemplate, int numbersCount)
{
    int[] numbers = new int[numbersCount];

    for (int i = 0; i < numbersCount; i++)
    {
        string currentMessage = string.Format(messageTemplate, i, i + 1);
        numbers[i] = ReadInt(currentMessage);
    }

    return numbers;
}

int[] CreateIntRandomNumbers(int numbersCount, int minValue = 0, int maxValue = 100)
{
    int[] numbers = new int[numbersCount];
    Random rnd = new Random();

    for (int i = 0; i < numbersCount; i++)
    {
        numbers[i] = rnd.Next(minValue, maxValue);
    }

    return numbers;
}

int numbersCount = ReadInt("Введите количество чисел в массиве: ");

Console.WriteLine($"Введите числа массива из {numbersCount} чисел.");
int[] userNumbers = ReadIntNumbers("Введите {1}-е число (элемент с индексом {0}): ", numbersCount);

int[] randomNumbers = CreateIntRandomNumbers(numbersCount);

Console.WriteLine($"Пользовательский массив: [{string.Join(", ", userNumbers)}]");
Console.WriteLine($"Случайный массив: [{string.Join(", ", randomNumbers)}]");
