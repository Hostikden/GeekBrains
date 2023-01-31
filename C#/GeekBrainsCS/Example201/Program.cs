DateTime dt = DateTime.Now;
PrintFibonacci(1,1,0,15);
Console.WriteLine();
Console.WriteLine(DateTime.Now-dt);

void PrintFibonacci(int a, int b, int counter, int number)
{
Console.Write($"{a} ");
if (counter < number) PrintFibonacci(b, a+b, counter+1, number);
}
