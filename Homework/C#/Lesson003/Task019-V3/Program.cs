// Задача 19:
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
using System.Text.RegularExpressions;

public class Palindrom
{
    public static string Reverser(string a)
    {
        char[] arr = a.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public static string Palindromer(string x)
    {
        string y = Reverser(x);
        Console.WriteLine(y);
        if (Equals(x, y))
            return "является палиндромом.";
        else
            return "не является палиндромом.";
    }

    public static void Main()
    {
        Console.WriteLine("Введите значение:");

        string pattern = @"\.+?|\,+?|\ +?|\-+?|\:+?";
        string? input = Console.ReadLine();
        if (input is not null)
        {
            string str = input.ToLower();
            str = (Regex.Replace(str, pattern, string.Empty));

            Console.WriteLine(input + " - эта строка " + Palindromer(str));
            Console.WriteLine();
        }
    }
}
