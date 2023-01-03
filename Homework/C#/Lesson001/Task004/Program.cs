Console.Write ("Введите первое число: ");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число: ");
int numberB = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите третье число: ");
int numberC = Convert.ToInt32 (Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA; // Учитель указал на ошибку, эта строка лишняя 
                                  //ведь я и так указал max = numberA
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write ("Максимальное число = ");
Console.Write (max);

