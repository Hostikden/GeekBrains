// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

Console.Clear();

int[,,] myArray = new int[2,5,3];


HashSet<int> numbers = new HashSet<int>();
Random r = new Random();

int GenerateUniqueNumber()
{
    while (true)
    {
        var n = r.Next(10, 99 +1);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}


for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        for (int k = 0; k < myArray.GetLength(2); k++)
        {
            Console.Write($"{myArray[i, j, k] = GenerateUniqueNumber()}\t");
            Thread.Sleep(1000);
        }

        Console.WriteLine($"\n");
        Thread.Sleep(1000);
    }

        Console.WriteLine($"\n");
        Thread.Sleep(1000);
}
