Console.Write("Введите число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "0");

int minNumber = userNumber > 0 ? -userNumber : userNumber;
int maxNumber = userNumber > 0 ? userNumber : -userNumber;
int i = minNumber;

Console.Write($"Диапазон чисел от {minNumber} до {maxNumber}: ");

while (i <= maxNumber)
{
    Console.Write(i + " ");
    i++;
}

Console.WriteLine();
