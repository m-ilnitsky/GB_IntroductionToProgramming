// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillByRandomNumbers(int[,] matrix, int minNumber, int maxNumber)
{
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minNumber, maxNumber);
        }
    }
}

void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[\t");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }

        Console.WriteLine(']');
    }
}

(int, int) GetMinSumOfRowsElements(int[,] matrix)
{
    var minSum = int.MaxValue;
    var minSumRowIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        var sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            minSumRowIndex = i;
        }
    }

    return (minSum, minSumRowIndex);
}

// int[,] matrix = {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4},
//     {5, 2, 6, 7}
// };

var rnd = new Random();
var rowsCount = rnd.Next(2, 4);
var columnsCount = rnd.Next(2, 6);

var matrix = new int[rowsCount, columnsCount];
FillByRandomNumbers(matrix, 1, 10);

var (minSum, minSumRowIndex) = GetMinSumOfRowsElements(matrix);

WriteMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов ({minSum}) получается в {minSumRowIndex + 1}-й строке (индекс {minSumRowIndex})");

