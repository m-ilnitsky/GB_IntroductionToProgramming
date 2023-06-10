// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Дополнительное:
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void WriteRow(double[] row)
{
    Console.Write("[\t");

    for (int i = 0; i < row.Length; i++)
    {
        Console.Write($"{row[i],0:G3}\t");
    }

    Console.WriteLine(']');
}

void WriteMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[\t");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],0:G3}\t");
        }

        Console.WriteLine(']');
    }
}

double[] GetColumnsAverage(double[,] matrix)
{
    var columnsAverage = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }

        columnsAverage[i] = sum / matrix.GetLength(0);
    }

    return columnsAverage;
}

double GetSumOfDiagonalElements(double[,] matrix)
{
    int minSize = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
    double sum = 0;

    for (int i = 0; i < minSize; i++)
    {
        sum += matrix[i, i];
    }

    return sum;
}

double[,] matrix =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.WriteLine();
Console.WriteLine("Дана матрица: ");
WriteMatrix(matrix);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбцов:");
WriteRow(GetColumnsAverage(matrix));

Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали: {GetSumOfDiagonalElements(matrix)}");

Console.WriteLine();