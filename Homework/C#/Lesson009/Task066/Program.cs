// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int m = 4, n = 8;
Console.WriteLine(SumNumbers(m, n));

int SumNumbers(int m, int n)
{
    int sum = 0, temp;
    if (n < 0 || m < 0) return 0;  // если задано отрицательное - возвращаем ноль
    if (n == m) return 0;          // если заданные числа равны - возвращаем ноль
    if (m > n)                     // если m > n - меняем их местами
    {
        temp = m;
        m = n;
        n = temp;
    }
    if (n > m)                     // конечное решение + рекурсия
    {
        int Recurce(int m, int n)
        {
            if (n >= m) return sum = n + Recurce(m, n - 1);
            return 0;
        }
        return sum = Recurce(m, n);
    }
    return sum;
}