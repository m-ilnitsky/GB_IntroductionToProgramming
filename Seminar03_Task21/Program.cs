// Задача 21: 
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве

double ReadDouble(string message)
{
    while (true)
    {
        Console.Write(message);
        var numberString = Console.ReadLine();

        if (double.TryParse(numberString, out var number))
        {
            return number;
        }

        Console.WriteLine("Введите корректное вещественное число!");
    }
}

double GetDistance(double x1, double y1, double x2, double y2)
{
    var diffX = x1 - x2;
    var diffY = y1 - y2;

    return Math.Sqrt(diffX * diffX + diffY * diffY);
}

var x1 = ReadDouble("Введите координату X1: ");
var y1 = ReadDouble("Введите координату Y1: ");

var x2 = ReadDouble("Введите координату X2: ");
var y2 = ReadDouble("Введите координату Y2: ");

var distance = GetDistance(x1, y1, x2, y2);

Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}) равно: {distance}");