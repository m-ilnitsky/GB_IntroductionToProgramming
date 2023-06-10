// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

double GetElement(double[,] matrix, int rowIndex, int columnIndex)
{
    if (rowIndex < 0 || rowIndex >= matrix.GetLength(0))
    {
        throw new ArgumentOutOfRangeException(
            nameof(rowIndex),
            $"Индекс строки должен быть в диапазоне от 0 до {matrix.GetLength(0) - 1}. Передан индекс: {rowIndex}");
    }
    if (columnIndex < 0 || columnIndex >= matrix.GetLength(1))
    {
        throw new ArgumentOutOfRangeException(
            nameof(columnIndex),
            $"Индекс столбца должен быть в диапазоне от 0 до {matrix.GetLength(1) - 1}. Передан индекс: {columnIndex}");
    }

    return matrix[rowIndex, columnIndex];
}

double? GetElementOrDefault(double[,] matrix, int rowIndex, int columnIndex)
{
    if (rowIndex < 0 || rowIndex >= matrix.GetLength(0) || columnIndex < 0 || columnIndex >= matrix.GetLength(1))
    {
        return null;
    }

    return matrix[rowIndex, columnIndex];
}

double[,] matrix =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

try
{
    int rowIndex = ReadInt("Введите индекс строки: ");
    int columnIndex = ReadInt("Введите индекс столбца: ");

    double? numberOrDefault = GetElementOrDefault(matrix, rowIndex, columnIndex);
    if (numberOrDefault != null)
    {
        Console.WriteLine($"matrix[{rowIndex}][{columnIndex}] = {numberOrDefault}");
    }
    else
    {
        Console.WriteLine($"В матрице нет элемента с индексами [{rowIndex}][{columnIndex}]");
    }

    double number = GetElement(matrix, rowIndex, columnIndex);
    Console.WriteLine($"matrix[{rowIndex}][{columnIndex}] = {number}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();