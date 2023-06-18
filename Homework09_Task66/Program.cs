// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int GetNaturalNumbersSum(int minNumber, int maxNumber)
{
    if (minNumber < 1)
    {
        throw new ArgumentException($"Натуральные числа больше нуля! Переданное минимальное число: {minNumber}", nameof(minNumber));
    }
    if (maxNumber < minNumber)
    {
        throw new ArgumentException($"Максимальное число ({maxNumber}) должно быть больше чем минимальное число ({minNumber})", nameof(maxNumber));
    }

    if (minNumber == maxNumber)
    {
        return maxNumber;
    }

    return minNumber + GetNaturalNumbersSum(minNumber + 1, maxNumber);
}

var minNumber = ReadInt("Введите минимальное натуральное число: ", 1);
var maxNumber = ReadInt("Введите максимальное натуральное число: ", 1);

try
{
    Console.WriteLine($"Сумма натуральных чисел от {minNumber} до {maxNumber} равна: {GetNaturalNumbersSum(minNumber, maxNumber)}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}