Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int lastDigit = number % 10;
System.Console.WriteLine($"Последняя цифра числа {number} это цифра {lastDigit}");
