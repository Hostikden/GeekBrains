// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int rows = 4, columns = 4, minValue = 0, maxValue = 9;

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine($"\n");
SearchMinSumInRows(array);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j]}\t");
        Console.WriteLine($"\n");
    }
}

int SearchMinSumInRows(int[,] array)
{
    int minSumInRow = maxValue * columns;
    int numberRow = 0;
    for (int i = 0; i < rows; i++)
    {
        int sumInRow = 0;
        for (int j = 0; j < columns; j++)
        {
            sumInRow += array[i, j];
        }
        if (sumInRow < minSumInRow)
        {
            minSumInRow = sumInRow;
            numberRow = i + 1;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов находится в строке №: {numberRow}");
    return numberRow;
}