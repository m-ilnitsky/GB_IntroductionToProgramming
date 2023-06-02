// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число для возведения в степень: ");
double number = double.Parse(Console.ReadLine());

Console.Write("Введите целое неотрицательное значение степени: ");
int power = int.Parse(Console.ReadLine());

if (power < 0)
{
    Console.WriteLine($"Введена степень {power}. Степень должна быть неотрицательной!");
    return;
}

double result = 1;

for (int i = 1; i <= power; i++)
{
    result *= number;
}

Console.WriteLine($"{number} ^ {power} = {result}");