// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Example 1:

int number = new Random().Next(100, 1000);
Console.WriteLine($"Ранодомное число = {number}");
Console.WriteLine ($"Вторая цифра числа {number} = {number % 100 / 10}");
 
//**************************************************************
//**************************************************************

// Example 2:

// int number = new Random().Next (100, 1000);
// Console.WriteLine(number);

// string str = number.ToString();        // преобразовываем число в строку
// int[] array = new int[str.Length];
// for (int i=0; i< str.Length; i++)
// {
//     array[i] = int.Parse(str[i].ToString());
// }

// Console.WriteLine (array [1]);
