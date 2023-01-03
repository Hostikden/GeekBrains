using System.Text;
using System.Threading;
using System.Collections.Generic;

string str1 = "abcde";
string str2 = "abcde";

bool areEqual = str1 == str2;       //сравниваем
System.Console.WriteLine(areEqual); //возвращаем true

areEqual = string.Equals(str1, str2, StringComparison.Ordinal); 
System.Console.WriteLine(areEqual); //выходит тоже самое что и выше

Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

System.Console.WriteLine("- Straße -");
string str11 = "Strasse";
string str12 = "Straße";
//посмотрим что выведут разные режимы сравнения:
bool areEqual2 = string.Equals(str11, str12, StringComparison.Ordinal); // Ordinal - байтовая репризинтация символов
                                                                        // более того данный режим работает быстрее всех остальных
                                                                        // используется чаще всего
System.Console.WriteLine(areEqual2);
bool areEqual3 = string.Equals(str11, str12, StringComparison.InvariantCulture); // InvariantCulture - стараемся избегать
System.Console.WriteLine(areEqual3);
bool areEqual4 = string.Equals(str11, str12, StringComparison.CurrentCulture); // Если очень неоьходимо сравнить именно в языковых рамках, то это крайний вариант
System.Console.WriteLine(areEqual4);