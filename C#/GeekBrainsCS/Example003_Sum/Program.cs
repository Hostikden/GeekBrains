// вариант 1:

//int numberA = 3;
//int numberB = 5;
//Console.WriteLine (numberA + numberB);

// вариант 2:

//int numberA = 3;
//int numberB = 5;
//int result = numberA + numberB;
//Console.WriteLine(result);

// рандом вариант 3:

int numberA = new Random().Next(1,10); // 1 2 3... 9
Console.Write("Первое число = ");
Console.WriteLine(numberA);
int numberB = 5;
int result = numberA + numberB;
Console.WriteLine(result);