// Задача 53. Задайте двумерный массив. Напишите программу,
// которая поменят местами первую и последнюю строку массива.

int rows = 4, columns = 4;
int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

Console.WriteLine($"#############");

ReplaceFirstAndLastLine(array);
PrintArray(array);

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

void ReplaceFirstAndLastLine(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = temp;
    }
}