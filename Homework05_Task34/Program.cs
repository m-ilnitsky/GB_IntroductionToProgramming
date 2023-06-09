// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomNumbers(int numbersCount, int minNumber, int maxNumber)
{
    var rnd = new Random();
    var numbers = new int[numbersCount];
    var rightBorder = maxNumber + 1;

    for (int i = 0; i < numbersCount; i++)
    {
        numbers[i] = rnd.Next(minNumber, rightBorder);
    }

    return numbers;
}

int GetEvenNumbersCount(int[] numbers)
{
    int evenNumbersCount = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            evenNumbersCount++;
        }
    }

    return evenNumbersCount;
}

void WriteNumbers(int[] numbers)
{
    foreach (var number in numbers)
    {
        Console.Write(number + "  ");
    }
}

void WriteNumbersLine(int[] numbers)
{
    WriteNumbers(numbers);
    Console.WriteLine();
}

var numbers = GetRandomNumbers(10, 100, 999);
var evenNumbersCount = GetEvenNumbersCount(numbers);

Console.Write("Числа массива: ");
WriteNumbersLine(numbers);

Console.WriteLine($"Количество чисел в массиве: {numbers.Length}");
Console.WriteLine($"Количество чётных чисел в массиве: {evenNumbersCount}");