// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next (1, 100000);
Console.WriteLine(number);
string stringNumber = number.ToString();

if (number < 100) Console.WriteLine ($"У числа {number} третью цифру украл инопланетянин :D");
else Console.WriteLine ($"У числа {number} третья цифра = {stringNumber[2]} ");