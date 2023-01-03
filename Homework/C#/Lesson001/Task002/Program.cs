Console.Write ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA; // Учитель указал на ошибку -> тело блока if повторяет 5 и 6 строку
int min = numberB;
if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}
Console.Write ("Максимальное число = " + max + " ,а минимальное число = " + min);
