// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool ContainsValue(int[,,] array3D, int value, int? addedValuesCount = null)
{
    var valuesCount = addedValuesCount ?? array3D.Length;
    var valueNumber = 0;

    if (valueNumber == valuesCount)
    {
        return false;
    }

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                if (array3D[i, j, k] == value)
                {
                    return true;
                }

                valueNumber++;

                if (valueNumber == valuesCount)
                {
                    return false;
                }
            }
        }
    }

    return false;
}

int[,,] GetRandomNumbers3DArray(int rowsCount, int columnsCount, int levelsCount, int minNumber, int maxNumber)
{
    var array3D = new int[rowsCount, columnsCount, levelsCount];
    var rnd = new Random();
    var addedValuesCount = 0;

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                int value;

                while (true)
                {
                    value = rnd.Next(minNumber, maxNumber);

                    if (!ContainsValue(array3D, value, addedValuesCount))
                    {
                        break;
                    }
                }

                array3D[i, j, k] = value;
                addedValuesCount++;
            }
        }
    }

    return array3D;
}

void Write3DArray(int[,,] array3D)
{
    for (int levelIndex = 0; levelIndex < array3D.GetLength(2); levelIndex++)
    {
        for (int rowIndex = 0; rowIndex < array3D.GetLength(0); rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < array3D.GetLength(1); columnIndex++)
            {
                Console.Write($"[{rowIndex}, {columnIndex}, {levelIndex}] {array3D[rowIndex, columnIndex, levelIndex]}\t");
            }

            Console.WriteLine();
        }
    }
}

var array3D = GetRandomNumbers3DArray(3, 4, 2, 10, 100);
Console.WriteLine();
Console.WriteLine($"Количество строк: {array3D.GetLength(0)}");
Console.WriteLine($"Количество столбцов: {array3D.GetLength(1)}");
Console.WriteLine($"Количество уровней: {array3D.GetLength(2)}");
Write3DArray(array3D);