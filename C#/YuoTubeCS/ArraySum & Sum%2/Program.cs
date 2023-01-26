// Поиск суммы четных элементов массива

int[] myArray = { 10, 2, 3, 4, 5, 6, 2, 1, 90 };

Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());