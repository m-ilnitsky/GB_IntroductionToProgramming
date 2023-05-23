Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine() ?? "0");

int maxNumber = number1;

if (maxNumber < number2)
{
    maxNumber = number2;
}

if (maxNumber < number3)
{
    maxNumber = number3;
}

Console.WriteLine("Максимальное число: " + maxNumber);