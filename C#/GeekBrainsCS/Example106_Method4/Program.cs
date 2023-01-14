/*
Методы, которые что-то принимают и что-то возвращают
*/

//через цикл while
/* 
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i< count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
System.Console.WriteLine(res);
*/

//через цикл for
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
System.Console.WriteLine(res);
