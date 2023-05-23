Console.Write("Введите номер дня: ");
int dayNumber = int.Parse(Console.ReadLine() ?? "0");

System.Console.WriteLine();
Console.WriteLine($"Введено число {dayNumber}");

if (dayNumber < 1)
{
    Console.WriteLine("Номер дня недели должен быть >= 1");
}
else if (dayNumber > 7)
{
    Console.WriteLine("Номер дня недели должен быть <= 7");
}
else if (dayNumber == 1)
{
    Console.WriteLine("День недели - понедельник");
}
else if (dayNumber == 2)
{
    Console.WriteLine("День недели - вторник");
}
else if (dayNumber == 3)
{
    Console.WriteLine("День недели - среда");
}
else if (dayNumber == 4)
{
    Console.WriteLine("День недели - четверг");
}
else if (dayNumber == 5)
{
    Console.WriteLine("День недели - пятница");
}
else if (dayNumber == 6)
{
    Console.WriteLine("День недели - суббота");
}
else
{
    Console.WriteLine("День недели - воскресенье");
}


