/*
Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
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

void PrintMyArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
}

void Print(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

PrintMyArray(myArray);
System.Console.Write(" -> ");
Print(myArray);