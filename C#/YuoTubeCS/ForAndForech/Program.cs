//цикл for
//                0  1  2  3  4  5  6  7  8
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

for (int i = 0; i < numbers.Length; i++)
{
    System.Console.Write(numbers[i] + " ");
}

System.Console.WriteLine();
// Обратный цикл

for (int i = numbers.Length - 1; i >= 0; i--)
{
    System.Console.Write(numbers[i] + " ");
}

System.Console.WriteLine();
//Вывод только четных чисел

for (int i =0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
    System.Console.Write(numbers[i] + " ");
    }
}

System.Console.WriteLine();
// цикл foreach нельзя развернуть!!!
// доступа к индексу не имеем!!! только к значению!!!

foreach (int val in numbers)
{
    System.Console.Write(val + " ");
}

