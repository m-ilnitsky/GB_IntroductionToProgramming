// Задача 19: 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом

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

int GetDigitsCount(int number)
{
    int i = 0;

    do
    {
        number /= 10;
        i++;
    }
    while (number != 0);

    return i;
}

int[] GetDigitsArray(int number)
{
    int digitsCount = GetDigitsCount(number);
    int[] digits = new int[digitsCount];
    int i = digitsCount - 1;

    do
    {
        digits[i] = number % 10;
        number /= 10;
        i--;
    }
    while (number != 0);

    return digits;
}

int GetDigitByIndex(int number, int indexFromRight)
{
    return number / (int)Math.Pow(10, indexFromRight) % 10;
}

bool IsPalindrome(int number)
{
    for (int leftIndex = GetDigitsCount(number) - 1, rightIndex = 0; leftIndex > rightIndex; leftIndex--, rightIndex++)
    {
        if (GetDigitByIndex(number, leftIndex) != GetDigitByIndex(number, rightIndex))
        {
            return false;
        }
    }

    return true;
}

bool IsPalindromeByArray(int number)
{
    int[] digits = GetDigitsArray(number);

    for (int leftIndex = 0, rightIndex = digits.Length - 1; leftIndex < rightIndex; leftIndex++, rightIndex--)
    {
        if (digits[leftIndex] != digits[rightIndex])
        {
            return false;
        }
    }

    return true;
}

bool IsPalindromeByString(int number)
{
    string numberString = Math.Abs(number).ToString();

    for (int leftIndex = 0, rightIndex = numberString.Length - 1; leftIndex < rightIndex; leftIndex++, rightIndex--)
    {
        if (numberString[leftIndex] != numberString[rightIndex])
        {
            return false;
        }
    }

    return true;
}

//int number = ReadInt("Ведите целое пятизначное число: ", 10000, 99999);
int number = ReadInt("Ведите целое число: ");

Console.WriteLine($"Число {number} - это {(IsPalindrome(number) ? "палиндром" : "не палиндром")}");
Console.WriteLine($"Число {number} - это {(IsPalindromeByArray(number) ? "палиндром" : "не палиндром")}");
Console.WriteLine($"Число {number} - это {(IsPalindromeByString(number) ? "палиндром" : "не палиндром")}");

