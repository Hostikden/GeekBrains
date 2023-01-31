decimal fRec = 0;
decimal fIte = 0;

decimal FibonnacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonnacciRecursion(n - 1) + FibonnacciRecursion(n - 2);
}

decimal FibonnacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonnacciIteration({n}) = {FibonnacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");
    fIte = 0;
}
Console.WriteLine();

for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonnacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
}

