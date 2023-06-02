// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в чисел.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int positiveNumber = Math.Abs(number);

int digitsCount = 0;
int digitsSum = 0;

do
{
    int digit = positiveNumber % 10;
    positiveNumber /= 10;

    digitsCount++;
    digitsSum += digit;
}
while (positiveNumber > 0);

Console.WriteLine($"Число {number} содержит {digitsCount} цифр. Сумма цифр равна: {digitsSum}");