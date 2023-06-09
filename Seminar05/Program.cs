// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] GetFibonacciNumbers(int index)
{
    int[] numbers = new int[index + 1];

    for (int i = 0; i < numbers.Length; i++)
    {
        if (i == 0 || i == 1)
        {
            numbers[i] = i;
        }
        else
        {
            numbers[i] = numbers[i - 1] + numbers[i - 2];
        }
    }

    return numbers;
}

void WriteNumbers(int[] numbers)
{
    Console.WriteLine($"[{string.Join(", ", numbers)}]");
}

var numbers = GetFibonacciNumbers(10);
WriteNumbers(numbers);