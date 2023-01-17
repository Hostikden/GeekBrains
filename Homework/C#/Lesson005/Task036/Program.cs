/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = GetArray(4);
Print(array);
System.Console.Write(" -> ");
System.Console.Write("Сумма элементов стоящих на нечётных позициях = " + Out(array)); ;

static int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-11, 11);
    }
    return result;
}

static void Print(int[] coll)
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

static int Out(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        count += array[i];
        i++;
    }
    return count;
}
