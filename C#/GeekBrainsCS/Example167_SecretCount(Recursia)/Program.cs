// у рекурсии есть скрытый count
// можно его задавать самому

int number = 4;

string Numbers(int number, int count = 0)
{
    if (count == number) return String.Empty;
    return "count " + Numbers(number, count + 1);
}

Console.WriteLine(Numbers(number));