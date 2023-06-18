// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

T[] GetRow<T>(T[,] matrix, int rowIndex)
{
    var row = new T[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        row[i] = matrix[rowIndex, i];
    }

    return row;
}

T[] GetColumn<T>(T[,] matrix, int columnIndex)
{
    var column = new T[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        column[i] = matrix[i, columnIndex];
    }

    return column;
}

N GetScalarProduct<N>(N[] vector1, N[] vector2) where N : struct, System.Numerics.INumber<N>
{
    if (vector1.Length != vector2.Length)
    {
        throw new ArgumentException($"Векторы должны быть одной размерности! Переданы векторы размерности {vector1.Length} и {vector2.Length}");
    }

    N sum = default;

    for (int i = 0; i < vector1.Length; i++)
    {
        sum += vector1[i] * vector2[i];
    }

    return sum;
}

N[,] GetProduct<N>(N[,] matrix1, N[,] matrix2) where N : struct, System.Numerics.INumber<N>
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        throw new ArgumentException($"Количество строк первой матрицы ({matrix1.GetLength(1)}) должно быть равно количеству столбцов второй матрицы ({matrix1.GetLength(0)})!");
    }

    var rowsCount = matrix1.GetLength(0);
    var columnsCount = matrix2.GetLength(1);
    var resultMatrix = new N[rowsCount, columnsCount];

    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnsCount; j++)
        {
            resultMatrix[i, j] = GetScalarProduct(GetRow(matrix1, i), GetColumn(matrix2, j));
        }
    }

    return resultMatrix;
}

string GetString<T>(T value)
{
    if (value is float || value is double)
    {
        return $"{value,0:G3}";
    }
    if (value is null)
    {
        return "null";
    }

    return value.ToString();
}

int GetMaxLengthOfElementString<T>(T[,] matrix)
{
    var maxLength = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            var elementLength = GetString(matrix[i, j]).Length;

            if (elementLength > maxLength)
            {
                maxLength = elementLength;
            }
        }
    }

    return maxLength;
}

void WriteMatrix<T>(T[,] matrix)
{
    var maxElementLength = GetMaxLengthOfElementString(matrix);
    var formatTemplate = $" {{0,{maxElementLength}}}";

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(formatTemplate, GetString(matrix[i, j]));
        }

        Console.WriteLine(" ]");
    }
}

int[,] intMatrixA = {
    {1, 2, 2},
    {3, 1, 1}
};
int[,] intMatrixB = {
    {4, 2},
    {3, 1},
    {1, 5}
};
int[,] intMatrixC = GetProduct(intMatrixA, intMatrixB);
int[,] intMatrixD = GetProduct(intMatrixB, intMatrixA);

double[,] doubleMatrixA = {
    {11.11, 127},
    {73, 55.55}
};
double[,] doubleMatrixB = {
    {37.37, 43.43},
    {29.29, 31.31}
};
double[,] doubleMatrixC = GetProduct(doubleMatrixA, doubleMatrixB);
double[,] doubleMatrixD = GetProduct(doubleMatrixB, doubleMatrixA);

Console.WriteLine("Целочисленные матрицы");
Console.WriteLine("Матрица A:");
WriteMatrix(intMatrixA);
Console.WriteLine("Матрица B:");
WriteMatrix(intMatrixB);
Console.WriteLine("C = A * B");
Console.WriteLine("Матрица C:");
WriteMatrix(intMatrixC);
Console.WriteLine("D = B * A");
Console.WriteLine("Матрица D:");
WriteMatrix(intMatrixD);

Console.WriteLine();
Console.WriteLine("Вещественные матрицы");
Console.WriteLine("Матрица A:");
WriteMatrix(doubleMatrixA);
Console.WriteLine("Матрица B:");
WriteMatrix(doubleMatrixB);
Console.WriteLine("C = A * B");
Console.WriteLine("Матрица C:");
WriteMatrix(doubleMatrixC);
Console.WriteLine("D = B * A");
Console.WriteLine("Матрица D:");
WriteMatrix(doubleMatrixD);