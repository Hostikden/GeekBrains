// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

//Example 1:

int number = new Random().Next(100, 1000);
Console.WriteLine($"Ранодомное число = {number}");
Console.WriteLine(number / 100 * 10 + number % 10);

// Example 2:

// int number = new Random().Next (100, 1000);
// Console.WriteLine(number);

// string str = number.ToString();
// int[] array = new int[str.Length];
// for (int i=0; i< str.Length; i++)
// {
//     array[i] = int.Parse(str[i].ToString());
// }

// Console.Write (array [0]);
// Console.Write (array [2]);

// Example 3:

// int number = new Random ().Next (100,1000);
// Console.WriteLine (number);
// int a = number / 100;
// int b = number % 10;
// Console.WriteLine($"{a} {b}");

