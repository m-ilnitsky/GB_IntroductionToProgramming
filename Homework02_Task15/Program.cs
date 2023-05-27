bool isValidDayNumber = false;
int dayNumber;

do
{
    Console.Write("Введите номер дня недели (число от 1 до 7): ");
    dayNumber = int.Parse(Console.ReadLine() ?? "0");

    if (dayNumber < 1)
    {
        Console.WriteLine($"Введённое число {dayNumber} меньше 1");
    }
    else if (dayNumber > 7)
    {
        Console.WriteLine($"Введённое число {dayNumber} больше 7");
    }
    else
    {
        isValidDayNumber = true;
    }
}
while (!isValidDayNumber);

if (dayNumber > 5)
{
    Console.WriteLine($"{dayNumber}й день недели является выходным");
}
else
{
    Console.WriteLine($"{dayNumber}й день недели является будним днём");
}
