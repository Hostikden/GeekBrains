// Задача 62: Заполните спирально массив 4 на 4.


Console.Clear();

Console.Write($"Введите ширину матрицы:\t");
int n = int.Parse(Console.ReadLine());

int[,] createMatrix = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= n * n)
{
    createMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < n - 1)
        j++;
    else if (i < j && i + j >= n - 1)
        i++;
    else if (i >= j && i + j > n - 1)
        j--;
    else
        i--;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
            Thread.Sleep(1000);
        }

        Console.WriteLine($"\n");
        Thread.Sleep(1000);

    }
}

Console.WriteLine($"\n");
PrintArray(createMatrix);


     ///////////////////////////////////////
    //////////                 ////////////
   //////////       TEST      ////////////
  //////////                 ////////////
 ///////////////////////////////////////


// int[,] firstArray =
// {
//     {1,2,3,4},
//     {5,6,7,8},
//     {9,10,11,12},
//     {13,14,15,16}
// };

// for (int i = 0; i < firstArray.GetLength(0); i++)
// {
//     for (int j = 0; j < firstArray.GetLength(1); j++)
//     {
//         Console.Write($"{firstArray[i, j]}\t");
//         Thread.Sleep(1000);
//     }
//     Console.WriteLine($"\n");
// }

// Console.WriteLine($"\n");

