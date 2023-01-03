int number = new Random().Next(0, 1000);
System.Console.WriteLine($"Ранодомное число равно {number}");

if (number % 7 == 0 && number % 23 == 0) System.Console.WriteLine($"{number} -> да");
else System.Console.WriteLine($"{number} -> нет");
System.Console.WriteLine($"Число {number} делится на 7 с остатком {number % 7}");
System.Console.WriteLine($"Число {number} делится на 23 с остатком {number % 23}");