//             0123456789
string name = "abracadabra";
bool containsA = name.Contains('a'); //ищем есть в строке буква а
bool containsB = name.Contains('E'); //ищем есть ли в строке буква Е
System.Console.WriteLine(containsA); // true
System.Console.WriteLine(containsB); // false


int x = 1;                         // задаём x как число 
string str = x.ToString();         // приводим переменную x к строке
System.Console.WriteLine(x + 1);   // число с матемачискими операциями
System.Console.WriteLine(str + 1); //строка не может вычислять


//базовый API:
bool andsWithAbra = name.EndsWith("abra");//проверяем оканчивается ли наша строка на abra
System.Console.WriteLine($"Наша строка оканчивается на abra? {andsWithAbra}"); //выводит True
bool startWithAbr = name.StartsWith("abr"); //проверяем начинсется ли наша строка на abr
System.Console.WriteLine($"Наша строка начинается на abr? {startWithAbr}");

int indexOfA = name.IndexOf('a'); //ищем первое вхождение а по индексу!!!
System.Console.WriteLine(indexOfA); // выводим индекс в который первее всего вошло значение а

int indexOfB = name.IndexOf('b', 6); //в конце указали с какого индекса начинать вхождение
System.Console.WriteLine(indexOfB);

int lastIndexOfR = name.LastIndexOf('r'); // находит последнее вхождение символа r 
System.Console.WriteLine(lastIndexOfR);
System.Console.WriteLine("________");
// также мы можем узнать длину строки
//строка - массив символов пронумерованных от 0 до n
// ВАЖНО длина строки .Length считывается компьютером не с 0, а как есть
// из человеских соображений
// в то время как индексы считаются от 0
System.Console.WriteLine($"длина строки = {name.Length}");

// метод .Substring - взятие подстроки

string substrFrom5 = name.Substring(5);
string substrFrom2 = name.Substring(0, 3);

System.Console.WriteLine(substrFrom5);// выведет начиная с 5го индекса 
System.Console.WriteLine(substrFrom2);// выведет указанное количество

// объединение строк
string abc = string.Concat("a", "B", "c"); //соединяем три строки
System.Console.WriteLine(abc);             // выводим объединённый результат
// объединение строк с разделителем
string nameConcat = string.Join(" ", "My", "name", "is", "Den");
System.Console.WriteLine(nameConcat);
nameConcat = "My " + "name " + "is " + "Den ";
System.Console.WriteLine(nameConcat);
// мы можем вставить строку в строку, но тут есть нюанс
// нам обязательно необходимо перезаписать переменную либо 
// ввести новую, иначе при выводе нам выведет старое значение строки
// без вставки

nameConcat = nameConcat.Insert(0, "By the way, ");//перезаписываем переменную!!! 0 - с какого индекса вставляем 
System.Console.WriteLine(nameConcat);

// удаление подстроки
nameConcat = nameConcat.Remove(0, 1); // 0 - index 1 - количество удаляемых 
System.Console.WriteLine(nameConcat);

// замена
string replaced = nameConcat.Replace('n', 'z'); // все вхождения n изменятся на z
System.Console.WriteLine(replaced);

string data = "12;28;32;87";
string[] splitData = data.Split(';'); // методу .Split передаём разделитель по которому хотим разделить данные
string first = splitData[0];
System.Console.WriteLine(first);

char[] chars = nameConcat.ToCharArray();
System.Console.WriteLine(chars[0]); 
// на самом деле мы можем сразу обратиться к nameConcat[0]
// но массив в примере выше даёт нам новый API который мы можем использовать
// так что toCharArray не обязателен и мы можем это сделать так:
System.Console.WriteLine(nameConcat[0]); 

// преобьразование всех чаров к ВЕРХНЕМУ и НИЖНЕМУ регистру:
string lower = nameConcat.ToLower();
string upper = nameConcat.ToUpper();
System.Console.WriteLine(lower);
System.Console.WriteLine(upper);

// метод Trim - убирает пробелы в начале и конце строки
string trim = "   My name Den   ";
System.Console.WriteLine(trim);
// убираем пробелы в начале и конце прямо в выводе (так тоже можно, без перезаписи)
System.Console.WriteLine(trim.Trim());