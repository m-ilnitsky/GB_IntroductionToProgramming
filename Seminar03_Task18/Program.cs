// Задача 18: 
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadNumber(string message, int minNumber, int maxNumber)
{
    while (true)
    {
        Console.Write(message);
        string? numberString = Console.ReadLine();

        if (int.TryParse(numberString, out int number))
        {
            if (number < minNumber)
            {
                Console.WriteLine($"Число {number} слишком маленькое!");
            }
            else if (number > maxNumber)
            {
                Console.WriteLine($"Число {number} слишком большое!");
            }
            else
            {
                return number;
            }
        }
        else
        {
            Console.WriteLine("Введите корректное целое число!");
        }
    }
}

int number = ReadNumber("Введите номер четверти (число от 1 до 4): ", 1, 4);

if (number == 1)
{
    Console.WriteLine("В первой четверти x > 0 и y > 0");
}
else if (number == 2)
{
    Console.WriteLine("Во второй четверти x < 0 и y > 0");
}
else if (number == 3)
{
    Console.WriteLine("В третьей четверти x < 0 и y < 0");
}
else
{
    Console.WriteLine("В четвёртой четверти x > 0 и y < 0");
}
