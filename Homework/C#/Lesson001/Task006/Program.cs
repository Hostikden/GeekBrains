Console.Write ("Введите целое число: ");
double number = Convert.ToDouble (Console.ReadLine()); // Учитель указал на недочет double излишен

if (number % 2 == 0)
{
    Console.WriteLine ("Число " + number + " является четным.");
}

else
{
    Console.WriteLine ("Число " + number + " является нечетным.");
}