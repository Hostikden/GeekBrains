Console.WriteLine("Введите число: ");
string? N = Console.ReadLine();
int number;
while (!int.TryParse(N, out number))
{
    Console.WriteLine("Ошибка! Введите одно целое число!");
    N = Console.ReadLine();
}
if (number > 0)
{
    int count = 0;
    Console.WriteLine("Четные числа: ");
    while (count < number - 1)
    {
        count += 2;
        Console.WriteLine(count);
    }
}
else
{
    int count = 0;
    Console.WriteLine("Четные числа: ");
    while (count > number + 1)
    {
        count -= 2;
        Console.WriteLine(count);
    }
}