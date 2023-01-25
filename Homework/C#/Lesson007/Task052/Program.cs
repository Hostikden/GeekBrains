// int[] arr = { 1, 2, 3, 4, 5 };
// int i = 0;
// while (i < arr.Length)
// {
//     arr[i] *= i * 2;
//     Console.Write(arr[i++]);
// }

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
            Console.Write($"{matr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] SearchNumber(int[,] matr, int i, int j)
{
    int[,] result = new int[i, j];
    if (i < 0 || i > matr.GetLength(0) || j < 0 || j > matr.GetLength(1))
    {
        Console.WriteLine("Нет такого элемента");
    }
    else
    {
        Console.Write($"Число с указанными индексами = {array[numberRow, numberColomn]}");
    }
    return result;
}
