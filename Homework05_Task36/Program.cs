// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void WriteNumbers(int[] numbers)
{
    Console.Write($"[{string.Join(", ", numbers)}]");
}

void WriteNumbersLine(int[] numbers)
{
    WriteNumbers(numbers);
    Console.WriteLine();
}

int GetSumOfNumbersWithOddIndex(int[] numbers)
{
    int sumOfNumbersWithOddIndex = 0;

    for (int i = 1; i < numbers.Length; i += 2)
    {
        sumOfNumbersWithOddIndex += numbers[i];
    }

    return sumOfNumbersWithOddIndex;
}

var numbers = GetRandomNumbers(10, 1, 10);

Console.Write("Массив: ");
WriteNumbersLine(numbers);

Console.WriteLine($"Сумма чисел на нечётных позициях: {GetSumOfNumbersWithOddIndex(numbers)}");
