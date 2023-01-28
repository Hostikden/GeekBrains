//  Задача 58: Задайте две матрицы. Напишите программу, 
//  которая будет находить произведение двух матриц.


Console.Clear();


int[,] firstMatrix = new int[2, 2]
{
    {3,5},
    {2,1}
};

int[,] secondMatrix = new int[2, 3]
{
    {8,2,3},
    {1,7,2}
};

Console.WriteLine($"##### MATRIX I ##### \n");
PrintArray(firstMatrix);
Console.WriteLine($"##### MATRIX II ##### \n");
PrintArray(secondMatrix);


void PrintArray(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write($"{firstMatrix[i, j]}\t");
        }
        Console.WriteLine($"\n");
    }
}


