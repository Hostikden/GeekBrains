// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк массива:\t");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива:\t");
int columns = int.Parse(Console.ReadLine());


int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();


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
            Console.Write($"{matr[i, j]} ");
        Console.WriteLine();
    }
}

void MeanColumns(int[,] array)
{
    double sum;
    double result;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        result = sum / array.GetLength(0);
        Console.WriteLine(string.Format("{0:f1}", result));
    }
}

MeanColumns(array);