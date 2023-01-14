int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine();
}

//метод, который упорядочивает наш массив

void SelectionSort(int[] array)
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

    
        for (int e = array.Length - 1; e >= 0; e--)
        {
            System.Console.Write(array[e]);
        }
        System.Console.WriteLine();
    

}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

