Console.Clear();

int[] a1;                          // объявляем массив
a1 = new int[10];

int[] a2 = new int[5];

int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

int[] a4 = { 1, 2, 3, 4, 5 };            //самая краткая запись
System.Console.WriteLine(a4[0]);

int number = a4[4];
System.Console.WriteLine(number);

a4[4] = 12;                        //можем перезаписать индекс
System.Console.WriteLine(a4[4]);


System.Console.WriteLine(a4.Length); //массивы предоставляют свойство length - 
                                     //переменная обозначающая длину массива

// Как обратиться к последнему элементу массива не зная длину массива?
System.Console.WriteLine(a4[a4.Length - 1]);

// Массивы также могут быть и в виде строки:
// однако стоить помнить, что строки не возможно модифицировать
// модифицируя строку мы получаем новый экземпляр!
// либо перезаписываем старый экземпляр, но НЕ ИЗМЕНЯЕМ!
// т.е. s1[0] = 'z'; не прокатит и выдаст ошибку

string s1 = "abcdefg";

char first=s1[0];
char last=s1[s1.Length-1];

System.Console.WriteLine($"First: {first} | Last: {last}");