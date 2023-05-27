// Задача 22: 
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N

int ReadInt(string message, int? minNumber = null, int? maxNumber = null)
{
    while (true)
    {
        Console.Write(message);
        string? numberString = Console.ReadLine();

        if (int.TryParse(numberString, out int number))
        {
            if (minNumber != null && number < minNumber)
            {
                Console.WriteLine($"Число {number} слишком маленькое!");
            }
            else if (maxNumber != null && number > maxNumber)
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

int number = ReadInt("Введите число больше 0: ", 1);

Console.Write($"Квадраты чисел от 1 до {number}: ");
for (int i = 1; i <= number; i++)
{
    Console.Write(i * i);

    if (i != number)
    {
        Console.Write(", ");
    }
    else
    {
        Console.WriteLine(".");
    }
}
