// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetRandomDoubleNumbers(int numbersCount)
{
    var rnd = new Random();
    var numbers = new double[numbersCount];

    for (int i = 0; i < numbersCount; i++)
    {
        numbers[i] = rnd.NextDouble();
    }

    return numbers;
}

string GetString(double[] numbers)
{
    return $"[{string.Join(", ", numbers.Select(e => $"{e,0:F3}"))}]";
}

double GetMaxDifferenceOfNumbers(double[] numbers)
{
    var minNumber = double.MaxValue;
    var maxNumber = double.MinValue;

    foreach (var number in numbers)
    {
        if (number > maxNumber)
        {
            maxNumber = number;
        }

        if (number < minNumber)
        {
            minNumber = number;
        }
    }

    return maxNumber - minNumber;
}

var numbers = GetRandomDoubleNumbers(10);

Console.WriteLine($"Массив: {GetString(numbers)}");
Console.WriteLine($"Максимальная разность чисел: {GetMaxDifferenceOfNumbers(numbers),0:F3}");