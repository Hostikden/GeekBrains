/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();
System.Console.WriteLine($"\nВведите количество элеметов массива:\t");
int count = int.Parse(Console.ReadLine());

int[] myArray = new int[count];
for (int i = 0; i < myArray.Length; i++)
{
    System.Console.Write($"Введите значение под индексом {i}:\t");
    myArray[i] = int.Parse(Console.ReadLine());
}

Print(myArray);
System.Console.Write(" -> ");
Sort(myArray);

static void Print(int[] coll)
{
    double count = coll.Length;
    int index = 0;
    Console.Write("[ ");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
}

//метод, который упорядочивает наш массив

static void Sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }

    int sum = 0;
    for (int e = array.Length - 1; e >= 0; e--)
    {
        sum = array[array.Length - 1] - array[0];
    }
    System.Console.Write(sum);
}

