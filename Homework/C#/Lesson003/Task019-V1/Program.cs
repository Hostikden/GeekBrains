/*
Задача 19:
Напишите программу, которая принимает на вход пятизначное число и 
проверяет,является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да 
*/

Console.Clear();
System.Console.Write("Введите пятизначноне число: ");
string? numbers = Console.ReadLine();
char first;
char two;
char three;
char four;
char five;
int number = int.Parse(numbers);


if (number < 9999 || number >= 100000)
{
    System.Console.WriteLine($"Число {number} не пятизначное");
}

else
{
    first = numbers[0];
    two = numbers[1];
    three = numbers[2];
    four = numbers[3];
    five = numbers[4];

    if (first == five && two == four)
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}
