// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadDouble(string message)
{
    Console.Write(message);

    while (true)
    {
        var line = Console.ReadLine();

        if (double.TryParse(line, out var number))
        {
            return number;
        }

        Console.WriteLine("Введите корректное число: ");
    }
}

bool Equals(double a, double b)
{
    return Math.Abs(a - b) < 1e-10;
}

(double?, double?) GetIntersectionPoint(double b1, double c1, double b2, double c2)
{
    if (Equals(b1, b2))
    {
        return (null, null);
    }

    var x = (c2 - c1) / (b1 - b2);
    var y = b1 * x + c1;

    return (x, y);
}

string GetLineString(double b, double c)
{
    if (Equals(b, 0))
    {
        return $"y = {c,0:G3}";
    }
    if (Equals(b, 1))
    {
        return $"y = x + {c,0:G3}";
    }
    if (Equals(b, -1))
    {
        return $"y = -x + {c,0:G3}";
    }

    return $"y = {b,0:G3}*x + {c,0:G3}";
}

string GetPointString(double x, double y)
{
    return $"({x,0:G3}; {y,0:G3})";
}

Console.WriteLine("Формула прямой: y = b*x + c");

var b1 = ReadDouble("Введите для 1й прямой коэффициент b: ");
var c1 = ReadDouble("Введите для 1й прямой коэффициент c: ");

var b2 = ReadDouble("Введите для 2й прямой коэффициент b: ");
var c2 = ReadDouble("Введите для 2й прямой коэффициент c: ");

Console.WriteLine();
Console.WriteLine($"Даны две прямые: {GetLineString(b1, c1)} и {GetLineString(b2, c2)}");

var (x, y) = GetIntersectionPoint(b1, c1, b2, c2);

if (x == null || y == null)
{
    Console.WriteLine("Прямые не пересекаются!");
}
else
{
    Console.WriteLine($"Точка пересечения прямых: {GetPointString(x.Value, y.Value)}");
}