// int[] elements = new int[10];

// int length = elements.Length;
// int index = 0;
// int sum = 0;

// while (index < length)
// {
//     int current = Random.Shared.Next(30);
//     elements[index] = current;
//     Console.WriteLine(elements[index]);

//     if (current >= 10 && current <= 99)
//     {
//         sum = sum + current;

//         index = index + 1;
//     }
// }
// Console.WriteLine("_____");
// Console.WriteLine(sum);






// static int[] CreateArray()
// {
//     return new int[10];
// }

// void Fill(int[] elements)
// {
//     int length = elements.Length;
//     int index = 0;

//     while (index < length)
//     {
//         int current = Random.Shared.Next(30);
//         elements[index] = current;
//         index = index + 1;
//     }
// }

// int GetSum(int[] array)
// {
//     int size = array.Length;
//     int sum = 0;
//     int current = 0;

//     while (current < size)
//     {
//         if (current >= 10 && current <= 99)
//         {
//             sum = sum + current;
//         }
//     }
// }

// string Print(int[] collection)
// {
//     string output = String.Empty;

//     int size = collection.Length;
//     int index = 0;
//     while (index < size)
//     {
//         int current = collection[index];
//         output = output + $" {current} ";
//     }

//     return output;
// }

// int[] arr = CreateArray();
// Fill(arr);
// int sum = GetSum(arr);
// Console.WriteLine(Print(arr));
// Console.WriteLine($"sum = {sum} ");


// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0) sumPos += myArray[i];
    else sumNeg += myArray[i];
}

System.Console.WriteLine($"Сумма положительных элементов = {sumPos}");
System.Console.WriteLine($"Сумма положительных элементов = {sumNeg}");
