// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int A(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0)
    {
        return A(n - 1, 1);
    }

    return A(n - 1, A(n, m - 1));
}

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

Console.WriteLine();
Console.WriteLine("Вычисление функции A(n, m)");

var n = ReadInt("Введите неотрицательное целое число n: ", 0);
var m = ReadInt("Введите неотрицательное целое число m: ", 0);

Console.WriteLine($"A({n}, {m}) = {A(n, m)}");
Console.WriteLine();