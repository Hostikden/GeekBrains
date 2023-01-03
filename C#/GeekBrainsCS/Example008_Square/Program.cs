// Напишите программу, которая принимает число и выдает его квадрат.
// Например:
// 4 -> 16
// 3 -> 9
// 7 -> 49

Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 - преобразование строки в целое число
int result = number * number;
Console.WriteLine ("Квадрат числа " + number + " будет = " + result);
