// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int absNumber = Math.Abs(number);
Console.WriteLine($"Выбрано число: {absNumber}");

if (absNumber < 100)
{
    Console.WriteLine($"Невозможно вывести третью цифру числа {absNumber}, т.к. третьей цифры нет!");

}
else
{
    int thirdDigit = (absNumber % 1000) / 100;
    Console.WriteLine($"Третья цифра числа {absNumber} это: {thirdDigit}");
}