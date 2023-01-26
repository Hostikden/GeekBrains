// Поиск уникальных элементов массива

int[] myArray = { 10, 2, 1, 4, 5, 6, 2, 1, 90 };

int[] result = myArray.OrderBy(i => i).ToArray();

for (int i = 0; i < result.Length; i++)
{
    Console.Write($"{result[i]}\t");
}

System.Console.WriteLine();

// обратный порядок

int[] result2 = myArray.OrderByDescending(i => i).ToArray();

for (int i = 0; i < result2.Length; i++)
{
    Console.Write($"{result2[i]}\t");
}

System.Console.WriteLine();

// через Array
System.Console.WriteLine("---------------");

Array.Sort(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"{myArray[i]}\t");
}

System.Console.WriteLine();