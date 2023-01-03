System.Console.WriteLine("Введите целое число:");
int number = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Число = {number}");

//что бы поменять значение местами:

System.Console.WriteLine("Введите первое целое число:");
int numberA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе целое число:");
int numberB = int.Parse(Console.ReadLine());

System.Console.WriteLine($"A = {numberA} | B = {numberB}");

int numberC = numberB;
numberB = numberA;
numberA = numberC;

System.Console.WriteLine($"A = {numberA} | B = {numberB}");

// вывод количества цирф числа

System.Console.WriteLine("Введите целое число:");
int numbers = int.Parse(Console.ReadLine());

System.Console.WriteLine(numbers.ToString().Length);