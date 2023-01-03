using System.Text;
//using System.Collections.Generic;

int answer = 4;
string result = string.Format("{0:d}", answer);
string result2 = string.Format("{0:d4}", answer); //d4 если число меньше 4 символов, то заполняем его левую часть нулями
System.Console.WriteLine(result);
System.Console.WriteLine(result2);

string result3 = string.Format("{0:f}", answer);
string result4 = string.Format("{0:f4}", answer); // вывод float
System.Console.WriteLine(result3);
System.Console.WriteLine(result4);

// полноуенное округление
double answer2 = 42.08;
string result5 = string.Format("{0:f2}", answer2);
string result6 = string.Format("{0:f1}", answer2); 
System.Console.WriteLine(result5);
System.Console.WriteLine(result6);

// вывод знака валют
// предварительно подключаем Encoding
// подключаем using System.Text;
Console.OutputEncoding = Encoding.UTF8;

double money = 12.8;
string result10 = string.Format("{0:C}", money);
string result11 = string.Format("{0:C2}", money);

result = $"{money:C2}"; // вариант через интерполяцию
System.Console.WriteLine(result);

System.Console.WriteLine(money.ToString("C2"));// альтернативный вариант
System.Console.WriteLine(result11);

// можем изменить на значок $ изменив локаль
Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
System.Console.WriteLine(money.ToString("C2"));
