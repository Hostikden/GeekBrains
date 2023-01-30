// Собрать строку с числами от a до b, a <= b.

///////////// FOR ///////////////

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}\t";
    }
    return result;
}

Console.WriteLine(NumbersFor(1, 10));

//////////// РЕКУРСИЯ ////////////////

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b); // если a <= b, то мы будем собирать строку
                                                       // с текущим значение А и вызывать новую 
                                                       // копию метода со значениями аргументов 
                                                       // (первый будет увеличен на еденичку).
    else return string.Empty;
}

Console.WriteLine(NumbersRec(1, 10));