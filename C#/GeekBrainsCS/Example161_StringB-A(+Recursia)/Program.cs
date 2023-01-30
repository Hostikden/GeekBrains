// Собрать строку с числами от b до a, a >= b.


string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = b; i >= a; i--)
    {
        result += $"{i}\t";
    }
    return result;
}

Console.WriteLine(NumbersFor(1, 10));

//////////// РЕКУРСИЯ ////////////////

string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return string.Empty;
}

Console.WriteLine(NumbersRec(1, 10));