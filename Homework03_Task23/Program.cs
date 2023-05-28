// Задача 23: 
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

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

Console.Write($"Кубы чисел от 1 до {number}: ");
for (int i = 1; i <= number; i++)
{
    //Console.Write(Math.Pow(i, 3));
    Console.Write(i * i * i);

    if (i != number)
    {
        Console.Write(", ");
    }
    else
    {
        Console.WriteLine(".");
    }
}
