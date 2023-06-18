// ДОПОЛНИТЕЛЬНАЯ. 
// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ReadInt(string message)
{
    Console.Write(message);

    while (true)
    {
        var line = Console.ReadLine();

        if (int.TryParse(line, out var number))
        {
            return number;
        }

        Console.WriteLine("Введите корректное целое число: ");
    }
}

void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j],5}");
        }

        Console.WriteLine("  ]");
    }
}

void FillInSpiral(int[,] matrix)
{
    var minRowIndex = 0;
    var maxRowIndex = matrix.GetLength(0) - 1;
    var minColumnIndex = 0;
    var maxColumnIndex = matrix.GetLength(1) - 1;
    var maxNumber = matrix.Length;

    var rowIndex = 0;
    var columnIndex = 0;
    var number = 1;

    matrix[rowIndex, columnIndex] = number;

    minColumnIndex = -1;

    while (minRowIndex < maxRowIndex || minColumnIndex < maxColumnIndex)
    {
        if (rowIndex == minRowIndex && (columnIndex == minColumnIndex || minColumnIndex == -1))
        {
            minColumnIndex++;

            while (columnIndex < maxColumnIndex)
            {
                columnIndex++;
                number++;
                matrix[rowIndex, columnIndex] = number;
            }
        }
        else if (rowIndex == minRowIndex && columnIndex == maxColumnIndex)
        {
            minRowIndex++;

            while (rowIndex < maxRowIndex)
            {
                rowIndex++;
                number++;
                matrix[rowIndex, columnIndex] = number;
            }
        }
        else if (rowIndex == maxRowIndex && columnIndex == maxColumnIndex)
        {
            maxColumnIndex--;

            while (columnIndex > minColumnIndex)
            {
                columnIndex--;
                number++;
                matrix[rowIndex, columnIndex] = number;
            }
        }
        else if (rowIndex == maxRowIndex && columnIndex == minColumnIndex)
        {
            maxRowIndex--;

            while (rowIndex > minRowIndex)
            {
                rowIndex--;
                number++;
                matrix[rowIndex, columnIndex] = number;
            }
        }

        if (number == maxNumber)
        {
            break;
        }
    }
}

var rowsCount = ReadInt("Введите количество строк: ");
var columnsCount = ReadInt("Введите количество столбцов: ");

var matrix = new int[rowsCount, columnsCount];

Console.WriteLine("Матрица до заполнения:");
WriteMatrix(matrix);

FillInSpiral(matrix);

Console.WriteLine();
Console.WriteLine("Матрица после спирального заполнения:");
WriteMatrix(matrix);