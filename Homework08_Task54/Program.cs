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

void SortRowsDescending(int[,] matrix)
{
    var rowsCount = matrix.GetLength(0);
    var columnsCount = matrix.GetLength(1);

    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = columnsCount - 1; j > 0; j--)
        {
            var wasExchange = false;

            for (int k = 0; k < j; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    var temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;

                    wasExchange = true;
                }
            }

            if (!wasExchange)
            {
                break;
            }
        }
    }
}

// int[,] matrix = {
//     {1, 1, 3, 3, 5, 5, 7, 7},
//     {9, 7, 5, 3, 2, 4, 6, 8},
//     {1, 3, 5, 7, 8, 6, 4, 2}
// };

var rnd = new Random();
var rowsCount = rnd.Next(2, 4);
var columnsCount = rnd.Next(2, 10);

var matrix = new int[rowsCount, columnsCount];
FillByRandomNumbers(matrix, 1, 10);

WriteMatrix(matrix);
Console.WriteLine();
SortRowsDescending(matrix);
WriteMatrix(matrix);