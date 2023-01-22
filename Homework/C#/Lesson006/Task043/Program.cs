/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
System.Console.Write("Введите b1: ");
int b1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите k1: ");
int k1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите b2: ");
int b2 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите k2: ");
int k2 = System.Convert.ToInt32(System.Console.ReadLine());

ShowResult(b1, b2, k1, k2);

static void ShowResult(double b1, double b2, double k1, double k2)
{
    string result;
    if (Parallel(k1, k2)) result = "линии параллельны";
    else
    {
        double x = SearchX(b1, b2, k1, k2);
        double y = SearchY(b1, b2, k1, k2);
        result = x + "; " + y;
    }

    if (Merge(b1, b2, k1, k2)) result = "линии совпадают";
    if (Perpendicular(k1, k2)) result = "линии перпендикулярны";

    System.Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({result})");
}

static bool Parallel(double k1, double k2)
{
    return k1 == k2;
}

static bool Merge(double b1, double b2, double k1, double k2)
{
    return k1 == k2 && b1 == b2 && k1 == b1;
}

static bool Perpendicular(double k1, double k2)
{
    return k1 * k2 == -1;
}

static double SearchX(double b1, double b2, double k1, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

static double SearchY(double b1, double b2, double k1, double k2)
{
    return k1 * ((b2 - b1) / (k1 - k2)) + b1;
}
