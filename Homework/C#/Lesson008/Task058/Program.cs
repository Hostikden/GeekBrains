//  Задача 58: Задайте две матрицы. Напишите программу, 
//  которая будет находить произведение двух матриц.

Console.Clear();
int[,] firstMatrix = new int[2, 3]
{
    {1,2,4},
    {2,0,3}
};

int[,] secondMatrix = new int[3, 2]
{
    {2,5},
    {1,3},
    {1,1}
};

int[,] tempMatrix = MultiplicationArray(firstMatrix, secondMatrix);

Console.WriteLine($"##### MATRIX I ##### \n");
PrintArray(firstMatrix);
Console.WriteLine($"##### MATRIX II ##### \n");
PrintArray(secondMatrix);
Console.WriteLine($"##### RESULT MATRIX ##### \n");
PrintArray(tempMatrix);

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

int[,] MultiplicationArray(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.WriteLine($"\n Операция умножения двух матриц не выполнима. Число столбцов в первой матрице не равно числу строк во второй.");
        return resultMatrix;
    }
    else
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    sum += firstMatrix[i, k] * secondMatrix[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
    }
    return resultMatrix;
}