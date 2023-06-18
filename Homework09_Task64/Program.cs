// Задача 64: 
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadInt(string message, int minNumber = int.MinValue)
{
    Console.Write(message);

    while (true)
    {
        var line = Console.ReadLine();

        if (int.TryParse(line, out var number))
        {
            if (number < minNumber)
            {
                Console.WriteLine($"Введите число не меньше {minNumber}: ");
                continue;
            }

            return number;
        }

        Console.WriteLine("Введите корректное целое число: ");
    }
}

string GetNaturalNumbersInAscendingOrder(int maxNumber)
{
    if (maxNumber < 1)
    {
        throw new ArgumentException($"Натуральные числа больше нуля! Передано число: {maxNumber}", nameof(maxNumber));
    }

    if (maxNumber == 1)
    {
        return "1";
    }

    return GetNaturalNumbersInAscendingOrder(maxNumber - 1) + $", {maxNumber}";
}

string GetNaturalNumbersInDescendingOrder(int maxNumber)
{
    if (maxNumber < 1)
    {
        throw new ArgumentException($"Натуральные числа больше нуля! Передано число: {maxNumber}", nameof(maxNumber));
    }

    if (maxNumber == 1)
    {
        return "1";
    }

    return $"{maxNumber}, " + GetNaturalNumbersInDescendingOrder(maxNumber - 1);
}

var maxNumber = ReadInt("Введите максимальное натуральное число: ", 1);

Console.WriteLine($"Ряд натуральных чисел от 1 до {maxNumber} по возрастанию: {GetNaturalNumbersInAscendingOrder(maxNumber)}");
Console.WriteLine($"Ряд натуральных чисел от 1 до {maxNumber} по убыванию:    {GetNaturalNumbersInDescendingOrder(maxNumber)}");