// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillByRandomNumbers1(double[,] matrix, double minNumber = 0, double maxNumber = 1)
{
    var rnd = new Random();
    var difference = maxNumber - minNumber;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = minNumber + difference * rnd.NextDouble();
        }
    }
}

void FillByRandomNumbers2(double[][] matrix, double minNumber = 0, double maxNumber = 1)
{
    var rnd = new Random();
    var difference = maxNumber - minNumber;

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            matrix[i][j] = minNumber + difference * rnd.NextDouble();
        }
    }
}

double[][] GetTriangleMatrix(int size)
{
    var matrix = new double[size][];

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[i] = new double[i + 1];
    }

    return matrix;
}

void WriteMatrix1(double[,] matrix)
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

void WriteMatrix2(double[][] matrix)
{
    var columnsCount = 0;

    foreach (var row in matrix)
    {
        if (columnsCount < row.Length)
        {
            columnsCount = row.Length;
        }
    }

    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write("[\t");

        int j = 0;
        for (; j < matrix[i].Length; j++)
        {
            Console.Write($"{matrix[i][j],0:G3}\t");
        }
        for (; j < matrix.Length; j++)
        {
            Console.Write("\t");
        }

        Console.WriteLine(']');
    }
}

double[,] rectangularMatrix = new double[3, 5];
double[][] triangularMatrix = GetTriangleMatrix(4);

Console.WriteLine("Прямоугольная матрица до заполнения:");
WriteMatrix1(rectangularMatrix);
Console.WriteLine();

Console.WriteLine("Треугольная матрица до заполнения:");
WriteMatrix2(triangularMatrix);
Console.WriteLine();

FillByRandomNumbers1(rectangularMatrix, 1, 10);
FillByRandomNumbers2(triangularMatrix, 1, 10);

Console.WriteLine("Прямоугольная матрица после заполнения:");
WriteMatrix1(rectangularMatrix);
Console.WriteLine();

Console.WriteLine("Треугольная матрица после заполнения:");
WriteMatrix2(triangularMatrix);
Console.WriteLine();