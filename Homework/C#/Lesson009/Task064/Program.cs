// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = 5;
Console.WriteLine($"N = {n} -> {ReverseRecurce(n)}");

string ReverseRecurce(int n)
{
    if (n > 1) return $"{n}" + ", " + ReverseRecurce(n - 1);

    // следующую строку сделал потому что 
    // ничего умнее не придумал как
    // убрать запятую в конце
    if (n > 0) return $"{n}" + ReverseRecurce(n - 1);
    return string.Empty;
}