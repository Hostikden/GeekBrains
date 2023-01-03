// байт мы легко можем привести к инту
byte b = 3; // 0000 0011
int i = b;  // 0000 0000 0000 0000 0000 0000 0000 0011

// инт мы легко можем привести к лонгу
long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

float f = i; // выведет в консоль 3, но фактически это 3,0

System.Console.WriteLine(f);

// b = i; // компилятор ругается - нельзя впихнуть не впихуемое!!!
//но есть способ обхода, если мы уверены что переполнения не будет
b = (byte)i; // явно указываем byte и понимая всю ответсвенность
//то же всамое касается записи int = float
i = (int)f;

System.Console.WriteLine($"{b}; {i}");

f = 3.1f; // обрезается всё после плавающей точки
i = (int)f;
System.Console.WriteLine(i);

string str = "1";
// i = (int) str; ТАК НЕ РАБОТАЕТ
i = int.Parse(str);

int x = 5;
int result = x / 2;
System.Console.WriteLine(result); // выводит не 2.5 а 2

double result2 = (double)x / 2;
System.Console.WriteLine(result2); // выводит 2.5