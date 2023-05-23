Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

if (number1 * number1 == number2)
{
    Console.WriteLine($"Число {number2} является квадратом числа {number1}");
}
else if (number2 * number2 == number1)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else
{
    Console.WriteLine($"Числа {number2} и {number1} НЕ являются квадратами друг друга");
}