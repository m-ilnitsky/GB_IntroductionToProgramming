// Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

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