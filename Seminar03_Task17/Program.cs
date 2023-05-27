int GetNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        string? numberString = Console.ReadLine();

        if (int.TryParse(numberString, out int number))
        {
            return number;
        }
    }
}

void WriteLine(int x, int y, string info)
{
    Console.WriteLine($"({x}, {y}) - {info}");
}

int x = GetNumber("Введите координату X: ");
int y = GetNumber("Введите координату Y: ");

if (x > 0 && y > 0)
{
    WriteLine(x, y, "точка находится в первой четверти координатной плоскости");
}
else if (x < 0 && y > 0)
{
    WriteLine(x, y, "точка находится во второй четверти координатной плоскости");
}
else if (x < 0 && y < 0)
{
    WriteLine(x, y, "точка находится в третьей четверти координатной плоскости");
}
else if (x > 0 && y < 0)
{
    WriteLine(x, y, "точка находится в четвёртой четверти координатной плоскости");
}
else
{
    WriteLine(x, y, "точка находится на координатной оси");
}
