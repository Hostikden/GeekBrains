/*
Напишите програму, которая на вход принимает число 'A' и выдаёт сумму
чисел от 1 до A
7 -> 28
4 -> 10
8 -> 36
*/

// int Sum(int a)
// {
//     int sum = 0;

//     for (int i = 1; i <= a; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// System.Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Sum(a));
// System.Console.WriteLine(Sum(4));
// System.Console.WriteLine(Sum(15));


void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма цифр от 1 до введённого числа = {sum}");
}

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Clear();
GetSumNums(a);