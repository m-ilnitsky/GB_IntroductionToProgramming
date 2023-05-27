// Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number < 2)
{
    Console.WriteLine($"Число {number} меньше минимального четного положительного числа");
    return;
}

Console.WriteLine($"Чётные числа от 1 до {number}:");

// Вариант 1
for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + "  ");
    }
}

Console.WriteLine();

// Вариант 2
for (int i = 2; i <= number; i += 2)
{
    Console.Write(i + "  ");
}

Console.WriteLine();

// Вариант 3
int j = 1;
while (j <= number)
{
    if (j % 2 == 0)
    {
        Console.Write(j + "  ");
    }

    j++;
}

Console.WriteLine();

// Вариант 4
j = 1;
do
{
    if (j % 2 == 0)
    {
        Console.Write(j + "  ");
    }

    j++;
}
while (j <= number);

Console.WriteLine();