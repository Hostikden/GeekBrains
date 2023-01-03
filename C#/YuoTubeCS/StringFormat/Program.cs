using System.Text;
//using System.Collections.Generic;

string name = "Den";
int age = 30;                         // 0 и 1 - placeholders
string str1 = string.Format("My name is {0} and I'm {1}", name, age); // вместо переменных name и age можно использовать литералы
                                                                      // естественно, чаще используют переменные
string str2 = $"My name is {name} and I'm {age}"; // $ - интерполирование строк
// string str2 = "My name is " + name + " and I'm " + age;

System.Console.WriteLine(str1);
System.Console.WriteLine(str2);

// перевод на новую строку \n
string str3 = "My name is \n Den";
System.Console.WriteLine(str3);
// можно ещё так:
// разница лишь в том, что метод Environment  работает кроссплатформенно
// это означает, что такой вариант будет работать правильно на всех ос
str3 = $"My name is {Environment.NewLine} DEN";
System.Console.WriteLine(str3);

// табуляция \t
string str4 = "My name is \t DeN";
System.Console.WriteLine(str4);

//вывод кавычек \ экранируем слэшами
string str5 = "I'm Den and I'm \"good\" programmer";
System.Console.WriteLine(str5);
// что делать если мы хотим прописать путь со \
string str6 = "C:\\\\usr\\local\\bin\\test.php"; // экранируем вторым слэшем
System.Console.WriteLine(str6);
// более элегантный способ через @ verbatin string как есть
string str7 = @"C:\\usr\local\bin\test.php";
System.Console.WriteLine(str7);