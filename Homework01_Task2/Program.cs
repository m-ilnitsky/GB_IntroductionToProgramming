﻿// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

//int maxNumber = number1 > number2 ? number1 : number2;
//int maxNumber = Math.Max(number1, number2);
int maxNumber;

if (number1 > number2)
{
    maxNumber = number1;
}
else
{
    maxNumber = number2;
}

Console.WriteLine("Максимальное число: " + maxNumber);