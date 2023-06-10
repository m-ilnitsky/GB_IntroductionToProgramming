int ReadInt(string message)
{
    Console.Write(message);

    while (true)
    {
        var line = Console.ReadLine();

        if (int.TryParse(line, out var number))
        {
            return number;
        }

        Console.WriteLine("Введите корректное целое число: ");
    }
}

int[] ReadIntNumbers(int numbersCount, string individualMessageTemplate, string? commonMessage = null)
{
    if (!string.IsNullOrWhiteSpace(commonMessage))
    {
        Console.WriteLine(commonMessage);
    }

    var numbers = new int[numbersCount];

    for (int i = 0; i < numbersCount; i++)
    {
        var individualMessage = string.Format(individualMessageTemplate, i, i + 1);
        numbers[i] = ReadInt(individualMessage);
    }

    return numbers;
}

string GetString(int[] numbers)
{
    return $"[{string.Join(", ", numbers)}]";
}

(int, int, int) GetNumbersCount(int[] numbers)
{
    var negativeNumbersCount = 0;
    var zeroNumbersCount = 0;
    var positiveNumbersCount = 0;

    foreach (var number in numbers)
    {
        if (number > 0)
        {
            positiveNumbersCount++;
        }
        else if (number < 0)
        {
            negativeNumbersCount++;
        }
        else
        {
            zeroNumbersCount++;
        }
    }

    return (negativeNumbersCount, zeroNumbersCount, positiveNumbersCount);
}

var numbersCount = ReadInt("Введите количество чисел в массиве: ");
var numbers = ReadIntNumbers(numbersCount, "Введите {1}-число (индекс {0}): ", $"Введите {numbersCount} чисел.");
var (negativeNumbersCount, zeroNumbersCount, positiveNumbersCount) = GetNumbersCount(numbers);

Console.WriteLine();
Console.WriteLine($"Массив чисел: {GetString(numbers)}");
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел: {positiveNumbersCount}");
Console.WriteLine($"Количество нулевых чисел: {zeroNumbersCount}");
Console.WriteLine($"Количество отрицательных чисел: {negativeNumbersCount}");