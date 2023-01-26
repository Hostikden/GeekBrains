// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.Clear();

Console.Write("Введите количество строк массива:\t");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива:\t");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите индекс искомого элемента в строке:\t");
int numberRow = int.Parse(Console.ReadLine());

Console.Write("Введите индекс искомого элемента в столбце:\t");
int numberColomn = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
SearchNumber(array, numberRow, numberColomn);


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
        Console.WriteLine();
    }
}

void SearchNumber(int[,] matr, int i, int j)
{
    if (i < 0 || i > matr.GetLength(0)-1 || j < 0 || j > matr.GetLength(1)-1)
    {
        Console.WriteLine("Нет такого элемента");
    }
    else
    {
        Console.WriteLine($"Число с указанными индексами = {array[numberRow, numberColomn]}");
    }
}
