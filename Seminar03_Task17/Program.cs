// Задача 17:
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

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
