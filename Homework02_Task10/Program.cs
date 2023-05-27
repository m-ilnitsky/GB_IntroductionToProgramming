Console.WriteLine("Введите  число от 100 до 999:");
int number = int.Parse(Console.ReadLine() ?? "0");

int absNumber = Math.Abs(number);
Console.WriteLine($"Выбрано число: {absNumber}");

if (absNumber < 10)
{
    Console.WriteLine("Невозможно вывести вторую цифру числа, состоящего из одной цифры!");
    return;
}

int secondDigit = (absNumber % 100) / 10;
Console.WriteLine($"Вторая цифра числа {absNumber} это: {secondDigit}");
