Console.Clear();

int[,] myMatrix = new int[3, 3]
{
            {4,7,8},
            {5,2,3},
            {6,7,9}
};

Console.WriteLine($"####### DEFAULT MATRIX #######\n");
PrintArray(myMatrix);

int[] myArray = new int[9];
int z = 0;
for (int i = 0; i < myMatrix.GetLength(0); i++)
    for (int j = 0; j < myMatrix.GetLength(1); j++)
    {
        myArray[z] = myMatrix[i, j];
        z++;
    }

for (int i = 0; i < myArray.Length; i++) { }
int[] result = myArray.OrderBy(i => i).ToArray();
for (int i = 0; i < result.Length; i++) { }

Console.WriteLine($"####### SORT MATRIX #######\n");

int[,] sortMyMatrix = new int[3, 3];
int k = 0;
for (int i = 0; i < sortMyMatrix.GetLength(0); i++)
{
    for (int j = 0; j < sortMyMatrix.GetLength(1); j++)
    {
        sortMyMatrix[i, j] = result[k];
        Console.Write($"{sortMyMatrix[i, j]}\t");
        k++;
    }
    Console.WriteLine($"\n");
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