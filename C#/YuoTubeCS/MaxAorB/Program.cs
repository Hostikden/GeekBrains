Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

int max = a;
if (b > a)
{
    max = b;

    System.Console.WriteLine($"Максимальное число = {max}");
}

//Вариант 2:
// int max;
// if (a > b)
//     max = a;
// else
//     max = b;


//Вариант 3 тернарное выражение
// int max = (a > b ? a : b);
//если a > b то присвоить в значение макс. в противном случае b присвоить в значение макс.


