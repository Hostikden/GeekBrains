// ввводим массив, для того что бы избавиться от количества переменных
// на примере 101 задачи
int[] array = new int[10];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (col[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);