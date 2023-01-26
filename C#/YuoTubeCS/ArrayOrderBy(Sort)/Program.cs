// Поиск уникальных элементов массива

int[] myArray = { 10, 2, 1, 4, 5, 6, 2, 1, 90 };

int[] result = myArray.OrderBy(i => i).ToArray();

for (int i = 0; i < result.Length-1; i++)
{
    Console.Write($"{result[i]}\t");
}

System.Console.WriteLine();